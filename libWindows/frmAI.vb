Imports Microsoft.Win32

Public Class frmAI
   Private Sub frmAI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	  If Not IsRunningAsAdmin() Then
		 chkBoxNoUseStoreOpenWith.Enabled = False
	  End If
   End Sub

   Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click

	  ' Current User
	  If chkBoxBingSearchEnabled.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "BingSearchEnabled", 0)
	  End If

	  If chkBoxCortanaConsent.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "CortanaConsent", 0)
	  End If

	  If chkBoxAllowSearchToUseLocation.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "AllowSearchToUseLocation", 0)
	  End If

	  ' Local Machine
	  If chkBoxNoUseStoreOpenWith.Checked Then
		 RegWriteDWord(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows\Explorer", "AllowSearchToUseLocation", 1)
	  End If

   End Sub

End Class