using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using NetOffice;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Shapes 
	/// SupportByVersion PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Shapes : COMObject ,IEnumerable<NetOffice.PowerPointApi.Shape>
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
                    _type = typeof(Shapes);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shapes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shapes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shapes(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shapes() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Shapes(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public object Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
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
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
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
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState HasTitle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasTitle", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoTriState)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape Title
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Title", paramsArray);
				NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Placeholders Placeholders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Placeholders", paramsArray);
				NetOffice.PowerPointApi.Placeholders newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Placeholders.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Placeholders;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.Shape this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoCalloutType Type</param>
		/// <param name="left">Single Left</param>
		/// <param name="top">Single Top</param>
		/// <param name="width">Single Width</param>
		/// <param name="height">Single Height</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddCallout(NetOffice.OfficeApi.Enums.MsoCalloutType type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddCallout", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoConnectorType Type</param>
		/// <param name="beginX">Single BeginX</param>
		/// <param name="beginY">Single BeginY</param>
		/// <param name="endX">Single EndX</param>
		/// <param name="endY">Single EndY</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddConnector(NetOffice.OfficeApi.Enums.MsoConnectorType type, Single beginX, Single beginY, Single endX, Single endY)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, beginX, beginY, endX, endY);
			object returnItem = Invoker.MethodReturn(this, "AddConnector", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="safeArrayOfPoints">object SafeArrayOfPoints</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddCurve(object safeArrayOfPoints)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(safeArrayOfPoints);
			object returnItem = Invoker.MethodReturn(this, "AddCurve", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation Orientation</param>
		/// <param name="left">Single Left</param>
		/// <param name="top">Single Top</param>
		/// <param name="width">Single Width</param>
		/// <param name="height">Single Height</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddLabel(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(orientation, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddLabel", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="beginX">Single BeginX</param>
		/// <param name="beginY">Single BeginY</param>
		/// <param name="endX">Single EndX</param>
		/// <param name="endY">Single EndY</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddLine(Single beginX, Single beginY, Single endX, Single endY)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(beginX, beginY, endX, endY);
			object returnItem = Invoker.MethodReturn(this, "AddLine", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState LinkToFile</param>
		/// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState SaveWithDocument</param>
		/// <param name="left">Single Left</param>
		/// <param name="top">Single Top</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top, object width, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddPicture", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState LinkToFile</param>
		/// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState SaveWithDocument</param>
		/// <param name="left">Single Left</param>
		/// <param name="top">Single Top</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddPicture", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="linkToFile">NetOffice.OfficeApi.Enums.MsoTriState LinkToFile</param>
		/// <param name="saveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState SaveWithDocument</param>
		/// <param name="left">Single Left</param>
		/// <param name="top">Single Top</param>
		/// <param name="width">optional Single Width = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, left, top, width);
			object returnItem = Invoker.MethodReturn(this, "AddPicture", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="safeArrayOfPoints">object SafeArrayOfPoints</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddPolyline(object safeArrayOfPoints)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(safeArrayOfPoints);
			object returnItem = Invoker.MethodReturn(this, "AddPolyline", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoAutoShapeType Type</param>
		/// <param name="left">Single Left</param>
		/// <param name="top">Single Top</param>
		/// <param name="width">Single Width</param>
		/// <param name="height">Single Height</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddShape(NetOffice.OfficeApi.Enums.MsoAutoShapeType type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddShape", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="presetTextEffect">NetOffice.OfficeApi.Enums.MsoPresetTextEffect PresetTextEffect</param>
		/// <param name="text">string Text</param>
		/// <param name="fontName">string FontName</param>
		/// <param name="fontSize">Single FontSize</param>
		/// <param name="fontBold">NetOffice.OfficeApi.Enums.MsoTriState FontBold</param>
		/// <param name="fontItalic">NetOffice.OfficeApi.Enums.MsoTriState FontItalic</param>
		/// <param name="left">Single Left</param>
		/// <param name="top">Single Top</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddTextEffect(NetOffice.OfficeApi.Enums.MsoPresetTextEffect presetTextEffect, string text, string fontName, Single fontSize, NetOffice.OfficeApi.Enums.MsoTriState fontBold, NetOffice.OfficeApi.Enums.MsoTriState fontItalic, Single left, Single top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetTextEffect, text, fontName, fontSize, fontBold, fontItalic, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddTextEffect", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation Orientation</param>
		/// <param name="left">Single Left</param>
		/// <param name="top">Single Top</param>
		/// <param name="width">Single Width</param>
		/// <param name="height">Single Height</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddTextbox(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(orientation, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddTextbox", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="editingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="x1">Single X1</param>
		/// <param name="y1">Single Y1</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.FreeformBuilder BuildFreeform(NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(editingType, x1, y1);
			object returnItem = Invoker.MethodReturn(this, "BuildFreeform", paramsArray);
			NetOffice.PowerPointApi.FreeformBuilder newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.FreeformBuilder.LateBindingApiWrapperType) as NetOffice.PowerPointApi.FreeformBuilder;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public void SelectAll()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SelectAll", paramsArray);
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">optional object index</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.ShapeRange Range(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Range", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.ShapeRange Range()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Range", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddTitle()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddTitle", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		/// <param name="className">optional string ClassName = </param>
		/// <param name="fileName">optional string FileName = </param>
		/// <param name="displayAsIcon">optional NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon = 0</param>
		/// <param name="iconFileName">optional string IconFileName = </param>
		/// <param name="iconIndex">optional Int32 IconIndex = 0</param>
		/// <param name="iconLabel">optional string IconLabel = </param>
		/// <param name="link">optional NetOffice.OfficeApi.Enums.MsoTriState Link = 0</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject(object left, object top, object width, object height, object className, object fileName, object displayAsIcon, object iconFileName, object iconIndex, object iconLabel, object link)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height, className, fileName, displayAsIcon, iconFileName, iconIndex, iconLabel, link);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject(object left)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject(object left, object top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject(object left, object top, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject(object left, object top, object width, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		/// <param name="className">optional string ClassName = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject(object left, object top, object width, object height, object className)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height, className);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		/// <param name="className">optional string ClassName = </param>
		/// <param name="fileName">optional string FileName = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject(object left, object top, object width, object height, object className, object fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height, className, fileName);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		/// <param name="className">optional string ClassName = </param>
		/// <param name="fileName">optional string FileName = </param>
		/// <param name="displayAsIcon">optional NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject(object left, object top, object width, object height, object className, object fileName, object displayAsIcon)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height, className, fileName, displayAsIcon);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		/// <param name="className">optional string ClassName = </param>
		/// <param name="fileName">optional string FileName = </param>
		/// <param name="displayAsIcon">optional NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon = 0</param>
		/// <param name="iconFileName">optional string IconFileName = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject(object left, object top, object width, object height, object className, object fileName, object displayAsIcon, object iconFileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height, className, fileName, displayAsIcon, iconFileName);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		/// <param name="className">optional string ClassName = </param>
		/// <param name="fileName">optional string FileName = </param>
		/// <param name="displayAsIcon">optional NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon = 0</param>
		/// <param name="iconFileName">optional string IconFileName = </param>
		/// <param name="iconIndex">optional Int32 IconIndex = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject(object left, object top, object width, object height, object className, object fileName, object displayAsIcon, object iconFileName, object iconIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height, className, fileName, displayAsIcon, iconFileName, iconIndex);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		/// <param name="className">optional string ClassName = </param>
		/// <param name="fileName">optional string FileName = </param>
		/// <param name="displayAsIcon">optional NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon = 0</param>
		/// <param name="iconFileName">optional string IconFileName = </param>
		/// <param name="iconIndex">optional Int32 IconIndex = 0</param>
		/// <param name="iconLabel">optional string IconLabel = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddOLEObject(object left, object top, object width, object height, object className, object fileName, object displayAsIcon, object iconFileName, object iconIndex, object iconLabel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height, className, fileName, displayAsIcon, iconFileName, iconIndex, iconLabel);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 1.25</param>
		/// <param name="top">optional Single Top = 1.25</param>
		/// <param name="width">optional Single Width = 145.25</param>
		/// <param name="height">optional Single Height = 145.25</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddComment(object left, object top, object width, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddComment", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddComment()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddComment", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 1.25</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddComment(object left)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left);
			object returnItem = Invoker.MethodReturn(this, "AddComment", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 1.25</param>
		/// <param name="top">optional Single Top = 1.25</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddComment(object left, object top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top);
			object returnItem = Invoker.MethodReturn(this, "AddComment", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="left">optional Single Left = 1.25</param>
		/// <param name="top">optional Single Top = 1.25</param>
		/// <param name="width">optional Single Width = 145.25</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddComment(object left, object top, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width);
			object returnItem = Invoker.MethodReturn(this, "AddComment", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.PowerPointApi.Enums.PpPlaceholderType Type</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddPlaceholder(NetOffice.PowerPointApi.Enums.PpPlaceholderType type, object left, object top, object width, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddPlaceholder", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.PowerPointApi.Enums.PpPlaceholderType Type</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddPlaceholder(NetOffice.PowerPointApi.Enums.PpPlaceholderType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "AddPlaceholder", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.PowerPointApi.Enums.PpPlaceholderType Type</param>
		/// <param name="left">optional Single Left = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddPlaceholder(NetOffice.PowerPointApi.Enums.PpPlaceholderType type, object left)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left);
			object returnItem = Invoker.MethodReturn(this, "AddPlaceholder", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.PowerPointApi.Enums.PpPlaceholderType Type</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddPlaceholder(NetOffice.PowerPointApi.Enums.PpPlaceholderType type, object left, object top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddPlaceholder", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.PowerPointApi.Enums.PpPlaceholderType Type</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		/// <param name="width">optional Single Width = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddPlaceholder(NetOffice.PowerPointApi.Enums.PpPlaceholderType type, object left, object top, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width);
			object returnItem = Invoker.MethodReturn(this, "AddPlaceholder", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject(string fileName, object left, object top, object width, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="left">optional Single Left = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject(string fileName, object left)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, left);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject(string fileName, object left, object top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject(string fileName, object left, object top, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, left, top, width);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.ShapeRange Paste()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="numRows">Int32 NumRows</param>
		/// <param name="numColumns">Int32 NumColumns</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddTable(Int32 numRows, Int32 numColumns, object left, object top, object width, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRows, numColumns, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddTable", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="numRows">Int32 NumRows</param>
		/// <param name="numColumns">Int32 NumColumns</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddTable(Int32 numRows, Int32 numColumns)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRows, numColumns);
			object returnItem = Invoker.MethodReturn(this, "AddTable", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="numRows">Int32 NumRows</param>
		/// <param name="numColumns">Int32 NumColumns</param>
		/// <param name="left">optional Single Left = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddTable(Int32 numRows, Int32 numColumns, object left)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRows, numColumns, left);
			object returnItem = Invoker.MethodReturn(this, "AddTable", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="numRows">Int32 NumRows</param>
		/// <param name="numColumns">Int32 NumColumns</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddTable(Int32 numRows, Int32 numColumns, object left, object top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRows, numColumns, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddTable", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="numRows">Int32 NumRows</param>
		/// <param name="numColumns">Int32 NumColumns</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		/// <param name="width">optional Single Width = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddTable(Int32 numRows, Int32 numColumns, object left, object top, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRows, numColumns, left, top, width);
			object returnItem = Invoker.MethodReturn(this, "AddTable", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="dataType">optional NetOffice.PowerPointApi.Enums.PpPasteDataType DataType = 0</param>
		/// <param name="displayAsIcon">optional NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon = 0</param>
		/// <param name="iconFileName">optional string IconFileName = </param>
		/// <param name="iconIndex">optional Int32 IconIndex = 0</param>
		/// <param name="iconLabel">optional string IconLabel = </param>
		/// <param name="link">optional NetOffice.OfficeApi.Enums.MsoTriState Link = 0</param>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.ShapeRange PasteSpecial(object dataType, object displayAsIcon, object iconFileName, object iconIndex, object iconLabel, object link)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataType, displayAsIcon, iconFileName, iconIndex, iconLabel, link);
			object returnItem = Invoker.MethodReturn(this, "PasteSpecial", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.ShapeRange PasteSpecial()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PasteSpecial", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="dataType">optional NetOffice.PowerPointApi.Enums.PpPasteDataType DataType = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.ShapeRange PasteSpecial(object dataType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataType);
			object returnItem = Invoker.MethodReturn(this, "PasteSpecial", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="dataType">optional NetOffice.PowerPointApi.Enums.PpPasteDataType DataType = 0</param>
		/// <param name="displayAsIcon">optional NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.ShapeRange PasteSpecial(object dataType, object displayAsIcon)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataType, displayAsIcon);
			object returnItem = Invoker.MethodReturn(this, "PasteSpecial", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="dataType">optional NetOffice.PowerPointApi.Enums.PpPasteDataType DataType = 0</param>
		/// <param name="displayAsIcon">optional NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon = 0</param>
		/// <param name="iconFileName">optional string IconFileName = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.ShapeRange PasteSpecial(object dataType, object displayAsIcon, object iconFileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataType, displayAsIcon, iconFileName);
			object returnItem = Invoker.MethodReturn(this, "PasteSpecial", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="dataType">optional NetOffice.PowerPointApi.Enums.PpPasteDataType DataType = 0</param>
		/// <param name="displayAsIcon">optional NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon = 0</param>
		/// <param name="iconFileName">optional string IconFileName = </param>
		/// <param name="iconIndex">optional Int32 IconIndex = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.ShapeRange PasteSpecial(object dataType, object displayAsIcon, object iconFileName, object iconIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataType, displayAsIcon, iconFileName, iconIndex);
			object returnItem = Invoker.MethodReturn(this, "PasteSpecial", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="dataType">optional NetOffice.PowerPointApi.Enums.PpPasteDataType DataType = 0</param>
		/// <param name="displayAsIcon">optional NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon = 0</param>
		/// <param name="iconFileName">optional string IconFileName = </param>
		/// <param name="iconIndex">optional Int32 IconIndex = 0</param>
		/// <param name="iconLabel">optional string IconLabel = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.ShapeRange PasteSpecial(object dataType, object displayAsIcon, object iconFileName, object iconIndex, object iconLabel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataType, displayAsIcon, iconFileName, iconIndex, iconLabel);
			object returnItem = Invoker.MethodReturn(this, "PasteSpecial", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.ShapeRange.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="type">NetOffice.OfficeApi.Enums.MsoDiagramType Type</param>
		/// <param name="left">Single Left</param>
		/// <param name="top">Single Top</param>
		/// <param name="width">Single Width</param>
		/// <param name="height">Single Height</param>
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddDiagram(NetOffice.OfficeApi.Enums.MsoDiagramType type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddDiagram", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 10, 11, 12, 14
		/// </summary>
		/// <param name="left">Single Left</param>
		/// <param name="top">Single Top</param>
		/// <param name="width">Single Width</param>
		/// <param name="height">Single Height</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Shape AddCanvas(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddCanvas", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		[SupportByVersionAttribute("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.Shape AddChart(object type, object left, object top, object width, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddChart", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.Shape AddChart()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddChart", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.Shape AddChart(object type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "AddChart", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
		/// <param name="left">optional Single Left = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.Shape AddChart(object type, object left)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left);
			object returnItem = Invoker.MethodReturn(this, "AddChart", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.Shape AddChart(object type, object left, object top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddChart", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 12, 14
		/// </summary>
		/// <param name="type">optional NetOffice.OfficeApi.Enums.XlChartType Type = -1</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		/// <param name="width">optional Single Width = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.Shape AddChart(object type, object left, object top, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width);
			object returnItem = Invoker.MethodReturn(this, "AddChart", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="linkToFile">optional NetOffice.OfficeApi.Enums.MsoTriState LinkToFile = 0</param>
		/// <param name="saveWithDocument">optional NetOffice.OfficeApi.Enums.MsoTriState SaveWithDocument = -1</param>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject2(string fileName, object linkToFile, object saveWithDocument, object left, object top, object width, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject2", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject2(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject2", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="linkToFile">optional NetOffice.OfficeApi.Enums.MsoTriState LinkToFile = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject2(string fileName, object linkToFile)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject2", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="linkToFile">optional NetOffice.OfficeApi.Enums.MsoTriState LinkToFile = 0</param>
		/// <param name="saveWithDocument">optional NetOffice.OfficeApi.Enums.MsoTriState SaveWithDocument = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject2(string fileName, object linkToFile, object saveWithDocument)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject2", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="linkToFile">optional NetOffice.OfficeApi.Enums.MsoTriState LinkToFile = 0</param>
		/// <param name="saveWithDocument">optional NetOffice.OfficeApi.Enums.MsoTriState SaveWithDocument = -1</param>
		/// <param name="left">optional Single Left = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject2(string fileName, object linkToFile, object saveWithDocument, object left)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, left);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject2", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="linkToFile">optional NetOffice.OfficeApi.Enums.MsoTriState LinkToFile = 0</param>
		/// <param name="saveWithDocument">optional NetOffice.OfficeApi.Enums.MsoTriState SaveWithDocument = -1</param>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject2(string fileName, object linkToFile, object saveWithDocument, object left, object top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject2", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="linkToFile">optional NetOffice.OfficeApi.Enums.MsoTriState LinkToFile = 0</param>
		/// <param name="saveWithDocument">optional NetOffice.OfficeApi.Enums.MsoTriState SaveWithDocument = -1</param>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObject2(string fileName, object linkToFile, object saveWithDocument, object left, object top, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, left, top, width);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject2", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="embedTag">string EmbedTag</param>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObjectFromEmbedTag(string embedTag, object left, object top, object width, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(embedTag, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObjectFromEmbedTag", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="embedTag">string EmbedTag</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObjectFromEmbedTag(string embedTag)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(embedTag);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObjectFromEmbedTag", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="embedTag">string EmbedTag</param>
		/// <param name="left">optional Single Left = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObjectFromEmbedTag(string embedTag, object left)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(embedTag, left);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObjectFromEmbedTag", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="embedTag">string EmbedTag</param>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObjectFromEmbedTag(string embedTag, object left, object top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(embedTag, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObjectFromEmbedTag", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="embedTag">string EmbedTag</param>
		/// <param name="left">optional Single Left = 0</param>
		/// <param name="top">optional Single Top = 0</param>
		/// <param name="width">optional Single Width = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddMediaObjectFromEmbedTag(string embedTag, object left, object top, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(embedTag, left, top, width);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObjectFromEmbedTag", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="layout">NetOffice.OfficeApi.SmartArtLayout Layout</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		/// <param name="width">optional Single Width = -1</param>
		/// <param name="height">optional Single Height = -1</param>
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout, object left, object top, object width, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(layout, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddSmartArt", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="layout">NetOffice.OfficeApi.SmartArtLayout Layout</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(layout);
			object returnItem = Invoker.MethodReturn(this, "AddSmartArt", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="layout">NetOffice.OfficeApi.SmartArtLayout Layout</param>
		/// <param name="left">optional Single Left = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout, object left)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(layout, left);
			object returnItem = Invoker.MethodReturn(this, "AddSmartArt", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="layout">NetOffice.OfficeApi.SmartArtLayout Layout</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout, object left, object top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(layout, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddSmartArt", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14
		/// </summary>
		/// <param name="layout">NetOffice.OfficeApi.SmartArtLayout Layout</param>
		/// <param name="left">optional Single Left = -1</param>
		/// <param name="top">optional Single Top = -1</param>
		/// <param name="width">optional Single Width = -1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("PowerPoint", 14)]
		public NetOffice.PowerPointApi.Shape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout, object left, object top, object width)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(layout, left, top, width);
			object returnItem = Invoker.MethodReturn(this, "AddSmartArt", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.Shape.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.PowerPointApi.Shape> Member
        
        /// <summary>
		/// SupportByVersionAttribute PowerPoint, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
       public IEnumerator<NetOffice.PowerPointApi.Shape> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.PowerPointApi.Shape item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute PowerPoint, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return NetOffice.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}