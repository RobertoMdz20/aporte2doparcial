using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    class FuenteEnergia
    {
        private string marcafuente;
        private string certificacion;

        public FuenteEnergia(String marcafuente, string certificacion)
        {
            this.marcafuente = marcafuente;
            this.certificacion = certificacion;
        }

        public string MarcaFuente 
        {
            get { return marcafuente; }
            set { marcafuente= value; }
        }
        public string Certificacion 
        {
            get { return certificacion; }
            set { certificacion = value; }
        }
    }
}
