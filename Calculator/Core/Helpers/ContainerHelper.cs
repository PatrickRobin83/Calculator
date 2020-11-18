/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   ContainerHelper.cs
 *   Date			:   2020-11-18 16:00:04
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using System;
using System.Linq;
using System.Reflection;
using System.Windows.Documents;
using Unity;

namespace Calculator.Core.Helpers
{
    public class ContainerHelper : IContainerHelper
    {
        private readonly IUnityContainer _container;


        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Constructor

        public ContainerHelper(IUnityContainer container)
        {
            _container = container;
        }
        #endregion

        #region Methods

        #endregion

        public object Create(string typeName)
        {
            var type = Assembly.GetExecutingAssembly().GetTypes().SingleOrDefault(x => x.Name == typeName);
            if (type == null)
            {
               throw new InvalidOperationException("The typeName doesnt match anything");
            }

            return _container.Resolve(type);
        }

    }
}