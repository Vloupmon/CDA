using System;
using System.Web.UI;
using StoreAPI;

namespace WebApp {

    public partial class SiteMaster : MasterPage {

        protected void Page_Load(object sender, EventArgs e) {
            DAL dal = DAL.Instance;

            //Load currency dropdown list
            CurrencyDropDownList.DataSource = dal.storeClient.GetCurrenciesAsync().Result;
            CurrencyDropDownList.DataTextField = "Name";
            CurrencyDropDownList.DataValueField = "Rate";
            CurrencyDropDownList.DataBind();
        }
    }
}