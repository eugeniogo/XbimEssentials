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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcSlabType : IIfcSlabType
	{
		Xbim.Ifc4.SharedBldgElements.IfcSlabTypeEnum IIfcSlabType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.SharedBldgElements.IfcSlabTypeEnum.FLOOR:
						return Xbim.Ifc4.SharedBldgElements.IfcSlabTypeEnum.FLOOR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcSlabTypeEnum.ROOF:
						return Xbim.Ifc4.SharedBldgElements.IfcSlabTypeEnum.ROOF;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcSlabTypeEnum.LANDING:
						return Xbim.Ifc4.SharedBldgElements.IfcSlabTypeEnum.LANDING;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcSlabTypeEnum.BASESLAB:
						return Xbim.Ifc4.SharedBldgElements.IfcSlabTypeEnum.BASESLAB;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcSlabTypeEnum.USERDEFINED:
						return Xbim.Ifc4.SharedBldgElements.IfcSlabTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcSlabTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.SharedBldgElements.IfcSlabTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}