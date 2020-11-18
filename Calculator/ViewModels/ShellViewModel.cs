/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   ShellViewModel.cs
 *   Date			:   2020-11-17 12:21:51
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using Calculator.Core.Calculations;
using Calculator.ViewModels.Base;
using Calculator.ViewModels.Calculators;
using Prism.Commands;

namespace Calculator.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        #region Fields
        private ViewModelBase selectedCalculatorViewModel;
        #endregion

        #region Properties
        public ViewModelBase SelectedCalculatorViewModel
        {
            get { return selectedCalculatorViewModel; }
            set { SetProperty(ref selectedCalculatorViewModel, value); }
        }
        #endregion

        #region Constructor

        public ShellViewModel(ICalculator calculator)
        {
            var viewModel = new BasicCalculatorViewModel(calculator);
            SelectedCalculatorViewModel = viewModel;
        }
        #endregion

        #region Methods

        #endregion

        #region Commands
        
        #endregion

    }
}