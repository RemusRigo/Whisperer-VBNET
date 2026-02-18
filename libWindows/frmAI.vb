Imports Microsoft.Win32

Public Class frmAI
   Private Sub frmAI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	  If Not IsRunningAsAdmin() Then
		 chkBoxNoUseStoreOpenWith.Enabled = False
	  End If
   End Sub

   Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

	  ' Current User
	  If chkBoxShowCopilotButton.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowCopilotButton", 0)
	  End If

	  If chkBoxAllowSearchToUseLocation.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "AllowSearchToUseLocation", 0)
	  End If

	  If chkBoxBingSearchEnabled.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "BingSearchEnabled", 0)
	  End If

	  If chkBoxCortanaConsent.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Search", "CortanaConsent", 0)
	  End If

	  If chkBoxDisableSearchBoxSuggestions.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\Explorer", "DisableSearchBoxSuggestions", 1)
	  End If

	  If chkBoxDisableAIDataAnalysis.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\WindowsAI", "DisableAIDataAnalysis", 1)
	  End If

	  If chkBoxTurnOffWindowsCopilot.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Policies\Microsoft\Windows\WindowsCopilot", "TurnOffWindowsCopilot", 1)
	  End If

	  ' Local Machine
	  If chkBoxNoUseStoreOpenWith.Checked Then
		 RegWriteDWord(Registry.LocalMachine, "SOFTWARE\Policies\Microsoft\Windows\Explorer", "AllowSearchToUseLocation", 1)
	  End If

   End Sub

End Class