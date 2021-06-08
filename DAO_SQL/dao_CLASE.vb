Imports System.Data
Imports System.Data.SqlClient
Imports CLASES

Public Class dao_CLASE
    Public Sub agregar(a As CLASE)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("set language 'español'; insert into CLASE values('" & a.FECHA & "','" & a.HORA & "'," & a.ID_DOC & ")", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("AGREGADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub modificar(a As CLASE)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("set language 'español'; update CLASE set FECHA = " & a.FECHA & ",hora=" & a.HORA & ",ID_DOC = " & a.ID_DOC & " where ID_CLASE = " & a.ID_CLASE & "", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("MODIFICADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub eliminar(a As CLASE)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("delete from CLASE where ID_CLASE = " & a.ID_CLASE & "", con.getconexion)
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
            Dim da As New SqlDataAdapter("select * from vista_clase", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listado2(d As Integer) As DataSet
        Dim dt As New DataSet
        Try
            Dim con As New dao_CONEXION
            con.conectar()
            Dim da As New SqlDataAdapter("select * from vista_clase2 where ID_DOC = " & d & "", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listadodinamico(nom As String) As DataTable
        Dim cn As dao_CONEXION
        Dim da As SqlDataAdapter
        Dim dt As New DataTable

        Try
            cn = New dao_CONEXION
            cn.conectar()
            da = New SqlDataAdapter("select * from vista_clase where DOCENTE like '" & nom & "%'", cn.getconexion)
            da.Fill(dt)
            cn.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
