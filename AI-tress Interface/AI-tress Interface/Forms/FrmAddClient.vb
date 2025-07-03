Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class FrmAddClient

#Region "Variables"

    Private Property MSG_SUCCESS_INSERT = "Cliente adicionado com sucesso!"
    Private Property MSG_ERROR_INSERT = "Erro durante inserção do cliente: "
    Private Property MSG_ERROR_INPUT = "Número de telefone inválido."
    Private Const PHONE_NUMBER_LENGTH As Integer = 11

#End Region

#Region "Main Methods"

    Private Sub AddClient()
        Dim baseDir As String = AppDomain.CurrentDomain.BaseDirectory
        Dim mediumIconsDir As String = Path.Combine(baseDir, "..\..\..\Resources\Icons\24x24\")

        PgInsert.Value = 0
        PgInsert.Maximum = 100
        PgInsert.Style = ProgressBarStyle.Continuous

        StartLoadingUX(True)
        Application.DoEvents()

        Try
            Dim stringClientNum As String = MskClientNum.Text
            Dim clientNumConverted As String = Regex.Replace(stringClientNum, "[^\d]", "")
            Dim clientNum As Long

            IncreaseProgress(20)

            Select Case clientNumConverted.Length
                Case PHONE_NUMBER_LENGTH
                    If Long.TryParse(clientNumConverted, clientNum) Then
                        IncreaseProgress(40)

                        Dim newClient As New Clients With {
                        .Number = clientNum
                    }

                        IncreaseProgress(60)

                        Using ctx = DbContextFactory.CreateContext()
                            ctx.Clients.Add(newClient)
                            ctx.SaveChanges()
                        End Using

                        IncreaseProgress(100)

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
        Finally
            PgInsert.Value = 100
            Application.DoEvents()
            Thread.Sleep(300)
            StartLoadingUX(False)
        End Try
    End Sub

#End Region

#Region "Auxiliar Methods"

    Private Sub StartLoadingUX(loadingState As Boolean)
        PicIcon.Visible = Not loadingState
        LblResponse.Visible = Not loadingState
        PgInsert.Visible = loadingState
    End Sub

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

    Private Sub IncreaseProgress(targetValue As Integer)
        While PgInsert.Value < targetValue
            PgInsert.Value += 5
            Application.DoEvents()
            Thread.Sleep(30)
        End While
    End Sub

#End Region

#Region "Events"

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnAddClient_Click(sender As Object, e As EventArgs) Handles BtnAddClient.Click
        AddClient()
    End Sub

#End Region

End Class