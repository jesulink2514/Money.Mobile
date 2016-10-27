using System.Collections.ObjectModel;
using System.Linq;
using ExpensesPredictor.Mobile.Infrastructure.NoSQL;
using ExpensesPredictor.Mobile.Models;
using ExpensesPredictor.Mobile.ViewModels.Abstract;

namespace ExpensesPredictor.Mobile.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        private readonly IExpensesRepository _expensesRepository;
        private ObservableCollection<Expense> _expenses = new ObservableCollection<Expense>();

        public MainViewModel(IExpensesRepository expensesRepository)
        {
            _expensesRepository = expensesRepository;
        }

        public MainViewModel() : this(new ExpensesRepository())
        {
        }

        public override void OnPushed()
        {
            var exps = _expensesRepository.FindAll();
            this.Expenses = new ObservableCollection<Expense>(exps);
        }

        public ObservableCollection<Expense> Expenses
        {
            get { return _expenses; }
            set
            {
                SetProperty(ref _expenses, value);
                OnPropertyChanged("AnyExpense");
            }
        }
        public bool AnyExpense => Expenses.Any();
    }
}
