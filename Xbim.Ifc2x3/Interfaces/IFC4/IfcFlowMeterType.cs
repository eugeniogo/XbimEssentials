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
	public partial class @IfcFlowMeterType : IIfcFlowMeterType
	{
		Xbim.Ifc4.HvacDomain.IfcFlowMeterTypeEnum IIfcFlowMeterType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.HVACDomain.IfcFlowMeterTypeEnum.ELECTRICMETER:
						//TODO: Handle translation of ELECTRICMETER member from IfcFlowMeterTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
										
					case Xbim.Ifc2x3.HVACDomain.IfcFlowMeterTypeEnum.ENERGYMETER:
						return Xbim.Ifc4.HvacDomain.IfcFlowMeterTypeEnum.ENERGYMETER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcFlowMeterTypeEnum.FLOWMETER:
						//TODO: Handle translation of FLOWMETER member from IfcFlowMeterTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
										
					case Xbim.Ifc2x3.HVACDomain.IfcFlowMeterTypeEnum.GASMETER:
						return Xbim.Ifc4.HvacDomain.IfcFlowMeterTypeEnum.GASMETER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcFlowMeterTypeEnum.OILMETER:
						return Xbim.Ifc4.HvacDomain.IfcFlowMeterTypeEnum.OILMETER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcFlowMeterTypeEnum.WATERMETER:
						return Xbim.Ifc4.HvacDomain.IfcFlowMeterTypeEnum.WATERMETER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcFlowMeterTypeEnum.USERDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcFlowMeterTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.HVACDomain.IfcFlowMeterTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcFlowMeterTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}