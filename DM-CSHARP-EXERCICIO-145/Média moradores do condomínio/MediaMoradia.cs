namespace DM_CSHARP_EXERCICIO_145.Média_moradores_do_condomínio
{
    public class MediaMoradia
    {
        public int bloco_a = 120;
        public int bloco_b = 80;
        public int Bloco_c => bloco_a  / 2;

        public string ObterMediaMoradia()
        {
            double media = (bloco_a + bloco_b + Bloco_c) / 3;
            System.Console.WriteLine("// Obtendo Media de Moradores de um Condominio //");
            return $"Média de Moradores por condominios é de : {media}\n";
        }
    }
}