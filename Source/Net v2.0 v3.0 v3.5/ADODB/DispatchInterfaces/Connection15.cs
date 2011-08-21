//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi
{
	///<summary>
	/// DispatchInterface Connection15 SupportByLibrary ADODB, 2.1,2.5
	///</summary>
	[SupportByLibrary("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Connection15 : _ADO
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Connection15);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection15(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection15(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection15(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection15() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Connection15(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public string ConnectionString
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConnectionString", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ConnectionString", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 CommandTimeout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandTimeout", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CommandTimeout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 ConnectionTimeout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConnectionTimeout", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ConnectionTimeout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public string Version
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Version", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Errors Errors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Errors", paramsArray);
				NetOffice.ADODBApi.Errors newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ADODBApi.Errors.LateBindingApiWrapperType) as NetOffice.ADODBApi.Errors;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public string DefaultDatabase
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultDatabase", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultDatabase", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.IsolationLevelEnum IsolationLevel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsolationLevel", paramsArray);
				return (NetOffice.ADODBApi.Enums.IsolationLevelEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IsolationLevel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
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
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.CursorLocationEnum CursorLocation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CursorLocation", paramsArray);
				return (NetOffice.ADODBApi.Enums.CursorLocationEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CursorLocation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi.Enums.ConnectModeEnum Mode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Mode", paramsArray);
				return (NetOffice.ADODBApi.Enums.ConnectModeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Mode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get/Set
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public string Provider
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Provider", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Provider", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 State
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "State", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="CommandText">string CommandText</param>
		/// <param name="RecordsAffected">object RecordsAffected</param>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset Execute(string commandText, object recordsAffected, Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(commandText, recordsAffected, options);
			object returnItem = Invoker.MethodReturn(this, "Execute", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public Int32 BeginTrans()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "BeginTrans", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void CommitTrans()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CommitTrans", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void RollbackTrans()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RollbackTrans", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="ConnectionString">string ConnectionString</param>
		/// <param name="UserID">string UserID</param>
		/// <param name="Password">string Password</param>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public void Open(string connectionString, string userID, string password, Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(connectionString, userID, password, options);
			Invoker.Method(this, "Open", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Schema">NetOffice.ADODBApi.Enums.SchemaEnum Schema</param>
		/// <param name="Restrictions">optional object Restrictions</param>
		/// <param name="SchemaID">optional object SchemaID</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset OpenSchema(NetOffice.ADODBApi.Enums.SchemaEnum schema, object restrictions, object schemaID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schema, restrictions, schemaID);
			object returnItem = Invoker.MethodReturn(this, "OpenSchema", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// </summary>
		/// <param name="Schema">NetOffice.ADODBApi.Enums.SchemaEnum Schema</param>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		public NetOffice.ADODBApi._Recordset OpenSchema(NetOffice.ADODBApi.Enums.SchemaEnum schema)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(schema);
			object returnItem = Invoker.MethodReturn(this, "OpenSchema", paramsArray);
			NetOffice.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ADODBApi._Recordset;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}