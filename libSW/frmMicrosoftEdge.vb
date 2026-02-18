Imports Microsoft.Win32

Public Class frmMicrosoftEdge
   Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
	  ' Current User
	  If chkBoxComposeInlineEnabled.Checked Then
		 RegWriteDWord(Registry.CurrentUser, "Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowCopilotButton", 0)
	  End If
   End Sub
End Class