Imports System.Data.SqlClient
Imports CLASES

Public Class dao_AULA
    Public Sub agregar(a As AULA)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("insert into AULA values(" & a.ID_CLASE & "," & a.ID_MAT & ")", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("AGREGADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub modificar(a As AULA)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("update AULA set ID_CLASE = " & a.ID_CLASE & ",ID_MAT = " & a.ID_MAT & " where ID_AUU = " & a.ID_AUU & "", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("MODIFICADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub eliminar(a As AULA)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("delete from AULA where ID_AUU = " & a.ID_AUU & "", con.getconexion)
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
            Dim da As New SqlDataAdapter("select * from vista_aula", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
    Public Function listado2(x As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Dim con As New dao_CONEXION
            con.conectar()
            Dim da As New SqlDataAdapter("select ID,ALUMNO ,CARRERA ,ciclo,CURSO,fecha,hora from vista_aula where [ID CLASE] = " & x & "", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
