using System;
using System.Web.UI;

namespace WebApp {

    public partial class _Default : Page {
        private DAL dal = DAL.Instance;

        protected void Page_Load(object sender, EventArgs e) {
            test_IMG.ImageUrl = dal.GetCategoryImgSrcById(5).Result;
        }
    }
}