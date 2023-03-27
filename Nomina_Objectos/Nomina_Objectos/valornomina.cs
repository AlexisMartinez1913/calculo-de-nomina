using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina_Objectos
{
    class valornomina
    {
        public string nombre;
        public int año_ingreso;
        public int cedula;
        public int horas_trabajadas;
        public int valor_base;
        public int salario;
        public int horas_extras;
        public int valor_extras;
        public double subsidio_alimentacion;
        public double subsidio_transporte;
        public double bonificacion;
        public int años_empresa;
        public double total;
        

        public int calcular_Extras(int horas_extras)
        {
            
            valor_extras = horas_extras * 12000;
            return valor_extras;
        }

        public int calcular_salario(int valor, int horas)
        {

            salario = valor_base * horas_trabajadas;
            return salario;
        }
        public double calcular_alimentos(int salario)
        {
            subsidio_alimentacion = (salario * 4.2) / 100;
            return subsidio_alimentacion;
        }
        public double calcular_transporte(int salario)
        {
            subsidio_transporte = (salario * 7.5) / 100;
            return subsidio_transporte;
        }
        public int años_en_empresa(int año_ingreso)
        {

            años_empresa = 2023 - año_ingreso;
            return años_empresa;
        }

        public double calcular_bonificacion1(int salario )
        {
            bonificacion = (salario * 3.5) / 100;

            return bonificacion;
        }
        public double calcular_bonificacion2(int salario)
        {
            bonificacion = (salario * 6.6) / 100;
            return bonificacion;

        }
        public double totalgeneral(int salario, int extras, double sub1, double sub2, double bonifi)
        {
            total = (salario + valor_extras + subsidio_alimentacion + subsidio_transporte + bonificacion);
            return total;
        }




    }
}
