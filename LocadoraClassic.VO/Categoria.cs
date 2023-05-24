using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Categoria
    {
        public int Id;
        public string Nome;
        public string ValorDiaria;

        public Categoria()
        {
        }
        public Categoria(int id)
        {
            Id = id;
        }
        public Categoria(string nome, string valorDiaria)
        {
            Nome = nome;
            ValorDiaria = valorDiaria;
        }
    }
}
