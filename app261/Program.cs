using System;

namespace app261
{
    internal class Paciente
    {
        public string Nome { get; set; } = default!;
        public string Sobrenome { get; set; } = default!;
        public string Urgencia { get; set; } = default!;
        public int Chegada { get; set; }

        public string NomePaciente()
        {
            return Nome;
        }
        public string SobrenomePaciente()
        {
            return Sobrenome;
        }
        public string UrgenciaAtendimento()
        {
            return Urgencia;
        }
        public int HorasChegada()
        {
            return Chegada;
        }

    }
}