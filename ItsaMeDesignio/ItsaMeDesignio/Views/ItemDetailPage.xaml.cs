using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ItsaMeDesignio.Models;
using ItsaMeDesignio.ViewModels;
using Xamarin.Forms.PancakeView;
using System.Linq;

namespace ItsaMeDesignio.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        private PancakeView previouslySelectedCategory;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
            //previouslySelectedCategory = viewModel.Categories.First();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //var stuff = categoryItems.ToList();
            categoryCollectionView.SelectedItem = viewModel.Categories.First();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await heartLabel.RotateTo(360, 500, Easing.SpringOut);
            await heartLabel.RotateTo(0, 0);
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            var item = sender as PancakeView;

            if (previouslySelectedCategory != null)
                await previouslySelectedCategory.FadeTo(0.2, 100);
            await item.FadeTo(1, 400, Easing.SpringOut);

            previouslySelectedCategory = item;
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}