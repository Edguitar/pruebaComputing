using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pruebas.Models
{
    public class Factura
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public string Ruc { get; set; }

        public string ClienteNombre { get; set; }

        public ICollection<Detalle> Detalle { get; set; }

        public Factura()
        {
            this.Detalle = new HashSet<Detalle>();
        }
    }
}