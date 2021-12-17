using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaForm.Models.Request
{
    class TransporteRequest
    {
        public string producto { get; set; }
        public int cantidad { get; set; }
        public string nombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int teléfono { get; set; }
        public string dirección { get; set; }
    }
}
