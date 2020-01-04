using ItsaMeDesignio.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace ItsaMeDesignio.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<CarouselImage> CarouselImages { get; set; }

        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;

            Categories = new ObservableCollection<Category>
            {
                new Category
                {
                    Icon = IconFonts.Candycane,
                    Opacity = 1.0,
                    Text = "All",
                    Color = Color.FromHex( "#fa947c"),
                },
                new Category
                {
                    Icon=IconFonts.Bus,
                    Opacity=0.2,
                    Text="Bus",
                    Color=Color.LightGreen
                },
                new Category
                {
                    Icon=IconFonts.Mountain,
                    Opacity=0.2,
                    Text="Tour",
                    Color=Color.LightBlue
                },
                new Category
                {
                    Icon=IconFonts.SignDirection,
                    Opacity=0.2,
                    Text="Map",
                    Color=Color.Yellow
                },
                new Category
                {
                    Icon=IconFonts.Food,
                    Opacity=0.2,
                    Text="Food",
                    Color=Color.Purple
                },
                new Category
                {
                    Icon=IconFonts.Tour,
                    Opacity=0.2,
                    Text="Tour",
                    Color=Color.Red
                }
            };

            CarouselImages = new ObservableCollection<CarouselImage>
            {
                new CarouselImage { Source = "majesty.jpg" },
                new CarouselImage { Source = "astor.jpg" },
                new CarouselImage { Source = "aidaluna.jpg" }
            };
        }
    }
}
