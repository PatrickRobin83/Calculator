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

using System.Windows;
using Calculator.Core.Calculations;
using Calculator.Core.Helpers;
using Calculator.Models;
using Calculator.ViewModels.Base;
using Calculator.ViewModels.Calculators;
using Calculator.ViewModels.Interfaces;
using Prism.Commands;

namespace Calculator.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        

        #region Fields
        private ICalculatorViewModel selectedCalculatorViewModel;
        private readonly IContainerHelper _containerHelper;
        private bool flyOutOpen;

        #endregion

        #region Properties
        public ICalculatorViewModel SelectedCalculatorViewModel
        {
            get { return selectedCalculatorViewModel; }
            set { SetProperty(ref selectedCalculatorViewModel, value); }
        }
        public bool FlyOutOpen
        {
            get { return flyOutOpen; }
            set { SetProperty(ref flyOutOpen, value); }
        }
        public string Title { get; } = "Cool Calculator";

        #endregion

        #region Constructor

        public ShellViewModel(IContainerHelper containerHelper)
        {
            _containerHelper = containerHelper;
        }
        #endregion

        #region Methods

        protected override void RegisterCommands()
        {
            OpenFlyOutCommand = new DelegateCommand(OpenFlyOut);
            CalculatorChangedCommand = new DelegateCommand<CalculatorType>(CalculatorChanged);
        }


        private void CalculatorChanged(CalculatorType calculatorType)
        {
            var newCalculator = (ICalculatorViewModel) _containerHelper.Create(calculatorType.TypeName);
            SelectedCalculatorViewModel = newCalculator;
            FlyOutOpen = false;
        }

        private void OpenFlyOut()
        {
            FlyOutOpen = true;
        }
        #endregion

        #region Commands
        public DelegateCommand OpenFlyOutCommand { get; set; }
        public DelegateCommand<CalculatorType> CalculatorChangedCommand { get; set; }

        #endregion

    }
}