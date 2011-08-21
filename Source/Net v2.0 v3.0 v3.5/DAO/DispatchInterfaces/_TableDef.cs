//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.DAOApi
{
	///<summary>
	/// DispatchInterface _TableDef SupportByLibrary DAO, 6,12
	///</summary>
	[SupportByLibrary("DAO", 6,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _TableDef : _DAO
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_TableDef);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TableDef(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TableDef(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TableDef(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TableDef() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _TableDef(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 Attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attributes", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Attributes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string Connect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Connect", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Connect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public object DateCreated
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DateCreated", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public object LastUpdated
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastUpdated", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string SourceTableName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceTableName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SourceTableName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool Updatable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Updatable", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string ValidationText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ValidationText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ValidationText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string ValidationRule
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ValidationRule", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ValidationRule", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 RecordCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Fields Fields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fields", paramsArray);
				NetOffice.DAOApi.Fields newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.Fields.LateBindingApiWrapperType) as NetOffice.DAOApi.Fields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Indexes Indexes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Indexes", paramsArray);
				NetOffice.DAOApi.Indexes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.DAOApi.Indexes.LateBindingApiWrapperType) as NetOffice.DAOApi.Indexes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string ConflictTable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConflictTable", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// Get/Set
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public object ReplicaFilter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReplicaFilter", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReplicaFilter", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset(object type, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, options);
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void RefreshLink()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RefreshLink", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Size">optional object Size</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Field CreateField(object name, object type, object size)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, size);
			object returnItem = Invoker.MethodReturn(this, "CreateField", paramsArray);
			NetOffice.DAOApi.Field newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Field.LateBindingApiWrapperType) as NetOffice.DAOApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Field CreateField()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateField", paramsArray);
			NetOffice.DAOApi.Field newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Field.LateBindingApiWrapperType) as NetOffice.DAOApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Index CreateIndex(object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "CreateIndex", paramsArray);
			NetOffice.DAOApi.Index newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Index.LateBindingApiWrapperType) as NetOffice.DAOApi.Index;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Index CreateIndex()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateIndex", paramsArray);
			NetOffice.DAOApi.Index newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.DAOApi.Index.LateBindingApiWrapperType) as NetOffice.DAOApi.Index;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Value">optional object Value</param>
		/// <param name="DDL">optional object DDL</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Property CreateProperty(object name, object type, object value, object dDL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, value, dDL);
			object returnItem = Invoker.MethodReturn(this, "CreateProperty", paramsArray);
			NetOffice.DAOApi.Property newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Property;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO 6, 12
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Property CreateProperty()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateProperty", paramsArray);
			NetOffice.DAOApi.Property newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Property;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}