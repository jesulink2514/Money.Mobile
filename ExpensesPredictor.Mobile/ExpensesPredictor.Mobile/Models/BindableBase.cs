using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace ExpensesPredictor.Mobile.Models
{
    public class BindableBase:BindableObject
    {
        protected virtual void SetProperty<T>(ref T value,T newvalue,[CallerMemberName] string propertyName = null)
        {
            value = newvalue;
            OnPropertyChanged(propertyName);
        }
    }
}