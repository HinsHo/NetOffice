//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Category SupportByLibrary Word, 12,14
	///</summary>
	[SupportByLibrary("Word", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Category : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Category);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Category(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Category(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Category(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Category() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Category(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
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
		/// SupportByLibrary Word 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.BuildingBlocks BuildingBlocks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BuildingBlocks", paramsArray);
				NetOffice.WordApi.BuildingBlocks newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.BuildingBlocks.LateBindingApiWrapperType) as NetOffice.WordApi.BuildingBlocks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.BuildingBlockType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				NetOffice.WordApi.BuildingBlockType newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.BuildingBlockType.LateBindingApiWrapperType) as NetOffice.WordApi.BuildingBlockType;
				return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}