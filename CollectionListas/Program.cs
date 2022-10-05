using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MANIPULANDO LISTAS

            string aulaProgramacao = "1º Aula de Programação";
            string aulaRequisitos = "2º Aula de Requisitos";
            string aulaBancoDeDados = "3º Aula de Banco de Dados";

            List<string> aulas = new List<string>()
            {
                aulaProgramacao,
                aulaRequisitos,
                aulaBancoDeDados
            };


        }
    }
}
