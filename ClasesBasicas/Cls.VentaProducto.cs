using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Clases_DS_Sabado.ClasesBasicas
{
    public class Cls
    {

        //Propiedades de entrada - Solo escritura-get es publico
        public Int16 Cantidad { private get; set; }
        public double ValorUnitario {get; private set; }

        //Propiedades de salida - Solo lo puedo leer- set es privado
        public double ValorTotal { get; private set; }
        public double ValorIva { get; private set; }
        public double ValorSubtotal { get; private set; }
        public string Error { get; private set; }
        //Atributos
        private double porcentaIva;

        public void CalcularTotal() 
        {
            ValorIva = Cantidad * ValorUnitario;
            // con el valor total se puede calcular el subtotal, como es un método que retorna un valor
            //se escribe atributos funcion
            ValorSubtotal = CalcularSubtotal();
            ValorIva = CalcularIva();
        }
        public double CalcularIva()
        {
            return (ValorTotal - ValorSubtotal);
        }
        public double CalcularSubtotal()

        {
            porcentaIva = 0.19;
            return ValorTotal / (1 + porcentaIva);
        }
       
    }
}
