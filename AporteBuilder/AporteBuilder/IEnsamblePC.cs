using System;
using System.Collections.Generic;
using System.Text;

namespace AporteBuilder
{
    interface IEnsamblePC
    {

        EnsamblePC NombreCliente(String nombre);
        EnsamblePC PrecioFinal(double precio);
        
        EnsamblePC LaPlacaBase(PlacaBase placabase);
        EnsamblePC ElCpu(Cpu procesador);
        EnsamblePC LaRam(Ram ram);
        EnsamblePC ElAlmacenamiento(Almacenamiento almacenamiento);
        EnsamblePC LaGpu(Gpu grafica);
        EnsamblePC LaRefrigeracion(Refrigeracion cooler);
        EnsamblePC LaFuenteEnergia(FuenteEnergia fuente);
        EnsamblePC LaCaja(Caja caja);
    }
}
