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
        BtnExit = New Button()
        BtnHelp = New Button()
        BtnSettings = New Button()
        PanelResourcesSubmenu = New Panel()
        BtnSendPromo = New Button()
        BtnFillMenu = New Button()
        BtnAddClient = New Button()
        BtnResources = New Button()
        PanelChildForm = New Panel()
        TxtHelp = New TextBox()
        PictureBox9 = New PictureBox()
        panelLogo.SuspendLayout()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelSideMenu.SuspendLayout()
        PanelResourcesSubmenu.SuspendLayout()
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
        PanelSideMenu.Controls.Add(BtnExit)
        PanelSideMenu.Controls.Add(BtnHelp)
        PanelSideMenu.Controls.Add(BtnSettings)
        PanelSideMenu.Controls.Add(PanelResourcesSubmenu)
        PanelSideMenu.Controls.Add(BtnResources)
        PanelSideMenu.Controls.Add(panelLogo)
        PanelSideMenu.Dock = DockStyle.Left
        PanelSideMenu.Location = New Point(0, 0)
        PanelSideMenu.Name = "PanelSideMenu"
        PanelSideMenu.Size = New Size(250, 568)
        PanelSideMenu.TabIndex = 0
        ' 
        ' BtnExit
        ' 
        BtnExit.BackColor = Color.PeachPuff
        BtnExit.Dock = DockStyle.Top
        BtnExit.FlatAppearance.BorderSize = 0
        BtnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(23), CByte(21), CByte(32))
        BtnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(24), CByte(22), CByte(34))
        BtnExit.Font = New Font("Microsoft Sans Serif", 11.25F)
        BtnExit.ForeColor = Color.Black
        BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), Image)
        BtnExit.ImageAlign = ContentAlignment.MiddleLeft
        BtnExit.Location = New Point(0, 349)
        BtnExit.Name = "BtnExit"
        BtnExit.Padding = New Padding(5, 0, 0, 0)
        BtnExit.Size = New Size(246, 45)
        BtnExit.TabIndex = 9
        BtnExit.Text = "   Sair"
        BtnExit.TextAlign = ContentAlignment.MiddleLeft
        BtnExit.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnExit.UseVisualStyleBackColor = False
        ' 
        ' BtnHelp
        ' 
        BtnHelp.BackColor = Color.PeachPuff
        BtnHelp.Dock = DockStyle.Top
        BtnHelp.FlatAppearance.BorderSize = 0
        BtnHelp.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(23), CByte(21), CByte(32))
        BtnHelp.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(24), CByte(22), CByte(34))
        BtnHelp.Font = New Font("Microsoft Sans Serif", 11.25F)
        BtnHelp.ForeColor = Color.Black
        BtnHelp.Image = CType(resources.GetObject("BtnHelp.Image"), Image)
        BtnHelp.ImageAlign = ContentAlignment.MiddleLeft
        BtnHelp.Location = New Point(0, 304)
        BtnHelp.Name = "BtnHelp"
        BtnHelp.Padding = New Padding(5, 0, 0, 0)
        BtnHelp.Size = New Size(246, 45)
        BtnHelp.TabIndex = 8
        BtnHelp.Text = "   Ajuda"
        BtnHelp.TextAlign = ContentAlignment.MiddleLeft
        BtnHelp.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnHelp.UseVisualStyleBackColor = False
        ' 
        ' BtnSettings
        ' 
        BtnSettings.BackColor = Color.PeachPuff
        BtnSettings.Dock = DockStyle.Top
        BtnSettings.FlatAppearance.BorderSize = 0
        BtnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(23), CByte(21), CByte(32))
        BtnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(24), CByte(22), CByte(34))
        BtnSettings.Font = New Font("Microsoft Sans Serif", 11.25F)
        BtnSettings.ForeColor = Color.Black
        BtnSettings.Image = CType(resources.GetObject("BtnSettings.Image"), Image)
        BtnSettings.ImageAlign = ContentAlignment.MiddleLeft
        BtnSettings.Location = New Point(0, 259)
        BtnSettings.Name = "BtnSettings"
        BtnSettings.Padding = New Padding(5, 0, 0, 0)
        BtnSettings.Size = New Size(246, 45)
        BtnSettings.TabIndex = 6
        BtnSettings.Text = "   Configurações"
        BtnSettings.TextAlign = ContentAlignment.MiddleLeft
        BtnSettings.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnSettings.UseVisualStyleBackColor = False
        ' 
        ' PanelResourcesSubmenu
        ' 
        PanelResourcesSubmenu.BackColor = Color.LavenderBlush
        PanelResourcesSubmenu.Controls.Add(BtnSendPromo)
        PanelResourcesSubmenu.Controls.Add(BtnFillMenu)
        PanelResourcesSubmenu.Controls.Add(BtnAddClient)
        PanelResourcesSubmenu.Dock = DockStyle.Top
        PanelResourcesSubmenu.Location = New Point(0, 137)
        PanelResourcesSubmenu.Name = "PanelResourcesSubmenu"
        PanelResourcesSubmenu.Size = New Size(246, 122)
        PanelResourcesSubmenu.TabIndex = 4
        ' 
        ' BtnSendPromo
        ' 
        BtnSendPromo.BackColor = Color.LavenderBlush
        BtnSendPromo.Dock = DockStyle.Top
        BtnSendPromo.FlatAppearance.BorderSize = 0
        BtnSendPromo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        BtnSendPromo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        BtnSendPromo.FlatStyle = FlatStyle.Popup
        BtnSendPromo.Font = New Font("Microsoft Sans Serif", 11.25F)
        BtnSendPromo.ForeColor = Color.Black
        BtnSendPromo.Location = New Point(0, 80)
        BtnSendPromo.Name = "BtnSendPromo"
        BtnSendPromo.Padding = New Padding(35, 0, 0, 0)
        BtnSendPromo.Size = New Size(246, 40)
        BtnSendPromo.TabIndex = 2
        BtnSendPromo.Text = "Enviar promoção"
        BtnSendPromo.TextAlign = ContentAlignment.MiddleLeft
        BtnSendPromo.UseVisualStyleBackColor = False
        ' 
        ' BtnFillMenu
        ' 
        BtnFillMenu.BackColor = Color.LavenderBlush
        BtnFillMenu.Dock = DockStyle.Top
        BtnFillMenu.FlatAppearance.BorderSize = 0
        BtnFillMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        BtnFillMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        BtnFillMenu.FlatStyle = FlatStyle.Popup
        BtnFillMenu.Font = New Font("Microsoft Sans Serif", 11.25F)
        BtnFillMenu.ForeColor = Color.Black
        BtnFillMenu.Location = New Point(0, 40)
        BtnFillMenu.Name = "BtnFillMenu"
        BtnFillMenu.Padding = New Padding(35, 0, 0, 0)
        BtnFillMenu.Size = New Size(246, 40)
        BtnFillMenu.TabIndex = 1
        BtnFillMenu.Text = "Preencher cardápio"
        BtnFillMenu.TextAlign = ContentAlignment.MiddleLeft
        BtnFillMenu.UseVisualStyleBackColor = False
        ' 
        ' BtnAddClient
        ' 
        BtnAddClient.BackColor = Color.LavenderBlush
        BtnAddClient.Dock = DockStyle.Top
        BtnAddClient.FlatAppearance.BorderSize = 0
        BtnAddClient.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        BtnAddClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(42), CByte(38), CByte(46))
        BtnAddClient.FlatStyle = FlatStyle.Popup
        BtnAddClient.Font = New Font("Microsoft Sans Serif", 11.25F)
        BtnAddClient.ForeColor = Color.Black
        BtnAddClient.Location = New Point(0, 0)
        BtnAddClient.Name = "BtnAddClient"
        BtnAddClient.Padding = New Padding(35, 0, 0, 0)
        BtnAddClient.Size = New Size(246, 40)
        BtnAddClient.TabIndex = 0
        BtnAddClient.Text = "Adicionar cliente"
        BtnAddClient.TextAlign = ContentAlignment.MiddleLeft
        BtnAddClient.UseVisualStyleBackColor = False
        ' 
        ' BtnResources
        ' 
        BtnResources.BackColor = Color.PeachPuff
        BtnResources.Dock = DockStyle.Top
        BtnResources.FlatAppearance.BorderSize = 0
        BtnResources.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(23), CByte(21), CByte(32))
        BtnResources.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(24), CByte(22), CByte(34))
        BtnResources.Font = New Font("Microsoft Sans Serif", 11.25F)
        BtnResources.ForeColor = Color.Black
        BtnResources.Image = CType(resources.GetObject("BtnResources.Image"), Image)
        BtnResources.ImageAlign = ContentAlignment.MiddleLeft
        BtnResources.Location = New Point(0, 92)
        BtnResources.Name = "BtnResources"
        BtnResources.Padding = New Padding(5, 0, 0, 0)
        BtnResources.Size = New Size(246, 45)
        BtnResources.TabIndex = 3
        BtnResources.Text = "   Recursos"
        BtnResources.TextAlign = ContentAlignment.MiddleLeft
        BtnResources.TextImageRelation = TextImageRelation.ImageBeforeText
        BtnResources.UseVisualStyleBackColor = False
        ' 
        ' PanelChildForm
        ' 
        PanelChildForm.BackColor = Color.LavenderBlush
        PanelChildForm.Controls.Add(TxtHelp)
        PanelChildForm.Controls.Add(PictureBox9)
        PanelChildForm.Dock = DockStyle.Fill
        PanelChildForm.Location = New Point(250, 0)
        PanelChildForm.Name = "PanelChildForm"
        PanelChildForm.Size = New Size(684, 568)
        PanelChildForm.TabIndex = 2
        ' 
        ' TxtHelp
        ' 
        TxtHelp.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TxtHelp.BorderStyle = BorderStyle.FixedSingle
        TxtHelp.ForeColor = Color.Gray
        TxtHelp.Location = New Point(79, 361)
        TxtHelp.Name = "TxtHelp"
        TxtHelp.PlaceholderText = " Como posso ajudar?"
        TxtHelp.Size = New Size(533, 23)
        TxtHelp.TabIndex = 1
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
        MaximizeBox = False
        MinimumSize = New Size(950, 600)
        Name = "FrmMain"
        StartPosition = FormStartPosition.CenterScreen
        panelLogo.ResumeLayout(False)
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelSideMenu.ResumeLayout(False)
        PanelResourcesSubmenu.ResumeLayout(False)
        PanelChildForm.ResumeLayout(False)
        PanelChildForm.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Private WithEvents panelLogo As Panel
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents PanelSideMenu As Panel
    Private WithEvents BtnExit As Button
    Private WithEvents BtnHelp As Button
    Private WithEvents BtnSettings As Button
    Private WithEvents PanelResourcesSubmenu As Panel
    Private WithEvents BtnSendPromo As Button
    Private WithEvents BtnFillMenu As Button
    Private WithEvents BtnAddClient As Button
    Private WithEvents BtnResources As Button
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents TxtHelp As TextBox
End Class
