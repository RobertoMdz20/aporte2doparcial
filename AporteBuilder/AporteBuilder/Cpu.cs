using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    class Cpu
    {
        private string marcacpu;
        private string modelocpu;

        public Cpu(String marcacpu, string modelocpu)
        {
            this.marcacpu = marcacpu;
            this.modelocpu = modelocpu;
        }

        public string MarcaCpu
        {
            get { return marcacpu; }
            set { marcacpu = value; }
        }
        public string ModeloCpu
        {
            get { return modelocpu; }
            set { modelocpu = value; }
        }
    }
}
