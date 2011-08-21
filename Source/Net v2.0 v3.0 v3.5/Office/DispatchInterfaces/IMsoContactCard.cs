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
	/// DispatchInterface IMsoContactCard SupportByLibrary Office, 14
	///</summary>
	[SupportByLibrary("Office", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IMsoContactCard : _IMsoDispObj
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IMsoContactCard);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMsoContactCard(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMsoContactCard(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMsoContactCard(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMsoContactCard() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMsoContactCard(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public string Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Address", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public NetOffice.OfficeApi.Enums.MsoContactCardAddressType AddressType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoContactCardAddressType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 14)]
		public NetOffice.OfficeApi.Enums.MsoContactCardType CardType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CardType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoContactCardType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 14)]
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

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}