using System;

namespace CursoDemo2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("UNIVERSIDAD AUTONOMA DE CHIAPAS");
            //clase persona
           Persona miPersona=new Persona();
            miPersona.Id=1;
            miPersona.setNombre("Raul Gómez");
            miPersona.FechaNacimiento =DateTime.Parse("15/02/1980");
            Console.WriteLine("Nombre: "+ miPersona.getNombre()+" Cumpleaños: "+ miPersona.ObtenerCumpleaños());
            
            //clase Empleado
            Empleado miEmpleado=new Empleado();
            miEmpleado.Id=1;
            miEmpleado.setNombre("Maria mendez");
            miEmpleado.FechaNacimiento =DateTime.Parse("12/01/1989");
            miEmpleado.Sueldo=235;
            miEmpleado.FechaIngreso =DateTime.Parse("05/05/2005");
            miEmpleado.GenerarComision();  //Polimorfismo
            Console.WriteLine("Nombre: "+ miEmpleado.getNombre()+" Cumpleaños: "+miEmpleado.ObtenerCumpleaños()+" Sueldo: "+ miEmpleado.Sueldo );
            miEmpleado.GenerarComision(50);
            Console.WriteLine("Nombre: "+ miEmpleado.getNombre()+" Sueldo: "+ miEmpleado.Sueldo+" Antiguedad: "+miEmpleado.ObtenerAntiguedad());
            Console.WriteLine("Nombre: "+ miEmpleado.getNombre()+" Sueldo: "+ miEmpleado.Sueldo+" Antiguedad:"+miEmpleado.ObtenerAntiguedad()+" Quincena: "+ miEmpleado.ObtenerPagoNomina());
            Console.WriteLine("Nombre: "+ miEmpleado.getNombre()+" Sueldo: "+ miEmpleado.Sueldo+" Antiguedad: "+miEmpleado.ObtenerAntiguedad()+" Adicionales: "+ miEmpleado.ObtenerPagoNomina(12));
            
        }
    }
}
