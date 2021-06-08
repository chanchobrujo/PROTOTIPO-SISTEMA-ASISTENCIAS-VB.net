Public Class DOCENTE
    Property ID_DOCENTE As Integer
    Property DNI As Integer
    Property NOMBRE_APELLIDOS As String
    Property FOTO As Byte()

    Public Sub New(ID_DOCENTE As Integer, DNI As Integer, NOMBRE_APELLIDOS As String, FOTO As Byte())
        Me.ID_DOCENTE = ID_DOCENTE
        Me.DNI = DNI
        Me.NOMBRE_APELLIDOS = NOMBRE_APELLIDOS
        Me.FOTO = FOTO
    End Sub


End Class


