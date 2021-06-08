Imports CLASES

Public Class VENTANA_CURSOS
    Sub limpiar_1()
        TextBox1.Clear()
        NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
    End Sub
    Sub cargar_carrera()
        Try
            Dim dt As DataTable
            dt = dao_carrera.listado
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "carrera"
            ComboBox1.ValueMember = "carrera"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_cursos()
        Try
            Dim dt As DataTable
            dt = dao_cur.listado
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_datos()
        cargar_carrera()
        cargar_cursos()
    End Sub

    Private Sub VENTANA_CURSOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datos()
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            If (ComboBox4.Text = "REGISTRAR") Then
                Dim c As New CURSOS(0, TextBox1.Text, CInt(NumericUpDown1.Value.ToString), CInt(NumericUpDown2.Value.ToString), ComboBox1.SelectedValue)
                dao_cur.agregar(c)
            End If
            If (ComboBox4.Text = "ELIMINAR") Then
                Dim c As New CURSOS(CInt(DataGridView1.CurrentRow.Cells(0).Value), TextBox1.Text, CInt(NumericUpDown1.Value.ToString), CInt(NumericUpDown2.Value.ToString), ComboBox1.Text)
                dao_cur.eliminar(c)
            End If
            If (ComboBox4.Text = "ACTUALIZAR") Then
                Dim c As New CURSOS(CInt(DataGridView1.CurrentRow.Cells(0).Value), TextBox1.Text, CInt(NumericUpDown1.Value.ToString), CInt(NumericUpDown2.Value.ToString), ComboBox1.Text)
                dao_cur.modificar(c)
            End If
            If (ComboBox4.Text = "NUEVO") Then
            End If
            cargar_cursos()
            limpiar_1()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        NumericUpDown1.Value = DataGridView1.CurrentRow.Cells(2).Value
        NumericUpDown2.Value = DataGridView1.CurrentRow.Cells(3).Value
        ComboBox1.SelectedValue = DataGridView1.CurrentRow.Cells(4).Value
    End Sub
End Class