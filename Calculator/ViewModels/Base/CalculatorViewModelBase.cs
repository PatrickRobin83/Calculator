/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   CalculatorViewModel.cs
 *   Date			:   2020-11-18 13:21:24
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using System.Collections.Generic;
using System.Collections.ObjectModel;
using Calculator.Models;
using Calculator.ViewModels.Interfaces;

namespace Calculator.ViewModels.Base
{
    public abstract class CalculatorViewModelBase : ViewModelBase, ICalculatorViewModel
    {
        

        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Constructor

        #endregion

        #region Methods

        public override void RegisterCollections()
        {
            Calculations = new ObservableCollection<Calculation>();
        }

        #endregion

        public abstract string CalculatorType { get; }
        public ICollection<Calculation> Calculations { get; protected set; }
    }
}