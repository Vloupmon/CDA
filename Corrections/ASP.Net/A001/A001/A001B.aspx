<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A001B.aspx.cs" Inherits="A001.A001B" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Liste des paramètres</title>
    <link href="Css/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <thead>
                    <tr>
                        <th colspan="2">Résultat pour la méthode <%this.Response.Write(this.Request.Params["rdMethode"]); %></th>

                    </tr>
                    <tr>
                        <td>Propriété</td>
                        <td>Valeur</td>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <td colspan="2">Résultat pour la méthode HTTP <% this.Response.Write(this.Request.HttpMethod); %></td>
                    </tr>
                </tfoot>
                <% Response.Write(AfficherValeursRequete());
                 
                       %>
            </table>
        </div>
    </form>
</body>
</html>
