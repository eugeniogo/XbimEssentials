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
	public partial class @IfcElectricFlowStorageDeviceType : IIfcElectricFlowStorageDeviceType
	{
		Xbim.Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum IIfcElectricFlowStorageDeviceType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.BATTERY:
						return Xbim.Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.BATTERY;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.CAPACITORBANK:
						return Xbim.Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.CAPACITORBANK;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.HARMONICFILTER:
						return Xbim.Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.HARMONICFILTER;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.INDUCTORBANK:
						return Xbim.Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.INDUCTORBANK;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.UPS:
						return Xbim.Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.UPS;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.USERDEFINED:
						return Xbim.Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.ElectricalDomain.IfcElectricFlowStorageDeviceTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}