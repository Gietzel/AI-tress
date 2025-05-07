Public Class FrmMain

#Region "Properties"

    Private Property CurrentForm As Form = Nothing

#End Region

#Region "Main Methods"

    Private Sub OpenChildForm(childForm As Form)
        CurrentForm?.Close()
        CurrentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub ControlSubmenu(submenu As Panel, state As Boolean)
        submenu.Visible = state
    End Sub

#End Region

#Region "Auxiliary Methods"



#End Region

#Region "Events"

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ControlSubmenu(PanelResourcesSubmenu, False)
    End Sub

    Private Sub BtnResources_Click(sender As Object, e As EventArgs) Handles BtnResources.Click
        ControlSubmenu(PanelResourcesSubmenu, Not PanelResourcesSubmenu.Visible)
    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
        OpenChildForm(New FrmHelp())
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnAddClient_Click(sender As Object, e As EventArgs) Handles BtnAddClient.Click
        OpenChildForm(New FrmAddClient())
    End Sub

#End Region

End Class
