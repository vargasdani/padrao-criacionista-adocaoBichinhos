namespace Padrao_Criacao.Singleton
{
    public class ClasseUnica
    {
        private static ClasseUnica _instancia;

        private ClasseUnica()
        {

        }

        public static ClasseUnica ObterInstancia
        {
            get
            {
                if(_instancia is null)
                    _instancia = new ClasseUnica();

                return _instancia;
            }
        }

        public void Detalhe()
        {
            Console.WriteLine("Detalhes da classe unica");
        }

    }
}
