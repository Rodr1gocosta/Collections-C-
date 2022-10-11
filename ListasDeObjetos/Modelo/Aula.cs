using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDeObjetos.Modelo
{
    internal class Aula 
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get { return titulo; } set { titulo = value; } } 
        public int Tempo { get { return tempo; } set { tempo = value; } }

        public override string ToString()
        {
            return $"[título:{titulo} , tempo:{tempo} ]";
        }


    }
}
