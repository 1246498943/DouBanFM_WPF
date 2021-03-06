﻿using System;
using System.Runtime.Serialization;

namespace DouBanAPI.Models
{
    /// <summary>
    /// 频道信息实体
    /// </summary>
    [DataContract]
    public class Channel
    {
        /// <summary>
        /// 频道编号
        /// </summary>
        [DataMember(Name = "style")]
        public StyleInfo Style { get; set; }
        /// <summary>
        /// 频道名称
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }
        private Uri coverUri;
        /// <summary>
        /// 频道名称
        /// </summary>
        [DataMember(Name = "cover")]
        public Uri CoverUri
        {
            get
            {
                return coverUri;
            }
            set
            {
                coverUri = value;
                if (coverUri.ToString().Contains("large"))
                {
                    CoverSize = 2;
                    return;
                }
                if (coverUri.ToString().Contains("medium"))
                {
                    CoverSize = 1;
                    return;
                }
                CoverSize = 0;
            }
        }
        public int CoverSize { get; set; }
        /// <summary>
        /// 频道类型
        /// </summary>
        [DataMember(Name = "channel_type")]
        public string ChannelType { get; set; }
        /// <summary>
        /// 频道名称
        /// </summary>
        [DataMember(Name = "intro")]
        public string Intro { get; set; }
        /// <summary>
        /// 频道名称
        /// </summary>
        [DataMember(Name = "song_num")]
        public int SongNum { get; set; }
        /// <summary>
        /// 频道名称
        /// </summary>
        [DataMember(Name = "id")]
        public string ID { get; set; }
    }
}
