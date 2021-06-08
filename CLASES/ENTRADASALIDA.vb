Public Class ENTRADASALIDA
    Property ID_ES As Integer
    Property TIPO As String
    Property FECHA As Date
    Property ID_HORASIG As Integer
    Property HORA As String

    Public Sub New(ID_ES As Integer, TIPO As String, FECHA As Date, ID_HORASIG As Integer, HORA As String)
        Me.ID_ES = ID_ES
        Me.TIPO = TIPO
        Me.FECHA = FECHA
        Me.ID_HORASIG = ID_HORASIG
        Me.HORA = HORA
    End Sub
End Class
