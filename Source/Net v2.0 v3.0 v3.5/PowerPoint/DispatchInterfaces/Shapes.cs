//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Shapes SupportByLibrary PP09 PP10 PP11 PP12 PP14 
	///</summary>
	[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Shapes : COMObject ,IEnumerable
	{
		#pragma warning disable
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
		public Shapes()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
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
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
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
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
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
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
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
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState HasTitle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasTitle", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape Title
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Title", paramsArray);
				NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Placeholders Placeholders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Placeholders", paramsArray);
				NetOffice.PowerPointApi.Placeholders newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Placeholders;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.Shape this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.MsoCalloutType Type</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddCallout(NetOffice.OfficeApi.Enums.MsoCalloutType type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddCallout", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.MsoConnectorType Type</param>
		/// <param name="BeginX">Single BeginX</param>
		/// <param name="BeginY">Single BeginY</param>
		/// <param name="EndX">Single EndX</param>
		/// <param name="EndY">Single EndY</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddConnector(NetOffice.OfficeApi.Enums.MsoConnectorType type, Single beginX, Single beginY, Single endX, Single endY)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, beginX, beginY, endX, endY);
			object returnItem = Invoker.MethodReturn(this, "AddConnector", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="SafeArrayOfPoints">object SafeArrayOfPoints</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddCurve(object safeArrayOfPoints)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(safeArrayOfPoints);
			object returnItem = Invoker.MethodReturn(this, "AddCurve", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation Orientation</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddLabel(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(orientation, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddLabel", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="BeginX">Single BeginX</param>
		/// <param name="BeginY">Single BeginY</param>
		/// <param name="EndX">Single EndX</param>
		/// <param name="EndY">Single EndY</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddLine(Single beginX, Single beginY, Single endX, Single endY)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(beginX, beginY, endX, endY);
			object returnItem = Invoker.MethodReturn(this, "AddLine", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="LinkToFile">NetOffice.OfficeApi.Enums.MsoTriState LinkToFile</param>
		/// <param name="SaveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState SaveWithDocument</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddPicture(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddPicture", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="SafeArrayOfPoints">object SafeArrayOfPoints</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddPolyline(object safeArrayOfPoints)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(safeArrayOfPoints);
			object returnItem = Invoker.MethodReturn(this, "AddPolyline", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.MsoAutoShapeType Type</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddShape(NetOffice.OfficeApi.Enums.MsoAutoShapeType type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddShape", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="PresetTextEffect">NetOffice.OfficeApi.Enums.MsoPresetTextEffect PresetTextEffect</param>
		/// <param name="Text">string Text</param>
		/// <param name="FontName">string FontName</param>
		/// <param name="FontSize">Single FontSize</param>
		/// <param name="FontBold">NetOffice.OfficeApi.Enums.MsoTriState FontBold</param>
		/// <param name="FontItalic">NetOffice.OfficeApi.Enums.MsoTriState FontItalic</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddTextEffect(NetOffice.OfficeApi.Enums.MsoPresetTextEffect presetTextEffect, string text, string fontName, Single fontSize, NetOffice.OfficeApi.Enums.MsoTriState fontBold, NetOffice.OfficeApi.Enums.MsoTriState fontItalic, Single left, Single top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetTextEffect, text, fontName, fontSize, fontBold, fontItalic, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddTextEffect", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Orientation">NetOffice.OfficeApi.Enums.MsoTextOrientation Orientation</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddTextbox(NetOffice.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(orientation, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddTextbox", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="EditingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="X1">Single X1</param>
		/// <param name="Y1">Single Y1</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.FreeformBuilder BuildFreeform(NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(editingType, x1, y1);
			object returnItem = Invoker.MethodReturn(this, "BuildFreeform", paramsArray);
			NetOffice.PowerPointApi.FreeformBuilder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.FreeformBuilder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public void SelectAll()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SelectAll", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="index">optional object index</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.ShapeRange Range(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Range", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.ShapeRange Range()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Range", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddTitle()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AddTitle", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		/// <param name="ClassName">string ClassName</param>
		/// <param name="FileName">string FileName</param>
		/// <param name="DisplayAsIcon">NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon</param>
		/// <param name="IconFileName">string IconFileName</param>
		/// <param name="IconIndex">Int32 IconIndex</param>
		/// <param name="IconLabel">string IconLabel</param>
		/// <param name="Link">NetOffice.OfficeApi.Enums.MsoTriState Link</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddOLEObject(Single left, Single top, Single width, Single height, string className, string fileName, NetOffice.OfficeApi.Enums.MsoTriState displayAsIcon, string iconFileName, Int32 iconIndex, string iconLabel, NetOffice.OfficeApi.Enums.MsoTriState link)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height, className, fileName, displayAsIcon, iconFileName, iconIndex, iconLabel, link);
			object returnItem = Invoker.MethodReturn(this, "AddOLEObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddComment(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddComment", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Type">NetOffice.PowerPointApi.Enums.PpPlaceholderType Type</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddPlaceholder(NetOffice.PowerPointApi.Enums.PpPlaceholderType type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddPlaceholder", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddMediaObject(string fileName, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.ShapeRange Paste()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Paste", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="NumRows">Int32 NumRows</param>
		/// <param name="NumColumns">Int32 NumColumns</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddTable(Int32 numRows, Int32 numColumns, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRows, numColumns, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddTable", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="DataType">NetOffice.PowerPointApi.Enums.PpPasteDataType DataType</param>
		/// <param name="DisplayAsIcon">NetOffice.OfficeApi.Enums.MsoTriState DisplayAsIcon</param>
		/// <param name="IconFileName">string IconFileName</param>
		/// <param name="IconIndex">Int32 IconIndex</param>
		/// <param name="IconLabel">string IconLabel</param>
		/// <param name="Link">NetOffice.OfficeApi.Enums.MsoTriState Link</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.ShapeRange PasteSpecial(NetOffice.PowerPointApi.Enums.PpPasteDataType dataType, NetOffice.OfficeApi.Enums.MsoTriState displayAsIcon, string iconFileName, Int32 iconIndex, string iconLabel, NetOffice.OfficeApi.Enums.MsoTriState link)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataType, displayAsIcon, iconFileName, iconIndex, iconLabel, link);
			object returnItem = Invoker.MethodReturn(this, "PasteSpecial", paramsArray);
			NetOffice.PowerPointApi.ShapeRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.ShapeRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.MsoDiagramType Type</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddDiagram(NetOffice.OfficeApi.Enums.MsoDiagramType type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddDiagram", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddCanvas(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddCanvas", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		/// <param name="Type">NetOffice.OfficeApi.Enums.XlChartType Type</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.Shape AddChart(NetOffice.OfficeApi.Enums.XlChartType type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddChart", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="LinkToFile">NetOffice.OfficeApi.Enums.MsoTriState LinkToFile</param>
		/// <param name="SaveWithDocument">NetOffice.OfficeApi.Enums.MsoTriState SaveWithDocument</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP14")]
		public NetOffice.PowerPointApi.Shape AddMediaObject2(string fileName, NetOffice.OfficeApi.Enums.MsoTriState linkToFile, NetOffice.OfficeApi.Enums.MsoTriState saveWithDocument, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObject2", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="EmbedTag">string EmbedTag</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP14")]
		public NetOffice.PowerPointApi.Shape AddMediaObjectFromEmbedTag(string embedTag, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(embedTag, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddMediaObjectFromEmbedTag", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="Layout">NetOffice.OfficeApi.SmartArtLayout Layout</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("PP14")]
		public NetOffice.PowerPointApi.Shape AddSmartArt(NetOffice.OfficeApi.SmartArtLayout layout, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(layout, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddSmartArt", paramsArray);
			NetOffice.PowerPointApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.Shape;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
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