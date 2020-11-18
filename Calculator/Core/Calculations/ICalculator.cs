/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   ICalculator.cs
 *   Date			:   2020-11-18 10:12:16
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

namespace Calculator.Core.Calculations
{
    public interface ICalculator
    {
        double Calculate(string expression);
    }
}