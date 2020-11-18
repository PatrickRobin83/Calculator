/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   Calculators.cs
 *   Date			:   2020-11-18 15:44:21
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using Calculator.Models;
using Calculator.ViewModels.Calculators;

namespace Calculator.Core.Constants
{
    public static class Calculators
    {
        

        #region Fields

        #endregion

        #region Properties

        public static CalculatorType[] CalculatorTypes = new[]
        {
            CalculatorType.Create("Basic", "BasicCalculatorViewModel"),
            CalculatorType.Create("Scientific", "ScientificCalculatorViewModel")
        };

        #endregion

        #region Constructor

        #endregion

        #region Methods

        #endregion

    }
}