namespace Padrao_Criacao.Factory
{
    public class Cachorro : IBichinho
    {
        public void ExibirDetalhes()
        {
            Console.WriteLine($"O bichinho é : {nameof(Cachorro)}");
        }
    }
}
