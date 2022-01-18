using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    class Almacenamiento
    {
        private string marcaalm;
        private string tipoalm;
        private string capacidadalm;

        public Almacenamiento(String marcaalm, string tipoalm, string capacidadalm)
        {
            this.marcaalm = marcaalm;
            this.tipoalm = tipoalm;
            this.capacidadalm = capacidadalm;

        }

        public string MarcaAlm 
        {
            get { return marcaalm; }
            set { marcaalm = value; }
        }
        public string TipoAlm 
        {
            get { return tipoalm; }
            set { tipoalm = value; }
        }
        public string CapacidadAlm 
        {
            get { return capacidadalm; }
            set { capacidadalm = value; }
        }
    }
}
