using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using System.Collections.ObjectModel;

namespace OnscreenKeyboard.Model
{
    public class KeyboardModel : BindableBase
    {
        private ObservableCollection<KeysPanel> panels;

        public ObservableCollection<KeysPanel> Panels
        {
            get { return this.panels; }
            set
            {
                SetProperty(ref this.panels, value);
            }
        }
    }
}
