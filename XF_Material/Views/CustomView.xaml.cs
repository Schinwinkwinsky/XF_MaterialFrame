using Xamarin.Forms;

namespace XF_Material.Views
{
    public partial class CustomView : ContentView
    {
        #region BindableProperties
        public static readonly BindableProperty ProductPictureProperty =
            BindableProperty.Create(
                nameof(ProductPicture),
                typeof(string),
                typeof(CustomView),
                string.Empty,
                BindingMode.TwoWay);

        public static readonly BindableProperty ProductDescriptionProperty =
            BindableProperty.Create(
                nameof(ProductDescription),
                typeof(string),
                typeof(CustomView),
                string.Empty,
                BindingMode.TwoWay);

        public static readonly BindableProperty ProductPriceProperty =
            BindableProperty.Create(
                nameof(ProductPrice),
                typeof(decimal),
                typeof(CustomView),
                0m,
                BindingMode.TwoWay);
        #endregion

        public string ProductPicture
        {
            get => (string)GetValue(ProductPictureProperty);
            set => SetValue(ProductPictureProperty, value);
        }

        public string ProductDescription
        {
            get => (string)GetValue(ProductDescriptionProperty);
            set => SetValue(ProductDescriptionProperty, value);
        }

        public decimal ProductPrice
        {
            get => (decimal)GetValue(ProductPriceProperty);
            set => SetValue(ProductPriceProperty, value);
        }

        public CustomView()
        {
            InitializeComponent();
        }
    }
}