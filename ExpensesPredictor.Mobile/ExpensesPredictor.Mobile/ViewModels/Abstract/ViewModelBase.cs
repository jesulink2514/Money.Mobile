using ExpensesPredictor.Mobile.Models;

namespace ExpensesPredictor.Mobile.ViewModels.Abstract
{
    public abstract class ViewModelBase: BindableBase
    {
        public virtual void OnPushed()
        {
        }

        public virtual void OnPopped()
        {
        }
    }
}
