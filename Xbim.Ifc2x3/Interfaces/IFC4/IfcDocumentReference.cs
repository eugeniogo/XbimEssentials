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
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	public partial class @IfcDocumentReference : IIfcDocumentReference
	{

		private  Ifc4.MeasureResource.IfcText? _description;


		[CrossSchemaAttribute(typeof(IIfcDocumentReference), 4)]
		Ifc4.MeasureResource.IfcText? IIfcDocumentReference.Description 
		{ 
			get
			{
				return _description;
			} 
			set
			{
				SetValue(v => _description = v, _description, value, "Description", -4);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentReference), 5)]
		IIfcDocumentInformation IIfcDocumentReference.ReferencedDocument 
		{ 
			get
			{
				//## Handle return of ReferencedDocument for which no match was found
			    return ReferenceToDocument.FirstOrDefault();
			    //##
			} 
			set
			{
				//## Handle setting of ReferencedDocument for which no match was found
			    if (value == null)
			        ReferenceToDocument.ToList().ForEach(d => d.DocumentReferences.Remove(this));
			    else
			    {
                    var document = value as IfcDocumentInformation;
                    if (document != null && !document.DocumentReferences.Contains(this))
                        document.DocumentReferences.Add(this);    
			    }
				//##
				NotifyPropertyChanged("ReferencedDocument");
				
			}
		}
		IEnumerable<IIfcRelAssociatesDocument> IIfcDocumentReference.DocumentRefForObjects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesDocument>(e => (e.RelatingDocument as IfcDocumentReference) == this, "RelatingDocument", this);
			} 
		}
	//## Custom code
	//##
	}
}