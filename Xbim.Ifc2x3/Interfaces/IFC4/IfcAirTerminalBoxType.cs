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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcAirTerminalBoxType : IIfcAirTerminalBoxType
	{
		Xbim.Ifc4.HvacDomain.IfcAirTerminalBoxTypeEnum IIfcAirTerminalBoxType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.HVACDomain.IfcAirTerminalBoxTypeEnum.CONSTANTFLOW:
						return Xbim.Ifc4.HvacDomain.IfcAirTerminalBoxTypeEnum.CONSTANTFLOW;
					
					case Xbim.Ifc2x3.HVACDomain.IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREDEPENDANT:
						return Xbim.Ifc4.HvacDomain.IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREDEPENDANT;
					
					case Xbim.Ifc2x3.HVACDomain.IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREINDEPENDANT:
						return Xbim.Ifc4.HvacDomain.IfcAirTerminalBoxTypeEnum.VARIABLEFLOWPRESSUREINDEPENDANT;
					
					case Xbim.Ifc2x3.HVACDomain.IfcAirTerminalBoxTypeEnum.USERDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcAirTerminalBoxTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.HVACDomain.IfcAirTerminalBoxTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcAirTerminalBoxTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}