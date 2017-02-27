using AlphabetStepByStep.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlphabetStepByStep.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Content : ContentPage
    {
        public Content(Category selectedCategory)
        {
            InitializeComponent();
            this.BindingContext =  new ContentDirectoryVM();
        }
    }
}
