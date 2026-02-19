Imports Microsoft.Win32

Public Class frmMicrosoftEdge
   Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
	  ' Current User

	  ' Local Machine

	  'EdgeHistoryAISearchEnabled(Set to 0) — Disables natural language history search.
	  'AIGenThemesEnabled(Set to 0) — Disables AI-generated browser themes
	  If chkBoxComposeInlineEnabled.Checked Then
		 RegWriteDWord(Registry.LocalMachine, "Software\Policies\Microsoft\Edge", "ComposeInlineEnabled", 0)
	  End If
   End Sub
End Class