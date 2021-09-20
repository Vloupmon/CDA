using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AloMarcheSitepleaaaaiiiit
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool flag = false;
            NameValueCollection letablo = null;

            switch (this.Request.RequestType)
            {
                case "GET":
                    letablo = this.Request.QueryString;
                    break;
                case "POST":
                    letablo = this.Request.Form;
                    break;
            }

            HtmlTable table1 = new HtmlTable();
            HtmlTableRow row;
            HtmlTableCell cell;
            for (int i = 0; i <13; i++)
            {
                // Create a new row and set its background color.
                row = new HtmlTableRow();
                for (int j = 0; j <2; j++)
                {
                    string letexte = "";
                    if (j == 0)
                    {
                        letexte = letablo.GetKey(i);
                    }
                    else
                    {
                        letexte = letablo.GetValues(i)[0];
                    }
                    cell = new HtmlTableCell();
                    cell.InnerHtml = letexte;
                    
                    row.Cells.Add(cell);
                }

                // Add the row to the table.
                table1.Rows.Add(row);
            }

            // Add the table to the page.
            this.Controls.Add(table1);



        }
    }
}