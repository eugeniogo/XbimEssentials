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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcBuildingElementProxyType : IIfcBuildingElementProxyType
	{
		Xbim.Ifc4.SharedBldgElements.IfcBuildingElementProxyTypeEnum IIfcBuildingElementProxyType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.ProductExtension.IfcBuildingElementProxyTypeEnum.USERDEFINED:
						return Xbim.Ifc4.SharedBldgElements.IfcBuildingElementProxyTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.ProductExtension.IfcBuildingElementProxyTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.SharedBldgElements.IfcBuildingElementProxyTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}