using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public Cliente()
        {

        }
        public Cliente(int id)
        {
            Id = id;
        }
        public Cliente(string nome, string endereco, string telefone, string cpf, string rg)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Cpf = cpf;
            Rg = rg;
        }
    }
}
