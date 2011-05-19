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
	/// DispatchInterface _NameSpace SupportByLibrary Outlook, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _NameSpace : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NameSpace(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NameSpace(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NameSpace(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NameSpace()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
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
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Recipient CurrentUser
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentUser", paramsArray);
				NetOffice.OutlookApi.Recipient newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Recipient;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Folders Folders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Folders", paramsArray);
				NetOffice.OutlookApi._Folders newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Folders;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public string Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.AddressLists AddressLists
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressLists", paramsArray);
				NetOffice.OutlookApi.AddressLists newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.AddressLists;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.SyncObjects SyncObjects
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SyncObjects", paramsArray);
				NetOffice.OutlookApi.SyncObjects newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.SyncObjects;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public bool Offline
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Offline", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public COMObject MAPIOBJECT
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MAPIOBJECT", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 11,12,14)]
		public NetOffice.OutlookApi.Enums.OlExchangeConnectionMode ExchangeConnectionMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExchangeConnectionMode", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlExchangeConnectionMode)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Accounts Accounts
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Accounts", paramsArray);
				NetOffice.OutlookApi.Accounts newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Accounts;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public string CurrentProfileName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentProfileName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Stores Stores
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Stores", paramsArray);
				NetOffice.OutlookApi.Stores newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Stores;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Store DefaultStore
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultStore", paramsArray);
				NetOffice.OutlookApi.Store newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Store;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Categories Categories
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Categories", paramsArray);
				NetOffice.OutlookApi.Categories newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.Categories;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public string ExchangeMailboxServerName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExchangeMailboxServerName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public string ExchangeMailboxServerVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExchangeMailboxServerVersion", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public string AutoDiscoverXml
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoDiscoverXml", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlAutoDiscoverConnectionMode AutoDiscoverConnectionMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoDiscoverConnectionMode", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlAutoDiscoverConnectionMode)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="RecipientName">string RecipientName</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Recipient CreateRecipient(string recipientName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(recipientName);
			object returnItem = Invoker.MethodReturn(this, "CreateRecipient", paramsArray);
			NetOffice.OutlookApi.Recipient newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.Recipient;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="FolderType">NetOffice.OutlookApi.Enums.OlDefaultFolders FolderType</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.MAPIFolder GetDefaultFolder(NetOffice.OutlookApi.Enums.OlDefaultFolders folderType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(folderType);
			object returnItem = Invoker.MethodReturn(this, "GetDefaultFolder", paramsArray);
			NetOffice.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="EntryIDFolder">string EntryIDFolder</param>
		/// <param name="EntryIDStore">optional object EntryIDStore</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.MAPIFolder GetFolderFromID(string entryIDFolder, object entryIDStore)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(entryIDFolder, entryIDStore);
			object returnItem = Invoker.MethodReturn(this, "GetFolderFromID", paramsArray);
			NetOffice.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="EntryIDFolder">string EntryIDFolder</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.MAPIFolder GetFolderFromID(string entryIDFolder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(entryIDFolder);
			object returnItem = Invoker.MethodReturn(this, "GetFolderFromID", paramsArray);
			NetOffice.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="EntryIDItem">string EntryIDItem</param>
		/// <param name="EntryIDStore">optional object EntryIDStore</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject GetItemFromID(string entryIDItem, object entryIDStore)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(entryIDItem, entryIDStore);
			object returnItem = Invoker.MethodReturn(this, "GetItemFromID", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="EntryIDItem">string EntryIDItem</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject GetItemFromID(string entryIDItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(entryIDItem);
			object returnItem = Invoker.MethodReturn(this, "GetItemFromID", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="EntryID">string EntryID</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Recipient GetRecipientFromID(string entryID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(entryID);
			object returnItem = Invoker.MethodReturn(this, "GetRecipientFromID", paramsArray);
			NetOffice.OutlookApi.Recipient newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.Recipient;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Recipient">NetOffice.OutlookApi.Recipient Recipient</param>
		/// <param name="FolderType">NetOffice.OutlookApi.Enums.OlDefaultFolders FolderType</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.MAPIFolder GetSharedDefaultFolder(NetOffice.OutlookApi.Recipient recipient, NetOffice.OutlookApi.Enums.OlDefaultFolders folderType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(recipient, folderType);
			object returnItem = Invoker.MethodReturn(this, "GetSharedDefaultFolder", paramsArray);
			NetOffice.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Logoff()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Logoff", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Profile">optional object Profile</param>
		/// <param name="Password">optional object Password</param>
		/// <param name="ShowDialog">optional object ShowDialog</param>
		/// <param name="NewSession">optional object NewSession</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Logon(object profile, object password, object showDialog, object newSession)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(profile, password, showDialog, newSession);
			Invoker.Method(this, "Logon", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Logon()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Logon", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.MAPIFolder PickFolder()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PickFolder", paramsArray);
			NetOffice.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void RefreshRemoteHeaders()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RefreshRemoteHeaders", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Store">object Store</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void AddStore(object store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			Invoker.Method(this, "AddStore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Folder">NetOffice.OutlookApi.MAPIFolder Folder</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void RemoveStore(NetOffice.OutlookApi.MAPIFolder folder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(folder);
			Invoker.Method(this, "RemoveStore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="ContactItem">optional object ContactItem</param>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public void Dial(object contactItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(contactItem);
			Invoker.Method(this, "Dial", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public void Dial()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Dial", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 11, 12, 14
		/// </summary>
		/// <param name="Store">object Store</param>
		/// <param name="Type">NetOffice.OutlookApi.Enums.OlStoreType Type</param>
		[SupportByLibrary("Outlook", 11,12,14)]
		public void AddStoreEx(object store, NetOffice.OutlookApi.Enums.OlStoreType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store, type);
			Invoker.Method(this, "AddStoreEx", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.SelectNamesDialog GetSelectNamesDialog()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetSelectNamesDialog", paramsArray);
			NetOffice.OutlookApi.SelectNamesDialog newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.SelectNamesDialog;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="showProgressDialog">bool showProgressDialog</param>
		[SupportByLibrary("Outlook", 12,14)]
		public void SendAndReceive(bool showProgressDialog)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(showProgressDialog);
			Invoker.Method(this, "SendAndReceive", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="ID">string ID</param>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.AddressEntry GetAddressEntryFromID(string iD)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(iD);
			object returnItem = Invoker.MethodReturn(this, "GetAddressEntryFromID", paramsArray);
			NetOffice.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.AddressEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.AddressList GetGlobalAddressList()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetGlobalAddressList", paramsArray);
			NetOffice.OutlookApi.AddressList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.AddressList;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="ID">string ID</param>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Store GetStoreFromID(string iD)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(iD);
			object returnItem = Invoker.MethodReturn(this, "GetStoreFromID", paramsArray);
			NetOffice.OutlookApi.Store newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.Store;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Path">string Path</param>
		/// <param name="Name">optional object Name</param>
		/// <param name="DownloadAttachments">optional object DownloadAttachments</param>
		/// <param name="UseTTL">optional object UseTTL</param>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.MAPIFolder OpenSharedFolder(string path, object name, object downloadAttachments, object useTTL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, name, downloadAttachments, useTTL);
			object returnItem = Invoker.MethodReturn(this, "OpenSharedFolder", paramsArray);
			NetOffice.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Path">string Path</param>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.MAPIFolder OpenSharedFolder(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			object returnItem = Invoker.MethodReturn(this, "OpenSharedFolder", paramsArray);
			NetOffice.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Path">string Path</param>
		[SupportByLibrary("Outlook", 12,14)]
		public COMObject OpenSharedItem(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			object returnItem = Invoker.MethodReturn(this, "OpenSharedItem", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Context">object Context</param>
		/// <param name="Provider">optional object Provider</param>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.SharingItem CreateSharingItem(object context, object provider)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(context, provider);
			object returnItem = Invoker.MethodReturn(this, "CreateSharingItem", paramsArray);
			NetOffice.OutlookApi.SharingItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.SharingItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Context">object Context</param>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.SharingItem CreateSharingItem(object context)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(context);
			object returnItem = Invoker.MethodReturn(this, "CreateSharingItem", paramsArray);
			NetOffice.OutlookApi.SharingItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.SharingItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="FirstEntryID">string FirstEntryID</param>
		/// <param name="SecondEntryID">string SecondEntryID</param>
		[SupportByLibrary("Outlook", 12,14)]
		public bool CompareEntryIDs(string firstEntryID, string secondEntryID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(firstEntryID, secondEntryID);
			object returnItem = Invoker.MethodReturn(this, "CompareEntryIDs", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		/// <param name="AddressEntry">NetOffice.OutlookApi.AddressEntry AddressEntry</param>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OfficeApi.ContactCard CreateContactCard(NetOffice.OutlookApi.AddressEntry addressEntry)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(addressEntry);
			object returnItem = Invoker.MethodReturn(this, "CreateContactCard", paramsArray);
			NetOffice.OfficeApi.ContactCard newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.ContactCard;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}