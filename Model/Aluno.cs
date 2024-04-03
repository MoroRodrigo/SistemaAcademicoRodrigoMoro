﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoRodrigoMoro.Model
{
    class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }
    }

}
