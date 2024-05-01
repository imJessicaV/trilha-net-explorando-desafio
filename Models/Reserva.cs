using System.Globalization;

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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                Console.WriteLine($"Capaciadade da suite excedida. A capacidade da suite é {Suite.Capacidade}");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10 && DiasReservados <= 14)
            {
                decimal valorDesconto10 = valor - (valor * 10/100);
                Console.WriteLine($"Dias reservados: {DiasReservados}");
                Console.WriteLine($"Você teve um desconto de 10%, pois reservou entre 10 e 14 dias");                
                Console.WriteLine($"Valor da(s) diária(s) com desconto: {valorDesconto10.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR"))}");
            }
            if(DiasReservados >=15)
            {
                decimal valorDesconto25 = valor - (valor * 25/100);
                Console.WriteLine($"Dias reservados: {DiasReservados}");
                Console.WriteLine($"Você teve um desconto de 25%, pois reservou 15 ou mais dias");
                Console.WriteLine($"Valor da(s) diária(s) com desconto: {valorDesconto25.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR"))}");
                
            }

            return valor;
         
        }
    }
}