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
namespace Xbim.Ifc2x3.ConstraintResource
{
	public partial class @IfcObjective : IIfcObjective
	{
		IEnumerable<IIfcConstraint> IIfcObjective.BenchmarkValues 
		{ 
			get
			{
				//TODO: Handle return of BenchmarkValues for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.ConstraintResource.IfcLogicalOperatorEnum? IIfcObjective.LogicalAggregator 
		{ 
			get
			{
				//TODO: Handle return of LogicalAggregator for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.ConstraintResource.IfcObjectiveEnum IIfcObjective.ObjectiveQualifier 
		{ 
			get
			{
				switch (ObjectiveQualifier)
				{
					case Xbim.Ifc2x3.ConstraintResource.IfcObjectiveEnum.CODECOMPLIANCE:
						return Xbim.Ifc4.ConstraintResource.IfcObjectiveEnum.CODECOMPLIANCE;
					
					case Xbim.Ifc2x3.ConstraintResource.IfcObjectiveEnum.DESIGNINTENT:
						return Xbim.Ifc4.ConstraintResource.IfcObjectiveEnum.DESIGNINTENT;
					
					case Xbim.Ifc2x3.ConstraintResource.IfcObjectiveEnum.HEALTHANDSAFETY:
						return Xbim.Ifc4.ConstraintResource.IfcObjectiveEnum.HEALTHANDSAFETY;
					
					case Xbim.Ifc2x3.ConstraintResource.IfcObjectiveEnum.REQUIREMENT:
						return Xbim.Ifc4.ConstraintResource.IfcObjectiveEnum.REQUIREMENT;
					
					case Xbim.Ifc2x3.ConstraintResource.IfcObjectiveEnum.SPECIFICATION:
						return Xbim.Ifc4.ConstraintResource.IfcObjectiveEnum.SPECIFICATION;
					
					case Xbim.Ifc2x3.ConstraintResource.IfcObjectiveEnum.TRIGGERCONDITION:
						return Xbim.Ifc4.ConstraintResource.IfcObjectiveEnum.TRIGGERCONDITION;
					
					case Xbim.Ifc2x3.ConstraintResource.IfcObjectiveEnum.USERDEFINED:
						return Xbim.Ifc4.ConstraintResource.IfcObjectiveEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.ConstraintResource.IfcObjectiveEnum.NOTDEFINED:
						return Xbim.Ifc4.ConstraintResource.IfcObjectiveEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcObjective.UserDefinedQualifier 
		{ 
			get
			{
				if (UserDefinedQualifier == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcLabel((string)UserDefinedQualifier);
			} 
		}
	}
}