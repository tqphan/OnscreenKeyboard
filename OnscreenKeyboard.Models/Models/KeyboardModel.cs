using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using System.Collections.ObjectModel;

namespace OnscreenKeyboard.Models
{
    public class KeyboardModel : BindableBase, IKeyboardModel
    {
        private ObservableCollection<KeysPanel> panels;
        private double x;
        private double y;
        private double width;
        private double heigth;
        private double opacity;

        public ObservableCollection<KeysPanel> Panels
        {
            get { return this.panels; }
            set { SetProperty(ref this.panels, value); }
        }

        public double X
        {
            get { return this.x; }
            set { SetProperty(ref this.x, value); }
        }

        public double Y
        {
            get { return this.y; }
            set { SetProperty(ref this.y, value); }
        }

        public double Width
        {
            get { return this.width; }
            set { SetProperty(ref this.width, value); }
        }

        public double Heigth
        {
            get { return this.heigth; }
            set { SetProperty(ref this.heigth, value); }
        }

        public double Opacity
        {
            get { return this.opacity; }
            set { SetProperty(ref this.opacity, value); }
        }
    }
}
