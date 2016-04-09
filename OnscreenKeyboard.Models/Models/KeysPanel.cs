using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Mvvm;

namespace OnscreenKeyboard.Model
{
    public class KeysPanel : BindableBase
    {
        private ObservableCollection<KeyBase> keys;

        public ObservableCollection<KeyBase> Keys
        {
            get { return this.keys; }
            set
            {
                SetProperty(ref this.keys, value);
            }
        }
    }
}
