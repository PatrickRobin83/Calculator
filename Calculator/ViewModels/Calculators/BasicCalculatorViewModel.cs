/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   BasicCalculatorViewModel.cs
 *   Date			:   2020-11-18 12:50:33
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using Calculator.Core.Calculations;
using Calculator.ViewModels.Base;
using Prism.Commands;

namespace Calculator.ViewModels.Calculators
{
    public class BasicCalculatorViewModel :ViewModelBase
    {


        #region Fields

        private string expression;
        private readonly ICalculator _calculator;
        private bool hasCalculated = false;

        #endregion

        #region Properties
        public string Title { get; } = "Cool Calculator";
        public string Expression
        {
            get { return expression; }
            set { SetProperty(ref expression, value); }
        }

        #endregion

        #region Constructor

        public BasicCalculatorViewModel(ICalculator calculator)
        {
            _calculator = calculator;
        }
        #endregion

        #region Methods

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<string>(AddNumber);
            ClearCommand = new DelegateCommand<string>(Clear);
            EqualsCommand = new DelegateCommand<string>(Calculate);
        }

        private void Calculate(string obj)
        {
            Expression = _calculator.Calculate(Expression).ToString("N2");
            hasCalculated = true;
        }

        private void Clear(string ex)
        {
            Expression = string.Empty;
        }

        private void AddNumber(string buttonValue)
        {
            if (hasCalculated)
            {
                Clear("");
                hasCalculated = false;
            }
            Expression += buttonValue.ToString();
        }

        #endregion

        #region Commands
        public DelegateCommand<string> AddNumberCommand { get; set; }
        public DelegateCommand<string> ClearCommand { get; set; }
        public DelegateCommand<string> EqualsCommand { get; set; }

        #endregion

    }
}