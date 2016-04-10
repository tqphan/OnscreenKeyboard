using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnscreenKeyboard.Models
{
    internal interface IKeyboardModel
    {
        ObservableCollection<KeysPanel> Panels
        {
            get;
            set;
        }

        double X
        {
            get;
            set;
        }

        double Y
        {
            get;
            set;
        }

        double Width
        {
            get;
            set;
        }

        double Heigth
        {
            get;
            set;
        }

        double Opacity
        {
            get;
            set;
        }
    }
}
