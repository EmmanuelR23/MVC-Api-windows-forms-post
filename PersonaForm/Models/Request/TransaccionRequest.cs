using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaForm.Models.Request
{
    class TransaccionRequest
    {
        public string IdTarjetaOrigen { get; set; }
        public string IdTarjetaDestino { get; set; }
        public string ccv { get; set; }
        public string TipoTransaccion { get; set; }
        public string Motivo { get; set; }
        public string Monto { get; set; }
        public string Fecha { get; set; }
    }
}
