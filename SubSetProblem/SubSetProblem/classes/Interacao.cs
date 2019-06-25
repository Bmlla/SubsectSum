using System;
using System.Collections.Generic;
using System.Text;

namespace SubSetProblem.classes
{
    class Interacao
    { 
        public List<int> ListaNumeros = new List<int>();
        public int Soma { get; set; }

        public int Opcao { get; set; }

        private string LeDado()
        {
            return Console.ReadLine().ToString();
        }


        public void PreencheNumeroNaLista()
        {
            Console.Write("Digite o tamanho da lista a ser gerada: ");

            var valorDigitado = LeDado();


            var conversaoOK = Int32.TryParse(valorDigitado, out int resultadoConversao);

            if (conversaoOK && resultadoConversao >= 0)
            {
                for(int numero = 0; numero < resultadoConversao; numero++)
                    ListaNumeros.Add(numero);
            }
            else
                Console.WriteLine("\nNúmero da lista inválido\n");

        }

        public void SomaASerEncontrada()
        {
            Console.Write("\nDigite a soma a ser encontrada: ");

            var valorDigitadoSoma = LeDado();
            var conversaoOK = Int32.TryParse(valorDigitadoSoma, out int resultadoConversao);

            if (conversaoOK && resultadoConversao > 0)
                Soma = resultadoConversao;
            else
            {
                Console.Write("\nValor inválido. Digite um número maior que 0\n");
                SomaASerEncontrada();
            }
        }

        public void OpcaoParalelismoOuNao()
        {
            Console.Write("\nOpções\n==============\n1 - Paralelismo\n2 - Não-Paralelismo\n3 - Os dois\n==============\nOpção: ");

            var opcaoDigitada = LeDado();
            var conversaoOK = Int32.TryParse(opcaoDigitada, out int resultadoConversao);

            if (conversaoOK && resultadoConversao > 0 && resultadoConversao <= 3 && resultadoConversao >= 1)
                Opcao = resultadoConversao;
            else
            {
                Console.Write("\nValor inválido. Digite uma opção entre 1 e 3\n");
                OpcaoParalelismoOuNao();
            }
        }
    }
}
