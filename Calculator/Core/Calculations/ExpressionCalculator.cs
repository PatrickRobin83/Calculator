/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   ExpressionCalculator.cs
 *   Date			:   2020-11-18 10:15:29
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using System;
using System.Data;

namespace Calculator.Core.Calculations
{
    public class ExpressionCalculator : ICalculator
    {


        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Constructor

        #endregion

        #region Methods

        public double Calculate(string expression)
        {
            var dataTable = new DataTable();
            var value = dataTable.Compute(expression, "");
            return Convert.ToDouble(value);
        }

        #endregion

    }
}