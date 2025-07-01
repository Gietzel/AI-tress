Imports System.IO
Imports System.Text.RegularExpressions

Public Class FrmAddClient

#Region "Variables"

    Private Property MSG_SUCCESS_INSERT = "Cliente adicionado com sucesso!"
    Private Property MSG_ERROR_INSERT = "Erro durante inserção do cliente: "
    Private Property MSG_ERROR_INPUT = "Número de cliente inválido. Por favor, insira um número válido."
    Private Const PHONE_NUMBER_LENGTH As Integer = 11

#End Region

#Region "Main Methods"

    Private Sub ShowDbResponse(isSuccess As Boolean, iconDir As String)


        If isSuccess Then
            PicIcon.Image = Image.FromFile($"{iconDir}405-success.png")
            LblResponse.Text = MSG_SUCCESS_INSERT
        Else
            PicIcon.Image = Image.FromFile($"{iconDir}404-error.png")
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
        Dim baseDir As String = AppDomain.CurrentDomain.BaseDirectory
        Dim mediumIconsDir As String = Path.Combine(baseDir, "..\..\..\Resources\Icons\24x24\")

        Try
            Dim stringClientNum As String = MskClientNum.Text
            Dim clientNumConverted As String = Regex.Replace(stringClientNum, "[^\d]", "")
            Dim clientNum As Long

            Select Case clientNumConverted.Length
                Case PHONE_NUMBER_LENGTH
                    If Long.TryParse(clientNumConverted, clientNum) Then
                        Dim newClient As New Clients With {
                            .Number = clientNum
                        }

                        Using ctx = DbContextFactory.CreateContext()
                            ctx.Clients.Add(newClient)
                            ctx.SaveChanges()
                        End Using

                        ShowDbResponse(True, mediumIconsDir)
                    Else
                        PicIcon.Image = Image.FromFile($"{mediumIconsDir}404-error.png")
                        LblResponse.Text = MSG_ERROR_INPUT
                    End If

                Case Else
                    PicIcon.Image = Image.FromFile($"{mediumIconsDir}404-error.png")
                    LblResponse.Text = MSG_ERROR_INPUT
            End Select
        Catch ex As Exception
            ShowDbResponse(False, mediumIconsDir)
        End Try
    End Sub

#End Region

End Class