using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SubSetProblem.classes
{
    static class Subset
    {
        public static void ResolveSubset(Interacao interacaoUsuario, bool paralelismo = false)
        {
            var stopwatch = new Stopwatch();
            var soma = interacaoUsuario.Soma;
            var listaPreenchida = interacaoUsuario.ListaNumeros;
            var ocorrencias = 0;

            stopwatch.Start();

            if (!paralelismo)
                foreach (var numeroInicial in listaPreenchida)
                {
                    foreach (var numeroSecundario in listaPreenchida)
                    {
                        if ((numeroInicial + numeroSecundario) == soma)
                        {
                            ocorrencias++;
                        }
                    }
                }
            else
                Parallel.ForEach(listaPreenchida, numeroInicial =>
                {
                    foreach (var numeroSecundario in listaPreenchida)
                    {
                        if ((numeroInicial + numeroSecundario) == soma)
                        {
                            ocorrencias++;
                        }
                    }
                });

            stopwatch.Stop();

            var frase = paralelismo ? "Paralelismo" : "Não-Paralelismo";
            Console.WriteLine($"\n==============\n{frase}\n==============");
            Console.WriteLine("Encontradas {0} ocorrências", ocorrencias);
            Console.WriteLine($"Tempo decorrido: {stopwatch.Elapsed}\n");
        }
    }
}

