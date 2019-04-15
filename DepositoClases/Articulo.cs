using System;
using System.Collections.Generic;
using System.Text;

namespace DepositoClases
{
    class Articulo
    {
        public string Nombre { get; set; }
        public int Cod_Articulo { get; set; }
        public string Descripción { get; set; }
        public enum Tipo_Deposito { Estantes, Aislado, Refrigerado}
    }
}
