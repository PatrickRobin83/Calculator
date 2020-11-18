/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   CalculatorType.cs
 *   Date			:   2020-11-18 15:48:27
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

namespace Calculator.Models
{
    public class CalculatorType
    {

        #region Fields

        #endregion

        #region Properties

        public string DisplayName { get; private set; }
        public string TypeName { get; private set; }


        #endregion

        #region Constructor

        public CalculatorType(string displayName, string typeName)
        {
            DisplayName = displayName;
            TypeName = typeName;
        }
        #endregion

        #region Methods

        public static CalculatorType Create(string dispplayName, string typeName)
        {
            return new CalculatorType(dispplayName, typeName);
        }
        #endregion

    }
}