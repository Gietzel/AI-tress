<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        panelLogo = New Panel()
        pictureBox1 = New PictureBox()
        PanelSideMenu = New Panel()
        btnExit = New Button()
        btnHelp = New Button()
        PanelToolsSubmenu = New Panel()
        button10 = New Button()
        button12 = New Button()
        button13 = New Button()
        btnTools = New Button()
        PanelPlaylistSubmenu = New Panel()
        button1 = New Button()
        button6 = New Button()
        button7 = New Button()
        button8 = New Button()
        btnPlaylist = New Button()
        PanelChildForm = New Panel()
        TextBox1 = New TextBox()
        PictureBox9 = New PictureBox()
        panelLogo.SuspendLayout()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelSideMenu.SuspendLayout()
        PanelToolsSubmenu.SuspendLayout()
        PanelPlaylistSubmenu.SuspendLayout()
        PanelChildForm.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelLogo
        ' 
        panelLogo.BackColor = Color.PeachPuff
        panelLogo.Controls.Add(pictureBox1)
        panelLogo.Dock = DockStyle.Top
        panelLogo.Location = New Point(0, 0)
        panelLogo.Name = "panelLogo"
        panelLogo.Size = New Size(246, 92)
        panelLogo.TabIndex = 0
        ' 
        ' pictureBox1
        ' 
        pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Image)
        pictureBox1.Location = New Point(57, 0)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(136, 92)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 0
        pictureBox1.TabStop = False
        ' 
        ' PanelSideMenu
        ' 
        PanelSideMenu.AutoScroll = True
        PanelSideMenu.BackColor = Color.LavenderBlush
        PanelSideMenu.BorderStyle = BorderStyle.Fixed3D
        PanelSideMenu.Controls.Add(btnExit)
        PanelSideMenu.Controls.Add(btnHelp)
        PanelSideMenu.Controls.Add(PanelToolsSubmenu)
        PanelSideMenu.Controls.Add(btnTools)
        PanelSideMenu.Controls.Add(PanelPlaylistSubmenu)
        PanelSideMenu.Controls.Add(btnPlaylist)
        PanelSideMenu.Controls.Add(panelLogo)
        PanelSideMenu.Dock = DockStyle.Left
        PanelSideMenu.Location = New Point(0, 0)
        PanelSideMenu.Name = "PanelSideMenu"
        PanelSideMenu.Size = New Size(250, 568)
        PanelSideMenu.TabIndex = 0
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.PeachPuff
        btnExit.Dock = DockStyle.Bottom
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(23), CByte(21), CByte(32))
        btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(24), CByte(22), CByte(34))
        btnExit.Font = New Font("Microsoft Sans Serif", 11.25F)
        btnExit.ForeColor = Color.Black
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.ImageAlign = ContentAlignment.MiddleLeft
        btnExit.Location = New Point(0, 519)
        btnExit.Name = "btnExit"
        btnExit.Padding = New Padding(5, 0, 0, 0)
        btnExit.Size = New Size(246, 45)
        btnExit.TabIndex = 9
        btnExit.Text = "  Exit"
        btnExit.TextAlign = ContentAlignment.MiddleLeft
        btnExit.TextImageRelation = TextImageRelation.ImageBeforeText
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnHelp
        ' 
        btnHelp.BackColor = Color.PeachPuff
        btnHelp.Dock = DockStyle.Top
        btnHelp.FlatAppearance.BorderSize = 0
        btnHelp.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(23), CByte(21), CByte(32))
        btnHelp.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(24), CByte(22), CByte(34))
        btnHelp.Font = New Font("Microsoft Sans Serif", 11.25F)
        btnHelp.ForeColor = Color.Black
        btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), Image)
        btnHelp.ImageAlign = ContentAlignment.MiddleLeft
        btnHelp.Location = New Point(0, 467)
        btnHelp.Name = "btnHelp"
        btnHelp.Padding = New Padding(5, 0, 0, 0)
        btnHelp.Size = New Size(246, 45)
        btnHelp.TabIndex = 8
        btnHelp.Text = "  Help"
        btnHelp.TextAlign = ContentAlignment.MiddleLeft
        btnHelp.TextImageRelation = TextImageRelation.ImageBeforeText
        btnHelp.UseVisualStyleBackColor = False
        ' 
        ' PanelToolsSubmenu
        ' 
        PanelToolsSubmenu.BackColor = Color.LavenderBlush
        PanelToolsSubmenu.Controls.Add(button10)
        PanelToolsSubmenu.Controls.Add(button12)
        PanelToolsSubmenu.Controls.Add(button13)
        PanelToolsSubmenu.Dock = DockStyle.Top
        PanelToolsSubmenu.Location = New Point(0, 347)
        PanelToolsSubmenu.Name = "PanelToolsSubmenu"
        PanelToolsSubmenu.Size = New Size(246, 120)
        PanelToolsSubmenu.TabIndex = 7
        ' 
        ' button10
        ' 
        button10.BackColor = Color.LavenderBlush
        button10.Dock = DockStyle.Top
        button10.FlatAppearance.BorderSize = 0
        button10.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button10.FlatStyle = FlatStyle.Popup
        button10.Font = New Font("Microsoft Sans Serif", 11.25F)
        button10.ForeColor = Color.Black
        button10.Location = New Point(0, 80)
        button10.Name = "button10"
        button10.Padding = New Padding(35, 0, 0, 0)
        button10.Size = New Size(246, 40)
        button10.TabIndex = 2
        button10.Text = "Preferences"
        button10.TextAlign = ContentAlignment.MiddleLeft
        button10.UseVisualStyleBackColor = False
        ' 
        ' button12
        ' 
        button12.BackColor = Color.LavenderBlush
        button12.Dock = DockStyle.Top
        button12.FlatAppearance.BorderSize = 0
        button12.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button12.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button12.FlatStyle = FlatStyle.Popup
        button12.Font = New Font("Microsoft Sans Serif", 11.25F)
        button12.ForeColor = Color.Black
        button12.Location = New Point(0, 40)
        button12.Name = "button12"
        button12.Padding = New Padding(35, 0, 0, 0)
        button12.Size = New Size(246, 40)
        button12.TabIndex = 1
        button12.Text = "Effects and filters"
        button12.TextAlign = ContentAlignment.MiddleLeft
        button12.UseVisualStyleBackColor = False
        ' 
        ' button13
        ' 
        button13.BackColor = Color.LavenderBlush
        button13.Dock = DockStyle.Top
        button13.FlatAppearance.BorderSize = 0
        button13.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button13.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button13.FlatStyle = FlatStyle.Popup
        button13.Font = New Font("Microsoft Sans Serif", 11.25F)
        button13.ForeColor = Color.Black
        button13.Location = New Point(0, 0)
        button13.Name = "button13"
        button13.Padding = New Padding(35, 0, 0, 0)
        button13.Size = New Size(246, 40)
        button13.TabIndex = 0
        button13.Text = "Media converter"
        button13.TextAlign = ContentAlignment.MiddleLeft
        button13.UseVisualStyleBackColor = False
        ' 
        ' btnTools
        ' 
        btnTools.BackColor = Color.PeachPuff
        btnTools.Dock = DockStyle.Top
        btnTools.FlatAppearance.BorderSize = 0
        btnTools.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(23), CByte(21), CByte(32))
        btnTools.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(24), CByte(22), CByte(34))
        btnTools.Font = New Font("Microsoft Sans Serif", 11.25F)
        btnTools.ForeColor = Color.Black
        btnTools.Image = CType(resources.GetObject("btnTools.Image"), Image)
        btnTools.ImageAlign = ContentAlignment.MiddleLeft
        btnTools.Location = New Point(0, 302)
        btnTools.Name = "btnTools"
        btnTools.Padding = New Padding(5, 0, 0, 0)
        btnTools.Size = New Size(246, 45)
        btnTools.TabIndex = 6
        btnTools.Text = "  Tools"
        btnTools.TextAlign = ContentAlignment.MiddleLeft
        btnTools.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTools.UseVisualStyleBackColor = False
        ' 
        ' PanelPlaylistSubmenu
        ' 
        PanelPlaylistSubmenu.BackColor = Color.LavenderBlush
        PanelPlaylistSubmenu.Controls.Add(button1)
        PanelPlaylistSubmenu.Controls.Add(button6)
        PanelPlaylistSubmenu.Controls.Add(button7)
        PanelPlaylistSubmenu.Controls.Add(button8)
        PanelPlaylistSubmenu.Dock = DockStyle.Top
        PanelPlaylistSubmenu.Location = New Point(0, 137)
        PanelPlaylistSubmenu.Name = "PanelPlaylistSubmenu"
        PanelPlaylistSubmenu.Size = New Size(246, 165)
        PanelPlaylistSubmenu.TabIndex = 4
        ' 
        ' button1
        ' 
        button1.BackColor = Color.LavenderBlush
        button1.Dock = DockStyle.Top
        button1.FlatAppearance.BorderSize = 0
        button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button1.FlatStyle = FlatStyle.Popup
        button1.Font = New Font("Microsoft Sans Serif", 11.25F)
        button1.ForeColor = Color.Black
        button1.Location = New Point(0, 120)
        button1.Name = "button1"
        button1.Padding = New Padding(35, 0, 0, 0)
        button1.Size = New Size(246, 40)
        button1.TabIndex = 3
        button1.Text = "Export playlist"
        button1.TextAlign = ContentAlignment.MiddleLeft
        button1.UseVisualStyleBackColor = False
        ' 
        ' button6
        ' 
        button6.BackColor = Color.LavenderBlush
        button6.Dock = DockStyle.Top
        button6.FlatAppearance.BorderSize = 0
        button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button6.FlatStyle = FlatStyle.Popup
        button6.Font = New Font("Microsoft Sans Serif", 11.25F)
        button6.ForeColor = Color.Black
        button6.Location = New Point(0, 80)
        button6.Name = "button6"
        button6.Padding = New Padding(35, 0, 0, 0)
        button6.Size = New Size(246, 40)
        button6.TabIndex = 2
        button6.Text = "Import playlist"
        button6.TextAlign = ContentAlignment.MiddleLeft
        button6.UseVisualStyleBackColor = False
        ' 
        ' button7
        ' 
        button7.BackColor = Color.LavenderBlush
        button7.Dock = DockStyle.Top
        button7.FlatAppearance.BorderSize = 0
        button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button7.FlatStyle = FlatStyle.Popup
        button7.Font = New Font("Microsoft Sans Serif", 11.25F)
        button7.ForeColor = Color.Black
        button7.Location = New Point(0, 40)
        button7.Name = "button7"
        button7.Padding = New Padding(35, 0, 0, 0)
        button7.Size = New Size(246, 40)
        button7.TabIndex = 1
        button7.Text = "Managing playlist"
        button7.TextAlign = ContentAlignment.MiddleLeft
        button7.UseVisualStyleBackColor = False
        ' 
        ' button8
        ' 
        button8.BackColor = Color.LavenderBlush
        button8.Dock = DockStyle.Top
        button8.FlatAppearance.BorderSize = 0
        button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        button8.FlatStyle = FlatStyle.Popup
        button8.Font = New Font("Microsoft Sans Serif", 11.25F)
        button8.ForeColor = Color.Black
        button8.Location = New Point(0, 0)
        button8.Name = "button8"
        button8.Padding = New Padding(35, 0, 0, 0)
        button8.Size = New Size(246, 40)
        button8.TabIndex = 0
        button8.Text = "New playlist"
        button8.TextAlign = ContentAlignment.MiddleLeft
        button8.UseVisualStyleBackColor = False
        ' 
        ' btnPlaylist
        ' 
        btnPlaylist.BackColor = Color.PeachPuff
        btnPlaylist.Dock = DockStyle.Top
        btnPlaylist.FlatAppearance.BorderSize = 0
        btnPlaylist.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(23), CByte(21), CByte(32))
        btnPlaylist.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(24), CByte(22), CByte(34))
        btnPlaylist.Font = New Font("Microsoft Sans Serif", 11.25F)
        btnPlaylist.ForeColor = Color.Black
        btnPlaylist.Image = CType(resources.GetObject("btnPlaylist.Image"), Image)
        btnPlaylist.ImageAlign = ContentAlignment.MiddleLeft
        btnPlaylist.Location = New Point(0, 92)
        btnPlaylist.Name = "btnPlaylist"
        btnPlaylist.Padding = New Padding(5, 0, 0, 0)
        btnPlaylist.Size = New Size(246, 45)
        btnPlaylist.TabIndex = 3
        btnPlaylist.Text = "  Playlist management"
        btnPlaylist.TextAlign = ContentAlignment.MiddleLeft
        btnPlaylist.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPlaylist.UseVisualStyleBackColor = False
        ' 
        ' PanelChildForm
        ' 
        PanelChildForm.BackColor = Color.LavenderBlush
        PanelChildForm.Controls.Add(TextBox1)
        PanelChildForm.Controls.Add(PictureBox9)
        PanelChildForm.Dock = DockStyle.Fill
        PanelChildForm.Location = New Point(250, 0)
        PanelChildForm.Name = "PanelChildForm"
        PanelChildForm.Size = New Size(684, 568)
        PanelChildForm.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.ForeColor = Color.Gray
        TextBox1.Location = New Point(79, 361)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = " Como posso ajudar?"
        TextBox1.Size = New Size(533, 23)
        TextBox1.TabIndex = 1
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(3, 79)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(681, 276)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 0
        PictureBox9.TabStop = False
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(934, 568)
        Controls.Add(PanelChildForm)
        Controls.Add(PanelSideMenu)
        Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        MinimumSize = New Size(950, 600)
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        panelLogo.ResumeLayout(False)
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelSideMenu.ResumeLayout(False)
        PanelToolsSubmenu.ResumeLayout(False)
        PanelPlaylistSubmenu.ResumeLayout(False)
        PanelChildForm.ResumeLayout(False)
        PanelChildForm.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Private WithEvents panelLogo As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents PanelSideMenu As Panel
    Private WithEvents btnExit As Button
    Private WithEvents btnHelp As Button
    Private WithEvents PanelToolsSubmenu As Panel
    Private WithEvents button10 As Button
    Private WithEvents button12 As Button
    Private WithEvents button13 As Button
    Private WithEvents btnTools As Button
    Private WithEvents PanelPlaylistSubmenu As Panel
    Private WithEvents button1 As Button
    Private WithEvents button6 As Button
    Private WithEvents button7 As Button
    Private WithEvents button8 As Button
    Private WithEvents btnPlaylist As Button
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
