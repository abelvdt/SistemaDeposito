using System;
using System.Collections.Generic;
using System.Text;

namespace DepositoClases
{
    class Usuario
    {
        public string Name_User { get; set; }
        public string Nombre_Propietario { get; set; }
        public string Password { get; set; }
        public string Private_PIN { get; set; }
        public enum Rango { Administrador, Supervisor, operador }
    }
}
