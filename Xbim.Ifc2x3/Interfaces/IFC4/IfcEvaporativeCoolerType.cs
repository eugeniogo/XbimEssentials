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
	public partial class @IfcEvaporativeCoolerType : IIfcEvaporativeCoolerType
	{
		Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum IIfcEvaporativeCoolerType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case Xbim.Ifc2x3.HVACDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER:
						return Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER:
						return Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER:
						return Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER:
						return Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEAIRWASHER:
						return Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEAIRWASHER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEPACKAGEAIRCOOLER:
						return Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEPACKAGEAIRCOOLER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEWETCOIL:
						return Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEWETCOIL;
					
					case Xbim.Ifc2x3.HVACDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER:
						return Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER;
					
					case Xbim.Ifc2x3.HVACDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTDIRECTCOMBINATION:
						return Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.INDIRECTDIRECTCOMBINATION;
					
					case Xbim.Ifc2x3.HVACDomain.IfcEvaporativeCoolerTypeEnum.USERDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.USERDEFINED;
					
					case Xbim.Ifc2x3.HVACDomain.IfcEvaporativeCoolerTypeEnum.NOTDEFINED:
						return Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}