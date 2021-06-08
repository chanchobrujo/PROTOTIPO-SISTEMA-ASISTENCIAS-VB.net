Imports System.Data
Imports System.Data.SqlClient
Imports CLASES

Public Class dao_ENTRADASALIDA
    Public Sub agregar(a As ENTRADASALIDA)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("set language 'español'; insert into [ENTRADA/SALIDA] values('" & a.TIPO & "','" & a.FECHA & "'," & a.ID_HORASIG & ",'" & a.HORA & "')", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("AGREGADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub actualizar(a As ENTRADASALIDA)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("set language 'español'; update [ENTRADA/SALIDA] set tipo = '" & a.TIPO & "', fecha = '" & a.FECHA & "', ID_HORASIG = " & a.ID_HORASIG & ", hora='" & a.HORA & "' where id_es=" & a.ID_ES & "", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("MODIFICADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub eliminar(a As ENTRADASALIDA)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("delete from [entrada/salida] where id_es=" & a.ID_ES & "", con.getconexion)
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
            Dim da As New SqlDataAdapter("select * from vista_entradasalida", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
