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

using System.Collections.Generic;
using Calculator.Core.Calculations;
using Calculator.Models;
using Calculator.ViewModels.Base;
using Prism.Commands;

namespace Calculator.ViewModels.Calculators
{
    public class BasicCalculatorViewModel : CalculatorViewModelBase
    {
        #region Fields
        #endregion

        #region Properties
        public override string CalculatorType => "Basic";
        #endregion

        #region Constructor
        public BasicCalculatorViewModel(ICalculator calculator) :base(calculator)
        {
        }
        #endregion

        #region Methods

        #endregion


    }
}