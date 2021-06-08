Imports System.Data.SqlClient
Imports CLASES

Public Class dao_ASISTENCIA
    Dim con As New dao_CONEXION
    Dim dt As New DataSet
    Public Sub agregar(a As ASISTENCIA)
        Try
            Dim ad As New SqlCommand("insert into ASISTENCIA values(" & a.ID_AUU & ",'" & a.ESTADO & "')", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("AGREGADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub modificar(a As ASISTENCIA)
        Try
            Dim ad As New SqlCommand("update ASISTENCIA set ID_AUU = " & a.ID_AUU & ",ESTADO = '" & a.ESTADO & "' where ID_ASIS = " & a.ID_ASIS & "", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("MODIFICADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub eliminar(a As ASISTENCIA)
        Try
            Dim ad As New SqlCommand("delete from ASISTENCIA where ID_ASIS = " & a.ID_ASIS & "", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("ELIMINADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function listado(f As Integer) As DataSet
        Try
            con.conectar()
            Dim da As New SqlDataAdapter("select * from vista_asistencia  where CLASE = " & f & "", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
