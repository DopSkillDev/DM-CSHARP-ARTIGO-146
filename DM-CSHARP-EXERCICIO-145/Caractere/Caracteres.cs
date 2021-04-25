namespace DM_CSHARP_EXERCICIO_145.Caractere
{
    public class Caracteres
    {
        string nome = "DevMedia";
        char caracte;

        public string ObtendoCaractere()
        {
            System.Console.WriteLine("// Obtendo Caracteres //");

            return System.Convert.ToString(caracte = nome[3]) + "\n";
        }
    }
}