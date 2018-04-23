Imports Microsoft.VisualBasic
Imports System
Namespace ChildStandaloneForm
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
			Me.documentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
			Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document3 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document4 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.document5 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.documentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' documentManager1
			' 
			Me.documentManager1.MdiParent = Me
			Me.documentManager1.View = Me.tabbedView1
			Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.tabbedView1})
			' 
			' tabbedView1
			' 
			Me.tabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() { Me.documentGroup1})
			Me.tabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.document1, Me.document2, Me.document3, Me.document4, Me.document5})
'			Me.tabbedView1.QueryControl += New DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(Me.tabbedView1_QueryControl);
			' 
			' documentGroup1
			' 
			Me.documentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() { Me.document1, Me.document2, Me.document3, Me.document4, Me.document5})
			' 
			' document1
			' 
			Me.document1.Caption = "New Page"
			Me.document1.ControlName = "document1"
			' 
			' document2
			' 
			Me.document2.Caption = "New Page"
			Me.document2.ControlName = "document2"
			' 
			' document3
			' 
			Me.document3.Caption = "New Page"
			Me.document3.ControlName = "document3"
			' 
			' document4
			' 
			Me.document4.Caption = "New Page"
			Me.document4.ControlName = "document1"
			' 
			' document5
			' 
			Me.document5.Caption = "New Page"
			Me.document5.ControlName = "document2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1149, 592)
			Me.IsMdiContainer = True
			Me.Name = "Form1"
			Me.Text = "Simple Browser"
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.documentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
		Private WithEvents tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
		Private documentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
		Private document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document2 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document3 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document4 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private document5 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel


	End Class
End Namespace

