
Public Class RP_CARRERA
    Private Sub VENTANA_CARRERA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1.CARRERA' Puede moverla o quitarla según sea necesario.
        Me.CARRERATableAdapter.Fill(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet1.CARRERA)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class