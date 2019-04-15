using System;
using System.Collections.Generic;
using System.Text;

namespace DepositoClases
{
    class Dimension : Articulo
    {
         public int Alto { get; set; }
         public int Ancho { get; set; }
         public int Peso { get; set; }
         public int volumen_total { get; set; }
         public int Masa_Xunidad { get; set; }
    }
}
