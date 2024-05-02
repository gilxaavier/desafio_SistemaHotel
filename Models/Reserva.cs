namespace SistemaHotel.Models
{
   public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            try
            {
                if (Suite.Capacidade >= hospedes.Count)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    throw new Exception("Capacidade insuficiente para o número de hóspedes.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar hóspedes: {ex.Message}");
                
            }
        }


        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            if (Hospedes == null){
                
                return 0;
            }

            else{
                return Hospedes.Count;
            }
    

        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados * Suite.ValorDiaria;
            
            if (DiasReservados >= 10)
            {
                valor -= (valor * 0.10M) ;
            }

            return valor;
        }
    }
}


