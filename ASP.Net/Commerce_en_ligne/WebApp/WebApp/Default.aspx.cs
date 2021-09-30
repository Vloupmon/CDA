using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using StoreAPI;

namespace WebApp {

    public partial class _Default : Page {
        private readonly DAL dal = DAL.Instance;

        protected void Page_Load(object sender, EventArgs e) {
            testIMG.ImageUrl = dal.GetCategoryImgSrcById(5).Result;
            List<Category> list = dal.GetCategoriesAsList().Result;
            foreach (Category cat in list) {
                ListItem li = new ListItem {
                    Text = cat.Id + " - " + cat.Name
                };
                testList.Items.Add(li);
            }
        }
    }
}