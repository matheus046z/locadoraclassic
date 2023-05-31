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
        public int IdCategoria { get; set; }
        public int IdGenero { get; set; }
        public bool Stlocado { get; set; }
        public string URLbanner { get; set; }


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

        public Filme(string nome, string duracao, string sinopse, int idCategoria, int idGenero, bool stlocado, string uRLbanner)
        {
            Nome = nome;
            Duracao = duracao;
            Sinopse = sinopse;
            IdCategoria = idCategoria;
            IdGenero = idGenero;
            Stlocado = stlocado;
            URLbanner = uRLbanner;
        }
    }
}
