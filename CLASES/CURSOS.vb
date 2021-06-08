Public Class CURSOS
    Property ID_CURSO As Integer
    Property NOMBRE_CURSO As String
    Property CREDITOS As Integer
    Property HORAS As Integer
    Property CARRERA As String
    Public Sub New(ID_CURSO As Integer, NOMBRE_CURSO As String, CREDITOS As Integer, HORAS As Integer, CARRERA As String)
        Me.ID_CURSO = ID_CURSO
        Me.NOMBRE_CURSO = NOMBRE_CURSO
        Me.CREDITOS = CREDITOS
        Me.HORAS = HORAS
        Me.CARRERA = CARRERA
    End Sub
End Class
