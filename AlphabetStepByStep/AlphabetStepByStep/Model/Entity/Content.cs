using AlphabetStepByStep.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetStepByStep.model
{
    class Content : ObservableBaseObject
    {
        private string value;
        private string valueSound;
        private string description;
        private string descriptionSound;
        public string Value {
            get { return this.value; }
            set { this.value = value; OnPropertyChanged(); }
        }
        public string ValueSound
        {
            get { return this.valueSound; }
            set { this.valueSound = value; OnPropertyChanged(); }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; OnPropertyChanged(); }
        }
        public string DescriptionSound
        {
            get { return this.descriptionSound; }
            set { this.descriptionSound = value; OnPropertyChanged(); }
        }

    }
}
