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
namespace Xbim.Ifc2x3.CostResource
{
	public partial class @IfcCurrencyRelationship : IIfcCurrencyRelationship
	{
		IIfcMonetaryUnit IIfcCurrencyRelationship.RelatingMonetaryUnit 
		{ 
			get
			{
				return RelatingMonetaryUnit as IIfcMonetaryUnit;
			} 
		}
		IIfcMonetaryUnit IIfcCurrencyRelationship.RelatedMonetaryUnit 
		{ 
			get
			{
				return RelatedMonetaryUnit as IIfcMonetaryUnit;
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcPositiveRatioMeasure IIfcCurrencyRelationship.ExchangeRate 
		{ 
			get
			{
				return new Xbim.Ifc4.MeasureResource.IfcPositiveRatioMeasure((double)ExchangeRate);
			} 
		}
		Xbim.Ifc4.DateTimeResource.IfcDateTime? IIfcCurrencyRelationship.RateDateTime 
		{ 
			get
			{
				//TODO: Handle return of RateDateTime for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		IIfcLibraryInformation IIfcCurrencyRelationship.RateSource 
		{ 
			get
			{
				return RateSource as IIfcLibraryInformation;
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcResourceLevelRelationship.Name 
		{ 
			get
			{
				//TODO: Handle return of Name for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcResourceLevelRelationship.Description 
		{ 
			get
			{
				//TODO: Handle return of Description for which no match was found
				throw new System.NotImplementedException();
			} 
		}
	}
}