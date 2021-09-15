<%@ Page Language="C#" %>

<!DOCTYPE html>

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Liste des paramètres</title>
    <link href="Css/Site.css" rel="stylesheet" />
</head>
<body>
    <table>
        <thead>
            <tr>
                <th colspan="2">Résultat pour la méthode <%this.Response.Write(this.Request.Params["rdMethode"]); %></th>

            </tr>
            <tr>
                <th>Propriété</th>
                <th>Valeur</th>
            </tr>
        </thead>
        <tfoot>
            <tr>
                <td colspan="2">Résultat pour la méthode HTTP <% this.Response.Write(this.Request.HttpMethod); %></td>
            </tr>
        </tfoot>
        <tbody>
            <% 
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
                for (int i = 0; i < collectionClesValeurs.Count; i++)
                {
                    Response.Write(string.Format("<tr><td>{0}</td>", collectionClesValeurs.GetKey(i)));
                    Response.Write(string.Format("<td>{0}</td></tr>", collectionClesValeurs[collectionClesValeurs.GetKey(i)]));
                }
              %>
        </tbody>
    </table>

</body>
</html>
