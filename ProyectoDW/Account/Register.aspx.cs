using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using ProyectoDW.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using ProyectoDW.App_Code.Models;
using ProyectoDW.App_Code.Controller.ControllerMantenimiento;
using System.Data;

namespace ProyectoDW {
    public partial class Register : System.Web.UI.Page {
        ClsUsuario usuario = new ClsUsuario();
        ClsUsrTelefono usrTelefono = new ClsUsrTelefono();
        ClsUsrDireccion usrDireccion = new ClsUsrDireccion();
        ClsControllerUsuario controllUsuario = new ClsControllerUsuario();
        ClsControllerUsrDireccion controlDireccion = new ClsControllerUsrDireccion();
        ClsControllerUsrTelefono controlTelefono = new ClsControllerUsrTelefono();

        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void btnCreateUser_Click(object sender, EventArgs e) {

            try
            {
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Email = txtEmail.Text;
                usuario.Password = txtContra.Text;

                if (controllUsuario.InsertCliente(usuario))
                {
                    if (controllUsuario.GetIdUsuario(usuario))
                    {
                        DataTable dtUsu = controllUsuario.DsReturn.Tables["UsuarioId"];
                        int id = int.Parse(dtUsu.Rows[0]["ID_USUARIO"].ToString());
                        usrDireccion.IdUsuario = id;
                        usrDireccion.Descripcion = txtDireccionEnvio.Text;
                        if (controlDireccion.InsertDireccion(usrDireccion))
                        {
                            if (chboxDireccion.Checked == false)
                            {
                                usrDireccion.IdUsuario = id;
                                usrDireccion.Descripcion = txtDireccionFacturacion.Text;
                                controlDireccion.InsertDireccion(usrDireccion);
                            }
                            usrTelefono.IdUsuario = id;
                            usrTelefono.Descripcion = txtTelefono.Text;
                            if (controlTelefono.InsertTelefono(usrTelefono))
                            {
                                limpiarForm();
                                string StrQry = "<script language='javascript'>";
                                StrQry += "alert('Registro guardado correctamente'); ";
                                StrQry += "</script>";
                                ClientScript.RegisterStartupScript(GetType(), "mensaje", StrQry, false);
                            }
                        }
                    }
                    
                }
                else
                {
                    string StrQry = "<script language='javascript'>";
                    StrQry += "alert('No se guardo el registro'); ";
                    StrQry += "</script>";
                    ClientScript.RegisterStartupScript(GetType(), "mensaje", StrQry, false);
                }
            }
            catch (Exception ex)
            {
                string StrQry = "<script language='javascript'>";
                StrQry += "alert('"+ ex.ToString() +"'); ";
                StrQry += "</script>";
                ClientScript.RegisterStartupScript(GetType(), "mensaje", StrQry, false);
            }
            
        }
        public void limpiarForm()
        {
            txtApellido.Text = "";
            txtConfirmContra.Text = "";
            txtContra.Text = "";
            txtDireccionEnvio.Text = "";
            txtDireccionFacturacion.Text = "";
            txtEmail.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            chboxDireccion.Checked = false;
        }
    }
}