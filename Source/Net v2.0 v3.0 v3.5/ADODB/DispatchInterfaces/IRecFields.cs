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
	/// DispatchInterface IRecFields SupportByLibrary "ADODB", 2.5
	///</summary>
	[SupportByLibrary("ADODB", 2.5)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IRecFields : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRecFields(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRecFields(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRecFields(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IRecFields()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 2.5 
		/// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		public void ADOCheck()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ADOCheck", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}