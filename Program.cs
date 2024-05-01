using System.Globalization;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;



// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

//nomes ficiticios
Pessoa p1 = new Pessoa(nome: "Amanda", sobrenome:"Silva Nunes");
Pessoa p2 = new Pessoa(nome: "Karla", sobrenome:"Lima Silveira");
Pessoa p3 = new Pessoa(nome: "Marcelo", sobrenome:"Nunes Sobral");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Master", capacidade: 5, valorDiaria: 150);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 13);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
foreach (Pessoa p in hospedes) 
{
    Console.WriteLine($"Hóspede: {p.NomeCompleto}");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
}
Console.WriteLine($"Valor total da(s) diária(s): {reserva.CalcularValorDiaria().ToString("C",CultureInfo.CreateSpecificCulture("pt-BR"))}");
Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");