Imports System.Text.RegularExpressions

Public Class FrmAddClient

#Region "Variables"

    Private Property MSG_SUCCESS_INSERT = "Cliente adicionado com sucesso!"
    Private Property MSG_ERROR_INSERT = "Erro durante inserção do cliente: "

#End Region

#Region "Main Methods"

    Private Sub ShowDbResponse(isSuccess As Boolean)
        If isSuccess Then
            LblResponse.Text = MSG_SUCCESS_INSERT
        Else
            LblResponse.Text = MSG_ERROR_INSERT
        End If

        PicIcon.Visible = True
        LblResponse.Visible = True
    End Sub

#End Region

#Region "Events"

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnAddClient_Click(sender As Object, e As EventArgs) Handles BtnAddClient.Click
        Try
            Dim stringClientNum As String = MskClientNum.Text
            Dim clientNumConverted As String = Regex.Replace(stringClientNum, "[^\d]", "")
            Dim clientNum As Long

            If Long.TryParse(clientNumConverted, clientNum) Then
                Dim newClient As New Clients With {
                    .Number = clientNum
                }

                Using ctx = DbContextFactory.CreateContext()
                    ctx.Clients.Add(newClient)
                    ctx.SaveChanges()
                End Using

                ShowDbResponse(True)
            Else
                MessageBox.Show("Número de cliente inválido. Por favor, insira um número válido.")
            End If
        Catch ex As Exception
            ShowDbResponse(False)
        End Try
    End Sub

#End Region

End Class