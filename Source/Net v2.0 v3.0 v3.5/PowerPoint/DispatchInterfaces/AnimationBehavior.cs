//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface AnimationBehavior SupportByLibrary PowerPoint, 10,11,12,14
	///</summary>
	[SupportByLibrary("PowerPoint", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class AnimationBehavior : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(AnimationBehavior);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AnimationBehavior(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AnimationBehavior(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AnimationBehavior(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AnimationBehavior() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AnimationBehavior(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
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
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Enums.MsoAnimAdditive Additive
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Additive", paramsArray);
				return (NetOffice.PowerPointApi.Enums.MsoAnimAdditive)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Additive", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Enums.MsoAnimAccumulate Accumulate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Accumulate", paramsArray);
				return (NetOffice.PowerPointApi.Enums.MsoAnimAccumulate)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Accumulate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Enums.MsoAnimType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.PowerPointApi.Enums.MsoAnimType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.MotionEffect MotionEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MotionEffect", paramsArray);
				NetOffice.PowerPointApi.MotionEffect newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.MotionEffect.LateBindingApiWrapperType) as NetOffice.PowerPointApi.MotionEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.ColorEffect ColorEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColorEffect", paramsArray);
				NetOffice.PowerPointApi.ColorEffect newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ColorEffect.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ColorEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.ScaleEffect ScaleEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScaleEffect", paramsArray);
				NetOffice.PowerPointApi.ScaleEffect newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ScaleEffect.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ScaleEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.RotationEffect RotationEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RotationEffect", paramsArray);
				NetOffice.PowerPointApi.RotationEffect newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.RotationEffect.LateBindingApiWrapperType) as NetOffice.PowerPointApi.RotationEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.PropertyEffect PropertyEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyEffect", paramsArray);
				NetOffice.PowerPointApi.PropertyEffect newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.PropertyEffect.LateBindingApiWrapperType) as NetOffice.PowerPointApi.PropertyEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.Timing Timing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Timing", paramsArray);
				NetOffice.PowerPointApi.Timing newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Timing.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Timing;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.CommandEffect CommandEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandEffect", paramsArray);
				NetOffice.PowerPointApi.CommandEffect newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.CommandEffect.LateBindingApiWrapperType) as NetOffice.PowerPointApi.CommandEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.FilterEffect FilterEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FilterEffect", paramsArray);
				NetOffice.PowerPointApi.FilterEffect newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.FilterEffect.LateBindingApiWrapperType) as NetOffice.PowerPointApi.FilterEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public NetOffice.PowerPointApi.SetEffect SetEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SetEffect", paramsArray);
				NetOffice.PowerPointApi.SetEffect newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.SetEffect.LateBindingApiWrapperType) as NetOffice.PowerPointApi.SetEffect;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}