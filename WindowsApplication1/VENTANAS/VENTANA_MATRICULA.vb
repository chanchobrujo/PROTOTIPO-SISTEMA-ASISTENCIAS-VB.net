Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Drawing.Image
Imports System.IO
Imports CLASES

Public Class VENTANA_MATRICULA
    Sub cargar_alumno()
        Try
            Dim dt As DataTable
            dt = dao_alum.listado
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_cursos()
        Try
            Dim dt As DataTable
            dt = dao_cur.listado
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "NOMBRE_CURSO"
            ComboBox1.ValueMember = "ID_CURSO"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_matriculas()
        Try
            Dim dt As DataTable
            dt = dao_matt.listado
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_datos()
        cargar_alumno()
        cargar_cursos()
        cargar_matriculas()
    End Sub
    Private Sub VENTANA_MATRICULA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datos()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If (ComboBox4.Text = "REGISTRAR") Then
            Dim c As New MATRICULA(CInt(DataGridView1.CurrentRow.Cells(0).Value), ComboBox1.SelectedValue, CInt(NumericUpDown1.Value.ToString), 0)
            dao_matt.agregar(c)
            cargar_matriculas()
        End If
        If (ComboBox4.Text = "ELIMINAR") Then
            Dim c As New MATRICULA(CInt(DataGridView1.CurrentRow.Cells(0).Value), ComboBox1.SelectedValue, CInt(NumericUpDown1.Value.ToString), CInt(DataGridView2.CurrentRow.Cells(0).Value))
            dao_matt.modificar(c)
            cargar_matriculas()
        End If
        If (ComboBox4.Text = "ACTUALIZAR") Then
            Dim c As New MATRICULA(CInt(DataGridView1.CurrentRow.Cells(0).Value), ComboBox1.SelectedValue, CInt(NumericUpDown1.Value.ToString), CInt(DataGridView2.CurrentRow.Cells(0).Value))
            dao_matt.eliminar(c)
            cargar_matriculas()
        End If
    End Sub
End Class