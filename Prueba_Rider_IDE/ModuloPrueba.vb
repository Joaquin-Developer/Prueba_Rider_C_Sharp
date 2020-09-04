Public Module ModuloPrueba
    
    Sub Main(args As  String())
        Console.WriteLine("Hola mundo en VB.NET con Rider JetBrains")
        
        Dim persona as New Persona()
        persona.nombre = "joaquin"
        persona.apellido = "Parrilla"
        persona.edad = 19
        Console.WriteLine(persona.toString())
        
    End Sub
    
    private class Persona
        Property nombre() As String
        Property apellido() As String
        Property edad() As Integer
        
        Public  Sub New ()
            ' constructor vacio.
        End Sub
        
        Public  Sub New (nombre As String, apellido As String, edad As Integer)
            Me.nombre = nombre
            Me.apellido = apellido
            Me.edad = edad
        End Sub
        
        Public Function toString() As String
            Return "Nombre: " & nombre & vbCrLf & "Apellido: " & apellido & vbCrLf & "Edad: " & edad.ToString()
        End Function
        
    End class
    
End Module