namespace DM_CSHARP_EXERCICIO_145.Media_da_Família
{
    public class MediaFamilia
    {
        public int pai = 42;
        public int mae = 45;
        public  int filho = 15;
        public string ObterMedia()
        {
            double media = (pai + mae + filho) / 3;
            System.Console.WriteLine("// Obtendo Media de Uma Família //");
            return $"Média de Famíla é de: {media} de idade\n";
        }
    }
}