using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Test3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Utilisateur"]!=null)
            { string cookiecontent = string.Empty;
                HttpCookie cookie = Request.Cookies["Utilisateur"];
                foreach (string item in cookie.Values)
                {
                    cookiecontent += string.Format("<p>{0}</p>",cookie[item]);
                }
                contenu.Attributes["style"] = "color:red;background-color:blue";
                contenu.InnerHtml = cookiecontent;
            }
        }
    }
}