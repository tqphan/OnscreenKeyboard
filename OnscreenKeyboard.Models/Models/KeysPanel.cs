using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Mvvm;

namespace OnscreenKeyboard.Models
{
    public class KeysPanel : BindableBase
    {
        private ObservableCollection<KeyBase> keys;
        private bool visibility;
        private string name;
        private double width;
        private double height;

        public ObservableCollection<KeyBase> Keys
        {
            get { return this.keys; }
            set
            {
                SetProperty(ref this.keys, value);
            }
        }

        public bool Visibility
        {
            get { return this.visibility; }
            set
            {
                SetProperty(ref this.visibility, value);
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                SetProperty(ref this.name, value);
            }
        }

        public double Width
        {
            get { return this.width; }
            set { SetProperty(ref this.width, value); }
        }

        public double Height
        {
            get { return this.height; }
            set { SetProperty(ref this.height, value); }
        }
    }
}
