Public Class ALUMNO
    Property ID_ALUMNO As Integer
    Property DNI As Integer
    Property NOMBRE_APELLIDO As String
    Property CARRERA As String
    Property SEXO As String

    Public Sub New(ID_ALUMNO As Integer, DNI As Integer, NOMBRE_APELLIDO As String, CARRERA As String, SEXO As String)
        Me.ID_ALUMNO = ID_ALUMNO
        Me.DNI = DNI
        Me.NOMBRE_APELLIDO = NOMBRE_APELLIDO
        Me.CARRERA = CARRERA
        Me.SEXO = SEXO
    End Sub


End Class
