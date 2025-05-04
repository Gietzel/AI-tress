<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        BtnOK = New Button()
        ImageList32 = New ImageList(components)
        label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' BtnOK
        ' 
        BtnOK.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnOK.BackColor = Color.PeachPuff
        BtnOK.FlatAppearance.BorderSize = 0
        BtnOK.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnOK.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BtnOK.ImageKey = "036-check.png"
        BtnOK.ImageList = ImageList32
        BtnOK.Location = New Point(317, 407)
        BtnOK.Margin = New Padding(4, 3, 4, 3)
        BtnOK.Name = "BtnOK"
        BtnOK.Size = New Size(163, 58)
        BtnOK.TabIndex = 11
        BtnOK.UseVisualStyleBackColor = False
        ' 
        ' ImageList32
        ' 
        ImageList32.ColorDepth = ColorDepth.Depth32Bit
        ImageList32.ImageStream = CType(resources.GetObject("ImageList32.ImageStream"), ImageListStreamer)
        ImageList32.TransparentColor = Color.Transparent
        ImageList32.Images.SetKeyName(0, "036-check.png")
        ' 
        ' label1
        ' 
        label1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        label1.AutoSize = True
        label1.Font = New Font("Rockwell", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = Color.FromArgb(CByte(235), CByte(42), CByte(83))
        label1.Location = New Point(349, 9)
        label1.Margin = New Padding(4, 0, 4, 0)
        label1.Name = "label1"
        label1.Size = New Size(98, 36)
        label1.TabIndex = 8
        label1.Text = "Ajuda"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.Font = New Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Crimson
        Label2.Location = New Point(12, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(774, 374)
        Label2.TabIndex = 12
        Label2.Text = resources.GetString("Label2.Text")
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(798, 497)
        Controls.Add(BtnOK)
        Controls.Add(Label2)
        Controls.Add(label1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Private WithEvents BtnOK As Button
    Private WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ImageList32 As ImageList
End Class
