using System;
namespace Senai.OO.Pizzaria.MVC.Util
{
    /// <summary>
    /// Classe responsável pelas validoções de campos do sistema 
    /// </summary>
    public static class ValidacaoUtil
    {
        /// <summary>
        /// Valida o email do usuario, verifica se o email possui @ e .
        /// </summary>
        /// <param name="Email">Email a ser verificado</param>
        /// <returns>Retorna true caso o email e possua @ e . ou false caso não possua</returns>
        public static bool ValidarEmail(string Email) {
            if (Email.Contains("@") && Email.Contains(".")) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Valida a senha do usuario, verifica se senha possui mais que 6 caracteres
        /// </summary>
        /// <param name="Senha">Senha a ser verificada</param>
        /// <returns>Retorna true caso a senha possua mais que 6 caracteres ou false caso não possua</returns>
        public static bool ValidarSenha(string Senha) {
            if (Senha.Length >= 6) {
                return true;
            }
            return false;
        }
    }
}