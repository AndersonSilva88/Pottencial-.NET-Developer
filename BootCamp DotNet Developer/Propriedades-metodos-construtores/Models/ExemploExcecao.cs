using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_metodos_construtores.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Metodo2();
        }

        public void Metodo2()
        {
            try
            {
                Metodo3();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção tratada. " + e.Message);
            }
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    }


}