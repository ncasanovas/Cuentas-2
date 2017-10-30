using System;

namespace Ejercicio_Cuentas
{
    public class Cliente
    {
        public long DNI { get; set;}
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string Mail { get; set;}
        public int Telefono { get; set;}
        public DateTime Fecha_Nacimiento{ get; set;}
        

         public string NombreCompleto()
      {
          return string.Format("{0} {1}", this.Nombre, this.Apellido);
      }
    }


}