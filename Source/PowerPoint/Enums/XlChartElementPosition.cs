using System;
using NetOffice;
namespace NetOffice.PowerPointApi.Enums
{
	 /// <summary>
	 /// SupportByVersion PowerPoint 14, 15
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff745768.aspx </remarks>
	[SupportByVersionAttribute("PowerPoint", 14,15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlChartElementPosition
	{
		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-4105</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlChartElementPositionAutomatic = -4105,

		 /// <summary>
		 /// SupportByVersion PowerPoint 14, 15
		 /// </summary>
		 /// <remarks>-4114</remarks>
		 [SupportByVersionAttribute("PowerPoint", 14,15)]
		 xlChartElementPositionCustom = -4114
	}
}