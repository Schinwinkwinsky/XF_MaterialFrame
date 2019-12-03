using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XF_Material.Models;

namespace XF_Material.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get => products;
            set => SetProperty(ref products, value);
        }

        public DelegateCommand<Product> ItemTappedCommand { get; set; }

        public MainViewModel(INavigationService navigationService, IPageDialogService pageDialogService) 
            : base(navigationService, pageDialogService)
        {
            Title = "Products";

            Products = new ObservableCollection<Product>();

            Products.Add(new Product { ProductDescription = "Sugar", ProductPicture = "https://www.rd.com/wp-content/uploads/2016/10/03_foods_Will_make_arthritis_worse_sugar_twinsterphoto.jpg", ProductPrice = 0.9m });
            Products.Add(new Product { ProductDescription = "Rice", ProductPicture = "https://nutritionfacts.org/app/uploads/2009/12/NF-Arsenic-in-Rice.jpg", ProductPrice = 1m });
            Products.Add(new Product { ProductDescription = "Beans", ProductPicture = "https://www.drweil.com/wp-content/uploads/2016/12/Adzuki-bean-red-bean-in-wooden-pot-000086586693_Large-ART-cooking-with-adzuke-beans-1024x768.jpg", ProductPrice = 1.9m });
            Products.Add(new Product { ProductDescription = "Salt", ProductPicture = "https://cdn0.wideopeneats.com/wp-content/uploads/2016/08/AdobeStock_102006299-1024x683.jpeg", ProductPrice = 0.5m });
            Products.Add(new Product { ProductDescription = "Pasta", ProductPicture = "https://www.seriouseats.com/images/2017/02/20170210-vegan-carbonara-spaghetti-vicky-wasik-14.jpg", ProductPrice = 2.9m });

            ItemTappedCommand = new DelegateCommand<Product>(ItemTapped);
        }

        private async void ItemTapped(Product product)
        {
            var navParams = new NavigationParameters();
            navParams.Add("product", product);

            await _navigationService.NavigateAsync("ProductDetailPage", navParams);
        }
    }
}
