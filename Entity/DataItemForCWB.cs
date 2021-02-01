using System;
using System.Collections.Generic;
using System.Text;

namespace Buildmore.Entity
{
    public class DataItemForCWB
    {
		/// <summary>
		/// 國家
		/// </summary>
		public virtual string Country { get; set; }


		/// <summary>
		/// 城巿
		/// </summary>
		public virtual string City { get; set; }


		/// <summary>
		/// 觀測站
		/// </summary>
		public virtual string Station { get; set; }


		/// <summary>
		/// 資料時間
		/// </summary>
		public virtual DateTime DataTime { get; set; }


		/// <summary>
		/// 氣溫(攝氏)
		/// </summary>
		public virtual decimal? TemperatureC { get; set; }


		/// <summary>
		/// 氣溫(華氏)
		/// </summary>
		public virtual decimal? TemperatureF { get; set; }


		/// <summary>
		/// 天氣(晴/陰/雨)
		/// </summary>
		public virtual string Weather { get; set; }


		/// <summary>
		/// 風向
		/// </summary>
		public virtual string WindDirection { get; set; }


		/// <summary>
		/// 風力幾級
		/// </summary>
		public virtual int? WindForce { get; set; }


		/// <summary>
		/// 相對濕度
		/// </summary>
		public virtual int? Humidity { get; set; }


		/// <summary>
		/// 海平面氣壓(百帕)
		/// </summary>
		public virtual decimal? Pressure { get; set; }


		/// <summary>
		/// 當日累積雨量(毫米)
		/// </summary>
		public virtual decimal? RainFall { get; set; }


		/// <summary>
		/// 日照時數
		/// </summary>
		public virtual decimal? SunshineHours { get; set; }


	}
}
