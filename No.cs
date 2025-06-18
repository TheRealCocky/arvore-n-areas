using System.Collections.Generic;

namespace Arvore
{
    // Esta classe representa um nó da árvore de N-ária
    public class No
    {
        // Valor armazenado no nó (pode ser um nome, número, etc.)
        public string Valor { get; set; }

        // Lista de nós filhos (cada nó pode ter vários filhos)
        public List<No> Filhos { get; set; }

        // Construtor: cria um nó com um valor e inicializa a lista de filhos
        public No(string valor)
        {
            Valor = valor;
            Filhos = new List<No>();
        }

        // Adiciona um nó filho a este nó
        public void AdicionarFilho(No filho)
        {
            Filhos.Add(filho);
        }
    }
}
