Imports Microsoft.Reporting.WinForms
Public Class RP_ASISTENCIADEUNACLASE
    Sub cargar_clases()
        Try
            Dim dt As DataTable
            dt = dao_cla.listado
            TABLA.DataSource = dt
            TABLA.Columns("FOTO DEL DOCENTE").Width = 81
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub cargar_asistencia()
        Dim ds As New DataSet
        ds = dao_ass.listado(TABLA.CurrentRow.Cells(0).Value)
        Dim rds As New ReportDataSource("DataSet1", ds.Tables(0))
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)
        Me.vista_asistenciaTableAdapter.Fill(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet6.vista_asistencia)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub RP_ASISTENCIADEUNACLASE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_clases()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargar_asistencia()
    End Sub
End Class


