Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxGridView

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub
	Protected Sub cbCheck_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim cb As ASPxCheckBox = TryCast(sender, ASPxCheckBox)

		Dim container As GridViewDataItemTemplateContainer = TryCast(cb.NamingContainer, GridViewDataItemTemplateContainer)
		cb.ClientInstanceName = String.Format("cbCheck{0}", container.VisibleIndex)
		cb.Checked = grid.Selection.IsRowSelected(container.VisibleIndex)

		cb.ClientSideEvents.CheckedChanged = String.Format("function (s, e) {{ grid.SelectRowOnPage ({0}, s.GetChecked()); }}", container.VisibleIndex)
	End Sub
End Class
