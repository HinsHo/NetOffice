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
	/// DispatchInterface Signature SupportByLibrary Office, 10,11,12,14
	///</summary>
	[SupportByLibrary("Office", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Signature : _IMsoDispObj
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Signature);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Signature(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Signature(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Signature(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Signature() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Signature(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public string Signer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Signer", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public string Issuer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Issuer", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public object ExpireDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExpireDate", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public bool IsValid
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsValid", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public bool AttachCertificate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AttachCertificate", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AttachCertificate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
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
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public bool IsCertificateExpired
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsCertificateExpired", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public bool IsCertificateRevoked
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsCertificateRevoked", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public object SignDate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SignDate", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool IsSigned
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsSigned", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.SignatureInfo Details
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Details", paramsArray);
				NetOffice.OfficeApi.SignatureInfo newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SignatureInfo.LateBindingApiWrapperType) as NetOffice.OfficeApi.SignatureInfo;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool CanSetup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CanSetup", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.SignatureSetup Setup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Setup", paramsArray);
				NetOffice.OfficeApi.SignatureSetup newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.SignatureSetup.LateBindingApiWrapperType) as NetOffice.OfficeApi.SignatureSetup;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool IsSignatureLine
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsSignatureLine", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public COMObject SignatureLineShape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SignatureLineShape", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Int32 SortHint
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SortHint", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="varSigImg">optional object varSigImg</param>
		/// <param name="varDelSuggSigner">optional object varDelSuggSigner</param>
		/// <param name="varDelSuggSignerLine2">optional object varDelSuggSignerLine2</param>
		/// <param name="varDelSuggSignerEmail">optional object varDelSuggSignerEmail</param>
		[SupportByLibrary("Office", 12,14)]
		public void Sign(object varSigImg, object varDelSuggSigner, object varDelSuggSignerLine2, object varDelSuggSignerEmail)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varSigImg, varDelSuggSigner, varDelSuggSignerLine2, varDelSuggSignerEmail);
			Invoker.Method(this, "Sign", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public void Sign()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Sign", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public void ShowDetails()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ShowDetails", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}