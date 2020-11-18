/*
 * -----------------------------------------------------------------------------
 *	 
 *   Filename		:   IContainerHelper.cs
 *   Date			:   2020-11-18 15:58:45
 *   All rights reserved
 * 
 * -----------------------------------------------------------------------------
 * @author     Patrick Robin <support@rietrob.de>
 * @Version      1.0.0
 */

using Unity;

namespace Calculator.Core.Helpers
{
    public interface IContainerHelper
    {
        object Create(string typeName);
    }
}