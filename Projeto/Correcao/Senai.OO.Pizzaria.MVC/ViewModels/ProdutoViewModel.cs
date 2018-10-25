namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    ///Class respossavel pelos dados do produto
    ///herda da classe base
    /// </summary>
    public class ProdutoViewModel : BaseViewModel
    {
        /// <summary>
        /// Descrição do produto
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Preço do produto
        /// </summary>
        public decimal Preco { get; set; }

        /// <summary>
        /// Categoria do produto
        /// </summary>
        public string Categoria { get; set; }        
    }
}