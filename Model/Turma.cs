using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademicoRodrigoMoro.Model
{
    class Turma
    {
        public int Codigo { get; set; }
        public Disciplina Disciplina { get; set; }
        public Professor Professor { get; set; }
        private List<Aluno> alunosInscritos = new List<Aluno>();

        public string AddAluno(Aluno aluno)
        {
            if (alunosInscritos.Count < 10)
            {
                alunosInscritos.Add(aluno);
                return "Aluno adicionado";
            }
            else
            {
                return "Turma cheia";
            }
        }

        public bool AbrirTurma()
        {
            return alunosInscritos.Count >= 2;
        }

        public string GerarPauta()
        {
            string pauta = $"Código da Turma: {Codigo}\n";
            pauta += $"Disciplina: {Disciplina.Nome}\n";
            pauta += $"Professor: {Professor.Nome}\n";
            pauta += "Alunos inscritos:\n";
            foreach (var aluno in alunosInscritos)
            {
                pauta += $"- {aluno.Nome}\n";
            }
            return pauta;
        }
    }
}
