namespace DM_CSHARP_EXERCICIO_145.LampadasParaCasa
{
    public class Lampadas
    {

        int lampadas_Acessas =  10;
        int lampadas_Queimadas = 5;

        public string ObterLPCasa()
        {
            System.Console.WriteLine("// Obtendo Quantidade de lampadas //");
            return System.Convert.ToString(lampadas_Acessas + lampadas_Queimadas);
        }
    }
}
