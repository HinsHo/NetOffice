//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _Inspector SupportByLibrary Outlook, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Inspector : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_Inspector);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Inspector(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Inspector(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Inspector(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Inspector() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Inspector(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
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
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OfficeApi.CommandBars CommandBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandBars", paramsArray);
				NetOffice.OfficeApi.CommandBars newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CommandBars.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject CurrentItem
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentItem", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlEditorType EditorType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EditorType", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlEditorType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject ModifiedFormPages
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ModifiedFormPages", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject HTMLEditor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HTMLEditor", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject WordEditor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WordEditor", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public Int32 Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public Int32 Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public Int32 Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public Int32 Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlWindowState WindowState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WindowState", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlWindowState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WindowState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OutlookApi._AttachmentSelection AttachmentSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AttachmentSelection", paramsArray);
				NetOffice.OutlookApi._AttachmentSelection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._AttachmentSelection;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="SaveMode">NetOffice.OutlookApi.Enums.OlInspectorClose SaveMode</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Close(NetOffice.OutlookApi.Enums.OlInspectorClose saveMode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(saveMode);
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Modal">optional object Modal</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Display(object modal)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(modal);
			Invoker.Method(this, "Display", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Display()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Display", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="PageName">string PageName</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void HideFormPage(string pageName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pageName);
			Invoker.Method(this, "HideFormPage", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public bool IsWordMail()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "IsWordMail", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="PageName">string PageName</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void SetCurrentFormPage(string pageName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pageName);
			Invoker.Method(this, "SetCurrentFormPage", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="PageName">string PageName</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void ShowFormPage(string pageName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pageName);
			Invoker.Method(this, "ShowFormPage", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Activate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Activate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 11, 12, 14
		/// </summary>
		/// <param name="Control">object Control</param>
		/// <param name="PropertyName">string PropertyName</param>
		[SupportByLibrary("Outlook", 11,12,14)]
		public void SetControlItemProperty(object control, string propertyName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(control, propertyName);
			Invoker.Method(this, "SetControlItemProperty", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public COMObject NewFormRegion()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NewFormRegion", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Path">string Path</param>
		[SupportByLibrary("Outlook", 12,14)]
		public COMObject OpenFormRegion(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			object returnItem = Invoker.MethodReturn(this, "OpenFormRegion", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Page">object Page</param>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("Outlook", 12,14)]
		public void SaveFormRegion(object page, string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(page, fileName);
			Invoker.Method(this, "SaveFormRegion", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		/// <param name="Start">DateTime Start</param>
		[SupportByLibrary("Outlook", 14)]
		public void SetSchedulingStartTime(DateTime start)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start);
			Invoker.Method(this, "SetSchedulingStartTime", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}