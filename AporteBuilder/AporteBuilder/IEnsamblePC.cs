using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    interface IEnsamblePC
    {

        EnsamblePC NombreCliente(String nombre);
        EnsamblePC Precio(int precio);
        
        EnsamblePC PlacaBase(PlacaBase placabase);
        EnsamblePC Cpu(Cpu procesador);
        EnsamblePC Ram(Ram ram);
        EnsamblePC Almacenamiento(Almacenamiento almacenamiento);
        EnsamblePC Gpu(Gpu grafica);
        EnsamblePC Refrigeracion(Refrigeracion cooler);
        EnsamblePC FuenteEnergia(FuenteEnergia fuente);
        EnsamblePC Caja(Caja caja);
    }
}
