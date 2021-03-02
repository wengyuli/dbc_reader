using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AVLPumaReader
{

    /// <summary>
    /// 全局信号集合
    /// </summary>
    public static class GlobalDBC
    {
        public static List<DBCMessage> ListOfDBCMessage = new List<DBCMessage>();
    }

    //[StructLayout(LayoutKind.Sequential)]
    public struct DBCSignal
    {
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 66)]
        //public byte[] strName;//名称
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 201)]
        //public byte[] strComment;//注释
        //public uint nStartBit;//起始位
        //public uint nLen;//位长度
        //public double nFactor;//转换因子
        //public double nOffset;//转换偏移实际值=原始值*nFactor+nOffset
        //public double nMin;//最小值
        //public double nMax;//最大值
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
        //public byte[] unit;//单位
        //public double nValue;//实际值

        public UInt32 nStartBit;//起始位
        public UInt32 nLen;//位长度
        public Double nFactor;//转换因子
        public Double nOffset;//转换偏移 实际值=原始值*nFactor+nOffset
        public Double nMin;    // 最小值
        public Double nMax;    // 最大值
        public Double nValue;  //实际值
        public UInt64 nRawValue;//原始值 
        public Byte is_signed; //1:有符号数据, 0:无符号
        public Byte is_motorola;//是否摩托罗拉格式
        public Byte multiplexer_type;//see 'multiplexer type' above
        public Byte multiplexer_value;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
        public Byte[] unit;


        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        //public string strName;  //名称
        public Byte[] strName;

        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 201)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 201)]
        //public string strComment;  //注释
        public Byte[] strComment;


        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        //public string strValDesc;  //值描述
        public Byte[] strValDesc;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DBCMessage
    {
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 66)]
        //public byte[] strName;//消息名
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 201)]
        //public byte[] strComment;//注释
        //public uint nID;
        //public SByte nExtend;
        //public uint nSize;//消息占的字节数目
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 513)]
        //public DBCSignal[] vSignals;//信号集合
        //public uint nSignalCount;//信号数量

        public UInt32 nSignalCount; //信号数量
        public UInt32 nID;
        public Byte nExtend; //1:扩展帧, 0:标准帧
        public UInt32 nSize;   //消息占的字节数目

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public DBCSignal[] vSignals; //信号集合

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        //public string strName;  //名称
        public byte[] strName;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 201)]
        //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        //public string strComment;    //注释
        public byte[] strComment;
    }
    public enum ProtocolType
    {
        DBC_J1939,
        DBC_CAN,
    }
  unsafe  public struct FileInfo
    {
       // [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1001)]
        public fixed  byte  strFilePath[1001];
        public ProtocolType nType;
        public SByte merge;//1:不清除现有的数据, 即支持加载多个文件
    }
    public struct DevInfo
    {
        public   uint nDevType;
        public   uint nDevIndex;
        public   uint nChIndex;
    }

    public struct Ctx
    {
       public  IntPtr powner;
       public  DevInfo devinfo;
    }

    
}