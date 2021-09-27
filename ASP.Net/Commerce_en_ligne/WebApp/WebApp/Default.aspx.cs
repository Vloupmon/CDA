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

        protected void Page_Load(object sender, EventArgs e) {
            Utils utils = Utils.Instance;
            test_IMG.ImageUrl = utils.GetImgHTML(20).Result;
        }
    }
}