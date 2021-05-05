using System;
using System.Globalization;
using DM_CSHARP_EXERCICIO_145.Media_da_Família;
using DM_CSHARP_EXERCICIO_145.Media_de_alunos;
using DM_CSHARP_EXERCICIO_145.Média_moradores_do_condomínio;
using DM_CSHARP_EXERCICIO_145.Caractere;
using DM_CSHARP_EXERCICIO_145.Operadores_Logicos_e_Relacionais;
using DM_CSHARP_EXERCICIO_145.Operadores_Relacionais;
using DM_CSHARP_EXERCICIO_145.Tamanho_do_texto;
using DM_CSHARP_EXERCICIO_145.Variaveis;
using DM_CSHARP_EXERCICIO_145.ConversaoTipo;
using DM_CSHARP_EXERCICIO_145.LampadasParaCasa;

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

            // Console.WriteLine(new LPCasa().ObterLPCasa());


            // SSint tipoPessoa = (int) TipoPessoa.Verde;

            // Console.WriteLine("" + TipoPessoa.Verde);
            // Console.WriteLine("" + tipoPessoa);

            // int numero_1 = 10;
            // numero_1 *= ++numero_1;

            // Console.WriteLine(numero_1);

            // int a = 5, b = 10, c = 15, d = 20;

            // Console.WriteLine( a + b == c);
            // Console.WriteLine( b + c != d + a);
            // Console.WriteLine( c + a == d);
            // Console.WriteLine( b + c != a * b);

            // int a = 5;
            // a++;
            // a *= a;
            // a--;
            // a += a;
            // a /= 10;

            // Console.WriteLine(a);

            // int a = 30;
            // int b = 4;
            // int x = a / b;

            // Console.WriteLine(x);

            // int a = 10;
            // int b = 3;

            // Console.WriteLine( a % b);

            // string? nome = null;

            // string mascote_nome = "Felix";
            // int mascote_idade = 5;

            // TipoMascote mascote_tipo = TipoMascote.Lhama;

            // Console.WriteLine(mascote_tipo);

            // Variaveis var = new Variaveis();

            // Console.WriteLine(var.ObterVariaveis());


            // int a = 8;
            // int b = 5;
            // int c = 2;

            // b *= a;
            // b /= c;

            // Console.WriteLine(b);

            // string nome = "Patrícia Inácio";
            // string iniciais = nome.ToString();
            // Console.WriteLine(iniciais);

            // int numero_1 = 15;
            // int numero_2 = numero_1;
            // numero_2 *= numero_2;

            // Console.WriteLine(numero_2);


            // int a = 5;
            // int b = a + 6;
            // a++;
            // int c = a + b;

            // Console.WriteLine(c);

            // int n1 = 5;
            // int n2 = 10;
            // n1 += 2;
            // n2 -= 5;

            // Console.WriteLine("Valor 1 = " + n1 + " e o Valor 2 = " + n2);

            //  Obtendo o caractere //
            // string a = "asp.net mvc";
            // char b = a[a.Length - 1];

            // Console.WriteLine(b);

            // string framework = "asp.net mvc";
            // char ponto = framework[3];

            // Console.WriteLine(ponto);
        }
    }
}
