using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;
using Microsoft.AspNet.Identity.Owin;
using ProyectoDW.App_Code.Models;
using ProyectoDW.App_Code.Controller.ControllerMantenimiento;
using DXWebApplication.App_Code.Utilidades;

namespace ProyectoDW {
    public partial class Login : System.Web.UI.Page {

        ClsErrorHandler log = new ClsErrorHandler();
        DataSet dsUsuario = new DataSet();
        ClsControllerUsuario objUsuario = new ClsControllerUsuario();
        ClsUsuario usuario = new ClsUsuario();
        ClsUsuario usuarioIngresado = new ClsUsuario();
       

        protected void Page_Load(object sender, EventArgs e) {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e) {

            //string StrQry = "<script language='javascript'>";

            validar();

            /*usuarioIngresado.Email = tbUserName.Text;
            usuarioIngresado.Password = tbPassword.Text;*/

            /*if (objUsuario.getCliente(usuarioIngresado))
            {
                if (usuarioIngresado.Password == objUsuario.DsReturn.Tables["TB_USUARIO"].Rows[0]["PASSWORD"].ToString())
                {
                    Session["ID_USUARIO"] = objUsuario.DsReturn.Tables["TB_USUARIO"].Rows[0]["ID_USUARIO"].ToString();
                    StrQry += "alert('Ingreso de usuario correcto'); ";
                } else {
                    StrQry += "alert('El password es incorrecto'); ";
                }
            }else {
                StrQry += "alert('No existe usuario registrado con el correo ingresado'); ";
            }

            StrQry += "</script>";
            ClientScript.RegisterStartupScript(GetType(), "mensaje", StrQry, false);*/


        }

        protected void validar() {


            if (IsValid)
            {
                // Validate the user password
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

                // This doen't count login failures towards account lockout
                // To enable password failures to trigger lockout, change to shouldLockout: true
                var result = signinManager.PasswordSignIn(tbUserName.Text, tbPassword.Text, isPersistent: false, shouldLockout: false);

                switch (result)
                {
                    case SignInStatus.Success:
                        IdentityHelper.RedirectToReturnUrl("~/WebForms/Inicio/WebInicio.aspx", Response);
                        //IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                        break;
                    case SignInStatus.LockedOut:
                        Response.Redirect("~/Account/Lockout.aspx");
                        break;
                    case SignInStatus.RequiresVerification:
                        Response.Redirect(String.Format("/Account/TwoFactorAuthenticationSignIn.aspx?ReturnUrl={0}&RememberMe={1}",
                                                        Request.QueryString["ReturnUrl"],
                                                        false),
                                          true);
                        break;
                    case SignInStatus.Failure:
                    default:
                        tbUserName.ErrorText = "Invalid user";
                        tbUserName.IsValid = false;
                        break;
                }
            }
        }

    }
}