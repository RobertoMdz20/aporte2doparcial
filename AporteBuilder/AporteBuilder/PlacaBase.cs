using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    class PlacaBase
    {
        private string marcaplaca;
        private string modeloplaca;
        
        public PlacaBase(String marcaplaca, string modeloplaca)
        {
            this.marcaplaca = marcaplaca;
            this.modeloplaca = modeloplaca;
        }

        public string MarcaPlaca
        {
            get { return marcaplaca; }
            set { marcaplaca = value; }
        }

        public string ModeloPlaca 
        {
            get { return modeloplaca; }
            set { modeloplaca = value; }
        }
    }
}
