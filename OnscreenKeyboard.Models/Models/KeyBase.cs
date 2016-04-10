using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;

namespace OnscreenKeyboard.Models
{
    public abstract class KeyBase: BindableBase
    {
        private double x;
        private double y;
        private double width;
        private double height;
        private bool repeating;

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

        public double Height
        {
            get { return this.height; }
            set { SetProperty(ref this.height, value); }
        }

        public bool Repeating
        {
            get { return this.repeating; }
            set { SetProperty(ref this.repeating, value); }
        }
    }
}
