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
	/// DispatchInterface OMathMat SupportByLibrary Word, 12,14
	///</summary>
	[SupportByLibrary("Word", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class OMathMat : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(OMathMat);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathMat(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathMat(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathMat(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathMat() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OMathMat(string progId) : base(progId)
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
		public NetOffice.WordApi.OMathMatRows Rows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Rows", paramsArray);
				NetOffice.WordApi.OMathMatRows newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.OMathMatRows.LateBindingApiWrapperType) as NetOffice.WordApi.OMathMatRows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.OMathMatCols Cols
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Cols", paramsArray);
				NetOffice.WordApi.OMathMatCols newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.OMathMatCols.LateBindingApiWrapperType) as NetOffice.WordApi.OMathMatCols;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get
		/// </summary>
		/// <param name="Row">Int32 Row</param>
		/// <param name="Col">Int32 Col</param>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.OMath get_Cell(Int32 row, Int32 col)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(row, col);
			object returnItem = Invoker.PropertyGet(this, "Cell", paramsArray);
			NetOffice.WordApi.OMath newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.OMath.LateBindingApiWrapperType) as NetOffice.WordApi.OMath;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Enums.WdOMathVertAlignType Align
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Align", paramsArray);
				return (NetOffice.WordApi.Enums.WdOMathVertAlignType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Align", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool PlcHoldHidden
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PlcHoldHidden", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PlcHoldHidden", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Enums.WdOMathSpacingRule RowSpacingRule
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowSpacingRule", paramsArray);
				return (NetOffice.WordApi.Enums.WdOMathSpacingRule)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RowSpacingRule", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public Int32 RowSpacing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowSpacing", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RowSpacing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public Int32 ColSpacing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColSpacing", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColSpacing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Enums.WdOMathSpacingRule ColGapRule
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColGapRule", paramsArray);
				return (NetOffice.WordApi.Enums.WdOMathSpacingRule)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColGapRule", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public Int32 ColGap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColGap", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ColGap", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}