using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    class Gpu
    {
        private string marcagpu;
        private string modelogpu;

        public Gpu(String marcagpu, string modelogpu)
        {
            this.marcagpu = marcagpu;
            this.modelogpu = modelogpu;
        }

        public string MarcaGpu 
        {
            get { return marcagpu; }
            set { marcagpu = value; }
        }
        public string ModeloGpu 
        {
            get { return modelogpu; }
            set { modelogpu= value; }
        }
    }
}
