Public Class ASISTENCIA
    Property ID_ASIS As Integer
    Property ID_AUU As Integer
    Property ESTADO As String
    Public Sub New(ID_ASIS As Integer, ID_AUU As Integer, ESTADO As String)
        Me.ID_ASIS = ID_ASIS
        Me.ID_AUU = ID_AUU
        Me.ESTADO = ESTADO
    End Sub
End Class
