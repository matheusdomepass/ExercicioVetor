﻿using System;

namespace ExercicioVetor
{
    class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return "Quartos ocupados: "
            + Nome + ", "
            + Email;
        }
    }
}
