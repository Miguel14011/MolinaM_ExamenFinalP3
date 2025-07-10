using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MolinaM_Examen.Models
{
    class Contacto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Correo { get; set; }

        private string telefono;

        public string Telefono
        {
            get => telefono;
            set
            {
                if (!value.StartsWith("+593"))
                    throw new ArgumentException("El teléfono debe iniciar con +593");
                telefono = value;
            }

        }
        public bool Favorito { get; set; }
    }
    
}
