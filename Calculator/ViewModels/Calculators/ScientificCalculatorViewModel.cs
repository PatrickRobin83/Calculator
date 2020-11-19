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

        private string _calculatedExpression;
        #endregion

        #region Properties

        public override string CalculatorType => "Scientific";
        public override int Height { get; set; } = 550;
        public override int Width { get; set; } = 350;
        public string CalculatedExpression
        {
            get { return _calculatedExpression; }
            set { SetProperty(ref _calculatedExpression, value); }
        }

        #endregion

        #region Constructor

        public ScientificCalculatorViewModel(ICalculator calculator) : base(calculator)
        {
        }
        #endregion

        #region Methods

        protected override void Calculate()
        {
            CalculatedExpression = Expression;
            base.Calculate();

        }

        #endregion

        #region EventHandler

        #endregion

    }
}