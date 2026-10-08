using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopForms
{
    public abstract class Animal
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }

        protected Animal(string nome, int idade)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome do animal é obrigatório.");

            if (idade < 0)
                throw new ArgumentException("A idade não pode ser negativa.");

            Nome = nome;
            Idade = idade;
        }

        public abstract string FazerSom();

        public void Comer() => Console.WriteLine($"{Nome} está comendo.");

        public override string ToString() => $"{Nome} ({Idade} anos) - {GetType().Name}";
    }
}
