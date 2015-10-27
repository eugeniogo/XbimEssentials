// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProductExtension;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcZone
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcZone : IIfcSystem
	{
		IfcLabel? @LongName { get; }
		
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IFCZONE", 1156)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcZone : IfcSystem, IInstantiableEntity, IIfcZone, IEqualityComparer<@IfcZone>, IEquatable<@IfcZone>
	{
		#region IIfcZone explicit implementation
		IfcLabel? IIfcZone.LongName { get { return @LongName; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcZone(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _longName;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @LongName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longName;
				((IPersistEntity)this).Activate(false);
				return _longName;
			} 
			set
			{
				SetValue( v =>  _longName = v, _longName, value,  "LongName");
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
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_longName = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:            	))) = 0);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcZone other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcZone
            var root = (@IfcZone)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcZone left, @IfcZone right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcZone left, @IfcZone right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcZone x, @IfcZone y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcZone obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}