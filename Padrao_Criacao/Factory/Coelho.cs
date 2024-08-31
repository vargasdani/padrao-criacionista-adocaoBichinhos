namespace Padrao_Criacao.Factory
{
    public class Coelho : IBichinho
    {
        public void ExibirDetalhes()
        {
            Console.WriteLine($"O bichinho é: {nameof(Coelho)}");
        }
    }
}
