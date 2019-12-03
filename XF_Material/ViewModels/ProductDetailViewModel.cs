using Prism.Navigation;
using Prism.Services;
using XF_Material.Models;

namespace XF_Material.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {
        private string productPicture;
        public string ProductPicture
        {
            get => productPicture;
            set => SetProperty(ref productPicture, value);
        }

        private string productDescription;
        public string ProductDescription
        {
            get => productDescription;
            set => SetProperty(ref productDescription, value);
        }

        private decimal productPrice;
        public decimal ProductPrice
        {
            get => productPrice;
            set => SetProperty(ref productPrice, value);
        }

        public ProductDetailViewModel(INavigationService navigationService, IPageDialogService pageDialogService) 
            : base(navigationService, pageDialogService)
        {
            Title = "Detail";
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters != null && parameters.ContainsKey("product"))
            {
                var product = parameters["product"] as Product;

                ProductDescription = product.ProductDescription;
                ProductPicture = product.ProductPicture;
                ProductPrice = product.ProductPrice;
            }
        }
    }
}
