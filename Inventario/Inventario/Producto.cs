using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    //En esta clase declaramos las variables con el metodo de get y set que es recibir y mostrar.
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Dimensiones { get; set; }
        public DateTime FechaEntrada { get; set; }
        public string Descripcion { get; set; }


        //Constructor
        public Producto() { }
        
        public Producto(int id, string nombre, int cantidad, string dimensiones, DateTime fechaEntrada, string descripcion)
 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Dimensiones = dimensiones;
            this.FechaEntrada = fechaEntrada;
            this.Descripcion = descripcion;
        }

    }
}
