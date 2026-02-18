Imports System.Runtime
Imports System.Windows
Imports System.Windows.Forms.Design.AxImporter
Imports libVM
Imports libSW
Imports libWindows
Imports Utilities.libUtilities

Public Class frmMain
   Public Sub ProcessOptions(frm As String)
      Dim frmChild As Form = Nothing
      scMain.Panel2.Controls.Clear()
      Me.Text = "Wisperer"
      Select Case frm
         Case "Microsoft Windows\AI"
            frmChild = New frmAI()
         Case "Microsoft Windows\Regional Settings"
            frmChild = New frmRegion()
         Case "Microsoft Windows\Start Menu"
            frmChild = New frmStartMenu()
         Case "Microsoft Windows\TaskBar"
            frmChild = New frmTaskBar()
         Case "Microsoft Windows\Theme"
            frmChild = New frmTheme()
         Case "Microsoft Windows\Virtualization\Hyper-V"
            frmChild = New frmHyperV()
         Case "Microsoft Edge"
            frmChild = New frmMicrosoftEdge()
         Case Else
      End Select
      If frmChild IsNot Nothing Then
         ' Embed the form inside the right panel
         frmChild.TopLevel = False
         frmChild.FormBorderStyle = FormBorderStyle.None
         frmChild.Dock = DockStyle.Fill
         scMain.Panel2.Controls.Add(frmChild)
         frmChild.Show()
      End If
   End Sub

   Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      tvItems.ExpandAll()

      ' resize
      Me.Width = Screen.PrimaryScreen.WorkingArea.Width * 0.75 ' 75%
      Me.Height = Screen.PrimaryScreen.WorkingArea.Height * 0.75

      ' recenter
      Me.StartPosition = FormStartPosition.Manual
      Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
      Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2

	  ' check admin privileges
	  If IsRunningAsAdmin() Then
         StatusStrip.Items(0).Text = "Whisperer is running with Admin privileges"
      Else
         StatusStrip.Items(0).Text = "Whisperer is NOT running with Admin privileges"
      End If
   End Sub

    Private Sub tvItems_DoubleClick(sender As Object, e As EventArgs) Handles tvItems.DoubleClick
        If tvItems.SelectedNode Is Nothing Then
            MsgBox("Please select a node first.", MsgBoxStyle.Exclamation, "No Node Selected")
            Return
        Else
            ProcessOptions(tvItems.SelectedNode.FullPath)
        End If
    End Sub

    Private Sub tvItems_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvItems.NodeMouseDoubleClick
        e.Node.Toggle()
    End Sub

End Class
