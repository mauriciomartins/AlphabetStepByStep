using AlphabetStepByStep.Model.Entity;
using AlphabetStepByStep.Model.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlphabetStepByStep.model
{
    class CategoryDirectoryVM : ObservableBaseObject
    {
        public ObservableCollection<Category> CategoryList  { get; set; }
        private bool isBusy = false;
        public bool IsBusy
        {
            get { return this.isBusy; }
            set { this.isBusy = value; OnPropertyChanged(); }
        }

        public Command LoadCategoryDirectoryCommand
        {
            get;set;
        }

        public CategoryDirectoryVM()
        {
            this.CategoryList = new ObservableCollection<Category>();
            this.IsBusy = false;
            this.LoadCategoryDirectoryCommand = new Command(()=> LoadDirectory(),()=>!this.IsBusy);
        }

        public async void LoadDirectory()
        {
            if (!IsBusy)
            {
                

                /*
                await Task.Delay(3000);
                var loadDirectory = CategoryDirectoryService.LoadCategoryDirectory();
                
                foreach (var category in loadDirectory.CategoryList)
                {
                    this.CategoryList.Add(category);
                }
                */
                try
                {
                    IsBusy = true;
                    this.CategoryList.Clear();
                    var categories =  await CategoryDirectoryService.GetCats();
                    foreach (var category in categories)
                    {
                        this.CategoryList.Add(category);
                    }
                }
                catch (Exception e)
                {
                    await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error!", e.Message, "OK");
                }
                finally
                {
                    IsBusy = false;
                }
            }
        }
    }
}
