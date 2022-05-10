using System;

namespace Ordenes.Models
{
    public class Orden
    {
        public int Id { get; set; }

        public string IdClientes { get; set; }

        public Productos IdProductos { get; set; }

        public DateTime Fecha { get; set; }
    }
}
