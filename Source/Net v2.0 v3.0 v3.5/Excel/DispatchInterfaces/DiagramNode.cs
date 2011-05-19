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
	/// DispatchInterface DiagramNode SupportByLibrary "Excel", 10,11,12,14
	///</summary>
	[SupportByLibrary("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DiagramNode : NetOffice.OfficeApi._IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
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
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.DiagramNodeChildren Children
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Children", paramsArray);
				NetOffice.ExcelApi.DiagramNodeChildren newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.DiagramNodeChildren;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Shape Shape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shape", paramsArray);
				NetOffice.ExcelApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.DiagramNode Root
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Root", paramsArray);
				NetOffice.ExcelApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.DiagramNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.OfficeApi.IMsoDiagram Diagram
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Diagram", paramsArray);
				NetOffice.OfficeApi.IMsoDiagram newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.IMsoDiagram;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType Layout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Layout", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Layout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.Shape TextShape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextShape", paramsArray);
				NetOffice.ExcelApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Shape;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="pos">NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos</param>
		/// <param name="nodeType">NetOffice.OfficeApi.Enums.MsoDiagramNodeType nodeType</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.DiagramNode AddNode(NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos, NetOffice.OfficeApi.Enums.MsoDiagramNodeType nodeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pos, nodeType);
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.ExcelApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="pTargetNode">NetOffice.ExcelApi.DiagramNode pTargetNode</param>
		/// <param name="pos">NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void MoveNode(NetOffice.ExcelApi.DiagramNode pTargetNode, NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pTargetNode, pos);
			Invoker.Method(this, "MoveNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="pTargetNode">NetOffice.ExcelApi.DiagramNode pTargetNode</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void ReplaceNode(NetOffice.ExcelApi.DiagramNode pTargetNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pTargetNode);
			Invoker.Method(this, "ReplaceNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="pTargetNode">NetOffice.ExcelApi.DiagramNode pTargetNode</param>
		/// <param name="swapChildren">bool swapChildren</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void SwapNode(NetOffice.ExcelApi.DiagramNode pTargetNode, bool swapChildren)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pTargetNode, swapChildren);
			Invoker.Method(this, "SwapNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="copyChildren">bool copyChildren</param>
		/// <param name="pTargetNode">NetOffice.ExcelApi.DiagramNode pTargetNode</param>
		/// <param name="pos">NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.DiagramNode CloneNode(bool copyChildren, NetOffice.ExcelApi.DiagramNode pTargetNode, NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(copyChildren, pTargetNode, pos);
			object returnItem = Invoker.MethodReturn(this, "CloneNode", paramsArray);
			NetOffice.ExcelApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		/// <param name="pReceivingNode">NetOffice.ExcelApi.DiagramNode pReceivingNode</param>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public void TransferChildren(NetOffice.ExcelApi.DiagramNode pReceivingNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pReceivingNode);
			Invoker.Method(this, "TransferChildren", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.DiagramNode NextNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NextNode", paramsArray);
			NetOffice.ExcelApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 10 11 12 14 
		/// </summary>
		[SupportByLibrary("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.DiagramNode PrevNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PrevNode", paramsArray);
			NetOffice.ExcelApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.DiagramNode;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}