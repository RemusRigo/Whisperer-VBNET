<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskBar
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
        cbSearchBox = New ComboBox()
        lblSearchBox = New Label()
        SuspendLayout()
        ' 
        ' cbSearchBox
        ' 
        cbSearchBox.DropDownStyle = ComboBoxStyle.DropDownList
        cbSearchBox.FormattingEnabled = True
        cbSearchBox.Location = New Point(92, 12)
        cbSearchBox.Name = "cbSearchBox"
        cbSearchBox.Size = New Size(121, 23)
        cbSearchBox.TabIndex = 0
        ' 
        ' lblSearchBox
        ' 
        lblSearchBox.AutoSize = True
        lblSearchBox.Location = New Point(3, 15)
        lblSearchBox.Name = "lblSearchBox"
        lblSearchBox.Size = New Size(61, 15)
        lblSearchBox.TabIndex = 1
        lblSearchBox.Text = "SearchBox"
        ' 
        ' frmTaskBar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblSearchBox)
        Controls.Add(cbSearchBox)
        Name = "frmTaskBar"
        Text = "TaskBar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbSearchBox As ComboBox
    Friend WithEvents lblSearchBox As Label
End Class
