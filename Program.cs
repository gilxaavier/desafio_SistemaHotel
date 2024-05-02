using SistemaHotel.Models;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> Hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Gil", "Xavier");
Pessoa p2 = new Pessoa(nome: "Cristiano", "Ronaldo");
Pessoa p3 = new Pessoa(nome: "Toni", "Kroos");

Hospedes.Add(p1);
Hospedes.Add(p2);
// Hospedes.Add(p3);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 5);
Reserva reserva = new Reserva(diasReservados: 15);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(Hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");