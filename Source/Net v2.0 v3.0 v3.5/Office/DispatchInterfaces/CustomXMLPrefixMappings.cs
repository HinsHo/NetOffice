//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface CustomXMLPrefixMappings SupportByLibrary Office, 12,14
	///</summary>
	[SupportByLibrary("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CustomXMLPrefixMappings : _IMsoDispObj ,IEnumerable
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(CustomXMLPrefixMappings);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLPrefixMappings(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLPrefixMappings(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLPrefixMappings(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLPrefixMappings() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLPrefixMappings(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
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
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
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
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("Office", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.CustomXMLPrefixMapping this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.CustomXMLPrefixMapping newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLPrefixMapping.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLPrefixMapping;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Prefix">string Prefix</param>
		/// <param name="NamespaceURI">string NamespaceURI</param>
		[SupportByLibrary("Office", 12,14)]
		public void AddNamespace(string prefix, string namespaceURI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(prefix, namespaceURI);
			Invoker.Method(this, "AddNamespace", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="Prefix">string Prefix</param>
		[SupportByLibrary("Office", 12,14)]
		public string LookupNamespace(string prefix)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(prefix);
			object returnItem = Invoker.MethodReturn(this, "LookupNamespace", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="NamespaceURI">string NamespaceURI</param>
		[SupportByLibrary("Office", 12,14)]
		public string LookupPrefix(string namespaceURI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(namespaceURI);
			object returnItem = Invoker.MethodReturn(this, "LookupPrefix", paramsArray);
			return (string)returnItem;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("Office", 12,14)]
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