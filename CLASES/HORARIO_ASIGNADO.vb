Public Class HORARIO_ASIGNADO
    Property ID_HORASIG As Integer
    Property ID_DOCENTE As Integer
    Property ID_HORARIO As Integer

    Public Sub New(ID_HORASIG As Integer, ID_DOCENTE As Integer, ID_HORARIO As Integer)
        Me.ID_HORASIG = ID_HORASIG
        Me.ID_DOCENTE = ID_DOCENTE
        Me.ID_HORARIO = ID_HORARIO
    End Sub

End Class
