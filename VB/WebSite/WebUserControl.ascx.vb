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

Partial Public Class WebUserControl
	Inherits System.Web.UI.UserControl
	Implements ITemplate

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim container As NavBarItemTemplateContainer = TryCast(Me.NamingContainer, NavBarItemTemplateContainer)
		Dim groupIndex As String = container.Item.Group.Index.ToString()
		ASPxButton1.ClientSideEvents.Click = "function(s, e){OnButtonClick(s, e, true, " & groupIndex & ")}"
		ASPxButton2.ClientSideEvents.Click = "function(s, e){OnButtonClick(s, e, false, " & groupIndex & ")}"
	End Sub

	Private Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
		container.Controls.Add(Me)
	End Sub
End Class
