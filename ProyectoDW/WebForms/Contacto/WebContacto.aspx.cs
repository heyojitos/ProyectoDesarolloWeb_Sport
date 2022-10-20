using DXWebApplication.App_Code.Utilidades;
using ProyectoDW.App_Code.Controller.ControllerPaginasWeb;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Contacto
{
    public partial class WebContacto : System.Web.UI.Page
    {
        ClsErrorHandler log = new ClsErrorHandler();
        ClsContacto contacto = new ClsContacto();
        ClsControllerContacto clsController = new ClsControllerContacto();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnEnviar2_Click(object sender, EventArgs e)
        {

            try
            {
                contacto.Nombre = txtNombre.Value;
                contacto.Email = txtEmail.Value;
                contacto.Mensaje = txtMensaje.Value;
                if (contacto.Nombre == null || contacto.Email == null || contacto.Mensaje == null)
                {
                    string mensaje_alerta = "Llene todos los datos del formulario";
                    ClientScript.RegisterStartupScript(GetType(), "alerta", "LlenarDatos('" + mensaje_alerta + "')", true);
                }
                else
                {
                    if (clsController.InsertContacto(contacto))
                    {
                        txtNombre.Value = "";
                        txtEmail.Value = "";
                        txtMensaje.Value = "";
                        string mensaje_alerta = "Hemos recibido correctamente su registro, nos pondremos en contacto";
                        ClientScript.RegisterStartupScript(GetType(), "alerta", "Agregado('" + mensaje_alerta + "')", true);

                    }
                    else
                    {
                        string mensaje_alerta = "Ocurrio un error al ingresar el registro";
                        ClientScript.RegisterStartupScript(GetType(), "alerta", "Error('" + mensaje_alerta + "')", true);
                    }
                }
                
            }
            catch (Exception ex)
            {
                log.LogError(ex.ToString(), ex.StackTrace);
                string mensaje_alerta = "Ocurrio un error al ingresar el registro";
                ClientScript.RegisterStartupScript(GetType(), "alerta", "Error('" + mensaje_alerta + "')", true);
            }          
        }
    }
}