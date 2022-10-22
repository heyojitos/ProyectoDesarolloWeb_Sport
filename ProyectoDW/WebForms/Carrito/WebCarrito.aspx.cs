using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Controller.ControllerMantenimiento;
using ProyectoDW.App_Code.Dao.DaoMantenimiento;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using ProyectoDW.App_Code.Dao;
using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;

namespace ProyectoDW.WebForms.Carrito
{
    public partial class WebCarrito : System.Web.UI.Page
    {
        ClsProducto clsProducto = new ClsProducto();
        ClsControllerProducto clsControllerProducto = new ClsControllerProducto();
        ClsControllerCarro carro = new ClsControllerCarro();
        //ClsClient client = new ClsClient();
        ClsDaoClient objCliente = new ClsDaoClient();
        ClsAspNetUsers aspCliente = new ClsAspNetUsers();
        ClsCarritoCompra compra;

        ClsErrorHandler log = new ClsErrorHandler();
        ServiceBanguat.TipoCambioSoapClient wsbanguat = new ServiceBanguat.TipoCambioSoapClient();
        ServiceGeneraToken.GeneradorTokenClient wstoken = new ServiceGeneraToken.GeneradorTokenClient();
        ServiceInsertTransaccion.InsertarTransaccionClient insertarTransaccion = new ServiceInsertTransaccion.InsertarTransaccionClient();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["miCarro"] == null)
            {
                Session["miCarro"] = new ClsCarritoCompra();               
            }
            compra = (ClsCarritoCompra)Session["miCarro"];
            if (!Page.IsPostBack)
            {
                FillData();
                Session["idCliente"] = User.Identity.GetUserId();
            }
            var res = wsbanguat.TipoCambioDia();
            idCambioDolar.Text = "Q. " + res.CambioDolar.First().referencia.ToString();
        }

        public void FillData()
        {
            DataTable dt = compra.TablaCarro();
            DataRow fila;
            foreach (var c in compra.carroItems)
            {
                fila = dt.NewRow();
                fila[0] = c.ID_regitro;
                fila[1] = c.Codigo_producto;
                fila[2] = c.Descripcion_producto;
                fila[3] = c.Imagen;
                fila[4] = c.Precio;
                fila[5] = c.Cantidad;
                fila[6] = c.Subtotal;
                dt.Rows.Add(fila);
            }

            gridCarrito.DataSource = dt;
            gridCarrito.DataBind();

            Session["DatosCarro"] = dt;
            Session["TotalCarro"] = compra.TotalCarro();
            idTotal.Text = "Q." + Session["TotalCarro"].ToString();
            decimal cambioTotal = compra.TotalCarro();
            var res = wsbanguat.TipoCambioDia();
            decimal cambio = decimal.Parse(res.CambioDolar.First().referencia.ToString());
            decimal resultado = decimal.Round((cambioTotal / cambio), 2);
            idTotalUSD.Text = "$. " + resultado.ToString();
        }      

        protected void gridCarrito_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int CodigoRegistro = int.Parse(e.Values["ID_DETALLE_REGISTRO"].ToString());
                compra.DeleteRegistro(CodigoRegistro);
                FillData();
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
            }
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            GridViewRow row = ((TextBox)sender).NamingContainer as GridViewRow;
            TextBox txtCanti = (TextBox)row.FindControl("txtCantidad");

            int codReg = int.Parse(row.Cells[1].Text);
            int can = int.Parse(txtCanti.Text);

            compra.UpdateRegistro(codReg, can);
            FillData();
        }        

        protected void btnContinuar_Click(object sender, EventArgs e)
        {
            ClsPedido pedido = new ClsPedido();
            ClsClient cliente = new ClsClient();
            String idClienteLogeado = User.Identity.GetUserId();
            String direccionCliente = txtDireccion.Text;
            String contactoCliente = txtContacto.Text;
            String telefonoCliente = txtTelefono.Text;
            String nitCliente = txtNit.Text;
            String nombreTarjeta = txtNombreTar.Text;
            String numeroTarjeta = txtNumTar.Text;
            String tarjetaCVV = txtCvv.Text;
            int mesTarjeta = int.Parse(cbxMes.SelectedItem.Value.ToString());
            int anioTarjeta = int.Parse(cbxYear.SelectedItem.ToString());
            List<ClsCarroItem> lstCarro = new List<ClsCarroItem>();

            try
            {
                objCliente.getUsuarioID(idClienteLogeado);

                if (objCliente.DsReturn.Tables["idCliente"].Rows.Count > 0)
                {
                    int codigoCliente = int.Parse(objCliente.DsReturn.Tables["idCliente"].Rows[0]["Codigo"].ToString());
                    String correoCliente = objCliente.DsReturn.Tables["idCliente"].Rows[0]["Email"].ToString();

                    foreach (var c in compra.carroItems)
                    {
                        ClsCarroItem item = new ClsCarroItem();
                        item.ID_regitro = c.ID_regitro;
                        item.Codigo_producto = c.Codigo_producto;
                        item.Cantidad = c.Cantidad;
                        item.Subtotal = c.Subtotal;
                        lstCarro.Add(item);
                    }
                    if (objCliente.getClienteXid(codigoCliente))
                    {
                        cliente.IdCliente = codigoCliente;
                        cliente.Contacto = contactoCliente;
                        cliente.Nit = nitCliente;
                        decimal total = decimal.Parse(Session["TotalCarro"].ToString());

                        string resultado = wstoken.getToken(nombreTarjeta, numeroTarjeta, mesTarjeta, anioTarjeta, tarjetaCVV);
                        int estado;
                        double monto = double.Parse(total.ToString());
                        if (resultado == null || resultado == "")
                        {
                            estado = 3;
                            insertarTransaccion.ingresarTransaccion(0, numeroTarjeta, nombreTarjeta, resultado, monto, estado);
                        }
                        else
                        {
                            estado = 1;
                            insertarTransaccion.ingresarTransaccion(0, numeroTarjeta, nombreTarjeta, resultado, monto, estado);
                        }

                        if (carro.InsertarPedido(cliente, lstCarro, total))
                        {
                            Session["miCarro"] = null;
                            Session["miCarro"] = new ClsCarritoCompra();
                            compra = (ClsCarritoCompra)Session["miCarro"];
                            FillData();
                            txtNit.Text = "";
                            txtContacto.Text = "";
                            txtDireccion.Text = "";
                            txtTelefono.Text = "";
                            string StrQry = "Se guardo correctamente el pedido, podrá verlo en Ver Compras";
                            ClientScript.RegisterStartupScript(GetType(), "alerta", "Agregado('" + StrQry + "')", true);
                        }
                        else
                        {
                            string StrQry = "Ocurrio un error al ingresar el pedido";
                            ClientScript.RegisterStartupScript(GetType(), "alerta", "Error('" + StrQry + "')", true);
                        }                       
                    }
                    else
                    {
                        cliente.IdCliente = codigoCliente;
                        cliente.Nombre = contactoCliente;
                        cliente.Correo = correoCliente;
                        cliente.Direccion = direccionCliente;
                        cliente.Telefono = telefonoCliente;
                        cliente.Nit = nitCliente;
                        decimal total = decimal.Parse(Session["TotalCarro"].ToString());
                        objCliente.InsertCliente(cliente);

                        string resultado = wstoken.getToken(nombreTarjeta, numeroTarjeta, mesTarjeta, anioTarjeta, tarjetaCVV);
                        int estado;
                        double monto = double.Parse(total.ToString());
                        if (resultado == null || resultado == "")
                        {
                            estado = 3;
                            insertarTransaccion.ingresarTransaccion(0, numeroTarjeta, nombreTarjeta, resultado, monto, estado);
                        }
                        else
                        {
                            estado = 1;
                            insertarTransaccion.ingresarTransaccion(0, numeroTarjeta, nombreTarjeta, resultado, monto, estado);
                        }

                        if (carro.InsertarPedido(cliente, lstCarro, total))
                        {
                            Session["miCarro"] = null;
                            Session["miCarro"] = new ClsCarritoCompra();
                            FillData();
                            txtNit.Text = "";
                            txtContacto.Text = "";
                            txtDireccion.Text = "";
                            txtTelefono.Text = "";
                            string StrQry = "Se guardo correctamente el pedido, podrá verlo en Ver Compras";
                            ClientScript.RegisterStartupScript(GetType(), "alerta", "Agregado('" + StrQry + "')", true);
                        }
                        else
                        {
                            string StrQry = "Ocurrio un error al ingresar el pedido";
                            ClientScript.RegisterStartupScript(GetType(), "alerta", "Error('" + StrQry + "')", true);
                        }
                    }                    
                }
                else
                {
                    string StrQry = "Debe de iniciar sesion para comprar";
                    ClientScript.RegisterStartupScript(GetType(), "alerta", "Usuario('" + StrQry + "')", true);
                }
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                //throw;
            }
            
        }

        public DataTable dtCliente()
        {
            DataTable dt = new DataTable();
            DataColumn correlativo = dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("PhoneNumber", typeof(string));
            dt.Columns.Add("UserName", typeof(string));
            dt.Columns.Add("Codigo", typeof(string));

            dt.PrimaryKey = new DataColumn[] { correlativo };
            correlativo.ReadOnly = true;

            return dt;
        }
    }
}