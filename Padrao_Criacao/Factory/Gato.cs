namespace Padrao_Criacao.Factory
{
    public class Gato : IBichinho
    {
        public void ExibirDetalhes()
        {
            Console.WriteLine($"O bichinho é: {nameof(Gato)}");
        }
    }
}
