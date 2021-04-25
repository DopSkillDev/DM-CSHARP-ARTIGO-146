namespace DM_CSHARP_EXERCICIO_145.Operadores_Logicos_e_Relacionais
{
    public class OperLogRel
    {
        int a = 10, b = 20, c = 30, d = 40;
        public string ObterOperLogRel()
        {
            System.Console.WriteLine("// Obtendo Operadores Lógicos e Relacionais //");

            var list = (
                c < d,
                ! (a > d),
                c > a * 2 || b == 20,
                b > a != b > c,
                a + c == d
            );

            return System.Convert.ToString(list) + "\n";
        }
    }
}