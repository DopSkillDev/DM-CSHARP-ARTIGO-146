namespace DM_CSHARP_EXERCICIO_145.Operadores_Relacionais
{
    public class OperadoresRelacionais
    {
        int a = 5, b = 10;
        double c = 10, d = 15;

        public string ObterOperadoresRelacionais()
        {
            System.Console.WriteLine("// Obtendo Operadores Relacionais //");

            var list = (
                b != c,
                a >= d,
                d / a < a,
                d <= c
            );

            return System.Convert.ToString(list) + "\n";
        }
    }
}