
Desafio de Projeto: Sistema de Hospedagem
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar reservas em um hotel. O sistema deve calcular corretamente os valores das reservas, considerando a quantidade de hóspedes e aplicando descontos, se aplicável.

Contexto
O sistema consistirá em três classes principais:

Pessoa: Representa um hóspede.
Suíte: Representa uma suíte do hotel, com capacidade e valor da diária.
Reserva: Realiza o relacionamento entre pessoas e suítes, além de calcular o valor da diária.
Regras e Validações
Capacidade da Suíte: Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes.
Obter Quantidade de Hóspedes: O método ObterQuantidadeHospedes da classe Reserva deve retornar a quantidade total de hóspedes.
Calcular Valor da Diária: O método CalcularValorDiaria da classe Reserva deve retornar o valor da diária (dias reservados x valor da diária). Além disso, um desconto de 10% deve ser concedido para reservas com duração igual ou maior que 10 dias.
