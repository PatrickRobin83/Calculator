/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   ShellViewModel.cs
 *   Date			:   2020-11-17 12:21:51
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using Calculator.ViewModels.Base;
using Prism.Commands;

namespace Calculator.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {


        #region Fields

        private string expression;

        #endregion

        #region Properties



        public string Title { get; } = "Cool Calculator";
        public string Expression
        {
            get { return expression; }
            set { SetProperty(ref expression, value); }
        }

        #endregion

        #region Constructor

        public ShellViewModel()
        {
            
        }

        #endregion

        #region Methods

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<string>(AddNumber);
            ClearCommand = new DelegateCommand<string>(Clear);
            //EqualsCommand = new DelegateCommand<string>();
        }

        private void Clear(string obj)
        {
            Expression = string.Empty;
        }

        private void AddNumber(string buttonValue)
        {
            Expression += buttonValue;
        }

        #endregion

        #region Commands

        public DelegateCommand<string> AddNumberCommand { get; set; }
        public DelegateCommand<string> ClearCommand { get; set; }

        public DelegateCommand<string> EqualsCommand { get; set; }

        #endregion

    }
}