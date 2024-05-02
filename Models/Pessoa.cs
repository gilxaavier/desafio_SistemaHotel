namespace SistemaHotel.Models
{
    public class Pessoa
    {

        public Pessoa() { }

        public Pessoa(string nome, string sorbrenome)
        {
            Nome = nome;
            Sobrenome = sorbrenome;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
         public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

    }
}
