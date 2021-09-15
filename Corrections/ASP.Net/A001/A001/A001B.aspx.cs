using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Collections.Specialized;

namespace A001
{
    public partial class A001B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AfficherValeursRequete();
        }

        protected StringBuilder AfficherValeursRequete()
        {
            NameValueCollection collectionClesValeurs = null;
            StringBuilder fluxTexte = new StringBuilder();
            
                switch (this.Request.Params["rdMethode"])
                {
                    case "GET":
                        collectionClesValeurs = this.Request.QueryString;
                        break;
                    case "POST":
                        collectionClesValeurs = this.Request.Form;
                        break;
                    case "POSTPARAM":
                        collectionClesValeurs = this.Request.Params;
                        break;
                    default:
                        break;
                }
            

            for (int i = 0; i < collectionClesValeurs.Count; i++)
            {
                fluxTexte.AppendFormat("<tr><td>{0}</td>", collectionClesValeurs.GetKey(i));
                string[] valeurs = collectionClesValeurs.GetValues(i);
                fluxTexte.Append("<td>");

                for (int j = 0; j < valeurs.Length; j++)
                {
                    if (j > 0) fluxTexte.Append(",");
                    fluxTexte.Append(valeurs[j]);


                }
                fluxTexte.Append("</td></tr>");
            }
            return fluxTexte;
        }
    }
}