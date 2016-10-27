﻿using ExpensesPredictor.Mobile.Models;
using ExpensesPredictor.Mobile.ViewModels;
using ExpensesPredictor.Mobile.Views.Abstract;

namespace ExpensesPredictor.Mobile.Views
{
    public partial class AddEditView : ViewBase
    {
        public AddEditView(Expense expense)
        {
            this.BindingContext = new AddEditViewModel(expense);
            InitializeComponent();
        }
        public AddEditView()
        {
            this.BindingContext = new AddEditViewModel(new Expense());
            InitializeComponent();
        }
    }
}
