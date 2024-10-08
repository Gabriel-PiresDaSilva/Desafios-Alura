﻿class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<double> Notas { get; set; } = new List<double>();
}

class Professor
{
    public string Nome { get; set; }
    public List<string> Disciplinas { get; set; } = new List<string>();
}

class Disciplina
{
    public string NomeDisciplina { get; set; }
    public List<Aluno> Aluno { get; set; } = new List<Aluno>();
}