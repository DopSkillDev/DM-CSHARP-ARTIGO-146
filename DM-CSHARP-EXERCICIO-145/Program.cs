using System.Globalization;
using DM_CSHARP_EXERCICIO_145.Media_da_Família;
using DM_CSHARP_EXERCICIO_145.Media_de_alunos;
using DM_CSHARP_EXERCICIO_145.Média_moradores_do_condomínio;
using DM_CSHARP_EXERCICIO_145.Caractere;
using DM_CSHARP_EXERCICIO_145.Operadores_Logicos_e_Relacionais;
using DM_CSHARP_EXERCICIO_145.Operadores_Relacionais;
using DM_CSHARP_EXERCICIO_145.Tamanho_do_texto;
using DM_CSHARP_EXERCICIO_145.Variaveis;
using System;
using DM_CSHARP_EXERCICIO_145.ConversaoTipo_;

namespace DM_CSHARP_EXERCICIO_145
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DateTime sd = DateTime.Now;
            string br = sd.ToString(new CultureInfo("pt-br"));

            Console.WriteLine($"\t\t Data: {br} \n-----------------------------------------------------------------");
            Console.WriteLine(" - Boas Vindas ao Exercícios 145, da Plataforma DEVMEDIA OOP com CSharp - ");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine(new Variavel_4().Var4Var2() + new Variavel_5().ObterVariavel_5());
            Console.WriteLine(new MediaFamilia().ObterMedia());
            Console.WriteLine(new MediaMoradia().ObterMediaMoradia());
            Console.WriteLine(new TamanhoTexto().ObterTamanhDeTexto());
            Console.WriteLine(new OperLogRel().ObterOperLogRel());
            Console.WriteLine(new OperadoresRelacionais().ObterOperadoresRelacionais());
            Console.WriteLine(new Caracteres().ObtendoCaractere());
            Console.WriteLine(new MediaAlunos().ObterMediaAlunos());
            Console.WriteLine(new ConversaoTipo().ObterConversaoTipo());
        }
    }
}
