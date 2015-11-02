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
namespace Xbim.Ifc2x3.ActorResource
{
	public partial class @IfcAddress : IIfcAddress
	{
		Xbim.Ifc4.ActorResource.IfcAddressTypeEnum? IIfcAddress.Purpose 
		{ 
			get
			{
				switch (Purpose)
				{
					case Xbim.Ifc2x3.ActorResource.IfcAddressTypeEnum.OFFICE:
						return Xbim.Ifc4.ActorResource.IfcAddressTypeEnum.OFFICE;
					
					case Xbim.Ifc2x3.ActorResource.IfcAddressTypeEnum.SITE:
						return Xbim.Ifc4.ActorResource.IfcAddressTypeEnum.SITE;
					
					case Xbim.Ifc2x3.ActorResource.IfcAddressTypeEnum.HOME:
						return Xbim.Ifc4.ActorResource.IfcAddressTypeEnum.HOME;
					
					case Xbim.Ifc2x3.ActorResource.IfcAddressTypeEnum.DISTRIBUTIONPOINT:
						return Xbim.Ifc4.ActorResource.IfcAddressTypeEnum.DISTRIBUTIONPOINT;
					
					case Xbim.Ifc2x3.ActorResource.IfcAddressTypeEnum.USERDEFINED:
						return Xbim.Ifc4.ActorResource.IfcAddressTypeEnum.USERDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcText? IIfcAddress.Description 
		{ 
			get
			{
				if (Description == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcText((string)Description);
			} 
		}
		Xbim.Ifc4.MeasureResource.IfcLabel? IIfcAddress.UserDefinedPurpose 
		{ 
			get
			{
				if (UserDefinedPurpose == null) return null;
				return new Xbim.Ifc4.MeasureResource.IfcLabel((string)UserDefinedPurpose);
			} 
		}
		IEnumerable<IIfcPerson> IIfcAddress.OfPerson 
		{ 
			get
			{
				return Model.Instances.Where<IIfcPerson>(e => e.Addresses != null &&  e.Addresses.Contains(this));
			} 
		}
		IEnumerable<IIfcOrganization> IIfcAddress.OfOrganization 
		{ 
			get
			{
				return Model.Instances.Where<IIfcOrganization>(e => e.Addresses != null &&  e.Addresses.Contains(this));
			} 
		}
	}
}