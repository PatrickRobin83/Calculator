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

using System;
using System.Windows;
using System.Windows.Documents;
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
        private readonly IContainerHelper containerHelper;
        private bool selectedCalculatorFlyOutOpen;
        private bool historyFlyoutOpen;

        #endregion

        #region Properties
        public ICalculatorViewModel SelectedCalculatorViewModel
        {
            get { return selectedCalculatorViewModel; }
            set { SetProperty(ref selectedCalculatorViewModel, value); }
        }
        public bool SelectCalculatorFlyOutOpen
        {
            get { return selectedCalculatorFlyOutOpen; }
            set { SetProperty(ref selectedCalculatorFlyOutOpen, value); }
        }

        public bool HistoryFlyoutOpen
        {
            get { return historyFlyoutOpen; }
            set { SetProperty(ref historyFlyoutOpen, value); }
        }

        public string Title { get; } = "Cool Calculator";

        #endregion

        #region Constructor

        public ShellViewModel(IContainerHelper containerHelper)
        {
            this.containerHelper = containerHelper;
            CalculatorChanged(Calculator.Core.Constants.Calculators.Basic);
        }
        #endregion

        #region Methods

        protected override void RegisterCommands()
        {
            OpenFlyOutCommand = new DelegateCommand<string>(OpenFlyOut);
            CalculatorChangedCommand = new DelegateCommand<CalculatorType>(CalculatorChanged);
        }


        private void CalculatorChanged(CalculatorType calculatorType)
        {
            var newCalculator = (ICalculatorViewModel) containerHelper.Create(calculatorType.TypeName);
            SelectedCalculatorViewModel = newCalculator;
            SelectCalculatorFlyOutOpen = false;
        }

        private void OpenFlyOut(string propertyName)
        {
            var property = GetType().GetProperty(propertyName);
            bool isOpen = Convert.ToBoolean(property.GetValue(this));

            if (isOpen)
            {
                property.SetValue(this, false);
            }
            else
            {
                property.SetValue(this, true);
            }
        }
        #endregion

        #region Commands
        public DelegateCommand<string> OpenFlyOutCommand { get; set; }
        public DelegateCommand<CalculatorType> CalculatorChangedCommand { get; set; }

        #endregion

    }
}