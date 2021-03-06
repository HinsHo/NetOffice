using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.MSHTMLApi
{
	///<summary>
	/// DispatchInterface IHTMLWindow2 
	/// SupportByVersion MSHTML, 4
	///</summary>
	[SupportByVersionAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IHTMLWindow2 : IHTMLFramesCollection2
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IHTMLWindow2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IHTMLWindow2(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow2(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLFramesCollection2 frames
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "frames", paramsArray);
				NetOffice.MSHTMLApi.IHTMLFramesCollection2 newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLFramesCollection2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public string defaultStatus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "defaultStatus", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "defaultStatus", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public string status
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "status", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "status", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLImageElementFactory Image
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Image", paramsArray);
				NetOffice.MSHTMLApi.IHTMLImageElementFactory newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLImageElementFactory;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLLocation location
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "location", paramsArray);
				NetOffice.MSHTMLApi.IHTMLLocation newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLLocation;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IOmHistory history
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "history", paramsArray);
				NetOffice.MSHTMLApi.IOmHistory newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IOmHistory;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object opener
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "opener", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "opener", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IOmNavigator navigator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "navigator", paramsArray);
				NetOffice.MSHTMLApi.IOmNavigator newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IOmNavigator;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public string name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "parent", paramsArray);
				NetOffice.MSHTMLApi.IHTMLWindow2 newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 self
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "self", paramsArray);
				NetOffice.MSHTMLApi.IHTMLWindow2 newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "top", paramsArray);
				NetOffice.MSHTMLApi.IHTMLWindow2 newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 window
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "window", paramsArray);
				NetOffice.MSHTMLApi.IHTMLWindow2 newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object onfocus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onfocus", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "onfocus", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object onblur
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onblur", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "onblur", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object onload
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onload", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "onload", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object onbeforeunload
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onbeforeunload", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "onbeforeunload", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object onunload
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onunload", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "onunload", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object onhelp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onhelp", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "onhelp", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object onerror
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onerror", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "onerror", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object onresize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onresize", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "onresize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object onscroll
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onscroll", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "onscroll", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLDocument2 document
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "document", paramsArray);
				NetOffice.MSHTMLApi.IHTMLDocument2 newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLDocument2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLEventObj get_event()
		{		
			object[] paramsArray = null;
			object returnItem = Invoker.PropertyGet(this, "event", paramsArray);
			NetOffice.MSHTMLApi.IHTMLEventObj newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLEventObj;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object _newEnum
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_newEnum", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLScreen screen
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "screen", paramsArray);
				NetOffice.MSHTMLApi.IHTMLScreen newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLScreen;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLOptionElementFactory Option
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Option", paramsArray);
				NetOffice.MSHTMLApi.IHTMLOptionElementFactory newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLOptionElementFactory;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public bool closed
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "closed", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IOmNavigator clientInformation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "clientInformation", paramsArray);
				NetOffice.MSHTMLApi.IOmNavigator newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IOmNavigator;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object offscreenBuffering
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "offscreenBuffering", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
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
				Invoker.PropertySet(this, "offscreenBuffering", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object external
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "external", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		/// <param name="language">optional object language</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public Int32 setTimeout(string expression, Int32 msec, object language)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec, language);
			object returnItem = Invoker.MethodReturn(this, "setTimeout", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public Int32 setTimeout(string expression, Int32 msec)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec);
			object returnItem = Invoker.MethodReturn(this, "setTimeout", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="timerID">Int32 timerID</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void clearTimeout(Int32 timerID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(timerID);
			Invoker.Method(this, "clearTimeout", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="message">optional string message = </param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void alert(object message)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(message);
			Invoker.Method(this, "alert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public void alert()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "alert", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="message">optional string message = </param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public bool confirm(object message)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(message);
			object returnItem = Invoker.MethodReturn(this, "confirm", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public bool confirm()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "confirm", paramsArray);
			return NetRuntimeSystem.Convert.ToBoolean(returnItem);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="message">optional string message = </param>
		/// <param name="defstr">optional string defstr = undefined</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object prompt(object message, object defstr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(message, defstr);
			object returnItem = Invoker.MethodReturn(this, "prompt", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public object prompt()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "prompt", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="message">optional string message = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public object prompt(object message)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(message);
			object returnItem = Invoker.MethodReturn(this, "prompt", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "close", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="name">optional string name = </param>
		/// <param name="features">optional string features = </param>
		/// <param name="replace">optional bool replace = false</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 open(object url, object name, object features, object replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url, name, features, replace);
			object returnItem = Invoker.MethodReturn(this, "open", paramsArray);
			NetOffice.MSHTMLApi.IHTMLWindow2 newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 open()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "open", paramsArray);
			NetOffice.MSHTMLApi.IHTMLWindow2 newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="url">optional string url = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 open(object url)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url);
			object returnItem = Invoker.MethodReturn(this, "open", paramsArray);
			NetOffice.MSHTMLApi.IHTMLWindow2 newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="name">optional string name = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 open(object url, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url, name);
			object returnItem = Invoker.MethodReturn(this, "open", paramsArray);
			NetOffice.MSHTMLApi.IHTMLWindow2 newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="url">optional string url = </param>
		/// <param name="name">optional string name = </param>
		/// <param name="features">optional string features = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public NetOffice.MSHTMLApi.IHTMLWindow2 open(object url, object name, object features)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url, name, features);
			object returnItem = Invoker.MethodReturn(this, "open", paramsArray);
			NetOffice.MSHTMLApi.IHTMLWindow2 newObject = Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSHTMLApi.IHTMLWindow2;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="url">string url</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void navigate(string url)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url);
			Invoker.Method(this, "navigate", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="dialog">string dialog</param>
		/// <param name="varArgIn">optional object varArgIn</param>
		/// <param name="varOptions">optional object varOptions</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object showModalDialog(string dialog, object varArgIn, object varOptions)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dialog, varArgIn, varOptions);
			object returnItem = Invoker.MethodReturn(this, "showModalDialog", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="dialog">string dialog</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public object showModalDialog(string dialog)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dialog);
			object returnItem = Invoker.MethodReturn(this, "showModalDialog", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="dialog">string dialog</param>
		/// <param name="varArgIn">optional object varArgIn</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public object showModalDialog(string dialog, object varArgIn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dialog, varArgIn);
			object returnItem = Invoker.MethodReturn(this, "showModalDialog", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="helpURL">string helpURL</param>
		/// <param name="helpArg">optional object helpArg</param>
		/// <param name="features">optional string features = </param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void showHelp(string helpURL, object helpArg, object features)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpURL, helpArg, features);
			Invoker.Method(this, "showHelp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="helpURL">string helpURL</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public void showHelp(string helpURL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpURL);
			Invoker.Method(this, "showHelp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="helpURL">string helpURL</param>
		/// <param name="helpArg">optional object helpArg</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public void showHelp(string helpURL, object helpArg)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpURL, helpArg);
			Invoker.Method(this, "showHelp", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void focus()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "focus", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void blur()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "blur", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void scroll(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "scroll", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		/// <param name="language">optional object language</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public Int32 setInterval(string expression, Int32 msec, object language)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec, language);
			object returnItem = Invoker.MethodReturn(this, "setInterval", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public Int32 setInterval(string expression, Int32 msec)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec);
			object returnItem = Invoker.MethodReturn(this, "setInterval", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="timerID">Int32 timerID</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void clearInterval(Int32 timerID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(timerID);
			Invoker.Method(this, "clearInterval", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="code">string code</param>
		/// <param name="language">optional string language = JScript</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public object execScript(string code, object language)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(code, language);
			object returnItem = Invoker.MethodReturn(this, "execScript", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="code">string code</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("MSHTML", 4)]
		public object execScript(string code)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(code);
			object returnItem = Invoker.MethodReturn(this, "execScript", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		[SupportByVersionAttribute("MSHTML", 4)]
		public string toString()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "toString", paramsArray);
			return NetRuntimeSystem.Convert.ToString(returnItem);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void scrollBy(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "scrollBy", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void scrollTo(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "scrollTo", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void moveTo(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "moveTo", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void moveBy(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "moveBy", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void resizeTo(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "resizeTo", paramsArray);
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByVersionAttribute("MSHTML", 4)]
		public void resizeBy(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "resizeBy", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}