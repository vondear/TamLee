//===================================================
//作    者：边涯  http://www.u3dol.com  QQ群：87481002
//创建时间：2016-02-18 23:03:22
//备    注：
//===================================================
using UnityEngine;
using System.Collections;

namespace TamLee
{
    /// <summary>
    /// 协议接口
    /// </summary>
    public interface IProto
    {
        //协议编号
        ushort ProtoCode { get; }

        //协议名称
        string ProtoEnName { get; }

        //协议转化为数组
        byte[] ToArray();
    }
}