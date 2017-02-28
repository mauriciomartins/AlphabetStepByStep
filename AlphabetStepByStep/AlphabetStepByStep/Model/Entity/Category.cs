using AlphabetStepByStep.Model.Entity;
using AlphabetStepByStep.Model.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetStepByStep.model
{
    public class Category: ObservableBaseObject,IKeyObject
    {
        private string value;
        private string description;
        private string image;

        public string Image
        {
            get { return this.image; }
            set { this.image = value; OnPropertyChanged(); }
        }
        public string Value
        {
            get { return this.value; }
            set { this.value = value; OnPropertyChanged(); }
        }
        
        public string Description
        {
            get { return this.description; }
            set { this.description = value; OnPropertyChanged(); }
        }

        public string Key
        {
            get;
            set;
        }
    }
}
