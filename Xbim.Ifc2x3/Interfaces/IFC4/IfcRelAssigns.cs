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
	public partial class @IfcRelAssigns : IIfcRelAssigns
	{
		IEnumerable<IIfcObjectDefinition> IIfcRelAssigns.RelatedObjects 
		{ 
			get
			{
			foreach (var member in RelatedObjects)
			{
				yield return member as IIfcObjectDefinition;
			}
			} 
		}
		Xbim.Ifc4.Kernel.IfcObjectTypeEnum? IIfcRelAssigns.RelatedObjectsType 
		{ 
			get
			{
				switch (RelatedObjectsType)
				{
					case Xbim.Ifc2x3.Kernel.IfcObjectTypeEnum.PRODUCT:
						return Xbim.Ifc4.Kernel.IfcObjectTypeEnum.PRODUCT;
					
					case Xbim.Ifc2x3.Kernel.IfcObjectTypeEnum.PROCESS:
						return Xbim.Ifc4.Kernel.IfcObjectTypeEnum.PROCESS;
					
					case Xbim.Ifc2x3.Kernel.IfcObjectTypeEnum.CONTROL:
						return Xbim.Ifc4.Kernel.IfcObjectTypeEnum.CONTROL;
					
					case Xbim.Ifc2x3.Kernel.IfcObjectTypeEnum.RESOURCE:
						return Xbim.Ifc4.Kernel.IfcObjectTypeEnum.RESOURCE;
					
					case Xbim.Ifc2x3.Kernel.IfcObjectTypeEnum.ACTOR:
						return Xbim.Ifc4.Kernel.IfcObjectTypeEnum.ACTOR;
					
					case Xbim.Ifc2x3.Kernel.IfcObjectTypeEnum.GROUP:
						return Xbim.Ifc4.Kernel.IfcObjectTypeEnum.GROUP;
					
					case Xbim.Ifc2x3.Kernel.IfcObjectTypeEnum.PROJECT:
						return Xbim.Ifc4.Kernel.IfcObjectTypeEnum.PROJECT;
					
					case Xbim.Ifc2x3.Kernel.IfcObjectTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.Kernel.IfcObjectTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}