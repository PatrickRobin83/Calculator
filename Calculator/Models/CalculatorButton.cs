#region Header

// /*
// *----------------------------------------------------------------------------------
// *          Filename: CalculatorButton.cs
// *          Date:        2020-11-19
// *          All rights reserved
// *
// *----------------------------------------------------------------------------------
// * @author Patrick Robin <support@rietrob.de>
// * @Version
// */

#endregion

namespace Calculator.Models
{
    public class CalculatorButton : Button
    {
        public CalculatorButton(string label, string commandParameter, int order) : base(label, commandParameter, order)
        {
        }

        public static CalculatorButton Create(string label, string commandParameter, int order)
        {
            return new CalculatorButton(label, commandParameter, order );
        }
    }
}