//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface ColorScale SupportByLibrary Excel, 12,14
	///</summary>
	[SupportByLibrary("Excel", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ColorScale : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ColorScale(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ColorScale(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ColorScale(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ColorScale()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
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
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
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
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
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
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public Int32 Priority
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Priority", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Priority", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public bool StopIfTrue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StopIfTrue", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Range AppliesTo
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AppliesTo", paramsArray);
				NetOffice.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public string Formula
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Formula", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Formula", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public Int32 Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public bool PTCondition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PTCondition", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.Enums.XlPivotConditionScope ScopeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScopeType", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlPivotConditionScope)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ScopeType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public NetOffice.ExcelApi.ColorScaleCriteria ColorScaleCriteria
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColorScaleCriteria", paramsArray);
				NetOffice.ExcelApi.ColorScaleCriteria newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.ColorScaleCriteria;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public void SetFirstPriority()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetFirstPriority", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public void SetLastPriority()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetLastPriority", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibrary("Excel", 12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.ExcelApi.Range Range</param>
		[SupportByLibrary("Excel", 12,14)]
		public void ModifyAppliesToRange(NetOffice.ExcelApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			Invoker.Method(this, "ModifyAppliesToRange", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}