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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcLightFixtureType : IIfcLightFixtureType
	{
		Xbim.Ifc4.ElectricalDomain.IfcLightFixtureTypeEnum IIfcLightFixtureType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.ElectricalDomain.IfcLightFixtureTypeEnum.POINTSOURCE:
						return Xbim.Ifc4.ElectricalDomain.IfcLightFixtureTypeEnum.POINTSOURCE;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcLightFixtureTypeEnum.DIRECTIONSOURCE:
						return Xbim.Ifc4.ElectricalDomain.IfcLightFixtureTypeEnum.DIRECTIONSOURCE;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcLightFixtureTypeEnum.USERDEFINED:
						return Xbim.Ifc4.ElectricalDomain.IfcLightFixtureTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcLightFixtureTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.ElectricalDomain.IfcLightFixtureTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}