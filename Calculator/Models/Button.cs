/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   Button.cs
 *   Date			:   2020-11-19 11:32:16
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

namespace Calculator.Models
{
    public abstract class Button
    {
        public string Label { get; }
        public string CommandParameter { get; }
        public int Order { get; set; }
        protected Button(string label, string commandParameter, int order)
        {
            Label = label;
            CommandParameter = commandParameter;
            Order = order;
        }
    }
}
