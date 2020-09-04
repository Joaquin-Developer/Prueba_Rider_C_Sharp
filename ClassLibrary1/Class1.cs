using System;

namespace ClassLibrary1 {
    
    public class Principal {
    
        static void Main(string[] args)
        {
            Console.Write("Hello world with C#");
            Console.WriteLine("... And JetBrains RiderIDE");
            Console.WriteLine("Fuck You Visual Studio :))");
            Persona unaPersona = new Persona();
            Console.ReadKey(); // espera interaccion de usuario para seguir.
            Console.Clear();
            unaPersona.nombre = "Joaquín";
            unaPersona.apellido = "Parrilla";
            unaPersona.edad = 19;
            unaPersona.salario = 42250.0;
            Console.WriteLine(unaPersona.nombre_Salario());
            Console.WriteLine(unaPersona.esMayor());
            Console.WriteLine(unaPersona.ToString());
        }
        
    }

    public class Persona
    {
        /* campos, con metodos getters y setters asociados */
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public double salario { get; set; }

        /* constructores, vacío y completo (o "por defecto") */
        
        public Persona() { /* const. vacio */}

        public Persona(string nombre, string apellido, int edad, double salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.salario = salario;
        }
        
        // métodos específicos:

        public bool esMayor()
        {
            return (this.edad >= 18);
        }

        public double impuestosQueDebePagar()
        {
            // retornamos el valor del 16% de salario
            return (this.salario * 0.16);
        }

        public double salarioNeto()
        {
            // retorna el salario final (descontándole el 16% de impuestos)
            return impuestosQueDebePagar() - this.salario;
        }

        public string nombre_Salario()
        {
            return this.apellido + " debe abonar impuestos por el valor de $ " + this.impuestosQueDebePagar();
        }
        
        // metodo toString
        public override string ToString()
        {
            return "Nombre: " + nombre + ", Apellido: " + apellido + ", salario nominal: " + salario + 
                   ", salario neto:" + salarioNeto();
        }
    }
    
}

