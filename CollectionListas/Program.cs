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

            //List<string> aulas = new List<string>
            //{
            //    aulaProgramacao,
            //    aulaRequisitos, 
            //    aulaBancoDeDados
            //};
            List<string> aulas = new List<string>();
            aulas.Add(aulaProgramacao);
            aulas.Add(aulaRequisitos);
            aulas.Add(aulaBancoDeDados);


            //FIRST() PEGA A PRIMEIRA INDICE DA LISTA
            Console.WriteLine(aulas.First());
            //LAST() PEGA A ULTIMA INDICE DA LISTA
            Console.WriteLine(aulas.Last());
            //FIRSTORDEFAULT() PEGA UM OBJETO, CASA NAO EXISTA ELE TRAZ NULL
            Console.WriteLine(aulas.FirstOrDefault());


            Console.WriteLine("A primeira aula 'Requisitos': " +
                aulas.First(aula => aula.Contains("Requisitos")));
            Console.WriteLine("A primeira aula 'Banco': " +
                aulas.Last(aula => aula.Contains("Banco")));
            Console.WriteLine("A primeira aula 'conclusão': " +
                aulas.FirstOrDefault(aula => aula.Contains("conclusão")));


            //REVERTER A ORDEM AO CONTRÁRIO(PARA VOLTAR PODE UTILIZAR O MESMO COMANDO)
            aulas.Reverse();

            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}
            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }
    }
}
