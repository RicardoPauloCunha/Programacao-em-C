namespace Pizzaria.Util
{
    public static class ValidacaoUtil
    {
        public static bool ValidarEmail(string email)
        {
            if (email.Contains("@") && email.Contains("."))
                return true;

            return false;
        }

        public static bool ValidarSenha(string senha)
        {
            if (senha.Length >= 6)
                return true;

            return false;
        }

        public static bool ValidarCategoria(string categoria)
        {
            if (categoria.ToLower() == "pizza" || categoria.ToLower() == "bebida")
                return true;

            return false;
        }
    }
}