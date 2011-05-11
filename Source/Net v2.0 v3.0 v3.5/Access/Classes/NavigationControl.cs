//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void NavigationControl_BeforeUpdateEventHandler(ref Int16 Cancel);
	public delegate void NavigationControl_AfterUpdateEventHandler();
	public delegate void NavigationControl_ChangeEventHandler();
	public delegate void NavigationControl_EnterEventHandler();
	public delegate void NavigationControl_ExitEventHandler(ref Int16 Cancel);
	public delegate void NavigationControl_GotFocusEventHandler();
	public delegate void NavigationControl_LostFocusEventHandler();
	public delegate void NavigationControl_ClickEventHandler();
	public delegate void NavigationControl_DblClickEventHandler(ref Int16 Cancel);
	public delegate void NavigationControl_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void NavigationControl_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void NavigationControl_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void NavigationControl_KeyDownEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void NavigationControl_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void NavigationControl_KeyUpEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void NavigationControl_DirtyEventHandler(ref Int16 Cancel);
	public delegate void NavigationControl_UndoEventHandler(ref Int16 Cancel);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass NavigationControl SupportByLibrary AC14 
	///</summary>
	[SupportByLibrary("AC14")]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class NavigationControl : _NavigationControl, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		DispNavigationControlEvents_SinkHelper _dispNavigationControlEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NavigationControl(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NavigationControl(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public NavigationControl(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public NavigationControl()
		{
			CreateFromProgId("Access.NavigationControl");
		}
		
		/// <param name="progId">progId</param>
		public NavigationControl(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, DispNavigationControlEvents_SinkHelper.Id);


			if(DispNavigationControlEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dispNavigationControlEvents_SinkHelper = new DispNavigationControlEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_BeforeUpdateEventHandler _BeforeUpdateEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_BeforeUpdateEventHandler BeforeUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeUpdateEvent += value;
			}
			remove
			{
				_BeforeUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_AfterUpdateEventHandler _AfterUpdateEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_AfterUpdateEventHandler AfterUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_AfterUpdateEvent += value;
			}
			remove
			{
				_AfterUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_ChangeEventHandler ChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ChangeEvent += value;
			}
			remove
			{
				_ChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_EnterEventHandler _EnterEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_EnterEventHandler EnterEvent
		{
			add
			{
				CreateEventBridge();
				_EnterEvent += value;
			}
			remove
			{
				_EnterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_ExitEventHandler _ExitEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_ExitEventHandler ExitEvent
		{
			add
			{
				CreateEventBridge();
				_ExitEvent += value;
			}
			remove
			{
				_ExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_GotFocusEventHandler _GotFocusEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_GotFocusEventHandler GotFocusEvent
		{
			add
			{
				CreateEventBridge();
				_GotFocusEvent += value;
			}
			remove
			{
				_GotFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_LostFocusEventHandler _LostFocusEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_LostFocusEventHandler LostFocusEvent
		{
			add
			{
				CreateEventBridge();
				_LostFocusEvent += value;
			}
			remove
			{
				_LostFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_DirtyEventHandler _DirtyEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_DirtyEventHandler DirtyEvent
		{
			add
			{
				CreateEventBridge();
				_DirtyEvent += value;
			}
			remove
			{
				_DirtyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		private event NavigationControl_UndoEventHandler _UndoEvent;

		/// <summary>
		/// SupportByLibrary AC14
		/// </summary>
		[SupportByLibrary("AC14")]
		public event NavigationControl_UndoEventHandler UndoEvent
		{
			add
			{
				CreateEventBridge();
				_UndoEvent += value;
			}
			remove
			{
				_UndoEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _dispNavigationControlEvents_SinkHelper)
			{
				_dispNavigationControlEvents_SinkHelper.Dispose();
				_dispNavigationControlEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}