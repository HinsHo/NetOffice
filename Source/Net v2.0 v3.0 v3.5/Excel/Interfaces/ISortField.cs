//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface ISortField SupportByLibrary Excel, 12,14
	///</summary>
	[SupportByLibrary("Excel", 12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class ISortField : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ISortField);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISortField(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISortField(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISortField(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISortField() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISortField(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Enums.XlSortOn SortOn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SortOn", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlSortOn)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SortOn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public COMObject SortOnValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SortOnValue", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Range Key
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Key", paramsArray);
				NetOffice.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Range.LateBindingApiWrapperType) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Enums.XlSortOrder Order
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Order", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlSortOrder)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Order", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public object CustomOrder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomOrder", paramsArray);
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
				Invoker.PropertySet(this, "CustomOrder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Enums.XlSortDataOption DataOption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataOption", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlSortDataOption)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataOption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public Int32 Priority
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Priority", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Priority", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public Int32 Delete()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Delete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="Key">NetOffice.ExcelApi.Range Key</param>
		[SupportByLibrary("Excel", 12,14)]
		public Int32 ModifyKey(NetOffice.ExcelApi.Range key)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(key);
			object returnItem = Invoker.MethodReturn(this, "ModifyKey", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="Icon">NetOffice.ExcelApi.Icon Icon</param>
		[SupportByLibrary("Excel", 12,14)]
		public Int32 SetIcon(NetOffice.ExcelApi.Icon icon)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(icon);
			object returnItem = Invoker.MethodReturn(this, "SetIcon", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}