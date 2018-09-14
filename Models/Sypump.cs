using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WisdomWaterServicePlatform.Models
{
    public class Sypump
    {
        public Sypump() {

        }
        /// <summary>
        /// 出水瞬时流量
        /// </summary>
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
        /// 出水瞬时流量
        /// </summary>
        public float sy1 { set; get; }
        /// <summary>
        /// 出水累计流量
        /// </summary>
        public float sy2 { set; get; }
        /// <summary>
        /// 变频器频率1
        /// </summary>
        public float sy3 { set; get; }
        /// <summary>
        /// 变频器频率2
        /// </summary>
        public float sy4 { set; get; }
        /// <summary>
        /// 变频器频率3
        /// </summary>
        public float sy5 { set; get; }

        /// <summary>
        /// 变频器频率4
        /// </summary>
        public float sy6 { set; get; }
        /// <summary>
        /// 水箱水位
        /// </summary>
        public float sy7 { set; get; }
        /// <summary>
        /// 泵前压力
        /// </summary>
        public float sy8 { set; get; }
        /// <summary>
        /// 泵后压力
        /// </summary>
        public float sy9 { set; get; }
        /// <summary>
        /// 电压UA
        /// </summary>
        public float sy10 { set; get; }
        /// <summary>
        /// 电压UB
        /// </summary>
        public float sy11 { set; get; }
        /// <summary>
        /// 电压UC
        /// </summary>
        public float sy12 { set; get; }
        /// <summary>
        /// 电量IA
        /// </summary>
        public float sy13 { set; get; }
        /// <summary>
        /// 电量IB
        /// </summary>
        public float sy14 { set; get; }
        /// <summary>
        /// 电量IC
        /// </summary>
        public float sy15 { set; get; }
        /// <summary>
        /// 辅泵变频器频率
        /// </summary>
        public float sy16 { set; get; }
        /// <summary>
        /// 进水电动阀开度
        /// </summary>
        public float sy17 { set; get; }
        /// <summary>
        /// 累计电量
        /// </summary>
        public float sy18 { set; get; }
        /// <summary>
        /// 1#变频运行
        /// </summary>
        public int sy19 { set; get; }
        /// <summary>
        /// 1#休息
        /// </summary>
        public int sy20 { set; get; }
        /// <summary>
        /// 1#空开跳闸
        /// </summary>
        public int sy21 { set; get; }
        /// <summary>
        /// 1#变频故障
        /// </summary>
        public int sy22 { set; get; }
        /// <summary>
        /// 1#变频运行
        /// </summary>
        public int sy23 { set; get; }
        /// <summary>
        /// 2#休息
        /// </summary>
        public int sy24 { set; get; }
        /// <summary>
        /// 2#空开跳闸
        /// </summary>
        public int sy25 { set; get; }
        /// <summary>
        /// 2#变频故障
        /// </summary>
        public int sy26 { set; get; }
        /// <summary>
        /// 3#变频运行
        /// </summary>
        public int sy27 { set; get; }

        /// <summary>
        /// 3#休息
        /// </summary>
        public int sy28 { set; get; }
        /// <summary>
        /// 3#空开跳闸
        /// </summary>
        public int sy29 { set; get; }
        /// <summary>
        /// 3#变频故障
        /// </summary>
        public int sy30 { set; get; }
        /// <summary>
        /// 辅泵变频运行
        /// </summary>
        public int sy31 { set; get; }
        /// <summary>
        /// 辅泵休息
        /// </summary>
        public int sy32 { set; get; }
        /// <summary>
        /// 辅泵空开跳闸
        /// </summary>
        public int sy33 { set; get; }
        /// <summary>
        /// 辅泵变频故障
        /// </summary>
        public int sy34 { set; get; }
        /// <summary>
        /// 污水故障
        /// </summary>
        public int sy35 { set; get; }
        /// <summary>
        /// 高水故障
        /// </summary>
        public int sy36 { set; get; }
        /// <summary>
        /// 地面积水故障
        /// </summary>
        public int sy37 { set; get; }
        /// <summary>
        /// 相序故障
        /// </summary>
        public int sy38 { set; get; }
        /// <summary>
        /// 出口超压
        /// </summary>
        public int sy39 { set; get; }
        /// <summary>
        /// 开停机远程控制切换
        /// </summary>
        public int sy40 { set; get; }
        /// <summary>
        /// 进水阀远程控制切换
        /// </summary>
        public int sy41 { set; get; }
        /// <summary>
        /// 正常开门信号1
        /// </summary>
        public int sy42 { set; get; }
        /// <summary>
        /// 正常开门信号2
        /// </summary>
        public int sy43 { set; get; }
        /// <summary>
        /// 非法入侵信号1
        /// </summary>
        public int sy44 { set; get; }
        /// <summary>
        /// 非法入侵信号2
        /// </summary>
        public int sy45 { set; get; }
        /// <summary>
        /// 1#远程启停
        /// </summary>
        public int sy46 { set; get; }
        /// <summary>
        /// 2#远程启停
        /// </summary>
        public int sy47 { set; get; }
        /// <summary>
        /// 3#远程启停
        /// </summary>
        public int sy48 { set; get; }
        /// <summary>
        /// 辅泵远程启停
        /// </summary>
        public int sy49 { set; get; }
        /// <summary>
        /// 视频监控报警信号
        /// </summary>
        public int sy50 { set; get; }
        /// <summary>
        /// 远程进水电动阀调节
        /// </summary>
        public int sy51 { set; get; }

        public void Check() {
            if (this.update_day == null) {
                String msg = String.Format("数据更新日期不可为空。");
                throw new ArgumentException(msg);
            }
            if (this.update_time == null)
            {
                String msg = String.Format("数据更新时间不可为空。");
                throw new ArgumentException(msg);
            }

        }

        public void validate() {
            if (string.IsNullOrEmpty(this.sy1.ToString())) {
                throw new ArgumentNullException("关键信息不能为空。");
            }

        }
    }
}
