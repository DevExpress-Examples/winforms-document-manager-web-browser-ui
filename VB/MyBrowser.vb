Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace ChildStandaloneForm

    Public Partial Class MyBrowser
        Inherits UserControl

        Const topIndent As Integer = 30

        Const startPage As String = "http://www.google.com"

        Public Sub New()
            InitializeComponent()
            SubscribeWebBrowserEvents()
            LoadNewDocument(startPage)
            AddHandler buttonEdit1.KeyDown, New KeyEventHandler(AddressOf buttonEdit1_KeyDown)
            AddHandler Resize, New EventHandler(AddressOf MyBrowser_Resize)
            AddHandler Disposed, New EventHandler(AddressOf MyBrowser_Disposed)
        End Sub

        Private Sub MyBrowser_Disposed(ByVal sender As Object, ByVal e As EventArgs)
            webBrowser1.Dispose()
        End Sub

        Private Sub MyBrowser_Resize(ByVal sender As Object, ByVal e As EventArgs)
            webBrowser1.Width = Width - 6
            webBrowser1.Height = Height - topIndent
        End Sub

        Private Sub buttonEdit1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode = Keys.Enter Then LoadNewDocument(buttonEdit1.Text)
        End Sub

        Private Sub SubscribeWebBrowserEvents()
            AddHandler webBrowser1.DocumentTitleChanged, New EventHandler(AddressOf webBrowser1_DocumentTitleChanged)
            AddHandler webBrowser1.CanGoBackChanged, New EventHandler(AddressOf webBrowser1_CanGoBackChanged)
            AddHandler webBrowser1.CanGoForwardChanged, New EventHandler(AddressOf webBrowser1_CanGoForwardChanged)
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

        Public ReadOnly Property Title As String
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
            If String.IsNullOrEmpty(address) Then Return
            If address.Equals("about:blank") Then Return
            If Not address.StartsWith("http://") AndAlso Not address.StartsWith("https://") Then
                address = "http://" & address
            End If

            Try
                webBrowser1.Navigate(New Uri(address))
                buttonEdit1.Text = address
            Catch __unusedUriFormatException1__ As UriFormatException
                Return
            End Try
        End Sub

        Private Sub buttonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            LoadNewDocument(buttonEdit1.Text)
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            webBrowser1.GoBack()
        End Sub

        Private Sub simpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs)
            webBrowser1.GoForward()
        End Sub

        Private Sub simpleButton1_Click_1(ByVal sender As Object, ByVal e As EventArgs)
            LoadNewDocument(buttonEdit1.Text)
        End Sub
    End Class
End Namespace
