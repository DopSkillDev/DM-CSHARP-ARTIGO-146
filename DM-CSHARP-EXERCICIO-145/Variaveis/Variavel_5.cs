namespace DM_CSHARP_EXERCICIO_145.Variaveis
{
    public class Variavel_5
    {
        public double Valor5;

        public string ObterVariavel_5()
        {
            return $"\nResultado da variavel que é representado pelo nivel 5 é de : { Valor5 = new Variavel_5B().valor1 + new Variavel_5C().valor3 }\n";
        }
        public class Variavel_5B : Variavel_1
        {
            public double Var5Var1()
            {
                return valor1;
            }
        }

        public class Variavel_5C : Variavel_3
        {
            public int Var5Var3()
            {
                return valor3;
            }
        }
    }
}