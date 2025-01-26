using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    internal class SuperHeroe
    {
        
        public string nombre { get; set; }
        public string identidadSecreta { get; set; }
        public string ciudad {  get; set; }
        public Boolean puedeVolar {  get; set; }

        public Superpoder superPoder { get; set; }

        public SuperHeroe() {
            superPoder = new Superpoder();

        }

    }
}
