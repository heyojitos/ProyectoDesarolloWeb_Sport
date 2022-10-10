using Microsoft.AspNet.Identity.Owin;
using ProyectoDW.App_Code.Controller.ControllerMantenimiento;
using ProyectoDW.App_Code.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoDW.WebForms.Mantenimientos
{
    public partial class WebLogin : System.Web.UI.Page
    {
        ClsControllerUsuario controllUsuario = new ClsControllerUsuario();
        ClsUsuario usuario = new ClsUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoginAdm_Click(object sender, EventArgs e)
        {

            if (isAdmin())
            {
                validar();
            }

        }

        protected void validar()
        {
            if (IsValid)
            {
                // Validate the user password
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

                // This doen't count login failures towards account lockout
                // To enable password failures to trigger lockout, change to shouldLockout: true
                var result = signinManager.PasswordSignIn(tbUserNameAdm.Text, tbPasswordAdm.Text, isPersistent: false, shouldLockout: false);

                switch (result)
                {
                    case SignInStatus.Success:
                        Response.Redirect("~/WebForms/Mantenimientos/WebMantenimientos.aspx");
                        
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
                        tbUserNameAdm.ErrorText = "Invalid user";
                        tbPasswordAdm.IsValid = false;
                        break;
                }
            }
        }

        protected bool isAdmin()
        {
            usuario.Email = tbUserNameAdm.Text;

            if (controllUsuario.getUsuario(usuario))
            {
                char isAdm = char.Parse(controllUsuario.DsReturn.Tables["AspNetUsers"].Rows[0]["IsAdm"].ToString());
                if (isAdm == 'S')
                {
                    return true;
                }
            }
            return false;
        } 
    }
}