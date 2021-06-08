Imports System.Data
Imports System.Data.SqlClient
Imports CLASES

Public Class dao_HORARIO
    Public Sub agregar(a As HORARIO)
        Try
            Dim con As New dao_CONEXION
            con.conectar()
            Dim sc As New SqlCommand("insertar_horario", con.getconexion)
            sc.CommandType = CommandType.StoredProcedure
            With sc.Parameters
                .AddWithValue("@d", a.DIA)
                .AddWithValue("@h", a.HORA)
            End With
            sc.ExecuteNonQuery()
            MsgBox("AGREGADO EN LA BASE DE DATOS")
            con.desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub actualizar(a As HORARIO)
        Try
            Dim con As New dao_CONEXION
            con.conectar()
            Dim sc As New SqlCommand("actualizar_horario", con.getconexion)
            sc.CommandType = CommandType.StoredProcedure
            With sc.Parameters
                .AddWithValue("@i", a.ID_HORARIO)
                .AddWithValue("@d", a.DIA)
                .AddWithValue("@h", a.HORA)
            End With
            sc.ExecuteNonQuery()
            MsgBox("MODIFICADO EN LA BASE DE DATOS")
            con.desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub eliminar(a As HORARIO)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("delete from horario where ID_HORARIO = " & a.ID_HORARIO, con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("ELIMINADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function listado() As DataTable
        Dim dt As New DataTable
        Try
            Dim con As New dao_CONEXION
            con.conectar()
            Dim da As New SqlDataAdapter("select * from HORARIO", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
