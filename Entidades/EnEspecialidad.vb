Imports System.Data
Imports Microsoft.Data.SqlClient
Imports Datos

Public Class EnEspecialidad
    Private IdEspecialidad As Integer
    Private nombreEspecialidad As String
    Private costo As Decimal

    Public Property IdEspecialidad1 As Integer
        Get
            Return IdEspecialidad
        End Get
        Set(value As Integer)
            IdEspecialidad = value
        End Set
    End Property

    Public Property NombreEspecialidad1 As String
        Get
            Return nombreEspecialidad
        End Get
        Set(value As String)
            nombreEspecialidad = value
        End Set
    End Property

    Public Property Costo1 As Decimal
        Get
            Return costo
        End Get
        Set(value As Decimal)
            costo = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Function listarEspecialidad() As DataTable

        Dim dt As New DataTable
        Dim cn As New Conexion
        Dim da As New SqlDataAdapter("ListarEspecialidad", cn.SqlCon1)
        cn.SqlCon1.ConnectionString = "Data Source=DESKTOP-KMFS1FS;Initial Catalog=Hospital;Integrated Security=True;TrustServerCertificate=True;"
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt)
        Return dt

    End Function

End Class
