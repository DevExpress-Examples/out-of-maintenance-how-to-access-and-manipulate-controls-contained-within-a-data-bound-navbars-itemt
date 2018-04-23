<%-- BeginRegion Page setup --%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ASPxperience_NavBar_ClientAccessToControlsInTemplate_DataBoundVersion" %>

<%@ Register Assembly="DevExpress.Web.v8.1" Namespace="DevExpress.Web.ASPxNavBar" TagPrefix="dxnb" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v8.1" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%-- EndRegion --%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>How to access and manipulate controls, contained within a data bound NavBar's ItemTemplate, on the client side</title>
</head>
<body>
    <form id="form1" runat="server">
            
    
    <script type="text/javascript">
    var cbItems = new Array();
    
    function OnButtonClick(s, e, checked, groupIndex){
        for (var i = 0; i < cbItems.length; i++){
            if(cbItems[i][0] == groupIndex){
                var checkBox = cbItems[i][1];
                checkBox.SetChecked(checked);
            }
        }
    }
    </script>
        
    <div>
        <dxnb:ASPxNavBar ID="ASPxNavBar1" runat="server" DataSourceID="XmlDataSource1" ClientInstanceName="navBar" OnGroupDataBound="ASPxNavBar1_GroupDataBound">
            <ItemTemplate>
                <dxe:ASPxCheckBox ID="ASPxCheckBox1" runat="server" ClientInstanceName="<%# GetItemClientName(Container.Item) %>"  Text='<%# Eval("Text") %>'>
                </dxe:ASPxCheckBox>
                <%# "<script type='text/javascript'>cbItems.push(new Array(" + GetGroupIndex(Container.Item) + ", " + GetItemClientName(Container.Item) + "));</script>"%>                
            </ItemTemplate>
        </dxnb:ASPxNavBar>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/NavBarCameras.xml"
            XPath="Cameras/*"></asp:XmlDataSource>
    </div>
    </form>
</body>
</html>
