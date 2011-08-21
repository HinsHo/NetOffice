//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// Interface DocumentProperties SupportByLibrary Office, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Office", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class DocumentProperties : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(DocumentProperties);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DocumentProperties(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DocumentProperties(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DocumentProperties(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DocumentProperties() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DocumentProperties(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
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
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.DocumentProperty this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.DocumentProperty newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.DocumentProperty.LateBindingApiWrapperType) as NetOffice.OfficeApi.DocumentProperty;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public COMObject Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="LinkToContent">bool LinkToContent</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Value">optional object Value</param>
		/// <param name="LinkSource">optional object LinkSource</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.DocumentProperty Add(string name, bool linkToContent, object type, object value, object linkSource)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, linkToContent, type, value, linkSource);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.DocumentProperty newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.DocumentProperty.LateBindingApiWrapperType) as NetOffice.OfficeApi.DocumentProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="LinkToContent">bool LinkToContent</param>
		[SupportByLibrary("Office", 9,10,11,12,14)]
		public NetOffice.OfficeApi.DocumentProperty Add(string name, bool linkToContent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, linkToContent);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OfficeApi.DocumentProperty newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.DocumentProperty.LateBindingApiWrapperType) as NetOffice.OfficeApi.DocumentProperty;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("Office", 9,10,11,12,14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}