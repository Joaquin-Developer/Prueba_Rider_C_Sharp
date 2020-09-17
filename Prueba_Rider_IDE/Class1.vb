Public Class Class1
    
    private Property nombre() As String
    Private  Property apellido() As String
    
    Public  Sub  New () ' constructor vacío
    End Sub
    
    Public  Sub New (nombre as String, apellido as String)
        Me.nombre = nombre
        Me.apellido = apellido
    End Sub

    Public Overrides Function ToString() As String
        ' Método sobrescrito ToString en VB.NET - Retorna una cadena personalizada (en este caso)
        Return "Nombre: " & Me.nombre & vbCrLf & "Apellido: " & Me.apellido
    End Function
    
End Class
