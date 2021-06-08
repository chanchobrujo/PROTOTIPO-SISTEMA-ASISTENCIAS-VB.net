Imports System.Data
Imports System.Data.SqlClient
Imports CLASES

Public Class dao_HORARIO_ASIGNADO
    Public Sub agregar(a As HORARIO_ASIGNADO)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("insert into HORARIO_ASIGNADO values(" & a.ID_DOCENTE & "," & a.ID_HORARIO & ")", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("AGREGADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub modificar(a As HORARIO_ASIGNADO)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("update HORARIO_ASIGNADO set ID_DOCENTE=" & a.ID_DOCENTE & ", ID_HORARIO=" & a.ID_HORARIO & " where ID_HORASIG=" & a.ID_HORASIG & "", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("MODIFICADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub eliminar(a As HORARIO_ASIGNADO)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("delete from HORARIO_ASIGNADO where ID_HORASIG = " & a.ID_HORASIG & " ", con.getconexion)
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
            Dim da As New SqlDataAdapter("select * from vista_horarioasignado", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function

End Class