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
using DevExpress.Web.ASPxNavBar;

public partial class WebUserControl : System.Web.UI.UserControl, ITemplate
{

    protected void Page_Load(object sender, EventArgs e){
        NavBarItemTemplateContainer container = this.NamingContainer as NavBarItemTemplateContainer;
        string groupIndex = container.Item.Group.Index.ToString();
        ASPxButton1.ClientSideEvents.Click = "function(s, e){OnButtonClick(s, e, true, " + groupIndex + ")}";
        ASPxButton2.ClientSideEvents.Click = "function(s, e){OnButtonClick(s, e, false, " + groupIndex + ")}";
    }

    void ITemplate.InstantiateIn(Control container) {
        container.Controls.Add(this);
    }
}
