<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddClient
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddClient))
        BtnClose = New Button()
        ImageList32 = New ImageList(components)
        BtnAddClient = New Button()
        MskClientNum = New MaskedTextBox()
        LblTitulo = New Label()
        LblResponse = New Label()
        PicIcon = New PictureBox()
        Label1 = New Label()
        ToolTip1 = New ToolTip(components)
        PgInsert = New ProgressBar()
        CType(PicIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnClose
        ' 
        BtnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnClose.FlatAppearance.BorderSize = 0
        BtnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(235), CByte(42), CByte(83))
        BtnClose.FlatStyle = FlatStyle.Flat
        BtnClose.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnClose.ForeColor = Color.LightGray
        BtnClose.ImageKey = "034-cancel.png"
        BtnClose.ImageList = ImageList32
        BtnClose.Location = New Point(760, 0)
        BtnClose.Margin = New Padding(0)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(36, 36)
        BtnClose.TabIndex = 21
        ToolTip1.SetToolTip(BtnClose, "Fechar tela")
        BtnClose.UseVisualStyleBackColor = True
        ' 
        ' ImageList32
        ' 
        ImageList32.ColorDepth = ColorDepth.Depth32Bit
        ImageList32.ImageStream = CType(resources.GetObject("ImageList32.ImageStream"), ImageListStreamer)
        ImageList32.TransparentColor = Color.Transparent
        ImageList32.Images.SetKeyName(0, "004-add.png")
        ImageList32.Images.SetKeyName(1, "034-cancel.png")
        ' 
        ' BtnAddClient
        ' 
        BtnAddClient.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnAddClient.BackColor = Color.PeachPuff
        BtnAddClient.FlatAppearance.BorderSize = 0
        BtnAddClient.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAddClient.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BtnAddClient.ImageKey = "004-add.png"
        BtnAddClient.ImageList = ImageList32
        BtnAddClient.Location = New Point(324, 266)
        BtnAddClient.Margin = New Padding(4, 3, 4, 3)
        BtnAddClient.Name = "BtnAddClient"
        BtnAddClient.Size = New Size(163, 58)
        BtnAddClient.TabIndex = 26
        ToolTip1.SetToolTip(BtnAddClient, "Cadastrar cliente")
        BtnAddClient.UseVisualStyleBackColor = False
        ' 
        ' MskClientNum
        ' 
        MskClientNum.BorderStyle = BorderStyle.FixedSingle
        MskClientNum.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MskClientNum.Location = New Point(327, 189)
        MskClientNum.Mask = "(99) 00000-0000"
        MskClientNum.Name = "MskClientNum"
        MskClientNum.Size = New Size(158, 35)
        MskClientNum.TabIndex = 29
        ' 
        ' LblTitulo
        ' 
        LblTitulo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblTitulo.AutoSize = True
        LblTitulo.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTitulo.ForeColor = Color.FromArgb(CByte(235), CByte(42), CByte(83))
        LblTitulo.Location = New Point(275, 17)
        LblTitulo.Margin = New Padding(4, 0, 4, 0)
        LblTitulo.Name = "LblTitulo"
        LblTitulo.Size = New Size(259, 33)
        LblTitulo.TabIndex = 30
        LblTitulo.Text = "Cadastrar Cliente"
        ' 
        ' LblResponse
        ' 
        LblResponse.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LblResponse.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblResponse.ForeColor = Color.Crimson
        LblResponse.Location = New Point(277, 336)
        LblResponse.Name = "LblResponse"
        LblResponse.Size = New Size(423, 29)
        LblResponse.TabIndex = 31
        LblResponse.Text = "Cliente adicionado com sucesso!"
        LblResponse.TextAlign = ContentAlignment.MiddleLeft
        LblResponse.Visible = False
        ' 
        ' PicIcon
        ' 
        PicIcon.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        PicIcon.Image = CType(resources.GetObject("PicIcon.Image"), Image)
        PicIcon.Location = New Point(247, 336)
        PicIcon.Name = "PicIcon"
        PicIcon.Size = New Size(24, 29)
        PicIcon.SizeMode = PictureBoxSizeMode.Zoom
        PicIcon.TabIndex = 32
        PicIcon.TabStop = False
        PicIcon.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Crimson
        Label1.Location = New Point(327, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 16)
        Label1.TabIndex = 33
        Label1.Text = "Digite o número de telefone:"
        ' 
        ' PgInsert
        ' 
        PgInsert.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PgInsert.Location = New Point(128, 342)
        PgInsert.Name = "PgInsert"
        PgInsert.Size = New Size(554, 23)
        PgInsert.TabIndex = 34
        PgInsert.Visible = False
        ' 
        ' FrmAddClient
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(798, 497)
        Controls.Add(PgInsert)
        Controls.Add(Label1)
        Controls.Add(PicIcon)
        Controls.Add(LblResponse)
        Controls.Add(LblTitulo)
        Controls.Add(MskClientNum)
        Controls.Add(BtnAddClient)
        Controls.Add(BtnClose)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FrmAddClient"
        CType(PicIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Private WithEvents BtnClose As Button
    Private WithEvents BtnAddClient As Button
    Friend WithEvents MskClientNum As MaskedTextBox
    Private WithEvents LblTitulo As Label
    Friend WithEvents LblResponse As Label
    Friend WithEvents PicIcon As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList32 As ImageList
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PgInsert As ProgressBar
End Class
