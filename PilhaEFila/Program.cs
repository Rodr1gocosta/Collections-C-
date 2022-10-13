using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEFila
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //COLEÇÃO NÓS

            LinkedList<string> dias = new LinkedList<string>();

            //Adiciona na lista na primeira posição
            var dQuarta = dias.AddFirst("quarta");
            //Adiciona na lista antes da posição que declarou no metodo
            var dSegunda = dias.AddBefore(dQuarta, "segunda");
            //Adiciona na lista depois da posição que declarou no metodo
            var dTerca = dias.AddAfter(dSegunda, "terça");
            //Adiciona na lista na ultima posição
            var dDomingo = dias.AddLast("domingo");

            var dSexta = dias.AddAfter(dQuarta, "sexta");
            var dQuinta = dias.AddBefore(dSexta, "quinta");
            var dSabado = dias.AddBefore(dDomingo, "sábado");

            foreach(string dia in dias)
            {
                Console.WriteLine(dia);
            }
        }
    }
}
