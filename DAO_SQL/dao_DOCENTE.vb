Imports System.Data
Imports System.Data.SqlClient
Imports CLASES

Public Class dao_DOCENTE
    Public Sub agregar(a As DOCENTE)
        Try
            Dim con As New dao_CONEXION
            con.conectar()
            Dim sc As New SqlCommand("insertar_docente", con.getconexion)
            sc.CommandType = CommandType.StoredProcedure
            With sc.Parameters
                .AddWithValue("@dni", a.DNI)
                .AddWithValue("@nombre_apellidos", a.NOMBRE_APELLIDOS)
                .AddWithValue("@foto", a.FOTO)
            End With
            sc.ExecuteNonQuery()
            MsgBox("AGREGADO EN LA BASE DE DATOS")
            con.desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub actualizar(a As DOCENTE)
        Try
            Dim con As New dao_CONEXION
            con.conectar()
            Dim sc As New SqlCommand("actualizar_docente", con.getconexion)
            sc.CommandType = CommandType.StoredProcedure
            With sc.Parameters
                .AddWithValue("@id_docente", a.ID_DOCENTE)
                .AddWithValue("@dni", a.DNI)
                .AddWithValue("@nombre_apellidos", a.NOMBRE_APELLIDOS)
                .AddWithValue("@foto", a.FOTO)
            End With
            sc.ExecuteNonQuery()
            MsgBox("MODIFICADO EN LA BASE DE DATOS")
            con.desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub eliminar(a As DOCENTE)
        Try
            Dim con As New dao_CONEXION
            Dim ad As New SqlCommand("eliminar_docente " & a.ID_DOCENTE & "", con.getconexion)
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
            Dim da As New SqlDataAdapter("select * from DOCENTE", con.getconexion)
            da.Fill(dt)
            con.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return dt
    End Function
End Class



