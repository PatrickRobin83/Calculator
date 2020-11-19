/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   CalculatorViewModel.cs
 *   Date			:   2020-11-18 13:21:24
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Calculator.Core.Calculations;
using Calculator.Models;
using Calculator.ViewModels.Interfaces;
using Prism.Commands;

namespace Calculator.ViewModels.Base
{
    public abstract class CalculatorViewModelBase : ViewModelBase, ICalculatorViewModel
    {



        #region Fields
        private readonly ICalculator calculator;
        private string expression;
        protected bool HasCalculated = false;
        #endregion

        #region Properties
        public abstract string CalculatorType { get; }
        public ICollection<Calculation> Calculations { get; protected set; }
        public string Expression
        {
            get { return expression; }
            set { SetProperty(ref expression, value); }
        }

        #endregion

        #region Constructor

        protected CalculatorViewModelBase(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        #endregion

        #region Methods

        public override void RegisterCollections()
        {
            Calculations = new ObservableCollection<Calculation>();
        }

        private void Calculate()
        {
            var value = calculator.Calculate(Expression).ToString("N2");
            var calculation = new Calculation(Expression, value);
            Expression = value;
            HasCalculated = true;
            Calculations.Add(calculation);
        }

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<string>(AddNumber);
            ClearCommand = new DelegateCommand<string>(Clear);
            EqualsCommand = new DelegateCommand(Calculate);
        }

        private void Clear(string ex)
        {
            Expression = string.Empty;
        }

        private void AddNumber(string buttonValue)
        {
            if (HasCalculated)
            {
                Clear("");
                HasCalculated = false;
            }
            Expression += buttonValue.ToString();
        }

        #endregion

        #region Commands
        public DelegateCommand<string> AddNumberCommand { get; set; }
        public DelegateCommand<string> ClearCommand { get; set; }
        public DelegateCommand EqualsCommand { get; set; }

        #endregion
    }
}