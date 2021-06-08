Public Class RP_DOCENTES
    Private Sub VENTANA_DOCENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet.vista_docente' Puede moverla o quitarla según sea necesario.
        Me.vista_docenteTableAdapter.Fill(Me._BD_CONTROL_DE_ASISTENCIAS_DOCENTE_ALUMNO_DataSet.vista_docente)

        Me.ReportViewer1.RefreshReport
    End Sub
End Class