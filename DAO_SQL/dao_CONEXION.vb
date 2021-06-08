Imports System.Data
Imports System.Data.SqlClient

Public Class dao_CONEXION
    Private cn As SqlConnection
    Public Sub New()
        cn = New SqlConnection("Data Source=192.168.1.162; Initial Catalog = BD_CONTROL DE ASISTENCIAS(DOCENTE/ALUMNO); user id=progra3;password=1234")
    End Sub
    Public Sub conectar()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub desconectar()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public ReadOnly Property getconexion As SqlConnection
        Get
            Return cn
        End Get
    End Property
End Class
