﻿namespace NbazhGPS.Protocol.Enums
{
    /// <summary>
    /// 报警
    /// </summary>
    public enum Alarm0X26: byte
    {
         正常 = 0x00,
         SOS求救 = 0x01,
         断电报警 = 0x02,
         震动报警 = 0x03,
         进围栏报警 = 0x04,
         出围栏报警 = 0x05,
         超速报警 = 0x06,
         位移报警 = 0x09,
         进GPS盲区报警 = 0x0A,
         出GPS盲区报警 = 0x0B,
         开机报警 = 0x0C,
         GPS第一次定位报警 = 0x0D,
         外电低电报警 = 0x0E,
         外电低电保护报警 = 0x0F,
         换卡报警 = 0x10,
         关机报警 = 0x11,
         外电低电保护后飞行模式报警 = 0x12,
         拆卸报警 = 0x13,
         门报警 = 0x14,
         低电关机报警 = 0x15,
         声控报警 = 0x16,
         伪基站报警 = 0x17,
         开盖报警 = 0x18,
         内部电池低电报警 = 0x19,
         进入深度休眠报警 = 0x20,
         预留1 = 0x21,
         预留2 = 0x22,
         跌倒报警 = 0x23,
         ACC关 = 0xFF,
         ACC开 = 0xFE
    }
}