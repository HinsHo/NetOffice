//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface SchemaRelationships SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SchemaRelationships : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SchemaRelationships(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SchemaRelationships(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SchemaRelationships(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SchemaRelationships()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XWC1.0")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OWC10Api.SchemaRelationship this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OWC10Api.SchemaRelationship newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.SchemaRelationship;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="ManySchemaRowsource">string ManySchemaRowsource</param>
		/// <param name="OneSchemaRowsource">string OneSchemaRowsource</param>
		/// <param name="ManySchemaField">string ManySchemaField</param>
		/// <param name="OneSchemaField">string OneSchemaField</param>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.SchemaRelationship Add(string name, string manySchemaRowsource, string oneSchemaRowsource, string manySchemaField, string oneSchemaField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, manySchemaRowsource, oneSchemaRowsource, manySchemaField, oneSchemaField);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OWC10Api.SchemaRelationship newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api.SchemaRelationship;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="ManySchemaRowsource">string ManySchemaRowsource</param>
		/// <param name="OneSchemaRowsource">string OneSchemaRowsource</param>
		/// <param name="ManySchemaField">string ManySchemaField</param>
		/// <param name="OneSchemaField">string OneSchemaField</param>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.SchemaRelationship AddNew(string name, string manySchemaRowsource, string oneSchemaRowsource, string manySchemaField, string oneSchemaField)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, manySchemaRowsource, oneSchemaRowsource, manySchemaField, oneSchemaField);
			object returnItem = Invoker.MethodReturn(this, "AddNew", paramsArray);
			NetOffice.OWC10Api.SchemaRelationship newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api.SchemaRelationship;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XWC1.0")]
		public void Delete(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("XWC1.0")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}