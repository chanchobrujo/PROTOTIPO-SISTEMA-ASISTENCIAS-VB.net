Imports System.Data.SqlClient
Imports CLASES

Public Class dao_ALUMNO
    Public Sub agregar(a As ALUMNO)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("insertar_alumno " & a.DNI & ",'" & a.NOMBRE_APELLIDO & "','" & a.CARRERA & "','" & a.SEXO & "'", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("AGREGADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub modificar(a As ALUMNO)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("actualizar_alumno " & a.ID_ALUMNO & "," & a.DNI & ",'" & a.NOMBRE_APELLIDO & "','" & a.CARRERA & "','" & a.SEXO & "'", con.getconexion)
            con.conectar()
            ad.ExecuteNonQuery()
            MsgBox("MODIFICADO EN LA BASE DE DATOS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub eliminar(a As ALUMNO)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("eliminar_alumno " & a.ID_ALUMNO & "", con.getconexion)
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
            Dim da As New SqlDataAdapter("select * from ALUMNO", con.getconexion)
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
            Dim da As New SqlDataAdapter("select * FROM ALUMNO WHERE CARRERA = '" & c & "'", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class
