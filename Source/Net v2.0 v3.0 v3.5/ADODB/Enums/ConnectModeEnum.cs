//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary 2.1,2.5,
	 /// </summary>
	[SupportByLibrary("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum ConnectModeEnum
	{
		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adModeUnknown = 0,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adModeRead = 1,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adModeWrite = 2,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adModeReadWrite = 3,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adModeShareDenyRead = 4,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adModeShareDenyWrite = 8,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adModeShareExclusive = 12,

		 /// <summary>
		 /// SupportByLibrary 2.1,2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.1,2.5)]
		adModeShareDenyNone = 16,

		 /// <summary>
		 /// SupportByLibrary 2.5,
		 /// </summary>
		[SupportByLibrary("ADODB", 2.5)]
		adModeRecursive = 4194304
	}
}