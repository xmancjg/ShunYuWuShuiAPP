using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WisdomWaterServicePlatform.Models
{
    public class Wushui
    {
        public int ID { set; get; }

        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime update_day { set; get; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public TimeSpan update_time { set; get; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string id_name { set; get; }
        /// <summary>
        /// 瞬时流量S01
        /// </summary>
        public float ssll { set; get; }
        /// <summary>
        /// 累计流量S01
        /// </summary>
        public Int32 ljll { set; get; }
        /// <summary>
        /// COD实时检测S01
        /// </summary>
        public Int32 cod_ss { set; get; }
        /// <summary>
        /// COD量程设定S01
        /// </summary>
        public Int32 cod_set { set; get; }
        /// <summary>
        /// MBR泵休息时间设定S01
        /// </summary>
        public Int32 mbr_rest_set { set; get; }
        /// <summary>
        /// MBR泵轮换时间设定S01
        /// </summary>
        public Int32 mbr_lh_set { set; get; }
        /// <summary>
        /// MBR泵运行时间设定S01
        /// </summary>
        public Int32 mbr_run_set { set; get; }
        /// <summary>
        /// PH实时检测S01
        /// </summary>
        public Int32 ph_ss { set; get; }
        /// <summary>
        /// 回流泵休息时间设定S01
        /// </summary>
        public Int32 hlb_rest_set { set; get; }
        /// <summary>
        /// 回流泵轮换时间设定S01
        /// </summary>
        public Int32 hlb_lh_set { set; get; }
        /// <summary>
        /// 回流泵运行时间设定S01
        /// </summary>
        public Int32 hlb_run_set { set; get; }
        /// <summary>
        /// 提升泵轮换时间设定S01
        /// </summary>
        public Int32 ts_lh_set { set; get; }
        /// <summary>
        /// 提升泵轮换氨氮实时检测S01时间设定S01
        /// </summary>
        public Int32 ad_ss { set; get; }
        /// <summary>
        /// 氨氮量程设定S01
        /// </summary>
        public Int32 ad_set { set; get; }
        /// <summary>
        /// 污泥泵休息时间设定S01
        /// </summary>
        public Int32 wn_rest_set { set; get; }
        /// <summary>
        /// 污泥泵轮换时间设定S01
        /// </summary>
        public Int32 wn_lh_set { set; get; }
        /// <summary>
        /// 污泥泵运行时间设定S01
        /// </summary>
        public Int32 wn_run_set { set; get; }
        /// <summary>
        /// 液位反馈S01
        /// </summary>
        public Int32 yw { set; get; }
        /// <summary>
        /// 液位量程设定S01
        /// </summary>
        public Int32 yw_set { set; get; }
        /// <summary>
        /// 风机休息时间设定S01
        /// </summary>
        public Int32 fan_rest_set { set; get; }
        /// <summary>
        /// 风机轮换时间设定S01
        /// </summary>
        public Int32 fan_lh_set { set; get; }
        /// <summary>
        /// 风机运行时间设定S01
        /// </summary>
        public Int32 fan_run_set { set; get; }
        /// <summary>
        /// 一号MBR泵停止S01
        /// </summary>
        public Int32 mbr1_stop { set; get; }
        /// <summary>
        /// 一号MBR泵手自动S01
        /// </summary>
        public Int32 mbr1_auto { set; get; }
        /// <summary>
        /// 一号MBR泵运行S01
        /// </summary>
        public Int32 mbr1_run { set; get; }
        /// <summary>
        /// 一号回流泵停止S01
        /// </summary>
        public Int32 hlb1_stop { set; get; }
        /// <summary>
        /// 一号回流泵启动S01
        /// </summary>
        public Int32 hlb1_start { set; get; }
        /// <summary>
        /// 一号回流泵手自动S01
        /// </summary>
        public Int32 hlb1_auto { set; get; }
        /// <summary>
        /// 一号回流泵故障S01
        /// </summary>
        public Int32 hlb1_fault { set; get; }
        /// <summary>
        /// 一号回流泵运行S01
        /// </summary>
        public Int32 hlb1_run { set; get; }
        /// <summary>
        /// 一号提升泵停止S01
        /// </summary>
        public Int32 tsb1_stop { set; get; }
        /// <summary>
        /// 一号提升泵启动S01
        /// </summary>
        public Int32 tsb1_start { set; get; }
        /// <summary>
        /// 一号提升泵手自动S01
        /// </summary>
        public Int32 tsb1_auto { set; get; }
        /// <summary>
        /// 一号提升泵运行S01
        /// </summary>
        public Int32 tsb1_run { set; get; }
        /// <summary>
        /// 一号污泥泵停止S01
        /// </summary>
        public Int32 wn1_stop { set; get; }
        /// <summary>
        /// 一号提升泵故障S01
        /// </summary>
        public Int32 tsb1_fault { set; get; }
        /// <summary>
        /// 一号污泥泵启动S01
        /// </summary>
        public Int32 wn1_start { set; get; }
        /// <summary>
        /// 一号污泥泵手自动S01
        /// </summary>
        public Int32 wn1_auto { set; get; }
        /// <summary>
        /// 一号污泥泵故障S01
        /// </summary>
        public Int32 wn1_fault { set; get; }
        /// <summary>
        /// 一号污泥泵运行S01
        /// </summary>
        public Int32 wn1_run { set; get; }
        /// <summary>
        /// 一号风机停止S01
        /// </summary>
        public Int32 fan1_stop { set; get; }
        /// <summary>
        /// 一号风机启动S01
        /// </summary>
        public Int32 fan1_start { set; get; }
        /// <summary>
        /// 一号风机手自动S01
        /// </summary>
        public Int32 fan1_auto { set; get; }
        /// <summary>
        /// 一号风机故障S01
        /// </summary>
        public Int32 fan1_fault { set; get; }
        /// <summary>
        /// 一号风机运行S01
        /// </summary>
        public Int32 fan1_run { set; get; }
        /// <summary>
        /// 二号回流泵停止S01
        /// </summary>
        public Int32 hlb2_stop { set; get; }
        /// <summary>
        /// 二号回流泵启动S01
        /// </summary>
        public Int32 hlb2_start { set; get; }
        /// <summary>
        /// 二号回流泵手自动S01
        /// </summary>
        public Int32 hlb2_auto { set; get; }
        /// <summary>
        /// 二号回流泵故障S01
        /// </summary>
        public Int32 hlb2_fault { set; get; }
        /// <summary>
        /// 二号回流泵故障S01
        /// </summary>
        public Int32 hlb2_run { set; get; }
        /// <summary>
        /// 二号提升泵停止S01
        /// </summary>
        public Int32 tsb2_stop { set; get; }
        /// <summary>
        /// 二号提升泵启动S01
        /// </summary>
        public Int32 tsb2_start { set; get; }
        /// <summary>
        /// 二号提升泵手自动S01
        /// </summary>
        public Int32 tsb2_auto { set; get; }
        /// <summary>
        /// 二号提升泵故障S01
        /// </summary>
        public Int32 tsb2_fault { set; get; }
        /// <summary>
        /// 二号提升泵运行S01
        /// </summary>
        public Int32 tsb2_run { set; get; }
        /// <summary>
        /// 二号污泥泵停止S01
        /// </summary>
        public Int32 wn2_stop { set; get; }
        /// <summary>
        /// 二号污泥泵启动S01
        /// </summary>
        public Int32 wn2_start { set; get; }
        /// <summary>
        /// 二号污泥泵手自动S01
        /// </summary>
        public Int32 wn2_auto { set; get; }
        /// <summary>
        /// 二号污泥泵故障S01
        /// </summary>
        public Int32 wn2_fault { set; get; }
        /// <summary>
        /// 二号污泥泵运行S01
        /// </summary>
        public Int32 wn2_run { set; get; }
        /// <summary>
        /// 二号风机停止S01
        /// </summary>
        public Int32 fan2_stop { set; get; }
        /// <summary>
        /// 二号风机停止S01
        /// </summary>
        public Int32 fan2_start { set; get; }
        /// <summary>
        /// 二号风机手自动S01
        /// </summary>
        public Int32 fan2_auto { set; get; }
        /// <summary>
        /// 二号风机故障S01
        /// </summary>
        public Int32 fan2_fault { set; get; }
        /// <summary>
        /// 二号风机运行S01
        /// </summary>
        public Int32 fan2_run { set; get; }
        /// <summary>
        /// 调节池低液位报警S01
        /// </summary>
        public Int32 tjc_low { set; get; }
        /// <summary>
        /// 调节池高液位报警S01
        /// </summary>
        public Int32 tjc_high { set; get; }

    }
}
