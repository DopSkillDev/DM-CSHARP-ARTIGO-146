namespace DM_CSHARP_EXERCICIO_145.ConversaoTipo
{
    public class Conversao
    {
        int numero1 = 17;
        int numero2 = 2;

        public string ObterConversaoTipo()
        {
            System.Console.WriteLine("// Obtendo Conversão de Tipo //");
            var resultado = (double) numero1 / numero2;
            return System.Convert.ToString(resultado == 8.5) + "\n";
        }
    }
}