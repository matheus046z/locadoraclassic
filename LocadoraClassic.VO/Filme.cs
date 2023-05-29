using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Filme
    {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public string Sinopse { get; set; }
        public string Categoria { get; set; }
        public string Genero { get; set; }

        public Filme()
        {
        }

        public Filme(int id)
        {
            Id = id;
        }

        public Filme(int id, string nome) : this(id)
        {
            Nome = nome;
        }

        public Filme(string nome, string duracao, string sinopse, string categoria, string genero)
        {
            Nome = nome;
            Duracao = duracao;
            Sinopse = sinopse;
            Categoria = categoria;
            Genero = genero;
        }
    }
}
