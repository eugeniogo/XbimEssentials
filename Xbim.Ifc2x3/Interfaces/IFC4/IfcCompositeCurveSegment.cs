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
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcCompositeCurveSegment : IIfcCompositeCurveSegment
	{
		Xbim.Ifc4.GeometryResource.IfcTransitionCode IIfcCompositeCurveSegment.Transition 
		{ 
			get
			{
				switch (Transition)
				{
					case Xbim.Ifc2x3.GeometryResource.IfcTransitionCode.DISCONTINUOUS:
						return Xbim.Ifc4.GeometryResource.IfcTransitionCode.DISCONTINUOUS;
					
					case Xbim.Ifc2x3.GeometryResource.IfcTransitionCode.CONTINUOUS:
						return Xbim.Ifc4.GeometryResource.IfcTransitionCode.CONTINUOUS;
					
					case Xbim.Ifc2x3.GeometryResource.IfcTransitionCode.CONTSAMEGRADIENT:
						return Xbim.Ifc4.GeometryResource.IfcTransitionCode.CONTSAMEGRADIENT;
					
					case Xbim.Ifc2x3.GeometryResource.IfcTransitionCode.CONTSAMEGRADIENTSAMECURVATURE:
						return Xbim.Ifc4.GeometryResource.IfcTransitionCode.CONTSAMEGRADIENTSAMECURVATURE;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		bool IIfcCompositeCurveSegment.SameSense 
		{ 
			get
			{
				return SameSense;
			} 
		}
		IIfcCurve IIfcCompositeCurveSegment.ParentCurve 
		{ 
			get
			{
				return ParentCurve as IIfcCurve;
			} 
		}
		IEnumerable<IIfcCompositeCurve> IIfcCompositeCurveSegment.UsingCurves 
		{ 
			get
			{
				return Model.Instances.Where<IIfcCompositeCurve>(e => e.Segments != null &&  e.Segments.Contains(this));
			} 
		}
	}
}