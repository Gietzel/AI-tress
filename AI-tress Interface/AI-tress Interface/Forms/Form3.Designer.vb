<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        button5 = New Button()
        label1 = New Label()
        BtnOK = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' button5
        ' 
        button5.FlatAppearance.BorderSize = 0
        button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(235), CByte(42), CByte(83))
        button5.FlatStyle = FlatStyle.Flat
        button5.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button5.ForeColor = Color.LightGray
        button5.Location = New Point(0, 0)
        button5.Margin = New Padding(4, 3, 4, 3)
        button5.Name = "button5"
        button5.Size = New Size(29, 29)
        button5.TabIndex = 21
        button5.Text = "X"
        button5.UseVisualStyleBackColor = True
        ' 
        ' label1
        ' 
        label1.Anchor = AnchorStyles.Top
        label1.AutoSize = True
        label1.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        label1.ForeColor = Color.FromArgb(CByte(235), CByte(42), CByte(83))
        label1.Location = New Point(302, 13)
        label1.Margin = New Padding(4, 0, 4, 0)
        label1.Name = "label1"
        label1.Size = New Size(173, 25)
        label1.TabIndex = 19
        label1.Text = "FORMULARIO X2"
        ' 
        ' BtnOK
        ' 
        BtnOK.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BtnOK.BackColor = Color.PeachPuff
        BtnOK.FlatAppearance.BorderSize = 0
        BtnOK.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnOK.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BtnOK.ImageKey = "036-check.png"
        BtnOK.Location = New Point(205, 359)
        BtnOK.Margin = New Padding(4, 3, 4, 3)
        BtnOK.Name = "BtnOK"
        BtnOK.Size = New Size(163, 58)
        BtnOK.TabIndex = 26
        BtnOK.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.BackColor = Color.PeachPuff
        Button1.FlatAppearance.BorderSize = 0
        Button1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.ImageKey = "036-check.png"
        Button1.Location = New Point(449, 359)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 58)
        Button1.TabIndex = 27
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(798, 497)
        Controls.Add(Button1)
        Controls.Add(BtnOK)
        Controls.Add(button5)
        Controls.Add(label1)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Private WithEvents button5 As Button
    Private WithEvents label1 As Label
    Private WithEvents BtnOK As Button
    Private WithEvents Button1 As Button
End Class
