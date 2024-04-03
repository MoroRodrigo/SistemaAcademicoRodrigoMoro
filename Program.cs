using SistemaAcademicoRodrigoMoro.Model;

class Program
{
    static void Main(string[] args)
    {
        // Teste das classes
        Aluno aluno1 = new Aluno(1, "João");
        Aluno aluno2 = new Aluno(2, "Maria");
        Aluno aluno3 = new Aluno(3, "Pedro");
        Professor professor = new Professor(100, "Dr. Silva");
        Disciplina disciplina = new Disciplina(123, "Matemática");

        Turma turma = new Turma
        {
            Codigo = 1,
            Disciplina = disciplina,
            Professor = professor
        };

        Console.WriteLine(turma.AddAluno(aluno1)); // Deve imprimir "Aluno adicionado"
        Console.WriteLine(turma.AddAluno(aluno2)); // Deve imprimir "Aluno adicionado"
        Console.WriteLine(turma.AddAluno(aluno3)); // Deve imprimir "Turma cheia"

        Console.WriteLine(turma.AbrirTurma()); // Deve imprimir "True"
        Console.WriteLine(turma.GerarPauta()); // Deve imprimir informações da turma
    }
}
