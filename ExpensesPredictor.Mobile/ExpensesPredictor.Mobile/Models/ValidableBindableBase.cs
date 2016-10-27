using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesPredictor.Mobile.Models
{
    public abstract class ValidableBindableBase: BindableBase
    {
        public abstract bool IsValid { get; }

        protected override void SetProperty<T>(ref T value, T newvalue, string propertyName = null)
        {
            base.SetProperty(ref value, newvalue, propertyName);

            if (propertyName!="IsValid")
                OnPropertyChanged("IsValid");
        }
    }
}
