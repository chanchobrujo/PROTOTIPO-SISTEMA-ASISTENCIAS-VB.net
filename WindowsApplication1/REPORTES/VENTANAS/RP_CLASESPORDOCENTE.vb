Imports Microsoft.Reporting.WinForms

Public Class RP_CLASESPORDOCENTE
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

    Sub cargar_clases()
        Try
            'Imports Microsoft.Reporting.WinForms
            Dim ds As New DataSet
            ds = dao_cla.listado2(ComboBox1.SelectedValue)
            Dim rds As New ReportDataSource("DataSet1", ds.Tables(0))
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(rds)
            'TODO: esta línea de código carga datos en la tabla '_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3.vista_clase2' Puede moverla o quitarla según sea necesario.
            Me.vista_clase2TableAdapter.Fill(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet3.vista_clase2)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub VENTANA_CLASESPORDOCENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_docente()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargar_clases()
    End Sub
End Class