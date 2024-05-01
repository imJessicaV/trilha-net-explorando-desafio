using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Jéssica", sobrenome:"Vitoriano");
Pessoa p2 = new Pessoa(nome: "Genilda", sobrenome:"Amara");
Pessoa p3 = new Pessoa(nome: "João Batista", sobrenome:"Souza");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
foreach (Pessoa p in hospedes) 
{
    Console.WriteLine($"Nome dos Hóspedes: {p.NomeCompleto}");
}

Console.WriteLine($"Valor diária: R${reserva.CalcularValorDiaria()}");