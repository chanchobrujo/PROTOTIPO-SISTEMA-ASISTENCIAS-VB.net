Public Class MATRICULA
    Property ID_ALUMNO As Integer
    Property ID_CURSOS As Integer
    Property CICLO As Integer
    Property ID_MAT As Integer
    Public Sub New(ID_ALUMNO As Integer, ID_CURSOS As Integer, CICLO As Integer, ID_MAT As Integer)
        Me.ID_ALUMNO = ID_ALUMNO
        Me.ID_CURSOS = ID_CURSOS
        Me.CICLO = CICLO
        Me.ID_MAT = ID_MAT
    End Sub
End Class
