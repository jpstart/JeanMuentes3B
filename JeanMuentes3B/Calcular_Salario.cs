using System;
using System.Collections.Generic;
using System.Text;

namespace JeanMuentes3B
{
    public class empleadoGL
    {
        public void CalcularSalario(empleado_temporal empleado) => Console.WriteLine("El sueldo mensual es", empleado.Salario_base);

        public void CalcularSalario(empleado_fijo empleado)
        {
            empleado.Salario_base += (empleado.Salario_base + empleado.Complemento) * (empleado.Año_de_entrada_a_la_empresa);
            Console.WriteLine("El sueldo mensual es", empleado.Salario_base);
        }
        public void CalcularSalario(empleado_por_Horas empleado. double Numero_de_horas_trabajadas_por_mes);{
        Empleado.Salario_base = Empleado.Salario_base* Empleado.Numero_de_horas_trabajadas_por_mes;
        Console.WriteLine("El sueldo mensual es", Empleado.Salario_base);


    }
    


}
