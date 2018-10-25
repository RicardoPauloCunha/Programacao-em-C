namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    ///Class respossavel pelos dados do usuario
    ///herda da classe base
    ///Para ser utulizar : e o nome da classe que deseja herdar
    /// </summary>
    public class UsuarioViewModel : BaseViewModel
    {
        /// <summary>
        /// Email do usuario
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Senha do usuario
        /// </summary>
        public string Senha { get; set; }


    }
}