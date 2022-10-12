using ListasDeObjetos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MANUPULANDO OBJETOS

            var aulaProgramacao = new Aula("1º Aula de Programação", 20);
            var aulaRequisitos = new Aula("2º Aula de Requisitos", 18);
            var aulaBancoDeDados = new Aula("3º Aula de Banco de Dados", 16);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaProgramacao);
            aulas.Add(aulaRequisitos);
            aulas.Add(aulaBancoDeDados);

            //IMPRIME A LISTA SEM O TOSTRING() E SEPARADO COM VÍRGULAS
            Console.WriteLine(String.Join(", ", aulas));

            //VERIFICA TEM CONTÉM AULAPROGRAMACAO DENTRO DA LISTA DE AULAS
            Console.WriteLine(aulas.Contains(aulaProgramacao));

            //COMPARA SE AULAS É IGUAL A AULA DE PROGRAMACAO(NESSE RESULTADO É FALSE, PQ NÃO SAO IGUAIS)
            Console.WriteLine(aulas.Equals(aulaProgramacao));

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
