using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Sistema_Abstraindo_Celular_POO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
                : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia");
        }
    }
}