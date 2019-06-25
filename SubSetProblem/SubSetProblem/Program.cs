using System;
using SubSetProblem.classes;

namespace SubSetProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var interacaoUsuario = new Interacao();

            interacaoUsuario.PreencheNumeroNaLista();
            interacaoUsuario.SomaASerEncontrada();
            interacaoUsuario.OpcaoParalelismoOuNao();

            switch (interacaoUsuario.Opcao)
            {
                case 1:
                    Subset.ResolveSubset(interacaoUsuario, true);
                    break;

                case 2:
                    Subset.ResolveSubset(interacaoUsuario);
                    break;

                case 3:
                    Subset.ResolveSubset(interacaoUsuario);
                    Subset.ResolveSubset(interacaoUsuario, true);
                    break;
            }
            
        }
    }
}
