using System;
using ExpensesPredictor.Mobile.Infrastructure.Commands;
using ExpensesPredictor.Mobile.Models;
using ExpensesPredictor.Mobile.ViewModels.Abstract;

namespace ExpensesPredictor.Mobile.ViewModels
{
    public class AddEditViewModel : ViewModelBase
    {
        private readonly Expense _expense;

        public AddEditViewModel(Expense expense)
        {
            if (expense == null) throw new ArgumentNullException(nameof(expense));
            _expense = expense;

            _expense.PropertyChanged += _expense_PropertyChanged;
        }

        private void _expense_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "IsValid":
                    RegisterCommand.RaiseCanExecuteChanged();
                    break;
            }
        }

        public RelayCommand<Expense> RegisterCommand { get; } = new RelayCommand<Expense>((exp) =>
        {
            
        },(exp) => exp!= null && exp.IsValid);

        public Expense Expense
        {
            get { return _expense; }
        }
    }
}
