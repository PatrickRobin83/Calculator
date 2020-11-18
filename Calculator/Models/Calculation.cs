/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   Calculation.cs
 *   Date			:   2020-11-18 13:15:12
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

namespace Calculator.Models
{
    public class Calculation
    {
        public string Expression { get; }
        public string Value { get; }


        public Calculation(string expression, string value)
        {
            Expression = expression;
            Value = value;
        }

    }
}