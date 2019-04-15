using System;
using System.Collections.Generic;
using System.Text;

namespace DepositoClases
{
    public class Reg_Entr_Salid
    {
        public enum Tipo_reg { Entrada = 1, Salida }
        public enum Dia_num : int { Max = 31, Min = 1 }
        public enum Dia_let { Domingo = 1, Lunes, Martes, Miercoles, Jueves, Viernes, Sábado }
        public enum Mes_num : int { Max = 12, Min = 1 }
        public enum Mes_let { Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre }
    }
}
