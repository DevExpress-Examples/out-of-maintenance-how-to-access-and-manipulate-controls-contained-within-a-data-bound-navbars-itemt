using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;

public partial class ASPxperience_NavBar_ClientAccessToControlsInTemplate_DataBoundVersion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected string GetItemClientName(NavBarItem item) {
        return "Item_" + item.Group.Index.ToString() + "_" + item.Index.ToString();
    }

    protected string GetGroupIndex(NavBarItem item) {
        return item.Group.Index.ToString();
    }

    protected void ASPxNavBar1_GroupDataBound(object source, NavBarGroupEventArgs e) {
        NavBarItem btnItem = e.Group.Items.Add();
        btnItem.Template = LoadControl("WebUserControl.ascx") as ITemplate;
    }
}
