//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface ListObjects SupportByLibrary "Excel", 11,12,14
	///</summary>
	[SupportByLibrary("Excel", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ListObjects : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObjects(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObjects(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObjects(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObjects()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
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
		/// SupportByLibrary 11 12 14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public NetOffice.ExcelApi.ListObject get__Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 11 12 14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("Excel", 11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.ListObject this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.ListObject;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 11 
		/// </summary>
		/// <param name="SourceType">NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType</param>
		/// <param name="Source">object Source</param>
		/// <param name="LinkSource">object LinkSource</param>
		/// <param name="XlListObjectHasHeaders">NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders</param>
		/// <param name="Destination">optional object Destination</param>
		[SupportByLibrary("Excel", 11)]
		public NetOffice.ExcelApi.ListObject Add(NetOffice.ExcelApi.Enums.XlListObjectSourceType sourceType, object source, object linkSource, NetOffice.ExcelApi.Enums.XlYesNoGuess xlListObjectHasHeaders, object destination)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders, destination);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="SourceType">NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType</param>
		/// <param name="Source">object Source</param>
		/// <param name="LinkSource">object LinkSource</param>
		/// <param name="XlListObjectHasHeaders">NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders</param>
		/// <param name="Destination">optional object Destination</param>
		/// <param name="TableStyleName">optional object TableStyleName</param>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.ListObject Add(NetOffice.ExcelApi.Enums.XlListObjectSourceType sourceType, object source, object linkSource, NetOffice.ExcelApi.Enums.XlYesNoGuess xlListObjectHasHeaders, object destination, object tableStyleName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders, destination, tableStyleName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 11 12 14 
		/// </summary>
		/// <param name="SourceType">NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType</param>
		/// <param name="Source">object Source</param>
		/// <param name="LinkSource">object LinkSource</param>
		/// <param name="XlListObjectHasHeaders">NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders</param>
		[SupportByLibrary("Excel", 11,12,14)]
		public NetOffice.ExcelApi.ListObject Add(NetOffice.ExcelApi.Enums.XlListObjectSourceType sourceType, object source, object linkSource, NetOffice.ExcelApi.Enums.XlYesNoGuess xlListObjectHasHeaders)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="SourceType">NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType</param>
		/// <param name="Source">object Source</param>
		/// <param name="LinkSource">object LinkSource</param>
		/// <param name="XlListObjectHasHeaders">NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders</param>
		/// <param name="Destination">optional object Destination</param>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.ListObject _Add(NetOffice.ExcelApi.Enums.XlListObjectSourceType sourceType, object source, object linkSource, NetOffice.ExcelApi.Enums.XlYesNoGuess xlListObjectHasHeaders, object destination)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders, destination);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="SourceType">NetOffice.ExcelApi.Enums.XlListObjectSourceType SourceType</param>
		/// <param name="Source">object Source</param>
		/// <param name="LinkSource">object LinkSource</param>
		/// <param name="XlListObjectHasHeaders">NetOffice.ExcelApi.Enums.XlYesNoGuess XlListObjectHasHeaders</param>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.ListObject _Add(NetOffice.ExcelApi.Enums.XlListObjectSourceType sourceType, object source, object linkSource, NetOffice.ExcelApi.Enums.XlYesNoGuess xlListObjectHasHeaders)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceType, source, linkSource, xlListObjectHasHeaders);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.ExcelApi.ListObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.ListObject;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("Excel", 11,12,14)]
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