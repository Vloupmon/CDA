using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Test2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                HttpCookie cookie = new HttpCookie("Utilisateur");
                cookie.Values.Add("Nom", txtNom.Value);
                cookie.Values.Add("Prenom", txtPrenom.Value);
                cookie.Values.Add("DateConnexion", DateTime.Now.ToLongDateString());
                // Aucune date d'expiration définie : cookie de session
                Response.Cookies.Add(cookie);
                Response.Redirect("Test3.aspx");
            }   
        }
    }
}