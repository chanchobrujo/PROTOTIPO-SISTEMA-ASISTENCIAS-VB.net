Imports CLASES

Public Class VENTANA_ASIGNACION_CLASE
    Sub cargar_clase()
        Try
            Dim dt As DataTable
            dt = dao_cla.listado
            DataGridView1.DataSource = dt
            DataGridView1.Columns("FOTO DEL DOCENTE").Width = 81
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
    Sub cargar_aula()
        Try
            Dim dt As DataTable
            dt = dao_au.listado
            DataGridView3.DataSource = dt
            DataGridView3.Columns("FOTO").Width = 81
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_datos()
        cargar_matriculas()
        cargar_clase()
        cargar_aula()
    End Sub
    Private Sub VENTANA_ASIGNACION_CLASE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datos()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            If (ComboBox4.Text = "REGISTRAR") Then
                Dim a As New AULA(0, DataGridView1.CurrentRow.Cells(0).Value, DataGridView2.CurrentRow.Cells(0).Value)
                dao_au.agregar(a)
            End If
            If (ComboBox4.Text = "ACTUALIZAR") Then
                Dim a As New AULA(DataGridView3.CurrentRow.Cells(0).Value, DataGridView1.CurrentRow.Cells(0).Value, DataGridView2.CurrentRow.Cells(0).Value)
                dao_au.modificar(a)
            End If
            If (ComboBox4.Text = "ELIMINAR") Then
                Dim a As New AULA(DataGridView3.CurrentRow.Cells(0).Value, DataGridView1.CurrentRow.Cells(0).Value, DataGridView2.CurrentRow.Cells(0).Value)
                dao_au.eliminar(a)
            End If
            cargar_aula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class