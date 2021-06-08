Public Class CLASE
    Property ID_CLASE As Integer
    Property FECHA As Date
    Property HORA As String
    Property ID_DOC As Integer
    Public Sub New(ID_CLASE As Integer, FECHA As Date, HORA As String, ID_DOC As Integer)
        Me.ID_CLASE = ID_CLASE
        Me.FECHA = FECHA
        Me.HORA = HORA
        Me.ID_DOC = ID_DOC
    End Sub
End Class
