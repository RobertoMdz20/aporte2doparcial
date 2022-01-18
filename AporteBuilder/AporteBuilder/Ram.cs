using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    class Ram
    {
        private string marcaram;
        private string frecuencia;
        private string capacidadram;

        public Ram(String marcaram, string frecuencia, string capacidadram)
        {
            this.marcaram = marcaram;
            this.frecuencia = frecuencia;
            this.capacidadram = capacidadram;

        }

        public string MarcaRam 
        {
            get { return marcaram; }
            set { marcaram = value; }
        }
        public string Frecuencia 
        {
            get { return frecuencia; }
            set { frecuencia = value; }
        }
        public string CapacidadRam 
        {
            get { return capacidadram; }
            set { capacidadram = value; }
        }
    }
}
