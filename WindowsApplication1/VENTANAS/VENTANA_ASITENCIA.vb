Imports CLASES

Public Class VENTANA_ASITENCIA
    Sub cargar_docente()
        Try
            Dim dt As DataTable
            dt = dao_doc.listado
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "NOMBRE_APELLIDOS"
            ComboBox1.ValueMember = "ID_DOCENTE"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub cargar_horario()
        Try
            Dim dt As DataTable
            dt = dao_jhor.listado
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_horarioaSIGNADO()
        Try
            Dim dt As DataTable
            dt = dao_horasig.listado
            DataGridView2.DataSource = dt
            DataGridView2.Columns("HORARIO").Width = 150
            DataGridView2.Columns("ID").Width = 45
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_movientos()
        Try
            Dim dt As DataTable
            dt = dao_entsal.listado
            DataGridView3.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_clase()
        Try
            Dim dt As DataTable
            dt = dao_cla.listado
            DataGridView4.DataSource = dt
            DataGridView4.Columns("FOTO DEL DOCENTE").Width = 81
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_datos()
        cargar_docente()
        cargar_horario()
        cargar_movientos()
        cargar_horarioaSIGNADO()
        cargar_clase()
    End Sub

    Private Sub VENTANA_ASSITENCIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_datos()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            If (ComboBox2.Text = "REGISTRAR") Then
                Dim C As New HORARIO_ASIGNADO(0, CInt(ComboBox1.SelectedValue), CInt(Convert.ToString(DataGridView1.CurrentRow.Cells(0).Value)))
                dao_horasig.agregar(C)
                cargar_horarioaSIGNADO()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            If (ComboBox4.Text = "REGISTRAR") Then
                Dim c As New ENTRADASALIDA(0, ComboBox3.Text, Date.Now.ToShortDateString, CInt(DataGridView2.CurrentRow.Cells(0).Value), Date.Now.ToShortTimeString)
                dao_entsal.agregar(c)
                cargar_movientos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        Try
            If (ComboBox9.Text = "REGISTRAR") Then
                Dim estado As String = ""
                If (RadioButton1.Checked) Then
                    estado = RadioButton1.Text
                End If
                If (RadioButton2.Checked) Then
                    estado = RadioButton2.Text
                End If
                If (RadioButton3.Checked) Then
                    estado = RadioButton3.Text
                End If
                Dim c As New ASISTENCIA(0, DataGridView5.CurrentRow.Cells(0).Value, estado)
                dao_ass.agregar(c)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim dt As DataTable
            dt = dao_cla.listadodinamico(TextBox1.Text)
            DataGridView4.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dt As DataTable
            dt = dao_au.listado2(DataGridView4.CurrentRow.Cells(0).Value)
            DataGridView5.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class


