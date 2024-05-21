namespace DesafioProjetoHospedagem.Models
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
            // Implementado!!
                        
            if (hospedes.Count <= Suite.Capacidade)
            {
                
                Hospedes = hospedes;
            }
            else
            {
                // Implementado!!
                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado!!
            return Hospedes != null ? Hospedes.Count : 0;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado!!
            decimal valorDiaria = DiasReservados * Suite.ValorDiaria;

            // Implementado!!
            if (DiasReservados >=10)
            {
                valorDiaria *= 0.9m;
            }

            return valorDiaria;
        }
    }
}