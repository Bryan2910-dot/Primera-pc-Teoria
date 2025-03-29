using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primera_pc_Teoria.Models
{
    public class Formulario
    {
        public double Cantidad { get; set; }
        public string? Moneda1 { get; set; }
        public string? Moneda2 { get; set; }
        public string? Operacion { get; set; }
        
        public double Calcular()
        {
            double resultado = 0;
            switch (Moneda1)
            {
                case "EEUU - Dolar americano":
                    if (Moneda2 == "BRL - Real brasileño")
                    {
                        resultado = Convert.ToDouble(Cantidad) * 5.76; 
                    }
                    else if (Moneda2 == "PEN - Sol Peru")
                    {
                        resultado = Convert.ToDouble(Cantidad) * 3.64; 
                    }
                    break;
                case "BRL - Real brasileño":
                    if (Moneda2 == "EEUU - Dolar americano")
                    {
                        resultado = Convert.ToDouble(Cantidad) * 0.17; 
                    }
                    else if (Moneda2 == "PEN - Sol Peru")
                    {
                        resultado = Convert.ToDouble(Cantidad) * 0.63; 
                    }
                    break;
                case "PEN - Sol Peru":
                    if (Moneda2 == "EEUU - Dolar americano")
                    {
                        resultado = Convert.ToDouble(Cantidad) / 0.27; 
                    }
                    else if (Moneda2 == "BRL - Real brasileño")
                    {
                        resultado = Convert.ToDouble(Cantidad) / 1.58; 
                    }
                    break;
            }
            return resultado;
        }

    }
}