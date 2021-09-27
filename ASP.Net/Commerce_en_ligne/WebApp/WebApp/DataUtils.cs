using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using StoreAPI;

namespace WebApp {

    public class Utils {

        private Utils() {
        }

        private static readonly Lazy<Utils> lazy = new Lazy<Utils>(() => new Utils());

        public static Utils Instance {
            get {
                return lazy.Value;
            }
        }

        private static readonly HttpClient httpClient = new HttpClient(new HttpClientHandler {
            ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
        });

        private static readonly StoreClient storeClient = new StoreClient(ConfigurationManager.ConnectionStrings["apiConnection"].ConnectionString, httpClient);

        public void Test() {
        }

        public async Task<string> GetImgHTML(int id) {
            Picture picture = null;
            try {
                picture = await storeClient.GetPictureByIdAsync(id);
            } catch (ApiException e) {
                Console.WriteLine(e.Message + "\n" + e.StackTrace);
            }
            if (picture != null) {
                return "data:" + picture.MimeType + ";base64," + Convert.ToBase64String(picture.PictureBinary);
            } else {
                return "";
            }
        }
    }
}