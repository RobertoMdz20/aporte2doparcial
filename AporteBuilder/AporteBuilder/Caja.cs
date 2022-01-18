using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    class Caja
    {
        private string marcacaja;
        private string modelocaja;

        public Caja(String marcacaja, string modelocaja)
        {
            this.marcacaja = marcacaja;
            this.modelocaja = modelocaja;
        }

        public string MarcaCaja 
        {
            get { return marcacaja; }
            set { marcacaja = value; }
        }
        public string ModeloCaja 
        {
            get { return modelocaja; }
            set { modelocaja = value; }
        }
    }
}
