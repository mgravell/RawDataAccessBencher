﻿#if !(DNXCORE50 || DNX451)
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for Oak, doing change tracking fetch
	/// </summary>
	public class OakDynamicDbNormalBencher : BencherBase<dynamic>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OakDynamicDbNormalBencher"/> class.
		/// </summary>
		public OakDynamicDbNormalBencher()
			: base(e => e.SalesOrderId, usesChangeTracking:true, usesCaching:false)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override dynamic FetchIndividual(int key)
		{
			var db = new OakDynamicDb.Bencher.SalesOrderHeaders();
			db.Projection = d => new OakDynamicDb.Bencher.SalesOrderHeader(d);
			db.PrimaryKeyField = "SalesOrderID";
			return db.Single(key);
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<dynamic> FetchSet()
		{
			var db = new OakDynamicDb.Bencher.SalesOrderHeaders();
			db.Projection = d => new OakDynamicDb.Bencher.SalesOrderHeader(d);
			return db.All();
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return "Oak.DynamicDb using typed dynamic class";
		}


		#region Properties
		/// <summary>
		/// Gets or sets the connection string to use
		/// </summary>
		public string ConnectionStringToUse { get; set; }
		#endregion
	}
}
#endif