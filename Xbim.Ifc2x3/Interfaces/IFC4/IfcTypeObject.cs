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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcTypeObject : IIfcTypeObject
	{
		Xbim.Ifc4.MeasureResource.IfcIdentifier? IIfcTypeObject.ApplicableOccurrence 
		{ 
			get
			{
				if (ApplicableOccurrence == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcIdentifier((string)ApplicableOccurrence);
			} 
		}
		IEnumerable<IIfcPropertySetDefinition> IIfcTypeObject.HasPropertySets 
		{ 
			get
			{
			foreach (var member in HasPropertySets)
			{
				yield return member as IIfcPropertySetDefinition;
			}
			} 
		}
		IEnumerable<IIfcRelDefinesByType> IIfcTypeObject.Types 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDefinesByType>(e => (e.RelatingType as IfcTypeObject) == this);
			} 
		}
	}
}