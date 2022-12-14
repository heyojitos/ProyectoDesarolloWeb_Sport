using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using Microsoft.AspNet.Identity;
using ProyectoDW.App_Code.Models;

namespace ProyectoDW {
    public partial class RootMaster : System.Web.UI.MasterPage {
        ClsCarritoCompra compra = new ClsCarritoCompra();

        protected void Page_Load(object sender, EventArgs e) {
            ASPxLabel2.Text = DateTime.Now.Year + Server.HtmlDecode(" &copy; Copyright by SportCenter S.A.");
        }
        protected void HeadLoginStatus_LoggingOut(object sender, LoginCancelEventArgs e) {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

    }
}