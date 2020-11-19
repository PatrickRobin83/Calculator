#region Header

// /*
// *----------------------------------------------------------------------------------
// *          Filename: SuperScriptButton.cs
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
    public class SuperScriptButton : Button
    {
        public SuperScriptButton(string label, string commandParameter, string superScriptLabel, int order) : base(label, commandParameter, order)
        {
            SuperScript = superScriptLabel;
        }
        public string SuperScript { get; }

        public static SuperScriptButton Create(string label, string commandParameter, string superScriptLabel,
            int order)
        {
            return new SuperScriptButton(label, commandParameter, superScriptLabel, order);
        }
    }
}