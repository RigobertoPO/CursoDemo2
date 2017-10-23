using System;
namespace CursoDemo2
{
    public class Persona
    {
        #region ATRIBUTOS
            private int id;
            private string nombre;
            private DateTime fechaNacimiento;
        #endregion
        #region PROPIEDADES
            public int Id
            {
            get { return id; }
            set { id = value; }
            }
            //primera forma de getter y setter
            public void setNombre(string nombre)
            {          
            this.nombre = nombre; 
            }
            public string getNombre()
            {
                return this.nombre;
            }
           
            
            //PARA TRABAJAR ENCAPSULAMIENTO CON GETTER Y SETTER
            public DateTime FechaNacimiento
            {
            set { fechaNacimiento = value; }
            }
        #endregion
        
        #region METODOS
            public string ObtenerCumpleaños()
            {
                return fechaNacimiento.Day + " de " + DefinirMes(fechaNacimiento.Month );
            }
            private string DefinirMes(int mes)
            {
                string nombreMes;
                switch (mes)
                {
                    case 1:
                    nombreMes="ENERO";
                    break;
                    case 2:
                    nombreMes="FEBRERO";
                    break;
                    case 3:
                        nombreMes="MARZO";
                    break;

                    default:
                        nombreMes="SIN MES";
                        break;
                }
                return nombreMes;
            }
        #endregion
    }
   
}