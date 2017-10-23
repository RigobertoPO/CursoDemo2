using System;
namespace CursoDemo2
{
    public class Empleado:Persona
    {
        #region ATRIBUTOS
            private double sueldo;
            private DateTime fechaIngreso;
        #endregion
        #region PROPIEDADES
            public double Sueldo
            {
            get { return sueldo; }
            set { sueldo = value; }
            }
            
            public DateTime FechaIngreso
            {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
            }
        #endregion
        #region METODOS
        public void GenerarComision()
        {
            Sueldo =Sueldo+ 10;
        }
        public void GenerarComision(double comision)
        {
            Sueldo +=comision;
        }
        public int ObtenerAntiguedad()
        {
            return DateTime.Now.Year- FechaIngreso.Year;
        }
        public double ObtenerPagoNomina()
        {
            return Sueldo*15;
        }
        public double ObtenerPagoNomina(int dias)
        {
            return Sueldo*dias;
        }

        #endregion
        
       
    }
}