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
namespace Xbim.Ifc2x3.TimeSeriesResource
{
	public partial class @IfcTimeSeriesValue : IIfcTimeSeriesValue
	{
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcValue> IIfcTimeSeriesValue.ListValues 
		{ 
			get
			{
			foreach (var member in ListValues)
			{
				if (member is Xbim.Ifc2x3.MeasureResource.IfcVolumeMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcVolumeMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcVolumeMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcTimeMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcTimeMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcTimeMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcThermodynamicTemperatureMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcThermodynamicTemperatureMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcThermodynamicTemperatureMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcSolidAngleMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcSolidAngleMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcSolidAngleMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcPositiveRatioMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcPositiveRatioMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcPositiveRatioMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcRatioMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcRatioMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcRatioMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcPositivePlaneAngleMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcPositivePlaneAngleMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcPlaneAngleMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcPlaneAngleMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcPlaneAngleMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcParameterValue) 
					yield return new Xbim.Ifc4.MeasureResource.IfcParameterValue((double)(Xbim.Ifc2x3.MeasureResource.IfcParameterValue)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcNumericMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcNumericMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcNumericMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcMassMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcMassMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcMassMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcPositiveLengthMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcPositiveLengthMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcLengthMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcLengthMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcLengthMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcElectricCurrentMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcElectricCurrentMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcElectricCurrentMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcDescriptiveMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcDescriptiveMeasure((string)(Xbim.Ifc2x3.MeasureResource.IfcDescriptiveMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcCountMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcCountMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcCountMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcContextDependentMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcContextDependentMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcContextDependentMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcAreaMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcAreaMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcAreaMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcAmountOfSubstanceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcAmountOfSubstanceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcAmountOfSubstanceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcLuminousIntensityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcLuminousIntensityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcLuminousIntensityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcNormalisedRatioMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcNormalisedRatioMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcComplexNumber) 
					yield return new Xbim.Ifc4.MeasureResource.IfcComplexNumber((List<double>)(Xbim.Ifc2x3.MeasureResource.IfcComplexNumber)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcInteger) 
					yield return new Xbim.Ifc4.MeasureResource.IfcInteger((long)(Xbim.Ifc2x3.MeasureResource.IfcInteger)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcReal) 
					yield return new Xbim.Ifc4.MeasureResource.IfcReal((double)(Xbim.Ifc2x3.MeasureResource.IfcReal)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcBoolean) 
					yield return new Xbim.Ifc4.MeasureResource.IfcBoolean((bool)(Xbim.Ifc2x3.MeasureResource.IfcBoolean)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcIdentifier) 
					yield return new Xbim.Ifc4.MeasureResource.IfcIdentifier((string)(Xbim.Ifc2x3.MeasureResource.IfcIdentifier)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcText) 
					yield return new Xbim.Ifc4.MeasureResource.IfcText((string)(Xbim.Ifc2x3.MeasureResource.IfcText)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcLabel) 
					yield return new Xbim.Ifc4.MeasureResource.IfcLabel((string)(Xbim.Ifc2x3.MeasureResource.IfcLabel)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcLogical) 
					yield return new Xbim.Ifc4.MeasureResource.IfcLogical((bool?)(Xbim.Ifc2x3.MeasureResource.IfcLogical)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcVolumetricFlowRateMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcVolumetricFlowRateMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcVolumetricFlowRateMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcTimeStamp) 
					yield return new Xbim.Ifc4.DateTimeResource.IfcTimeStamp((long)(Xbim.Ifc2x3.MeasureResource.IfcTimeStamp)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcThermalTransmittanceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcThermalTransmittanceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcThermalTransmittanceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcThermalResistanceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcThermalResistanceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcThermalResistanceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcThermalAdmittanceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcThermalAdmittanceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcThermalAdmittanceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcPressureMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcPressureMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcPressureMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcPowerMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcPowerMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcPowerMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcMassFlowRateMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcMassFlowRateMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcMassFlowRateMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcMassDensityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcMassDensityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcMassDensityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcLinearVelocityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcLinearVelocityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcLinearVelocityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcKinematicViscosityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcKinematicViscosityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcKinematicViscosityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcIntegerCountRateMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcIntegerCountRateMeasure((long)(Xbim.Ifc2x3.MeasureResource.IfcIntegerCountRateMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcHeatFluxDensityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcHeatFluxDensityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcHeatFluxDensityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcFrequencyMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcFrequencyMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcFrequencyMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcEnergyMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcEnergyMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcEnergyMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcElectricVoltageMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcElectricVoltageMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcElectricVoltageMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcDynamicViscosityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcDynamicViscosityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcDynamicViscosityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcCompoundPlaneAngleMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure((List<long>)(Xbim.Ifc2x3.MeasureResource.IfcCompoundPlaneAngleMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcAngularVelocityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcAngularVelocityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcAngularVelocityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcThermalConductivityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcThermalConductivityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcThermalConductivityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcMolecularWeightMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcMolecularWeightMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcMolecularWeightMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcVaporPermeabilityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcVaporPermeabilityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcVaporPermeabilityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcMoistureDiffusivityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcMoistureDiffusivityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcMoistureDiffusivityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcIsothermalMoistureCapacityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcIsothermalMoistureCapacityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcIsothermalMoistureCapacityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcSpecificHeatCapacityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcSpecificHeatCapacityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcSpecificHeatCapacityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcMonetaryMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcMonetaryMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcMonetaryMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcMagneticFluxDensityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcMagneticFluxDensityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcMagneticFluxDensityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcMagneticFluxMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcMagneticFluxMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcMagneticFluxMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcLuminousFluxMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcLuminousFluxMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcLuminousFluxMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcForceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcForceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcForceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcInductanceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcInductanceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcInductanceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcIlluminanceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcIlluminanceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcIlluminanceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcElectricResistanceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcElectricResistanceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcElectricResistanceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcElectricConductanceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcElectricConductanceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcElectricConductanceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcElectricChargeMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcElectricChargeMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcElectricChargeMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcDoseEquivalentMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcDoseEquivalentMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcDoseEquivalentMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcElectricCapacitanceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcElectricCapacitanceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcElectricCapacitanceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcAbsorbedDoseMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcAbsorbedDoseMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcAbsorbedDoseMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcRadioActivityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcRadioActivityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcRadioActivityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcRotationalFrequencyMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcRotationalFrequencyMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcRotationalFrequencyMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcTorqueMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcTorqueMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcTorqueMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcAccelerationMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcAccelerationMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcAccelerationMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcLinearForceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcLinearForceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcLinearForceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcLinearStiffnessMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcLinearStiffnessMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcLinearStiffnessMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcModulusOfSubgradeReactionMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcModulusOfSubgradeReactionMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcModulusOfElasticityMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcModulusOfElasticityMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcModulusOfElasticityMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcMomentOfInertiaMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcMomentOfInertiaMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcMomentOfInertiaMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcPlanarForceMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcPlanarForceMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcPlanarForceMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcRotationalStiffnessMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcRotationalStiffnessMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcRotationalStiffnessMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcShearModulusMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcShearModulusMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcShearModulusMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcLinearMomentMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcLinearMomentMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcLinearMomentMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcLuminousIntensityDistributionMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcLuminousIntensityDistributionMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcLuminousIntensityDistributionMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcCurvatureMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcCurvatureMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcCurvatureMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcMassPerLengthMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcMassPerLengthMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcMassPerLengthMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcRotationalMassMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcRotationalMassMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcRotationalMassMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcSectionalAreaIntegralMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcSectionalAreaIntegralMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcSectionalAreaIntegralMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcSectionModulusMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcSectionModulusMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcSectionModulusMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcTemperatureGradientMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcTemperatureGradientMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcTemperatureGradientMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcThermalExpansionCoefficientMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcThermalExpansionCoefficientMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcThermalExpansionCoefficientMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcWarpingConstantMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcWarpingConstantMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcWarpingConstantMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcWarpingMomentMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcWarpingMomentMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcWarpingMomentMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcSoundPowerMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcSoundPowerMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcSoundPowerMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcSoundPressureMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcSoundPressureMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcSoundPressureMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcHeatingValueMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcHeatingValueMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcHeatingValueMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcPHMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcPHMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcPHMeasure)member);
				if (member is Xbim.Ifc2x3.MeasureResource.IfcIonConcentrationMeasure) 
					yield return new Xbim.Ifc4.MeasureResource.IfcIonConcentrationMeasure((double)(Xbim.Ifc2x3.MeasureResource.IfcIonConcentrationMeasure)member);
			}
			} 
		}
	}
}