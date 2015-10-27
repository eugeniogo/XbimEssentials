// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPropertyDefinition
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPropertyDefinition : IIfcRoot, IfcDefinitionSelect
	{
		IEnumerable<IIfcRelDeclares> @HasContext {  get; }
		IEnumerable<IIfcRelAssociates> @HasAssociations {  get; }
		
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCPROPERTYDEFINITION", 851)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPropertyDefinition : IfcRoot, IIfcPropertyDefinition, IEqualityComparer<@IfcPropertyDefinition>, IEquatable<@IfcPropertyDefinition>
	{
		#region IIfcPropertyDefinition explicit implementation
	
	 
		IEnumerable<IIfcRelDeclares> IIfcPropertyDefinition.HasContext {  get { return @HasContext; } }
		IEnumerable<IIfcRelAssociates> IIfcPropertyDefinition.HasAssociations {  get { return @HasAssociations; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyDefinition(IModel model) : base(model) 		{ 
			Model = model; 
		}



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDeclares> @HasContext 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDeclares>(e => e.RelatedDefinitions != null &&  e.RelatedDefinitions.Contains(this));
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssociates> @HasAssociations 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociates>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyDefinition other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPropertyDefinition
            var root = (@IfcPropertyDefinition)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPropertyDefinition left, @IfcPropertyDefinition right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPropertyDefinition left, @IfcPropertyDefinition right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPropertyDefinition x, @IfcPropertyDefinition y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPropertyDefinition obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}