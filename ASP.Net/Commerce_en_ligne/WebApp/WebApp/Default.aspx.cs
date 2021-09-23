using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StoreAPI;

namespace WebApp {

    public partial class _Default : Page {

        private async Task test() {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };
            var httpClient = new HttpClient(httpClientHandler);
            var ApiClient = new StoreAPI.StoreClient("https://localhost:44319/", httpClient);

            Product result = await ApiClient.GetProductAsync(20);
            print.Text = "";
            print.Text += result.Name + "<br/>";
            print.Text += result.ProductPictureMappings;
        }

        protected void Page_Load(object sender, EventArgs e) {
            Task.Run(test);
        }
    }
}