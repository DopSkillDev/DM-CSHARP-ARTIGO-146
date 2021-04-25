namespace DM_CSHARP_EXERCICIO_145.Media_de_alunos
{
    public class MediaAlunos 
    {
        int salas = 12;
        int alunos = 250;

        public string ObterMediaAlunos()
        {
            System.Console.WriteLine("// Obtendo Média de Alunos //");

            return System.Convert.ToString((double) alunos / salas) +  "\n";
        }
    }
}