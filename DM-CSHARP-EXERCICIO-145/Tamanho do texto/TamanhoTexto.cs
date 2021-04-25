namespace DM_CSHARP_EXERCICIO_145.Tamanho_do_texto
{
    public class TamanhoTexto
    {
        public string Nome = "Framework";
        public int Tamanho => Nome.Length;

        public string ObterTamanhDeTexto()
        {
            System.Console.WriteLine("// Obtendo Tamanho de um Texto //");
            return $"A palavra {Nome} possui {Tamanho} letras\n";
        }
    }
}