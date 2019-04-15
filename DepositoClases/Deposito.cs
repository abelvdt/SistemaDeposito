using System;
using System.Collections.Generic;
using System.Text;

namespace DepositoClases
{
    class Deposito
    {
        public int Cod_Deposito { get; set; }
        public string Descripción { get; set; }
        public int Volumen { get; set; }
        public enum Tipo { Publico, Privado, Refrigerado }
    }
}
