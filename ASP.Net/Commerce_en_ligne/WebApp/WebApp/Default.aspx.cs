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
            var httpClientHandler = new HttpClientHandler {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
            };
            var httpClient = new HttpClient(httpClientHandler);
            var apiClient = new StoreClient("https://localhost:5001/", httpClient);

            Product result = await apiClient.GetProductAsync(20);
            Picture pic = await apiClient.GetPictureByIdAsync(20);
            print.Text = "";
            print.Text += result.Name + "<br/>";
            test_IMG.ImageUrl += "data:" + pic.MimeType + ";base64," + Convert.ToBase64String(pic.PictureBinary);
        }

        protected void Page_Load(object sender, EventArgs e) {
            Task.Run(test);
        }
    }
}