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
	public partial class @IfcResource : IIfcResource
	{
		Xbim.Ifc4.MeasureResource.IfcIdentifier? IIfcResource.Identification 
		{ 
			get
			{
				//TODO: Handle return of Identification for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcResource.LongDescription 
		{ 
			get
			{
				//TODO: Handle return of LongDescription for which no match was found
				throw new System.NotImplementedException();
			} 
		}
		IEnumerable<IIfcRelAssignsToResource> IIfcResource.ResourceOf 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssignsToResource>(e => (e.RelatingResource as IfcResource) == this);
			} 
		}
	}
}