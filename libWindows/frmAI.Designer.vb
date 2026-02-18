<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAI
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
	  btnDisable = New Button()
	  tabCOntrolAI = New TabControl()
	  TabPage1 = New TabPage()
	  chkBoxNoUseStoreOpenWith = New CheckBox()
	  chkBoxAllowSearchToUseLocation = New CheckBox()
	  chkBoxCortanaConsent = New CheckBox()
	  chkBoxBingSearchEnabled = New CheckBox()
	  TabPage2 = New TabPage()
	  chkCopilot = New CheckBox()
	  TabPage3 = New TabPage()
	  tabCOntrolAI.SuspendLayout()
	  TabPage1.SuspendLayout()
	  TabPage2.SuspendLayout()
	  SuspendLayout()
	  ' 
	  ' btnDisable
	  ' 
	  btnDisable.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
	  btnDisable.Location = New Point(755, 435)
	  btnDisable.Name = "btnDisable"
	  btnDisable.Size = New Size(75, 23)
	  btnDisable.TabIndex = 1
	  btnDisable.Text = "Disable"
	  btnDisable.UseVisualStyleBackColor = True
	  ' 
	  ' tabCOntrolAI
	  ' 
	  tabCOntrolAI.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
	  tabCOntrolAI.Controls.Add(TabPage1)
	  tabCOntrolAI.Controls.Add(TabPage2)
	  tabCOntrolAI.Controls.Add(TabPage3)
	  tabCOntrolAI.Location = New Point(0, 0)
	  tabCOntrolAI.Name = "tabCOntrolAI"
	  tabCOntrolAI.SelectedIndex = 0
	  tabCOntrolAI.Size = New Size(834, 429)
	  tabCOntrolAI.TabIndex = 3
	  ' 
	  ' TabPage1
	  ' 
	  TabPage1.Controls.Add(chkBoxNoUseStoreOpenWith)
	  TabPage1.Controls.Add(chkBoxAllowSearchToUseLocation)
	  TabPage1.Controls.Add(chkBoxCortanaConsent)
	  TabPage1.Controls.Add(chkBoxBingSearchEnabled)
	  TabPage1.Location = New Point(4, 24)
	  TabPage1.Name = "TabPage1"
	  TabPage1.Padding = New Padding(3)
	  TabPage1.Size = New Size(826, 401)
	  TabPage1.TabIndex = 0
	  TabPage1.Text = "Search"
	  TabPage1.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxNoUseStoreOpenWith
	  ' 
	  chkBoxNoUseStoreOpenWith.AutoSize = True
	  chkBoxNoUseStoreOpenWith.Checked = True
	  chkBoxNoUseStoreOpenWith.CheckState = CheckState.Checked
	  chkBoxNoUseStoreOpenWith.Location = New Point(5, 65)
	  chkBoxNoUseStoreOpenWith.Name = "chkBoxNoUseStoreOpenWith"
	  chkBoxNoUseStoreOpenWith.Size = New Size(146, 19)
	  chkBoxNoUseStoreOpenWith.TabIndex = 10
	  chkBoxNoUseStoreOpenWith.Text = "Access Microsoft Store"
	  chkBoxNoUseStoreOpenWith.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxAllowSearchToUseLocation
	  ' 
	  chkBoxAllowSearchToUseLocation.AutoSize = True
	  chkBoxAllowSearchToUseLocation.Checked = True
	  chkBoxAllowSearchToUseLocation.CheckState = CheckState.Checked
	  chkBoxAllowSearchToUseLocation.Location = New Point(5, 45)
	  chkBoxAllowSearchToUseLocation.Name = "chkBoxAllowSearchToUseLocation"
	  chkBoxAllowSearchToUseLocation.Size = New Size(91, 19)
	  chkBoxAllowSearchToUseLocation.TabIndex = 9
	  chkBoxAllowSearchToUseLocation.Text = "Use location"
	  chkBoxAllowSearchToUseLocation.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxCortanaConsent
	  ' 
	  chkBoxCortanaConsent.AutoSize = True
	  chkBoxCortanaConsent.Checked = True
	  chkBoxCortanaConsent.CheckState = CheckState.Checked
	  chkBoxCortanaConsent.Location = New Point(5, 25)
	  chkBoxCortanaConsent.Name = "chkBoxCortanaConsent"
	  chkBoxCortanaConsent.Size = New Size(115, 19)
	  chkBoxCortanaConsent.TabIndex = 8
	  chkBoxCortanaConsent.Text = "Cortana Consent"
	  chkBoxCortanaConsent.UseVisualStyleBackColor = True
	  ' 
	  ' chkBoxBingSearchEnabled
	  ' 
	  chkBoxBingSearchEnabled.AutoSize = True
	  chkBoxBingSearchEnabled.Checked = True
	  chkBoxBingSearchEnabled.CheckState = CheckState.Checked
	  chkBoxBingSearchEnabled.Location = New Point(5, 5)
	  chkBoxBingSearchEnabled.Name = "chkBoxBingSearchEnabled"
	  chkBoxBingSearchEnabled.Size = New Size(88, 19)
	  chkBoxBingSearchEnabled.TabIndex = 7
	  chkBoxBingSearchEnabled.Text = "Bing Search"
	  chkBoxBingSearchEnabled.UseVisualStyleBackColor = True
	  ' 
	  ' TabPage2
	  ' 
	  TabPage2.Controls.Add(chkCopilot)
	  TabPage2.Location = New Point(4, 24)
	  TabPage2.Name = "TabPage2"
	  TabPage2.Padding = New Padding(3)
	  TabPage2.Size = New Size(826, 401)
	  TabPage2.TabIndex = 1
	  TabPage2.Text = "Copilot"
	  TabPage2.UseVisualStyleBackColor = True
	  ' 
	  ' chkCopilot
	  ' 
	  chkCopilot.AutoSize = True
	  chkCopilot.Location = New Point(381, 178)
	  chkCopilot.Name = "chkCopilot"
	  chkCopilot.Size = New Size(65, 19)
	  chkCopilot.TabIndex = 5
	  chkCopilot.Text = "Copilot"
	  chkCopilot.UseVisualStyleBackColor = True
	  ' 
	  ' TabPage3
	  ' 
	  TabPage3.Location = New Point(4, 24)
	  TabPage3.Name = "TabPage3"
	  TabPage3.Size = New Size(826, 401)
	  TabPage3.TabIndex = 2
	  TabPage3.Text = "Windows AI"
	  TabPage3.UseVisualStyleBackColor = True
	  ' 
	  ' frmAI
	  ' 
	  AutoScaleDimensions = New SizeF(7F, 15F)
	  AutoScaleMode = AutoScaleMode.Font
	  ClientSize = New Size(834, 461)
	  Controls.Add(tabCOntrolAI)
	  Controls.Add(btnDisable)
	  Name = "frmAI"
	  Text = "frmAI"
	  tabCOntrolAI.ResumeLayout(False)
	  TabPage1.ResumeLayout(False)
	  TabPage1.PerformLayout()
	  TabPage2.ResumeLayout(False)
	  TabPage2.PerformLayout()
	  ResumeLayout(False)
   End Sub

   Friend WithEvents btnDisable As Button
   Friend WithEvents tabCOntrolAI As TabControl
   Friend WithEvents TabPage1 As TabPage
   Friend WithEvents TabPage2 As TabPage
   Friend WithEvents chkBoxBingSearchEnabled As CheckBox
   Friend WithEvents chkCopilot As CheckBox
   Friend WithEvents TabPage3 As TabPage
   Friend WithEvents chkBoxAllowSearchToUseLocation As CheckBox
   Friend WithEvents chkBoxCortanaConsent As CheckBox
   Friend WithEvents chkBoxNoUseStoreOpenWith As CheckBox
End Class
