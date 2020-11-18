/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   ICalculatorViewModel.cs
 *   Date			:   2020-11-18 13:14:02
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using System.Collections;
using System.Collections.Generic;
using System.Windows.Documents;
using Calculator.Models;

namespace Calculator.ViewModels.Interfaces
{
    public interface ICalculatorViewModel
    {
        string CalculatorType { get; }
        ICollection<Calculation> Calculations { get; }
    }

}