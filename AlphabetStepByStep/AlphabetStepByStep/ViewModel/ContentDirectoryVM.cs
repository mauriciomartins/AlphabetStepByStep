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
    class ContentDirectoryVM : ObservableBaseObject
    {
        public ObservableCollection<Content> ContentList { get; set; }
        private bool isBusy = false;
        public bool IsBusy
        {
            get { return this.isBusy; }
            set { this.isBusy = value; OnPropertyChanged(); }
        }

        public Command LoadContentDirectoryCommand
        {
            get; set;
        }

        public ContentDirectoryVM()
        {
            this.ContentList = new ObservableCollection<Content>();
            this.IsBusy = false;
            this.LoadContentDirectoryCommand = new Command((obj) => LoadDirectory());
        }

        private async void LoadDirectory()
        {
            if (!IsBusy)
            {
                IsBusy = false;

                await Task.Delay(3000);
                var loadDirectory = ContentDirectoryService.LoadContentDirectory();

                foreach (var content in loadDirectory.ContentList)
                {
                    this.ContentList.Add(content);
                }

                IsBusy = true;
            }
        }
    }
}
