<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A001C.aspx.cs" Inherits="A001.A001C" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Liste des paramètres</title>
    <link href="Css/Site.css" rel="stylesheet" />
</head>
<body>
    <% string enteteTableau;
   
   enteteTableau = string.Format("<table ><thead><tr><th colspan='2'>Résultat pour la méthode {0}</th></tr>"
       ,this.Request.Params["rdMethode"]);
   enteteTableau += "<tr><th>Propriété</th><th>Valeur</th></tr></thead><tbody>";
   
   NameValueCollection collectionClesValeurs = null;
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
   string[] cles = collectionClesValeurs.AllKeys;
   
   Response.Write(enteteTableau);
   for (int i = 0; i < cles.Length; i++)
			{
        Response.Write("<tr><td>" + cles[i] + "</td>");
        string[] valeurs = collectionClesValeurs.GetValues(i);
       Response.Write("<td>");
       for (int j = 0; j < valeurs.Length; j++)
			{
			 if (j > 0) Response.Write(" ,");
            Response.Write(Server.HtmlEncode(valeurs[j]));
			}
       Response.Write("</td></tr>");
			}
   
    Response.Write("</tbody></table>");
     %>
</body>
</html>
