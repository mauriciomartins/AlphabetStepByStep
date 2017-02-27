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
        private int position;
        private string value;
        private string valueSound;
        private string description;
        private string descriptionSound;
        public int Position
        {
            get { return this.position; }
            set { this.position = (int) value; OnPropertyChanged(); }
        }
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
