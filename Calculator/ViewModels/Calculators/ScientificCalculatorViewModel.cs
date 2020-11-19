/*
*----------------------------------------------------------------------------------
*          Filename:	ScientificCalculatorViewModel.cs
*          Date:        2020.11.18 21:48:58
*          All rights reserved
*
*----------------------------------------------------------------------------------
* @author Patrick Robin <support@rietrob.de>
*/

using System.Collections.Generic;
using Calculator.Core.Calculations;
using Calculator.Models;
using Calculator.ViewModels.Base;

namespace Calculator.ViewModels.Calculators

{
    public class ScientificCalculatorViewModel : CalculatorViewModelBase
    {

        #region Fields

        #endregion

        #region Properties

        public override string CalculatorType => "Scientific";

        #endregion

        #region Constructor

        public ScientificCalculatorViewModel(ICalculator calculator) : base(calculator)
        {
        }
        #endregion

        #region Methods

        #endregion

        #region EventHandler

        #endregion

    }
}