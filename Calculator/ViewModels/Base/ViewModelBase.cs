/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   ViewModelBase.cs
 *   Date			:   2020-11-17 12:22:39
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using Prism.Mvvm;

namespace Calculator.ViewModels.Base
{
    public abstract class ViewModelBase : BindableBase
    {

        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Constructor

        public ViewModelBase()
        {
            RegisterCommands();
            RegisterCollections();
        }

        #endregion

        #region Methods

        protected virtual void RegisterCommands(){ }

        public virtual void RegisterCollections(){ }

        #endregion

    }
}