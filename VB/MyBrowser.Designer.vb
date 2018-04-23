Imports Microsoft.VisualBasic
Imports System
Namespace ChildStandaloneForm
	Partial Public Class MyBrowser
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.btnForward = New DevExpress.XtraEditors.SimpleButton()
			Me.btnBack = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' webBrowser1
			' 
			Me.webBrowser1.Location = New System.Drawing.Point(6, 32)
			Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
			Me.webBrowser1.Name = "webBrowser1"
			Me.webBrowser1.Size = New System.Drawing.Size(1128, 456)
			Me.webBrowser1.TabIndex = 0
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Location = New System.Drawing.Point(90, 4)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, My.Resources.search, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True)})
			Me.buttonEdit1.Size = New System.Drawing.Size(554, 21)
			Me.buttonEdit1.TabIndex = 1
'			Me.buttonEdit1.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit1_ButtonClick);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Image = My.Resources.refresh
			Me.simpleButton1.Location = New System.Drawing.Point(61, 3)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(23, 22)
			Me.simpleButton1.TabIndex = 4
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click_1);
			' 
			' btnForward
			' 
			Me.btnForward.Enabled = False
			Me.btnForward.Image = My.Resources.forward
			Me.btnForward.Location = New System.Drawing.Point(32, 3)
			Me.btnForward.Name = "btnForward"
			Me.btnForward.Size = New System.Drawing.Size(23, 22)
			Me.btnForward.TabIndex = 3
'			Me.btnForward.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' btnBack
			' 
			Me.btnBack.Enabled = False
			Me.btnBack.Image = My.Resources.back
			Me.btnBack.Location = New System.Drawing.Point(3, 3)
			Me.btnBack.Name = "btnBack"
			Me.btnBack.Size = New System.Drawing.Size(23, 22)
			Me.btnBack.TabIndex = 2
'			Me.btnBack.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' MyBrowser
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.webBrowser1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.btnForward)
			Me.Controls.Add(Me.btnBack)
			Me.Controls.Add(Me.buttonEdit1)
			Me.Name = "MyBrowser"
			Me.Size = New System.Drawing.Size(1134, 488)
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private webBrowser1 As System.Windows.Forms.WebBrowser
		Private WithEvents buttonEdit1 As DevExpress.XtraEditors.ButtonEdit
		Private WithEvents btnBack As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnForward As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace
