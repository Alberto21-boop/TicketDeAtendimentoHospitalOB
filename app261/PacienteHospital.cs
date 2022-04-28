using app261;

Paciente paciente = new Paciente();

paciente.Nome = Console.ReadLine();
paciente.Sobrenome = Console.ReadLine();
paciente.Urgencia = Console.ReadLine();
paciente.Chegada = int.Parse(Console.ReadLine());

Console.WriteLine($"Nome : {paciente.NomePaciente()}");
Console.WriteLine($"Sobrenome : {paciente.SobrenomePaciente()}");
Console.WriteLine($"Urgencia : {paciente.UrgenciaAtendimento()}");
Console.WriteLine($"Horas de Chegada : {paciente.HorasChegada()}");