//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void CommandButton_ClickEventHandler();
	public delegate void CommandButton_EnterEventHandler();
	public delegate void CommandButton_ExitEventHandler(ref Int16 Cancel);
	public delegate void CommandButton_GotFocusEventHandler();
	public delegate void CommandButton_LostFocusEventHandler();
	public delegate void CommandButton_DblClickEventHandler(ref Int16 Cancel);
	public delegate void CommandButton_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void CommandButton_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void CommandButton_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void CommandButton_KeyDownEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void CommandButton_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void CommandButton_KeyUpEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass CommandButton SupportByLibrary AC09 AC10 AC11 AC12 AC14 
	///</summary>
	[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class CommandButton : _CommandButton, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_CommandButtonEvents_SinkHelper __CommandButtonEvents_SinkHelper;
		DispCommandButtonEvents_SinkHelper _dispCommandButtonEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandButton(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandButton(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CommandButton(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public CommandButton()
		{
			CreateFromProgId("Access.CommandButton");
		}
		
		/// <param name="progId">progId</param>
		public CommandButton(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _CommandButtonEvents_SinkHelper.Id,DispCommandButtonEvents_SinkHelper.Id);


			if(_CommandButtonEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__CommandButtonEvents_SinkHelper = new _CommandButtonEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(DispCommandButtonEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dispCommandButtonEvents_SinkHelper = new DispCommandButtonEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_ClickEventHandler ClickEvent
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_EnterEventHandler _EnterEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_EnterEventHandler EnterEvent
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_ExitEventHandler _ExitEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_ExitEventHandler ExitEvent
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_GotFocusEventHandler _GotFocusEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_GotFocusEventHandler GotFocusEvent
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_LostFocusEventHandler _LostFocusEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_LostFocusEventHandler LostFocusEvent
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_DblClickEventHandler DblClickEvent
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_MouseDownEventHandler MouseDownEvent
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_MouseMoveEventHandler MouseMoveEvent
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_MouseUpEventHandler MouseUpEvent
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_KeyDownEventHandler KeyDownEvent
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_KeyPressEventHandler KeyPressEvent
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event CommandButton_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event CommandButton_KeyUpEventHandler KeyUpEvent
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
			if( null != __CommandButtonEvents_SinkHelper)
			{
				__CommandButtonEvents_SinkHelper.Dispose();
				__CommandButtonEvents_SinkHelper = null;
			}
			if( null != _dispCommandButtonEvents_SinkHelper)
			{
				_dispCommandButtonEvents_SinkHelper.Dispose();
				_dispCommandButtonEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}