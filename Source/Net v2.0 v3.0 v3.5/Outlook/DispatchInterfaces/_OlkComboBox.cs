//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _OlkComboBox SupportByLibrary Outlook, 12,14
	///</summary>
	[SupportByLibrary("Outlook", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _OlkComboBox : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_OlkComboBox);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _OlkComboBox(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _OlkComboBox(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _OlkComboBox(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _OlkComboBox() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _OlkComboBox(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public bool AutoSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoSize", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public bool AutoTab
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoTab", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoTab", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public bool AutoWordSelect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoWordSelect", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoWordSelect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public Int32 BackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackColor", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlBorderStyle BorderStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BorderStyle", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlBorderStyle)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BorderStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlDragBehavior DragBehavior
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DragBehavior", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlDragBehavior)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DragBehavior", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public bool Enabled
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enabled", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Enabled", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlEnterFieldBehavior EnterFieldBehavior
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnterFieldBehavior", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlEnterFieldBehavior)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnterFieldBehavior", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public stdole.Font Font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Font", paramsArray);
				stdole.Font newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Font;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public Int32 ForeColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForeColor", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ForeColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public bool HideSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HideSelection", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HideSelection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public bool Locked
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Locked", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Locked", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public Int32 MaxLength
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaxLength", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaxLength", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public stdole.Picture MouseIcon
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MouseIcon", paramsArray);
				stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Picture;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MouseIcon", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlMousePointer MousePointer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MousePointer", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlMousePointer)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MousePointer", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public bool SelectionMargin
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelectionMargin", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelectionMargin", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlComboBoxStyle Style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Style", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlComboBoxStyle)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Style", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlTextAlign TextAlign
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextAlign", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlTextAlign)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TextAlign", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public Int32 TopIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TopIndex", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TopIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public object Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
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
				Invoker.PropertySet(this, "Value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public Int32 ListIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListIndex", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ListIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public Int32 ListCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public Int32 SelStart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelStart", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelStart", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public Int32 SelLength
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelLength", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SelLength", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public string SelText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SelText", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("Outlook", 12,14)]
		public string GetItem(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "GetItem", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		/// <param name="Item">string Item</param>
		[SupportByLibrary("Outlook", 12,14)]
		public void SetItem(Int32 index, string item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, item);
			Invoker.Method(this, "SetItem", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public void Paste()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Paste", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="ItemText">string ItemText</param>
		/// <param name="Index">optional object Index</param>
		[SupportByLibrary("Outlook", 12,14)]
		public void AddItem(string itemText, object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(itemText, index);
			Invoker.Method(this, "AddItem", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="ItemText">string ItemText</param>
		[SupportByLibrary("Outlook", 12,14)]
		public void AddItem(string itemText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(itemText);
			Invoker.Method(this, "AddItem", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("Outlook", 12,14)]
		public void RemoveItem(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "RemoveItem", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public void DropDown()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "DropDown", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}