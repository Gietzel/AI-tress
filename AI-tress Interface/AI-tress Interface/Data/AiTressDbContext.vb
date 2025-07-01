Imports Microsoft.EntityFrameworkCore

Public Class AiTressDbContext
    Inherits DbContext

    Public Sub New(options As DbContextOptions(Of AiTressDbContext))
        MyBase.New(options)
    End Sub

    Public Overridable Property Clients As DbSet(Of Clients)

    Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
    End Sub
End Class
