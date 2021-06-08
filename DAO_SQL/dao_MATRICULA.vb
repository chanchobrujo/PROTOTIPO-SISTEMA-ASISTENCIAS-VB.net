Imports System.Data
Imports System.Data.SqlClient
Imports CLASES

Public Class dao_MATRICULA
    Public Sub agregar(a As MATRICULA)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("insert into MATRICULA values(" & a.ID_ALUMNO & "," & a.ID_CURSOS & "," & a.CICLO & ")", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("AGREGADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub modificar(a As MATRICULA)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("update MATRICULA set ID_ALUMNO = " & a.ID_ALUMNO & ",ID_CURSOS = " & a.ID_CURSOS & ",CICLO = " & a.CICLO & " where ID_MAT = " & a.ID_MAT & "", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("MODIFICADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub eliminar(a As MATRICULA)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("delete from MATRICULA where ID_MAT =" & a.ID_MAT & "", con.getconexion)
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
            Dim da As New SqlDataAdapter("select * from vista_matricula", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listado2(c As String) As DataSet
        Dim dt As New DataSet
        Try
            Dim con As New dao_CONEXION
            con.conectar()
            Dim da As New SqlDataAdapter("select *  from vista_matricula where CARREra = '" & c & "'", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
