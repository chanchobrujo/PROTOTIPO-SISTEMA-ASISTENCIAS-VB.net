Public Class HORARIO
    Property ID_HORARIO As Integer
    Property DIA As Date
    Property HORA As String

    Public Sub New(ID_HORARIO As Integer, DIA As Date, HORA As String)
        Me.ID_HORARIO = ID_HORARIO
        Me.DIA = DIA
        Me.HORA = HORA
    End Sub
End Class

