using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestSol
{



    public class ViewModel : INotifyPropertyChanged
    {
        private int _Number = 0;

        /// <summary>
        /// 番号
        /// </summary>
        public int Number
        {
            get { return _Number; }
            set
            {
                _Number = value;
                this.SetProperty(ref this._Number, value);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void SetProperty<T>(ref T field, T value, [CallerMemberName]string propertyName = null)
        {
            field = value;
            var h = this.PropertyChanged;
            if (h != null) { h(this, new PropertyChangedEventArgs(propertyName)); }
        }

    }
}
