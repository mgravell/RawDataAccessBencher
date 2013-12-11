﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ProductModelProductDescriptionCulture'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class ProductModelProductDescriptionCulture : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="ProductModelProductDescriptionCulture"/> class.</summary>
		public ProductModelProductDescriptionCulture() : base()
		{
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the CultureId field. </summary>
		[DataMember]
		public System.String CultureId { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the ProductDescriptionId field. </summary>
		[DataMember]
		public System.Int32 ProductDescriptionId { get; set;}
		/// <summary>Gets or sets the ProductModelId field. </summary>
		[DataMember]
		public System.Int32 ProductModelId { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductModelProductDescriptionCulture.Culture - Culture.ProductModelProductDescriptionCultures (m:1)'</summary>
		[DataMember]
		public virtual Culture Culture { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductModelProductDescriptionCulture.ProductDescription - ProductDescription.ProductModelProductDescriptionCultures (m:1)'</summary>
		[DataMember]
		public virtual ProductDescription ProductDescription { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductModelProductDescriptionCulture.ProductModel - ProductModel.ProductModelProductDescriptionCultures (m:1)'</summary>
		[DataMember]
		public virtual ProductModel ProductModel { get; set;}
		#endregion
	}
}