using System;

namespace Aula04092018
{
    class Pessoa
    {
        // Atributos
        private string nome;
        private int idade;
        private double altura;
        private double peso;
        private string cpf;

        // Método Construtor
        public Pessoa()
        {
            this.nome = "";
            this.idade = 0;
            this.altura = 0.0;
            this.peso = 0.0;
            this.cpf = "";
        }

        public Pessoa(string cpf, string nome)
        {
            this.cpf = cpf;
            this.nome = nome;
        }

        //Métodos
        public string NomeCPF()
        {
            return this.nome + " - " + this.cpf;
        }
    }
}
