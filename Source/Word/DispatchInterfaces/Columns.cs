using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Columns 
	/// SupportByVersion Word, 9,10,11,12,14,15
	/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821526.aspx
	///</summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Columns : COMObject ,IEnumerable<NetOffice.WordApi.Column>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Columns);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public Columns(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Columns(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197165.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192580.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff835674.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff840886.aspx
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837342.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Column First
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "First", paramsArray);
				NetOffice.WordApi.Column newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Column.LateBindingApiWrapperType) as NetOffice.WordApi.Column;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff195612.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Column Last
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Last", paramsArray);
				NetOffice.WordApi.Column newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Column.LateBindingApiWrapperType) as NetOffice.WordApi.Column;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff844824.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff192793.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Borders Borders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Borders", paramsArray);
				NetOffice.WordApi.Borders newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Borders.LateBindingApiWrapperType) as NetOffice.WordApi.Borders;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Borders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff822974.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Shading Shading
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shading", paramsArray);
				NetOffice.WordApi.Shading newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Shading.LateBindingApiWrapperType) as NetOffice.WordApi.Shading;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff197186.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Int32 NestingLevel
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NestingLevel", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff820773.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public Single PreferredWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreferredWidth", paramsArray);
				return NetRuntimeSystem.Convert.ToSingle(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PreferredWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// Get/Set
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193039.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Enums.WdPreferredWidthType PreferredWidthType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreferredWidthType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdPreferredWidthType)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PreferredWidthType", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// 
		/// </summary>
		/// <param name="index">Int32 Index</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.Column this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.Column newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Column.LateBindingApiWrapperType) as NetOffice.WordApi.Column;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837258.aspx
		/// </summary>
		/// <param name="beforeColumn">optional object BeforeColumn</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Column Add(object beforeColumn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(beforeColumn);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Column newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Column.LateBindingApiWrapperType) as NetOffice.WordApi.Column;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff837258.aspx
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public NetOffice.WordApi.Column Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Column newObject = Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Column.LateBindingApiWrapperType) as NetOffice.WordApi.Column;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff193705.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839901.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff194545.aspx
		/// </summary>
		/// <param name="columnWidth">Single ColumnWidth</param>
		/// <param name="rulerStyle">NetOffice.WordApi.Enums.WdRulerStyle RulerStyle</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void SetWidth(Single columnWidth, NetOffice.WordApi.Enums.WdRulerStyle rulerStyle)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(columnWidth, rulerStyle);
			Invoker.Method(this, "SetWidth", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff839707.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void AutoFit()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AutoFit", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14, 15
		/// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff823264.aspx
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		public void DistributeWidth()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "DistributeWidth", paramsArray);
		}

		#endregion

       #region IEnumerable<NetOffice.WordApi.Column> Member
        
        /// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
       public IEnumerator<NetOffice.WordApi.Column> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.WordApi.Column item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14,15
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14,15)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}