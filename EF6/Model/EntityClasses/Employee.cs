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
	/// <summary>Class which represents the entity 'Employee'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class Employee : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="Employee"/> class.</summary>
		public Employee() : base()
		{
			this.Documents = new HashSet<Document>();
			this.EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
			this.EmployeePayHistories = new HashSet<EmployeePayHistory>();
			this.JobCandidates = new HashSet<JobCandidate>();
			this.PurchaseOrderHeaders = new HashSet<PurchaseOrderHeader>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the BirthDate field. </summary>
		[DataMember]
		public System.DateTime BirthDate { get; set;}
		/// <summary>Gets or sets the CurrentFlag field. </summary>
		[DataMember]
		public System.Boolean CurrentFlag { get; set;}
		/// <summary>Gets or sets the EmployeeId field. </summary>
		[DataMember]
		public System.Int32 EmployeeId { get; set;}
		/// <summary>Gets or sets the Gender field. </summary>
		[DataMember]
		public System.String Gender { get; set;}
		/// <summary>Gets or sets the HireDate field. </summary>
		[DataMember]
		public System.DateTime HireDate { get; set;}
		/// <summary>Gets or sets the LoginId field. </summary>
		[DataMember]
		public System.String LoginId { get; set;}
		/// <summary>Gets or sets the MaritalStatus field. </summary>
		[DataMember]
		public System.String MaritalStatus { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the NationalIdnumber field. </summary>
		[DataMember]
		public System.String NationalIdnumber { get; set;}
		/// <summary>Gets or sets the OrganizationLevel field. </summary>
		[DataMember]
		public Nullable<System.Int16> OrganizationLevel { get; set;}
		/// <summary>Gets or sets the OrganizationNode field. </summary>
		[DataMember]
		public System.String OrganizationNode { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Gets or sets the SalariedFlag field. </summary>
		[DataMember]
		public System.Boolean SalariedFlag { get; set;}
		/// <summary>Gets or sets the SickLeaveHours field. </summary>
		[DataMember]
		public System.Int16 SickLeaveHours { get; set;}
		/// <summary>Gets or sets the Title field. </summary>
		[DataMember]
		public System.String Title { get; set;}
		/// <summary>Gets or sets the VacationHours field. </summary>
		[DataMember]
		public System.Int16 VacationHours { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Document.Employee - Employee.Documents (m:1)'</summary>
		[DataMember]
		public virtual ICollection<Document> Documents { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'EmployeeDepartmentHistory.Employee - Employee.EmployeeDepartmentHistories (m:1)'</summary>
		[DataMember]
		public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'EmployeePayHistory.Employee - Employee.EmployeePayHistories (m:1)'</summary>
		[DataMember]
		public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'JobCandidate.Employee - Employee.JobCandidates (m:1)'</summary>
		[DataMember]
		public virtual ICollection<JobCandidate> JobCandidates { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Employee.Person - Person.Person.Employee (1:1)'</summary>
		[DataMember]
		public virtual Person Person { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.Employee - Employee.PurchaseOrderHeaders (m:1)'</summary>
		[DataMember]
		public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesPerson.Employee - Employee.SalesPerson (1:1)'</summary>
		[DataMember]
		public virtual SalesPerson SalesPerson { get; set;}
		#endregion
	}
}