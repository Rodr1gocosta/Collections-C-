using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEFila2.modelo
{
    public class Navegador
    {
        private string atual = "vazia";
        public Navegador()
        {
            Console.WriteLine($"Página atual: {atual}");
        }

        internal void NavegarPara(string url)
        {
            atual = url;
            Console.WriteLine($"Página atual: {atual}");
        }
    }
}
