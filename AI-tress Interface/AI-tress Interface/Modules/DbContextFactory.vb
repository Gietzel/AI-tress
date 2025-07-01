Imports Microsoft.EntityFrameworkCore

Public Module DbContextFactory
    Private _options As DbContextOptions(Of AiTressDbContext)

    Public ReadOnly Property Options As DbContextOptions(Of AiTressDbContext)
        Get
            If _options Is Nothing Then
                Dim builder As New DbContextOptionsBuilder(Of AiTressDbContext)
                builder.UseSqlServer("Server=DESKTOP-H1IDHCE\SQLEXPRESS;Database=test;User Id=sa;Password=Auth4QU3RY;TrustServerCertificate=True;")
                _options = builder.Options
            End If
            Return _options
        End Get
    End Property

    Public Function CreateContext() As AiTressDbContext
        Return New AiTressDbContext(Options)
    End Function
End Module