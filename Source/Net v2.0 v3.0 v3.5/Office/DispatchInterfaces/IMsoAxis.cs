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
	/// DispatchInterface IMsoAxis SupportByLibrary Office, 12,14
	///</summary>
	[SupportByLibrary("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IMsoAxis : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IMsoAxis);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMsoAxis(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMsoAxis(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMsoAxis(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMsoAxis() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMsoAxis(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool AxisBetweenCategories
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AxisBetweenCategories", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AxisBetweenCategories", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlAxisGroup AxisGroup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AxisGroup", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlAxisGroup)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoAxisTitle AxisTitle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AxisTitle", paramsArray);
				NetOffice.OfficeApi.IMsoAxisTitle newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.IMsoAxisTitle.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoAxisTitle;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public object CategoryNames
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CategoryNames", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CategoryNames", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlAxisCrosses Crosses
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Crosses", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlAxisCrosses)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Crosses", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Double CrossesAt
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CrossesAt", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CrossesAt", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool HasMajorGridlines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasMajorGridlines", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasMajorGridlines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool HasMinorGridlines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasMinorGridlines", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasMinorGridlines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool HasTitle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasTitle", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasTitle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.GridLines MajorGridlines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MajorGridlines", paramsArray);
				NetOffice.OfficeApi.GridLines newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.GridLines.LateBindingApiWrapperType) as NetOffice.OfficeApi.GridLines;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlTickMark MajorTickMark
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MajorTickMark", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlTickMark)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MajorTickMark", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Double MajorUnit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MajorUnit", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MajorUnit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Double LogBase
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LogBase", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LogBase", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool TickLabelSpacingIsAuto
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TickLabelSpacingIsAuto", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TickLabelSpacingIsAuto", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool MajorUnitIsAuto
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MajorUnitIsAuto", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MajorUnitIsAuto", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Double MaximumScale
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaximumScale", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaximumScale", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool MaximumScaleIsAuto
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaximumScaleIsAuto", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaximumScaleIsAuto", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Double MinimumScale
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MinimumScale", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MinimumScale", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool MinimumScaleIsAuto
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MinimumScaleIsAuto", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MinimumScaleIsAuto", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.GridLines MinorGridlines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MinorGridlines", paramsArray);
				NetOffice.OfficeApi.GridLines newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.GridLines.LateBindingApiWrapperType) as NetOffice.OfficeApi.GridLines;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlTickMark MinorTickMark
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MinorTickMark", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlTickMark)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MinorTickMark", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Double MinorUnit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MinorUnit", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MinorUnit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool MinorUnitIsAuto
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MinorUnitIsAuto", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MinorUnitIsAuto", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool ReversePlotOrder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReversePlotOrder", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReversePlotOrder", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlScaleType ScaleType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScaleType", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlScaleType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ScaleType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlTickLabelPosition TickLabelPosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TickLabelPosition", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlTickLabelPosition)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TickLabelPosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoTickLabels TickLabels
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TickLabels", paramsArray);
				NetOffice.OfficeApi.IMsoTickLabels newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.IMsoTickLabels.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoTickLabels;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Int32 TickLabelSpacing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TickLabelSpacing", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TickLabelSpacing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Int32 TickMarkSpacing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TickMarkSpacing", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TickMarkSpacing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlAxisType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlAxisType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlTimeUnit BaseUnit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaseUnit", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlTimeUnit)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BaseUnit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool BaseUnitIsAuto
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaseUnitIsAuto", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BaseUnitIsAuto", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlTimeUnit MajorUnitScale
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MajorUnitScale", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlTimeUnit)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MajorUnitScale", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlTimeUnit MinorUnitScale
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MinorUnitScale", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlTimeUnit)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MinorUnitScale", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlCategoryType CategoryType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CategoryType", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlCategoryType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CategoryType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Double Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Double Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Double Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Double Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.XlDisplayUnit DisplayUnit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayUnit", paramsArray);
				return (NetOffice.OfficeApi.Enums.XlDisplayUnit)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayUnit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public Double DisplayUnitCustom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayUnitCustom", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayUnitCustom", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public bool HasDisplayUnitLabel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasDisplayUnitLabel", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasDisplayUnitLabel", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoDisplayUnitLabel DisplayUnitLabel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayUnitLabel", paramsArray);
				NetOffice.OfficeApi.IMsoDisplayUnitLabel newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.IMsoDisplayUnitLabel.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoDisplayUnitLabel;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoBorder Border
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Border", paramsArray);
				NetOffice.OfficeApi.IMsoBorder newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.IMsoBorder.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoBorder;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
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
		/// SupportByLibrary Office 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public NetOffice.OfficeApi.IMsoChartFormat Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				NetOffice.OfficeApi.IMsoChartFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.IMsoChartFormat.LateBindingApiWrapperType) as NetOffice.OfficeApi.IMsoChartFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 14)]
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
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibrary("Office", 14)]
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

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public object Delete()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Delete", paramsArray);
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

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		[SupportByLibrary("Office", 12,14)]
		public object Select()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Select", paramsArray);
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

		#endregion
		#pragma warning restore
	}
}