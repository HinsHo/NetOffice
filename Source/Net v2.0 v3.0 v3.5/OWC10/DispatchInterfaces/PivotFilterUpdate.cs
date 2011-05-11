//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface PivotFilterUpdate SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PivotFilterUpdate : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotFilterUpdate(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotFilterUpdate(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotFilterUpdate(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotFilterUpdate()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Member">NetOffice.OWC10Api.PivotMember Member</param>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.Enums.PivotFilterUpdateMemberStateEnum get_StateOf(NetOffice.OWC10Api.PivotMember member)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(member);
			object returnItem = Invoker.PropertyGet(this, "StateOf", paramsArray);
			return (NetOffice.OWC10Api.Enums.PivotFilterUpdateMemberStateEnum)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool IsDirty
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsDirty", paramsArray);
				return (bool)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Member">NetOffice.OWC10Api.PivotMember Member</param>
		[SupportByLibrary("XWC1.0")]
		public void Click(NetOffice.OWC10Api.PivotMember member)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(member);
			Invoker.Method(this, "Click", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Member">NetOffice.OWC10Api.PivotMember Member</param>
		/// <param name="OldMemberState">NetOffice.OWC10Api.Enums.PivotFilterUpdateMemberStateEnum OldMemberState</param>
		/// <param name="NewMemberState">NetOffice.OWC10Api.Enums.PivotFilterUpdateMemberStateEnum NewMemberState</param>
		[SupportByLibrary("XWC1.0")]
		public void ClickFromTo(NetOffice.OWC10Api.PivotMember member, NetOffice.OWC10Api.Enums.PivotFilterUpdateMemberStateEnum oldMemberState, NetOffice.OWC10Api.Enums.PivotFilterUpdateMemberStateEnum newMemberState)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(member, oldMemberState, newMemberState);
			Invoker.Method(this, "ClickFromTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void Apply()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Apply", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}