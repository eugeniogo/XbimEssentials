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
namespace Xbim.Ifc2x3.TimeSeriesResource
{
	public partial class @IfcRegularTimeSeries : IIfcRegularTimeSeries
	{
		Xbim.Ifc4.MeasureResource.IfcTimeMeasure IIfcRegularTimeSeries.TimeStep 
		{ 
			get
			{
				return new Xbim.Ifc4.MeasureResource.IfcTimeMeasure((double)TimeStep);
			} 
		}
		IEnumerable<IIfcTimeSeriesValue> IIfcRegularTimeSeries.Values 
		{ 
			get
			{
			foreach (var member in Values)
			{
				yield return member as IIfcTimeSeriesValue;
			}
			} 
		}
	}
}