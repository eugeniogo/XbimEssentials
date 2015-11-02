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
namespace Xbim.Ifc2x3.UtilityResource
{
	public partial class @IfcOwnerHistory : IIfcOwnerHistory
	{
		IIfcPersonAndOrganization IIfcOwnerHistory.OwningUser 
		{ 
			get
			{
				return OwningUser as IIfcPersonAndOrganization;
			} 
		}
		IIfcApplication IIfcOwnerHistory.OwningApplication 
		{ 
			get
			{
				return OwningApplication as IIfcApplication;
			} 
		}
		Xbim.Ifc4.UtilityResource.IfcStateEnum? IIfcOwnerHistory.State 
		{ 
			get
			{
				switch (State)
				{
					case Xbim.Ifc2x3.UtilityResource.IfcStateEnum.READWRITE:
						return Xbim.Ifc4.UtilityResource.IfcStateEnum.READWRITE;
					
					case Xbim.Ifc2x3.UtilityResource.IfcStateEnum.READONLY:
						return Xbim.Ifc4.UtilityResource.IfcStateEnum.READONLY;
					
					case Xbim.Ifc2x3.UtilityResource.IfcStateEnum.LOCKED:
						return Xbim.Ifc4.UtilityResource.IfcStateEnum.LOCKED;
					
					case Xbim.Ifc2x3.UtilityResource.IfcStateEnum.READWRITELOCKED:
						return Xbim.Ifc4.UtilityResource.IfcStateEnum.READWRITELOCKED;
					
					case Xbim.Ifc2x3.UtilityResource.IfcStateEnum.READONLYLOCKED:
						return Xbim.Ifc4.UtilityResource.IfcStateEnum.READONLYLOCKED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Xbim.Ifc4.UtilityResource.IfcChangeActionEnum? IIfcOwnerHistory.ChangeAction 
		{ 
			get
			{
				switch (ChangeAction)
				{
					case Xbim.Ifc2x3.UtilityResource.IfcChangeActionEnum.NOCHANGE:
						return Xbim.Ifc4.UtilityResource.IfcChangeActionEnum.NOCHANGE;
					
					case Xbim.Ifc2x3.UtilityResource.IfcChangeActionEnum.MODIFIED:
						return Xbim.Ifc4.UtilityResource.IfcChangeActionEnum.MODIFIED;
					
					case Xbim.Ifc2x3.UtilityResource.IfcChangeActionEnum.ADDED:
						return Xbim.Ifc4.UtilityResource.IfcChangeActionEnum.ADDED;
					
					case Xbim.Ifc2x3.UtilityResource.IfcChangeActionEnum.DELETED:
						return Xbim.Ifc4.UtilityResource.IfcChangeActionEnum.DELETED;
					
					case Xbim.Ifc2x3.UtilityResource.IfcChangeActionEnum.MODIFIEDADDED:
						//TODO: Handle translation of MODIFIEDADDED member from IfcChangeActionEnum in property ChangeAction
						throw new System.NotImplementedException();
										
					case Xbim.Ifc2x3.UtilityResource.IfcChangeActionEnum.MODIFIEDDELETED:
						//TODO: Handle translation of MODIFIEDDELETED member from IfcChangeActionEnum in property ChangeAction
						throw new System.NotImplementedException();
										
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Xbim.Ifc4.DateTimeResource.IfcTimeStamp? IIfcOwnerHistory.LastModifiedDate 
		{ 
			get
			{
				if (LastModifiedDate == null) return null;
				return new Xbim.Ifc4.DateTimeResource.IfcTimeStamp((long)LastModifiedDate);
			} 
		}
		IIfcPersonAndOrganization IIfcOwnerHistory.LastModifyingUser 
		{ 
			get
			{
				return LastModifyingUser as IIfcPersonAndOrganization;
			} 
		}
		IIfcApplication IIfcOwnerHistory.LastModifyingApplication 
		{ 
			get
			{
				return LastModifyingApplication as IIfcApplication;
			} 
		}
		Xbim.Ifc4.DateTimeResource.IfcTimeStamp IIfcOwnerHistory.CreationDate 
		{ 
			get
			{
				return new Xbim.Ifc4.DateTimeResource.IfcTimeStamp((long)CreationDate);
			} 
		}
	}
}