namespace Aula2_RA6322501
{
    public class Filme
    {
        private string? titulo;
        private string? sinopse;
        private string? genero;
        private int classificacao;

        public void Receber()
        {
            Console.WriteLine("Digite o nome do filme: ");
            titulo = Console.ReadLine();
            Console.WriteLine("Digite a sinopse do filme");
            sinopse = Console.ReadLine();
            Console.WriteLine("Digite o gênero do filme");
            genero = Console.ReadLine();
            Console.WriteLine("Digite a classificação do filme");
            classificacao = Convert.ToInt32(Console.ReadLine());
        }
        
        public void Mostrar()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Sinopse: {sinopse}");
            Console.WriteLine($"Gênero: {genero}");
            Console.WriteLine($"Classificação: {classificacao} anos");
        }
    }
}
