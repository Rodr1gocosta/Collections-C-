using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //MANIPULANDO ARRAY

            string aulaProgramacao = "1º Aula de Programação";
            string aulaRequisitos = "2º Aula de Requisitos";
            string aulaBancoDeDados = "3º Aula de Banco de Dados";

            //string[] aulas = new string[] {
            //    aulaProgramacao,
            //    aulaRequisitos,
            //    aulaBancoDeDados
            //};

            string[] aulas = new string[3];
            aulas[0] = aulaProgramacao;
            aulas[1] = aulaRequisitos;
            aulas[2] = aulaBancoDeDados;

            //aulaProgramacao = "Aula de Programação com C#" (não adiciona no array de aulas);
            // JEITO CORRETO PARA ADICIONAR NO ARRAY DE AULAS
            aulas[0] = "1º Aula de Programação com C#";

            //PEGA O ÍNDICE
            Console.WriteLine("Pega o índice " + Array.IndexOf(aulas, aulaRequisitos));

            //REVERTER A ORDEM AO CONTRÁRIO(PARA VOLTAR PODE UTILIZAR O MESMO COMANDO)
            Array.Reverse(aulas);

            //ORDENAR POR ORDEM AFALBÉTICO
            Array.Sort(aulas);

            //CLONA UM ARRAY(FAZENDO A CONVERSÃO COM 'as' DE OBJETO PARA STRING[])
            string[] clone = aulas.Clone() as string[];

            //lIMPA O ELEMNTO DO ARRAYs
            Array.Clear(aulas, 0, aulas.Length);


            //foreach (string aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //} 
            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
