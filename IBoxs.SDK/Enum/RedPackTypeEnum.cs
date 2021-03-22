using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBoxs.SDK.Enum
{
    /// <summary>
    /// 红包类型
    /// </summary>
    public enum RedPackTypeEnum
    {
        /// <summary>
        /// 非红包
        /// </summary>
        None=0,
        /// <summary>
        /// 已转入余额
        /// </summary>
        Transferred=2,
        /// <summary>
        /// 点击收款
        /// </summary>
        Collect=4,
        /// <summary>
        /// 红包
        /// </summary>
        Red=10
    }
}
