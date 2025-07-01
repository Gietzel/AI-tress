Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("clients_nums")>
Public Class Clients
    <Key>
    <Column("id")>
    Public Property Id As Integer

    <Column("number")>
    Public Property Number As Long
End Class
