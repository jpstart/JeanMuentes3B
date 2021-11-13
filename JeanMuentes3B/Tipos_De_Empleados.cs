using System;
using System.Collections.Generic;
using System.Text;

namespace JeanMuentes3B
{
    public class empleado_temporal:Empleado
    {
        public int Fecha_de_ingreso { get; set; } 
        public int Fecha_de_salida { get; set;  } 

    }
    public class empleado_por_Horas:Empleado
    {
        public int Precio_por_hora { get; set; }
        public Boolean Numero_de_horas_trabajadas_por_mes { get; set; }
    }
    public class empleado_fijo:Empleado
    {
        public Boolean Año_de_entrada_a_la_empresa { get; set; }
        public int Complemento { get; set; }

    }
}
