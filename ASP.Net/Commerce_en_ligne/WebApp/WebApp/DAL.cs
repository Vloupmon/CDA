using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using StoreAPI;

namespace WebApp {

    public class DAL {

        private DAL() {
        }

        private static readonly Lazy<DAL> lazy = new Lazy<DAL>(() => new DAL());

        public static DAL Instance {
            get {
                return lazy.Value;
            }
        }

        private static readonly HttpClient httpClient = new HttpClient(new HttpClientHandler {
            ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; }
        });

        public readonly StoreClient storeClient
            = new StoreClient(ConfigurationManager.ConnectionStrings["apiConnection"].ConnectionString, httpClient);

        public async Task<string> GetCategoryImgSrcById(int id) {
            Picture picture = null;

            try {
                picture = await storeClient.GetPictureByIdAsync(id).ConfigureAwait(continueOnCapturedContext: false);
            } catch (ApiException e) {
                Debug.WriteLine(e.Message + "\n" + e.StackTrace + "\nInner :"
                    + e.InnerException.Message);
            }
            if (picture != null) {
                return "data:" + picture.MimeType + ";base64,"
                    + Convert.ToBase64String(picture.PictureBinary);
            } else {
                return "";
            }
        }

        public async Task<string> GetProductImgSrcById(int id) {
            Picture picture = null;

            try {
                picture = await storeClient.GetPictureById2Async(id).ConfigureAwait(continueOnCapturedContext: false);
            } catch (ApiException e) {
                Debug.WriteLine(e.Message + "\n" + e.StackTrace + "\nInner :"
                    + e.InnerException.Message);
            }
            if (picture != null) {
                return "data:" + picture.MimeType + ";base64,"
                    + Convert.ToBase64String(picture.PictureBinary);
            } else {
                return "";
            }
        }

        public async Task<List<Category>> GetCategoriesAsList() {
            List<Category> categories = null;

            try {
                var temp = await storeClient.GetCategoriesAsync().ConfigureAwait(continueOnCapturedContext: false);
                categories = temp.ToList();
            } catch (ApiException e) {
                Debug.WriteLine(e.Message + "\n" + e.StackTrace + "\nInner :"
                    + e.InnerException.Message);
            }
            if (categories != null) {
                return categories;
            }
            return new List<Category>();
        }
    }
}