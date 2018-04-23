Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraBars.Docking2010.Views

Namespace ChildStandaloneForm
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			tabbedView1.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost
		End Sub

		Private docs As New List(Of BaseDocument)()
		Private Sub tabbedView1_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs) Handles tabbedView1.QueryControl
			Dim wb As New MyBrowser()
			wb.Dock = DockStyle.Fill
			AddHandler wb.TitleChanged, AddressOf wb_TitleChanged
			docs.Add(e.Document)
			e.Control = wb
		End Sub

		Private Function FindDocument(ByVal documentControl As Object) As Document
			For Each doc As Document In docs
				If doc.Control Is documentControl Then
					Return doc
				End If
			Next doc
			Return Nothing
		End Function

		Private Sub wb_TitleChanged(ByVal sender As Object, ByVal e As EventArgs)
			tabbedView1.ActiveDocument.Caption = (TryCast(tabbedView1.ActiveDocument.Control, MyBrowser)).Title
			Dim activeFloatDoc As Document = FindDocument(sender) ' for floating documents
			If activeFloatDoc IsNot Nothing Then
				activeFloatDoc.Caption = (TryCast(sender, MyBrowser)).Title
			End If
		End Sub
	End Class
End Namespace
