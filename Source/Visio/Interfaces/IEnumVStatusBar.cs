using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// Interface IEnumVStatusBar 
	/// SupportByVersion Visio, 11,12,14,15
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IEnumVStatusBar : COMObject
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
                    _type = typeof(IEnumVStatusBar);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IEnumVStatusBar(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumVStatusBar(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumVStatusBar(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumVStatusBar(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumVStatusBar(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumVStatusBar() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IEnumVStatusBar(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="celt">Int32 celt</param>
		/// <param name="rgelt">NetOffice.VisioApi.IVStatusBar rgelt</param>
		/// <param name="pceltFetched">Int32 pceltFetched</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int32 Next(Int32 celt, out NetOffice.VisioApi.IVStatusBar rgelt, out Int32 pceltFetched)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true);
			rgelt = null;
			pceltFetched = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(celt, rgelt, pceltFetched);
			object returnItem = Invoker.MethodReturn(this, "Next", paramsArray);
			rgelt = (NetOffice.VisioApi.IVStatusBar)paramsArray[1];
			pceltFetched = (Int32)paramsArray[2];
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="celt">Int32 celt</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int32 Skip(Int32 celt)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(celt);
			object returnItem = Invoker.MethodReturn(this, "Skip", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// 
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int32 Reset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Reset", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="ppenm">NetOffice.VisioApi.IEnumVStatusBar ppenm</param>
		[SupportByVersionAttribute("Visio", 11,12,14,15)]
		public Int32 Clone(out NetOffice.VisioApi.IEnumVStatusBar ppenm)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			ppenm = null;
			object[] paramsArray = Invoker.ValidateParamsArray(ppenm);
			object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray);
			ppenm = (NetOffice.VisioApi.IEnumVStatusBar)paramsArray[0];
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}