// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ControlExtension
{
	public partial class @IfcPerformanceHistory : IIfcPerformanceHistory
	{
		Xbim.Ifc4.MeasureResource.IfcLabel IIfcPerformanceHistory.LifeCyclePhase 
		{ 
			get
			{
				return new Xbim.Ifc4.MeasureResource.IfcLabel((string)LifeCyclePhase);
			} 
		}
		Xbim.Ifc4.ControlExtension.IfcPerformanceHistoryTypeEnum? IIfcPerformanceHistory.PredefinedType 
		{ 
			get
			{
				//TODO: Handle return of PredefinedType for which no match was found
				throw new System.NotImplementedException();
			} 
		}
	}
}