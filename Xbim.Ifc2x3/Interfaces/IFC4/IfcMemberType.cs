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
	public partial class @IfcMemberType : IIfcMemberType
	{
		Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum IIfcMemberType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.BRACE:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.BRACE;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.CHORD:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.CHORD;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.COLLAR:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.COLLAR;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.MEMBER:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.MEMBER;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.MULLION:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.MULLION;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.PLATE:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.PLATE;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.POST:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.POST;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.PURLIN:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.PURLIN;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.RAFTER:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.RAFTER;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.STRINGER:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.STRINGER;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.STRUT:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.STRUT;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.STUD:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.STUD;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.USERDEFINED:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.SharedBldgElements.IfcMemberTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.SharedBldgElements.IfcMemberTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}