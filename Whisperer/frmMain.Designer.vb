<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim TreeNode1 As TreeNode = New TreeNode("AI")
        Dim TreeNode2 As TreeNode = New TreeNode("Start Menu")
        Dim TreeNode3 As TreeNode = New TreeNode("TaskBar")
        Dim TreeNode4 As TreeNode = New TreeNode("Theme")
        Dim TreeNode5 As TreeNode = New TreeNode("Hyper-V")
        Dim TreeNode6 As TreeNode = New TreeNode("Virtualization", New TreeNode() {TreeNode5})
        Dim TreeNode7 As TreeNode = New TreeNode("Windows Explorer")
        Dim TreeNode8 As TreeNode = New TreeNode("Windows Search")
        Dim TreeNode9 As TreeNode = New TreeNode("Microsoft Windows", New TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As TreeNode = New TreeNode("Google Chrome")
        Dim TreeNode11 As TreeNode = New TreeNode("Mozilla Firefox")
        Dim TreeNode12 As TreeNode = New TreeNode("Opera")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        scMain = New SplitContainer()
        tvItems = New TreeView()
        imgList = New ImageList(components)
        CType(scMain, ComponentModel.ISupportInitialize).BeginInit()
        scMain.Panel1.SuspendLayout()
        scMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' scMain
        ' 
        scMain.Dock = DockStyle.Fill
        scMain.FixedPanel = FixedPanel.Panel1
        scMain.Location = New Point(0, 0)
        scMain.Margin = New Padding(4, 3, 4, 3)
        scMain.Name = "scMain"
        ' 
        ' scMain.Panel1
        ' 
        scMain.Panel1.AccessibleName = ""
        scMain.Panel1.Controls.Add(tvItems)
        scMain.Size = New Size(933, 519)
        scMain.SplitterDistance = 273
        scMain.SplitterWidth = 5
        scMain.TabIndex = 0
        ' 
        ' tvItems
        ' 
        tvItems.Dock = DockStyle.Fill
        tvItems.ImageIndex = 0
        tvItems.ImageList = imgList
        tvItems.Location = New Point(0, 0)
        tvItems.Margin = New Padding(4, 3, 4, 3)
        tvItems.Name = "tvItems"
        TreeNode1.Name = "Node9"
        TreeNode1.Text = "AI"
        TreeNode2.Name = "Node1"
        TreeNode2.Text = "Start Menu"
        TreeNode3.Name = "Node2"
        TreeNode3.Text = "TaskBar"
        TreeNode4.Name = "Node10"
        TreeNode4.Text = "Theme"
        TreeNode5.ImageKey = "HyperV"
        TreeNode5.Name = "Node8"
        TreeNode5.Text = "Hyper-V"
        TreeNode6.Name = "Node7"
        TreeNode6.Text = "Virtualization"
        TreeNode7.Name = "Node0"
        TreeNode7.Text = "Windows Explorer"
        TreeNode8.Name = "Node3"
        TreeNode8.Text = "Windows Search"
        TreeNode9.Name = "Node0"
        TreeNode9.Text = "Microsoft Windows"
        TreeNode10.Name = "Node4"
        TreeNode10.Text = "Google Chrome"
        TreeNode11.Name = "Node6"
        TreeNode11.Text = "Mozilla Firefox"
        TreeNode12.Name = "Node5"
        TreeNode12.Text = "Opera"
        tvItems.Nodes.AddRange(New TreeNode() {TreeNode9, TreeNode10, TreeNode11, TreeNode12})
        tvItems.SelectedImageIndex = 0
        tvItems.Size = New Size(273, 519)
        tvItems.TabIndex = 0
        ' 
        ' imgList
        ' 
        imgList.ColorDepth = ColorDepth.Depth32Bit
        imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), ImageListStreamer)
        imgList.TransparentColor = Color.Transparent
        imgList.Images.SetKeyName(0, "empty.ico")
        imgList.Images.SetKeyName(1, "HyperV")
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 519)
        Controls.Add(scMain)
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmMain"
        Text = "Whisperer"
        scMain.Panel1.ResumeLayout(False)
        CType(scMain, ComponentModel.ISupportInitialize).EndInit()
        scMain.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents scMain As SplitContainer
	Friend WithEvents tvItems As TreeView
    Friend WithEvents imgList As ImageList
End Class
