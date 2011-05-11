//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface SearchScope SupportByLibrary OF10 OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF10","OF11","OF12","OF14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SearchScope : _IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SearchScope(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SearchScope(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SearchScope(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SearchScope()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoSearchIn Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoSearchIn)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.ScopeFolder ScopeFolder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScopeFolder", paramsArray);
				NetOffice.OfficeApi.ScopeFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.ScopeFolder;
				return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}