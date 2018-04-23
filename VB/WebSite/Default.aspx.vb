Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxNavBar
Imports DevExpress.Web.ASPxEditors

Partial Public Class ASPxperience_NavBar_ClientAccessToControlsInTemplate_DataBoundVersion
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Protected Function GetItemClientName(ByVal item As NavBarItem) As String
		Return "Item_" & item.Group.Index.ToString() & "_" & item.Index.ToString()
	End Function

	Protected Function GetGroupIndex(ByVal item As NavBarItem) As String
		Return item.Group.Index.ToString()
	End Function

	Protected Sub ASPxNavBar1_GroupDataBound(ByVal source As Object, ByVal e As NavBarGroupEventArgs)
		Dim btnItem As NavBarItem = e.Group.Items.Add()
		btnItem.Template = TryCast(LoadControl("WebUserControl.ascx"), ITemplate)
	End Sub
End Class
