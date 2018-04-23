Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace ChildStandaloneForm
	Partial Public Class MyBrowser
		Inherits UserControl
		Private Const topIndent As Integer = 30
		Private Const startPage As String = "http://www.google.com"
		Public Sub New()
			InitializeComponent()
			SubscribeWebBrowserEvents()
			LoadNewDocument(startPage)
			AddHandler buttonEdit1.KeyDown, AddressOf buttonEdit1_KeyDown
			AddHandler Resize, AddressOf MyBrowser_Resize
			AddHandler Disposed, AddressOf MyBrowser_Disposed
		End Sub

		Private Sub MyBrowser_Disposed(ByVal sender As Object, ByVal e As EventArgs)
			webBrowser1.Dispose()
		End Sub

		Private Sub MyBrowser_Resize(ByVal sender As Object, ByVal e As EventArgs)
			webBrowser1.Width = Me.Width - 6
			webBrowser1.Height = Me.Height - topIndent
		End Sub

		Private Sub buttonEdit1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.KeyCode = Keys.Enter Then
				LoadNewDocument(buttonEdit1.Text)
			End If
		End Sub

		Private Sub SubscribeWebBrowserEvents()
			AddHandler webBrowser1.DocumentTitleChanged, AddressOf webBrowser1_DocumentTitleChanged
			AddHandler webBrowser1.CanGoBackChanged, AddressOf webBrowser1_CanGoBackChanged
			AddHandler webBrowser1.CanGoForwardChanged, AddressOf webBrowser1_CanGoForwardChanged
		End Sub

		Private Sub webBrowser1_CanGoForwardChanged(ByVal sender As Object, ByVal e As EventArgs)
			btnForward.Enabled = webBrowser1.CanGoForward
		End Sub

		Private Sub webBrowser1_CanGoBackChanged(ByVal sender As Object, ByVal e As EventArgs)
			btnBack.Enabled = webBrowser1.CanGoBack
		End Sub
		Private Sub webBrowser1_DocumentTitleChanged(ByVal sender As Object, ByVal e As EventArgs)
			SetTitle(webBrowser1.DocumentTitle)
			buttonEdit1.Text = Convert.ToString(webBrowser1.Url)
		End Sub

		' Fields...
		Private _Title As String

		Public ReadOnly Property Title() As String
			Get
				Return _Title
			End Get
		End Property

		Public Event TitleChanged As EventHandler

		Protected Overridable Sub OnTitleChangedEvent()
			RaiseEvent TitleChanged(Me, EventArgs.Empty)
		End Sub

		Private Sub SetTitle(ByVal s As String)
			_Title = s
			OnTitleChangedEvent()
		End Sub

		Private Sub LoadNewDocument(ByVal address As String)
			If String.IsNullOrEmpty(address) Then
				Return
			End If
			If address.Equals("about:blank") Then
				Return
			End If
			If (Not address.StartsWith("http://")) AndAlso (Not address.StartsWith("https://")) Then
				address = "http://" & address
			End If
			Try
				webBrowser1.Navigate(New Uri(address))
				buttonEdit1.Text = address
			Catch e1 As System.UriFormatException
				Return
			End Try
		End Sub

		Private Sub buttonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles buttonEdit1.ButtonClick
			LoadNewDocument(buttonEdit1.Text)
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
			webBrowser1.GoBack()
		End Sub

		Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnForward.Click
			webBrowser1.GoForward()
		End Sub

		Private Sub simpleButton1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			LoadNewDocument(buttonEdit1.Text)
		End Sub
	End Class
End Namespace
