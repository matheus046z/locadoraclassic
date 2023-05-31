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
