Imports Microsoft.Reporting.WinForms
Public Class RP_ALUMNOPORCARRERA
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
    Sub cargar_alumno()
        Try

            Dim ds As New DataSet
            ds = dao_alum.listado2(ComboBox1.SelectedValue)
            Dim rds As New ReportDataSource("DataSet1", ds.Tables(0))
            Me.ReportViewer1.LocalReport.DataSources.Clear()
            Me.ReportViewer1.LocalReport.DataSources.Add(rds)
            'TODO: esta línea de código carga datos en la tabla '_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2.ALUMNO' Puede moverla o quitarla según sea necesario.
            Me.ALUMNOTableAdapter.Fill(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet2.ALUMNO)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RP_ALUMNOPORCARRERA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_carrera()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargar_alumno()
    End Sub
End Class