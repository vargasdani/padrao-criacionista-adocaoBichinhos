namespace Padrao_Criacao.Factory
{
    public class BichinhoFactory
    {
        public static IBichinho CriarBichinho(string tipo)
        {
            if (string.IsNullOrEmpty(tipo))
                throw new ArgumentNullException("A especie do seu bichinho precisa ser informada");

            switch (tipo.ToLower())
            {
                case "cachorro":
                    return new Cachorro();
                case "gato":
                    return new Gato();
                case "coelho":
                    return new Coelho();
                default:
                    throw new Exception("O tipo informado nao esta dispoivel para adocao!");
            }
        }
    }
}
