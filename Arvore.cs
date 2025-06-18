using System;

namespace Arvore
{
    // Esta classe representa a árvore inteira
    public class Arvore
    {
        // A raiz é o primeiro nó da árvore
        public No Raiz { get; set; }

        // Construtor: cria a árvore com a raiz inicial
        public Arvore(string valorRaiz)
        {
            Raiz = new No(valorRaiz);
        }

        // Busca recursivamente um nó com um valor específico
        public No Buscar(No atual, string valor)
        {
            // Se encontrou o valor, retorna o nó
            if (atual.Valor == valor) return atual;

            // Senão, busca entre os filhos
            foreach (var filho in atual.Filhos)
            {
                var encontrado = Buscar(filho, valor);
                if (encontrado != null) return encontrado;
            }

            // Se não encontrar, retorna nulo
            return null;
        }

        // Insere um novo nó como filho de um nó existente
        public void Inserir(string valorPai, string novoValor)
        {
            No pai = Buscar(Raiz, valorPai);

            if (pai != null)
            {
                pai.AdicionarFilho(new No(novoValor));
            }
            else
            {
                Console.WriteLine("Nó pai não encontrado.");
            }
        }

        // Remove um nó e todos os seus filhos (subárvore)
        public void Remover(string valor)
        {
            // Proteção: não deixa remover a raiz
            if (Raiz.Valor == valor)
            {
                Console.WriteLine("Não é possível remover a raiz.");
                return;
            }

            // Inicia a remoção recursiva a partir da raiz
            RemoverRecursivo(Raiz, valor);
        }

        // Função auxiliar que remove o nó de forma recursiva
        private bool RemoverRecursivo(No atual, string valor)
        {
            foreach (var filho in atual.Filhos)
            {
                // Se o filho é o que queremos remover
                if (filho.Valor == valor)
                {
                    atual.Filhos.Remove(filho);
                    return true;
                }

                // Se não, continua buscando nos filhos
                if (RemoverRecursivo(filho, valor))
                    return true;
            }
            return false;
        }

        // Lista todos os filhos diretos de um nó
        public void MostrarFilhos(string valor)
        {
            No no = Buscar(Raiz, valor);

            if (no != null)
            {
                Console.WriteLine($"Filhos de {valor}:");
                foreach (var filho in no.Filhos)
                    Console.WriteLine($"- {filho.Valor}");
            }
            else
            {
                Console.WriteLine("Nó não encontrado.");
            }
        }

        // Mostra toda a estrutura da árvore
        public void MostrarHierarquia()
        {
            MostrarRecursivo(Raiz, "");
        }

        // Função auxiliar para mostrar os nós com indentação
        private void MostrarRecursivo(No no, string prefixo)
        {
            Console.WriteLine($"{prefixo}- {no.Valor}");

            foreach (var filho in no.Filhos)
            {
                // Adiciona espaços para mostrar hierarquia
                MostrarRecursivo(filho, prefixo + "  ");
            }
        }
    }
}
