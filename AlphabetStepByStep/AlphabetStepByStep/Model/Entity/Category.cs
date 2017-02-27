using AlphabetStepByStep.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetStepByStep.model
{
    class Category: ObservableBaseObject
    {
        private string value;
        private string description;
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
    }
}
