<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMicrosoftEdge
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
	  Try
		 If disposing AndAlso components IsNot Nothing Then
			components.Dispose()
		 End If
	  Finally
		 MyBase.Dispose(disposing)
	  End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
	  chkBoxComposeInlineEnabled = New CheckBox()
	  btnRun = New Button()
	  SuspendLayout()
	  ' 
	  ' chkBoxComposeInlineEnabled
	  ' 
	  chkBoxComposeInlineEnabled.AutoSize = True
	  chkBoxComposeInlineEnabled.Location = New Point(5, 5)
	  chkBoxComposeInlineEnabled.Name = "chkBoxComposeInlineEnabled"
	  chkBoxComposeInlineEnabled.Size = New Size(133, 19)
	  chkBoxComposeInlineEnabled.TabIndex = 0
	  chkBoxComposeInlineEnabled.Text = "AI writing assistance"
	  chkBoxComposeInlineEnabled.UseVisualStyleBackColor = True
	  ' 
	  ' btnRun
	  ' 
	  btnRun.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
	  btnRun.Location = New Point(800, 430)
	  btnRun.Name = "btnRun"
	  btnRun.Size = New Size(75, 23)
	  btnRun.TabIndex = 1
	  btnRun.Text = "Run"
	  btnRun.UseVisualStyleBackColor = True
	  ' 
	  ' frmMicrosoftEdge
	  ' 
	  AutoScaleDimensions = New SizeF(7F, 15F)
	  AutoScaleMode = AutoScaleMode.Font
	  ClientSize = New Size(884, 461)
	  Controls.Add(btnRun)
	  Controls.Add(chkBoxComposeInlineEnabled)
	  Name = "frmMicrosoftEdge"
	  Text = "Microsoft Edge"
	  ResumeLayout(False)
	  PerformLayout()
   End Sub

   Friend WithEvents chkBoxComposeInlineEnabled As CheckBox
   Friend WithEvents btnRun As Button
End Class
