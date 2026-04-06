Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views.Tabbed
Imports DevExpress.XtraBars.Docking2010.Views

Namespace ChildStandaloneForm

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            tabbedView1.FloatingDocumentContainer = FloatingDocumentContainer.DocumentsHost
        End Sub

        Private docs As List(Of BaseDocument) = New List(Of BaseDocument)()

        Private Sub tabbedView1_QueryControl(ByVal sender As Object, ByVal e As QueryControlEventArgs)
            Dim wb As MyBrowser = New MyBrowser()
            wb.Dock = DockStyle.Fill
            AddHandler wb.TitleChanged, AddressOf wb_TitleChanged
            docs.Add(e.Document)
            e.Control = wb
        End Sub

        Private Function FindDocument(ByVal documentControl As Object) As Document
            For Each doc As Document In docs
                If doc.Control Is documentControl Then Return doc
            Next

            Return Nothing
        End Function

        Private Sub wb_TitleChanged(ByVal sender As Object, ByVal e As EventArgs)
            tabbedView1.ActiveDocument.Caption = TryCast(tabbedView1.ActiveDocument.Control, MyBrowser).Title
            Dim activeFloatDoc As Document = FindDocument(sender) ' for floating documents
            If activeFloatDoc IsNot Nothing Then activeFloatDoc.Caption = TryCast(sender, MyBrowser).Title
        End Sub
    End Class
End Namespace
