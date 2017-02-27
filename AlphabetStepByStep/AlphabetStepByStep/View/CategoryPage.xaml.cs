using AlphabetStepByStep.model;
using AlphabetStepByStep.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlphabetStepByStep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new CategoryDirectoryVM();
            this.CategoryList.ItemSelected += CategoryList_ItemSelected;
        }

        private void CategoryList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Category selectedCategory = (Category)e.SelectedItem;
            if(selectedCategory == null)
            {
                return;
            }

            Navigation.PushAsync(new View.Content(selectedCategory));
            this.CategoryList.SelectedItem = null;
        }
    }
}
