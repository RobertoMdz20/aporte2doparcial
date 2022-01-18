using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    class Refrigeracion
    {
        private string marcacool;
        private string tipocool;
        private string modelocool;

        public Refrigeracion(String marcacool, string tipocool, string modelocool)
        {
            this.marcacool = marcacool;
            this.tipocool = tipocool;
            this.modelocool = modelocool;

        }

        public string MarcaCool 
        {
            get { return marcacool; }
            set { marcacool = value; }
        }
        public string TipoCool 
        {
            get { return tipocool; }
            set { tipocool= value; }
        }
        public string ModeloCool 
        {
            get { return modelocool; }
            set { modelocool= value; }
        }
    }
}
