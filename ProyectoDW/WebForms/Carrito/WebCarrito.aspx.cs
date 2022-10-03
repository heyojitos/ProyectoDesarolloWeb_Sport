using ProyectoDW.App_Code.Controller.ControllerMantenimiento;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Carrito
{
    public partial class WebCarrito : System.Web.UI.Page
    {
        ClsProducto clsProducto = new ClsProducto();
        ClsControllerProducto clsControllerProducto = new ClsControllerProducto();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["idProducto"] == null) return;
                String idPro = Request.QueryString["idProducto"].ToString();
                if (Request.QueryString["cantidad"] != null)
                {
                    String canti = Request.QueryString["cantidad"].ToString();
                }
                cargaCarrito(idPro);
            }
            else
            {

            }
        }

        //Data table Virtual Carrito
        public DataTable filldata()
        {
            DataTable dt = new DataTable();
            DataColumn correlativo = dt.Columns.Add("ID_DETALLE_REGISTRO", typeof(int));
            dt.Columns.Add("ID_PRODUCTO", typeof(int));
            dt.Columns.Add("PRODUCTO", typeof(string));
            dt.Columns.Add("CANTIDAD", typeof(string));
            dt.Columns.Add("PRECIO_PRODUCTO", typeof(decimal));
            dt.Columns.Add("CANTIDAD", typeof(int));
            dt.Columns.Add("SUBTOTAL", typeof(decimal));

            //dt.Columns.Add("ELIMINAR", typeof(Button));
            dt.PrimaryKey = new DataColumn[] { correlativo };
            //correlativo.ReadOnly = true;

            return dt;
        }

        public void cargaCarrito(String idPro)
        {

            DataTable dt = null;
            int correlativo;
            dt = filldata();
            correlativo = 1;
            DataRow fila = dt.NewRow();

            fila[0] = correlativo;
           
        }

        public void setCarrito()
        {

        }

        public void 


        protected void eliminarID_DETALLE_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}