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
	/// Interface ISmartTag SupportByLibrary XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL10","XL11","XL12","XL14")]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class ISmartTag : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISmartTag(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISmartTag(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISmartTag(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISmartTag()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
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
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
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
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public string DownloadURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DownloadURL", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public string _Default
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public string XML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XML", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.SmartTagActions SmartTagActions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartTagActions", paramsArray);
				NetOffice.ExcelApi.SmartTagActions newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.SmartTagActions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.CustomProperties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				NetOffice.ExcelApi.CustomProperties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.CustomProperties;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public Int32 Delete()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Delete", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}