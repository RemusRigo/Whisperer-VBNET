Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32

Public Class frmTaskBar

   Private isInitialized As Boolean = False

   Private Sub frmTaskBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      cbSearchBox.Items.AddRange(New String() {"Hidden", "Show search icon only", "Show search box", "Show search button"})
      Try
         Using key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Search", False)
            If key IsNot Nothing Then
               cbSearchBox.SelectedIndex = Convert.ToInt32(key.GetValue("SearchboxTaskbarMode", Nothing))
            End If
         End Using
      Catch ex As Exception
         MessageBox.Show("Error: " & ex.Message)
      End Try
      isInitialized = True
   End Sub

   Private Sub cbSearchBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchBox.SelectedIndexChanged
      If isInitialized Then
         Try
            Using key As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Search", True)
               key.SetValue("SearchboxTaskbarMode", cbSearchBox.SelectedIndex, RegistryValueKind.DWord)
            End Using
         Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
         End Try
      End If
   End Sub
End Class