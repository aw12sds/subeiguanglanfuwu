// WinTcpS7.PlcClient
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using WinTcpS7;

public class PlcClient
{
    public enum PlcMemory
    {
        DI = 1,
        DQ,
        MR,
        DR,
        AI,
        AQ
    }

    public enum DataType
    {
        INT16 = 1,
        UINT16,
        DINT32,
        HEX32,
        REAL32,
        BIN16,
        CHAR8,
        BYTE8
    }

    public PlcClient()
    {
    
    }

    public short EntLink(string pcIP, ushort pcPort, string plcIP, ushort plcPort, ushort Rack, ushort Slot, string SN, ref int Handle, ushort WaitTime = 2000)
    {
        short num2;
        int num3 = default(int);
        int num5 = default(int);
        try
        {
        IL_0001:
            int num = 1;
            if ((Class7.int_0 > 0) & (Class6.int_1 <= 0))
            {
                goto IL_001a;
            }
            goto IL_0027;
        IL_001a:
            num = 2;
            Class6.int_1 = Class6.timeGetTime();
            goto IL_0027;
        IL_0027:
            num = 4;
            if (!Class6.smethod_8())
            {
                goto IL_0031;
            }
            goto IL_003c;
        IL_0031:
            num = 5;
            num2 = -80;
            goto end_IL_0001;
        IL_003c:
            num = 7;
            if (!Class6.smethod_7(pcIP))
            {
                goto IL_0047;
            }
            goto IL_0052;
        IL_0047:
            num = 8;
            num2 = -81;
            goto end_IL_0001;
        IL_0052:
            num = 10;
            if (!Class6.smethod_7(plcIP))
            {
                goto IL_005e;
            }
            goto IL_006a;
        IL_005e:
            num = 11;
            num2 = -82;
            goto end_IL_0001;
        IL_006a:
            num = 13;
            if (!Class6.smethod_9(plcIP, 1000))
            {
                goto IL_007b;
            }
            goto IL_0087;
        IL_007b:
            num = 14;
            num2 = -83;
            goto end_IL_0001;
        IL_0087:
            ProjectData.ClearProjectError();
            num3 = 1;
            goto IL_008e;
        IL_008e:
            num = 17;
            short num4 = Class7.smethod_0(pcIP, pcPort, plcIP, plcPort, Rack, Slot, ref Handle, WaitTime);
            goto IL_00a5;
        IL_00a5:
            num = 18;
            if (num4 < 0)
            {
                goto IL_00ad;
            }
            goto IL_00b8;
        IL_00ad:
            num = 19;
            num2 = num4;
            goto end_IL_0001;
        IL_00b8:
            num = 21;
            if (Operators.CompareString(SN, Class7.string_0, false) != 0)
            {
                goto IL_00cc;
            }
            goto IL_00d7;
        IL_00cc:
            num = 22;
            Class7.int_1 = 100;
            goto IL_00d7;
        IL_00d7:
            num = 24;
            num2 = 0;
            goto end_IL_0001;
        IL_00e7:
            int num6 = num5 + 1;
            num5 = 0;
            switch (num6)
            {
                case 25:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_001a;
                case 3:
                case 4:
                    goto IL_0027;
                case 5:
                    goto IL_0031;
                case 6:
                case 7:
                    goto IL_003c;
                case 8:
                    goto IL_0047;
                case 9:
                case 10:
                    goto IL_0052;
                case 11:
                    goto IL_005e;
                case 12:
                case 13:
                    goto IL_006a;
                case 14:
                    goto IL_007b;
                case 15:
                case 16:
                    goto IL_0087;
                case 17:
                    goto IL_008e;
                case 18:
                    goto IL_00a5;
                case 19:
                    goto IL_00ad;
                case 20:
                case 21:
                    goto IL_00b8;
                case 22:
                    goto IL_00cc;
                case 23:
                case 24:
                    goto IL_00d7;
                default:
                    goto IL_018e;
            }
        IL_015b:
            num5 = num;
            switch (num3)
            {
                case 1:
                    goto IL_00e7;
                default:
                    goto IL_018e;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num3 != 0) & (num5 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_018c: Could not find block for branch target IL_015b*/
            ;
        }
        short result = num2;
        if (num5 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_018e:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public short DeLink(int Handle)
    {
        short num4;
        int num = default(int);
        int num5 = default(int);
        try
        {
        IL_0001:
            ProjectData.ClearProjectError();
            num = 1;
            goto IL_0008;
        IL_0008:
            int num2 = 2;
            short num3 = Class7.smethod_1(Handle);
            goto IL_0012;
        IL_0012:
            num2 = 3;
            if (!Class6.smethod_0() | (Class6.int_0 > 0))
            {
                goto IL_0028;
            }
            goto IL_0045;
        IL_0028:
            num2 = 4;
            Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
            goto IL_003d;
        IL_003d:
            num2 = 5;
            num4 = -99;
            goto end_IL_0001;
        IL_0045:
            num2 = 7;
            num4 = num3;
            goto end_IL_0001;
        IL_004e:
            int num6 = num5 + 1;
            num5 = 0;
            switch (num6)
            {
                case 8:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_0008;
                case 3:
                    goto IL_0012;
                case 4:
                    goto IL_0028;
                case 5:
                    goto IL_003d;
                case 6:
                case 7:
                    goto IL_0045;
                default:
                    goto IL_00b1;
            }
        IL_007e:
            num5 = num2;
            switch (num)
            {
                case 1:
                    goto IL_004e;
                default:
                    goto IL_00b1;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num != 0) & (num5 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_00af: Could not find block for branch target IL_007e*/
            ;
        }
        short result = num4;
        if (num5 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_00b1:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public short CmdRead(int Handle, PlcMemory Memory, DataType ValType, ushort Block, ushort Address, ushort Count, ref object[] Redata)
    {
        short num3;
        int num = default(int);
        int num5 = default(int);
        try
        {
        IL_0001:
            ProjectData.ClearProjectError();
            num = 1;
            goto IL_0008;
        IL_0008:
            int num2 = 2;
            if (!Class6.smethod_0())
            {
                goto IL_0012;
            }
            goto IL_0032;
        IL_0012:
            num2 = 3;
            Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
            goto IL_0027;
        IL_0027:
            num2 = 4;
            num3 = -99;
            goto end_IL_0001;
        IL_0032:
            num2 = 6;
            short num4 = Class7.smethod_2(Handle, Memory, ValType, Block, Address, Count, ref Redata);
            goto IL_0046;
        IL_0046:
            num2 = 7;
            if ((Class7.int_1 > 0) & (num4 == 0))
            {
                goto IL_0058;
            }
            goto IL_0067;
        IL_0058:
            num2 = 8;
            checked
            {
                Class6.int_0++;
                goto IL_0067;
            }
        IL_0067:
            num2 = 10;
            num3 = num4;
            goto end_IL_0001;
        IL_0071:
            int num6 = num5 + 1;
            num5 = 0;
            switch (num6)
            {
                case 11:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_0008;
                case 3:
                    goto IL_0012;
                case 4:
                    goto IL_0027;
                case 5:
                case 6:
                    goto IL_0032;
                case 7:
                    goto IL_0046;
                case 8:
                    goto IL_0058;
                case 9:
                case 10:
                    goto IL_0067;
                default:
                    goto IL_00e0;
            }
        IL_00ad:
            num5 = num2;
            switch (num)
            {
                case 1:
                    goto IL_0071;
                default:
                    goto IL_00e0;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num != 0) & (num5 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_00de: Could not find block for branch target IL_00ad*/
            ;
        }
        short result = num3;
        if (num5 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_00e0:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public short CmdRead(int Handle, PlcMemory Memory, DataType ValType, ushort Block, ushort Address, ushort Count, ref string[] Redata)
    {
        checked
        {
            short num3;
            int num = default(int);
            int num7 = default(int);
            try
            {
            IL_0001:
                ProjectData.ClearProjectError();
                num = 1;
                goto IL_0009;
            IL_0009:
                int num2 = 2;
                if (!Class6.smethod_0())
                {
                    goto IL_0013;
                }
                goto IL_0033;
            IL_0013:
                num2 = 3;
                Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
                goto IL_0028;
            IL_0028:
                num2 = 4;
                num3 = -99;
                goto end_IL_0001;
            IL_0033:
                num2 = 6;
                object[] object_ = default(object[]);
                short num4 = Class7.smethod_2(Handle, Memory, ValType, Block, Address, Count, ref object_);
                goto IL_0047;
            IL_0047:
                num2 = 7;
                Redata = new string[Information.UBound(object_, 1) + 1];
                goto IL_005b;
            IL_005b:
                num2 = 10;
                int num5 = Information.UBound(object_, 1);
                for (int i = 0; i <= num5; num2 = 18, i++)
                {
                    goto IL_0071;
                IL_0071:
                    num2 = 11;
                    if (ValType == DataType.REAL32)
                    {
                        goto IL_0079;
                    }
                    goto IL_009a;
                IL_0079:
                    num2 = 12;
                    double num6 = Conversions.ToDouble(object_[i]);
                    goto IL_0087;
                IL_0087:
                    num2 = 13;
                    Redata[i] = num6.ToString();
                    continue;
                IL_009a:
                    num2 = 15;
                    goto IL_009e;
                IL_009e:
                    num2 = 16;
                    Redata[i] = object_[i].ToString();
                    continue;
                IL_00f0:
                    int num8 = unchecked(num7 + 1);
                    num7 = 0;
                    switch (num8)
                    {
                        case 23:
                            goto end_IL_0001;
                        case 1:
                            goto IL_0001;
                        case 2:
                            goto IL_0009;
                        case 3:
                            goto IL_0013;
                        case 4:
                            goto IL_0028;
                        case 5:
                        case 6:
                            goto IL_0033;
                        case 7:
                            goto IL_0047;
                        case 8:
                        case 10:
                            goto IL_005b;
                        case 11:
                            goto IL_0071;
                        case 12:
                            goto IL_0079;
                        case 13:
                            goto IL_0087;
                        case 15:
                            goto IL_009a;
                        case 16:
                            goto IL_009e;
                        case 14:
                        case 17:
                        case 18:
                            continue;
                        case 19:
                            goto end_IL_006b;
                        case 20:
                            goto IL_00d0;
                        case 21:
                        case 22:
                            goto IL_00e0;
                        default:
                            goto IL_0195;
                    }
                IL_015e:
                    num7 = num2;
                    switch (num)
                    {
                        case 1:
                            goto IL_00f0;
                        default:
                            goto IL_0195;
                    }
                    continue;
                end_IL_006b:
                    break;
                }
                num2 = 19;
                if ((Class7.int_1 > 0) & (num4 == 0))
                {
                    goto IL_00d0;
                }
                goto IL_00e0;
            IL_00e0:
                num2 = 22;
                num3 = num4;
                goto end_IL_0001;
            IL_00d0:
                num2 = 20;
                Class6.int_0++;
                goto IL_00e0;
            end_IL_0001:;
            }
            catch (object obj) when ((obj is Exception) & (num != 0) & (num7 == 0))
            {
                ProjectData.SetProjectError(unchecked((Exception)obj));
                /*Error near IL_0193: Could not find block for branch target IL_015e*/
                ;
            }
            short result = num3;
            if (num7 != 0)
            {
                ProjectData.ClearProjectError();
            }
            return result;
        }
    IL_0195:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public string CmdRead(int Handle, PlcMemory Memory, DataType ValType, ushort Block, ushort Address)
    {
        string text;
        int num = default(int);
        int num4 = default(int);
        try
        {
        IL_0001:
            ProjectData.ClearProjectError();
            num = 1;
            goto IL_0008;
        IL_0008:
            int num2 = 2;
            if (!Class6.smethod_0())
            {
                goto IL_0012;
            }
            goto IL_0035;
        IL_0012:
            num2 = 3;
            Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
            goto IL_0027;
        IL_0027:
            num2 = 4;
            text = "";
            goto end_IL_0001;
        IL_0035:
            num2 = 6;
            object[] object_ = default(object[]);
            short num3 = Class7.smethod_2(Handle, Memory, ValType, Block, Address, 1, ref object_);
            goto IL_0048;
        IL_0048:
            num2 = 7;
            if ((Class7.int_1 > 0) & (num3 == 0))
            {
                goto IL_005a;
            }
            goto IL_0069;
        IL_005a:
            num2 = 8;
            checked
            {
                Class6.int_0++;
                goto IL_0069;
            }
        IL_0069:
            num2 = 10;
            text = object_[0].ToString();
            goto end_IL_0001;
        IL_007d:
            int num5 = num4 + 1;
            num4 = 0;
            switch (num5)
            {
                case 11:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_0008;
                case 3:
                    goto IL_0012;
                case 4:
                    goto IL_0027;
                case 5:
                case 6:
                    goto IL_0035;
                case 7:
                    goto IL_0048;
                case 8:
                    goto IL_005a;
                case 9:
                case 10:
                    goto IL_0069;
                default:
                    goto IL_00f0;
            }
        IL_00bb:
            num4 = num2;
            switch (num)
            {
                case 1:
                    goto IL_007d;
                default:
                    goto IL_00f0;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num != 0) & (num4 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_00ee: Could not find block for branch target IL_00bb*/
            ;
        }
        string result = text;
        if (num4 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_00f0:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public short CmdWrite(int Handle, PlcMemory Memory, DataType ValType, ushort Block, ushort Address, ushort Count, ref object[] Data)
    {
        short num3;
        int num = default(int);
        int num5 = default(int);
        try
        {
        IL_0001:
            ProjectData.ClearProjectError();
            num = 1;
            goto IL_0008;
        IL_0008:
            int num2 = 2;
            if (!Class6.smethod_0())
            {
                goto IL_0012;
            }
            goto IL_0032;
        IL_0012:
            num2 = 3;
            Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
            goto IL_0027;
        IL_0027:
            num2 = 4;
            num3 = -99;
            goto end_IL_0001;
        IL_0032:
            num2 = 6;
            short num4 = Class7.smethod_3(Handle, Memory, ValType, Block, Address, Count, Data);
            goto IL_0047;
        IL_0047:
            num2 = 7;
            if ((Class7.int_1 > 0) & (num4 == 0))
            {
                goto IL_0059;
            }
            goto IL_0068;
        IL_0059:
            num2 = 8;
            checked
            {
                Class6.int_0++;
                goto IL_0068;
            }
        IL_0068:
            num2 = 10;
            num3 = num4;
            goto end_IL_0001;
        IL_0072:
            int num6 = num5 + 1;
            num5 = 0;
            switch (num6)
            {
                case 11:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_0008;
                case 3:
                    goto IL_0012;
                case 4:
                    goto IL_0027;
                case 5:
                case 6:
                    goto IL_0032;
                case 7:
                    goto IL_0047;
                case 8:
                    goto IL_0059;
                case 9:
                case 10:
                    goto IL_0068;
                default:
                    goto IL_00e1;
            }
        IL_00ae:
            num5 = num2;
            switch (num)
            {
                case 1:
                    goto IL_0072;
                default:
                    goto IL_00e1;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num != 0) & (num5 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_00df: Could not find block for branch target IL_00ae*/
            ;
        }
        short result = num3;
        if (num5 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_00e1:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public short CmdWrite(int Handle, PlcMemory Memory, DataType ValType, ushort Block, ushort Address, ushort Count, ref string[] Data)
    {
        checked
        {
            short num3;
            int num = default(int);
            int num5 = default(int);
            try
            {
            IL_0001:
                ProjectData.ClearProjectError();
                num = 1;
                goto IL_0009;
            IL_0009:
                int num2 = 2;
                if (!Class6.smethod_0())
                {
                    goto IL_0013;
                }
                goto IL_0033;
            IL_0013:
                num2 = 3;
                Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
                goto IL_0028;
            IL_0028:
                num2 = 4;
                num3 = -99;
                goto end_IL_0001;
            IL_0033:
                num2 = 6;
                object[] array = new object[Information.UBound(Data, 1) + 1];
                goto IL_0047;
            IL_0047:
                num2 = 9;
                int num4 = Information.UBound(Data, 1);
                for (int i = 0; i <= num4; num2 = 11, i++)
                {
                    goto IL_005a;
                IL_005a:
                    num2 = 10;
                    array[i] = Data[i];
                    continue;
                IL_00ba:
                    int num6 = unchecked(num5 + 1);
                    num5 = 0;
                    switch (num6)
                    {
                        case 17:
                            goto end_IL_0001;
                        case 1:
                            goto IL_0001;
                        case 2:
                            goto IL_0009;
                        case 3:
                            goto IL_0013;
                        case 4:
                            goto IL_0028;
                        case 5:
                        case 6:
                            goto IL_0033;
                        case 7:
                        case 9:
                            goto IL_0047;
                        case 10:
                            goto IL_005a;
                        case 11:
                            continue;
                        case 12:
                            goto end_IL_006e;
                        case 13:
                            goto IL_0087;
                        case 14:
                            goto IL_009a;
                        case 15:
                        case 16:
                            goto IL_00aa;
                        default:
                            goto IL_0147;
                    }
                IL_0110:
                    num5 = num2;
                    switch (num)
                    {
                        case 1:
                            goto IL_00ba;
                        default:
                            goto IL_0147;
                    }
                    continue;
                end_IL_006e:
                    break;
                }
                num2 = 12;
                short num7 = Class7.smethod_3(Handle, Memory, ValType, Block, Address, Count, array);
                goto IL_0087;
            IL_009a:
                num2 = 14;
                Class6.int_0++;
                goto IL_00aa;
            IL_00aa:
                num2 = 16;
                num3 = num7;
                goto end_IL_0001;
            IL_0087:
                num2 = 13;
                if ((Class7.int_1 > 0) & (num7 == 0))
                {
                    goto IL_009a;
                }
                goto IL_00aa;
            end_IL_0001:;
            }
            catch (object obj) when ((obj is Exception) & (num != 0) & (num5 == 0))
            {
                ProjectData.SetProjectError(unchecked((Exception)obj));
                /*Error near IL_0145: Could not find block for branch target IL_0110*/
                ;
            }
            short result = num3;
            if (num5 != 0)
            {
                ProjectData.ClearProjectError();
            }
            return result;
        }
    IL_0147:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public string CmdReadString(int Handle, PlcMemory Memory, ushort Block, ushort Address, ushort PlcDataSize)
    {
        checked
        {
            string text2;
            int num2 = default(int);
            int num7 = default(int);
            try
            {
            IL_0001:
                int num = 1;
                string text = "";
                goto IL_000b;
            IL_000b:
                ProjectData.ClearProjectError();
                num2 = 1;
                goto IL_0013;
            IL_0013:
                num = 3;
                if (!Class6.smethod_0())
                {
                    goto IL_001d;
                }
                goto IL_0040;
            IL_001d:
                num = 4;
                Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
                goto IL_0032;
            IL_0032:
                num = 5;
                text2 = "";
                goto end_IL_0001;
            IL_0040:
                num = 7;
                object[] object_ = default(object[]);
                short num3 = Class7.smethod_2(Handle, Memory, DataType.BYTE8, Block, Address, PlcDataSize, ref object_);
                goto IL_0054;
            IL_0054:
                num = 8;
                if (num3 == 0)
                {
                    goto IL_005c;
                }
                goto IL_00d3;
            IL_005c:
                num = 9;
                short num4 = (short)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(object_[1])));
                goto IL_0074;
            IL_0074:
                num = 10;
                if ((num4 <= 0) | (num4 > unchecked((int)PlcDataSize) - 2))
                {
                    goto IL_0089;
                }
                goto IL_0098;
            IL_0089:
                num = 11;
                text2 = "";
                goto end_IL_0001;
            IL_0098:
                num = 13;
                short num5 = (short)(1 + num4);
                for (short num6 = 2; num6 <= num5; num = 15, num6 = (short)unchecked(num6 + 1))
                {
                    goto IL_00a6;
                IL_00a6:
                    num = 14;
                    text += Conversions.ToString(Strings.Chr(Conversions.ToByte(object_[num6])));
                    continue;
                IL_0108:
                    int num8 = unchecked(num7 + 1);
                    num7 = 0;
                    switch (num8)
                    {
                        case 21:
                            goto end_IL_0001;
                        case 1:
                            goto IL_0001;
                        case 2:
                            goto IL_000b;
                        case 3:
                            goto IL_0013;
                        case 4:
                            goto IL_001d;
                        case 5:
                            goto IL_0032;
                        case 6:
                        case 7:
                            goto IL_0040;
                        case 8:
                            goto IL_0054;
                        case 9:
                            goto IL_005c;
                        case 10:
                            goto IL_0074;
                        case 11:
                            goto IL_0089;
                        case 12:
                        case 13:
                            goto IL_0098;
                        case 14:
                            goto IL_00a6;
                        case 15:
                            continue;
                        case 16:
                        case 17:
                            goto end_IL_00ce;
                        case 18:
                            goto IL_00e7;
                        case 19:
                        case 20:
                            goto IL_00f7;
                        default:
                            goto IL_01a5;
                    }
                IL_016e:
                    num7 = num;
                    switch (num2)
                    {
                        case 1:
                            goto IL_0108;
                        default:
                            goto IL_01a5;
                    }
                    continue;
                end_IL_00ce:
                    break;
                }
                goto IL_00d3;
            IL_00d3:
                num = 17;
                if ((Class7.int_1 > 0) & (num3 == 0))
                {
                    goto IL_00e7;
                }
                goto IL_00f7;
            IL_00e7:
                num = 18;
                Class6.int_0++;
                goto IL_00f7;
            IL_00f7:
                num = 20;
                text2 = text;
            end_IL_0001:;
            }
            catch (object obj) when ((obj is Exception) & (num2 != 0) & (num7 == 0))
            {
                ProjectData.SetProjectError(unchecked((Exception)obj));
                /*Error near IL_01a3: Could not find block for branch target IL_016e*/
                ;
            }
            string result = text2;
            if (num7 != 0)
            {
                ProjectData.ClearProjectError();
            }
            return result;
        }
    IL_01a5:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public short CmdWriteString(int Handle, PlcMemory Memory, ushort Block, ushort Address, ushort PlcDataSize, string Data)
    {
        checked
        {
            short num4;
            int num3 = default(int);
            int num7 = default(int);
            try
            {
            IL_0001:
                int num = 1;
                short num2 = (short)Strings.Len(Data);
                goto IL_000d;
            IL_000d:
                ProjectData.ClearProjectError();
                num3 = 1;
                goto IL_0015;
            IL_0015:
                num = 3;
                if (!Class6.smethod_0())
                {
                    goto IL_001f;
                }
                goto IL_003f;
            IL_001f:
                num = 4;
                Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
                goto IL_0034;
            IL_0034:
                num = 5;
                num4 = -99;
                goto end_IL_0001;
            IL_003f:
                num = 7;
                if ((num2 <= 0) | (num2 > unchecked((int)PlcDataSize) - 2))
                {
                    goto IL_0053;
                }
                goto IL_005e;
            IL_0053:
                num = 8;
                num4 = -21;
                goto end_IL_0001;
            IL_005e:
                num = 10;
                object[] array = new object[unchecked((int)PlcDataSize) - 1 + 1];
                goto IL_006f;
            IL_006f:
                num = 13;
                array[0] = PlcDataSize;
                goto IL_007e;
            IL_007e:
                num = 14;
                array[1] = num2;
                goto IL_008c;
            IL_008c:
                num = 15;
                short num5 = (short)(1 + num2);
                for (short num6 = 2; num6 <= num5; num = 17, num6 = (short)unchecked(num6 + 1))
                {
                    goto IL_009a;
                IL_009a:
                    num = 16;
                    array[num6] = Strings.Asc(Strings.Mid(Data, num6 - 1, 1));
                    continue;
                IL_010c:
                    int num8 = unchecked(num7 + 1);
                    num7 = 0;
                    switch (num8)
                    {
                        case 23:
                            goto end_IL_0001;
                        case 1:
                            goto IL_0001;
                        case 2:
                            goto IL_000d;
                        case 3:
                            goto IL_0015;
                        case 4:
                            goto IL_001f;
                        case 5:
                            goto IL_0034;
                        case 6:
                        case 7:
                            goto IL_003f;
                        case 8:
                            goto IL_0053;
                        case 9:
                        case 10:
                            goto IL_005e;
                        case 11:
                        case 13:
                            goto IL_006f;
                        case 14:
                            goto IL_007e;
                        case 15:
                            goto IL_008c;
                        case 16:
                            goto IL_009a;
                        case 17:
                            continue;
                        case 18:
                            goto end_IL_00c0;
                        case 19:
                            goto IL_00d9;
                        case 20:
                            goto IL_00ec;
                        case 21:
                        case 22:
                            goto IL_00fc;
                        default:
                            goto IL_01b1;
                    }
                IL_017a:
                    num7 = num;
                    switch (num3)
                    {
                        case 1:
                            goto IL_010c;
                        default:
                            goto IL_01b1;
                    }
                    continue;
                end_IL_00c0:
                    break;
                }
                num = 18;
                short num9 = Class7.smethod_3(Handle, Memory, DataType.BYTE8, Block, Address, PlcDataSize, array);
                goto IL_00d9;
            IL_00ec:
                num = 20;
                Class6.int_0++;
                goto IL_00fc;
            IL_00fc:
                num = 22;
                num4 = num9;
                goto end_IL_0001;
            IL_00d9:
                num = 19;
                if ((Class7.int_1 > 0) & (num9 == 0))
                {
                    goto IL_00ec;
                }
                goto IL_00fc;
            end_IL_0001:;
            }
            catch (object obj) when ((obj is Exception) & (num3 != 0) & (num7 == 0))
            {
                ProjectData.SetProjectError(unchecked((Exception)obj));
                /*Error near IL_01af: Could not find block for branch target IL_017a*/
                ;
            }
            short result = num4;
            if (num7 != 0)
            {
                ProjectData.ClearProjectError();
            }
            return result;
        }
    IL_01b1:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public short Bit_Test(int Handle, PlcMemory Memory, ushort Block, ushort Address, ushort Bit, ref bool State)
    {
        short num3;
        int num = default(int);
        int num5 = default(int);
        try
        {
        IL_0001:
            ProjectData.ClearProjectError();
            num = 1;
            goto IL_0008;
        IL_0008:
            int num2 = 2;
            if (!Class6.smethod_0())
            {
                goto IL_0012;
            }
            goto IL_0032;
        IL_0012:
            num2 = 3;
            Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
            goto IL_0027;
        IL_0027:
            num2 = 4;
            num3 = -99;
            goto end_IL_0001;
        IL_0032:
            num2 = 6;
            if (Class6.bool_1)
            {
                goto IL_003c;
            }
            goto IL_0050;
        IL_003c:
            num2 = 7;
            short num4 = Class6.RkRdiwuBr(Handle, Memory, Block, Address, Bit, ref State);
            goto IL_0067;
        IL_0050:
            num2 = 9;
            goto IL_0054;
        IL_0054:
            num2 = 10;
            num4 = Class6.smethod_2(Handle, Memory, Block, Address, Bit, ref State);
            goto IL_0067;
        IL_0067:
            num2 = 12;
            if ((Class7.int_1 > 0) & (num4 == 0))
            {
                goto IL_007a;
            }
            goto IL_008a;
        IL_007a:
            num2 = 13;
            checked
            {
                Class6.int_0++;
                goto IL_008a;
            }
        IL_008a:
            num2 = 15;
            num3 = num4;
            goto end_IL_0001;
        IL_009a:
            int num6 = num5 + 1;
            num5 = 0;
            switch (num6)
            {
                case 16:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_0008;
                case 3:
                    goto IL_0012;
                case 4:
                    goto IL_0027;
                case 5:
                case 6:
                    goto IL_0032;
                case 7:
                    goto IL_003c;
                case 9:
                    goto IL_0050;
                case 10:
                    goto IL_0054;
                case 8:
                case 11:
                case 12:
                    goto IL_0067;
                case 13:
                    goto IL_007a;
                case 14:
                case 15:
                    goto IL_008a;
                default:
                    goto IL_011d;
            }
        IL_00ea:
            num5 = num2;
            switch (num)
            {
                case 1:
                    goto IL_009a;
                default:
                    goto IL_011d;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num != 0) & (num5 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_011b: Could not find block for branch target IL_00ea*/
            ;
        }
        short result = num3;
        if (num5 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_011d:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public bool Bit_Test(int Handle, PlcMemory Memory, ushort Block, ushort Address, ushort Bit)
    {
        bool flag;
        int num = default(int);
        int num4 = default(int);
        try
        {
        IL_0001:
            ProjectData.ClearProjectError();
            num = 1;
            goto IL_0008;
        IL_0008:
            int num2 = 2;
            if (!Class6.smethod_0())
            {
                goto IL_0012;
            }
            goto IL_0031;
        IL_0012:
            num2 = 3;
            Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
            goto IL_0027;
        IL_0027:
            num2 = 4;
            flag = false;
            goto end_IL_0001;
        IL_0031:
            num2 = 6;
            if (Class6.bool_1)
            {
                goto IL_003b;
            }
            goto IL_004f;
        IL_003b:
            num2 = 7;
            bool bool_ = default(bool);
            short num3 = Class6.RkRdiwuBr(Handle, Memory, Block, Address, Bit, ref bool_);
            goto IL_0066;
        IL_004f:
            num2 = 9;
            goto IL_0053;
        IL_0053:
            num2 = 10;
            num3 = Class6.smethod_2(Handle, Memory, Block, Address, Bit, ref bool_);
            goto IL_0066;
        IL_0066:
            num2 = 12;
            if ((Class7.int_1 > 0) & (num3 == 0))
            {
                goto IL_0079;
            }
            goto IL_0089;
        IL_0079:
            num2 = 13;
            checked
            {
                Class6.int_0++;
                goto IL_0089;
            }
        IL_0089:
            num2 = 15;
            flag = bool_;
            goto end_IL_0001;
        IL_0099:
            int num5 = num4 + 1;
            num4 = 0;
            switch (num5)
            {
                case 16:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_0008;
                case 3:
                    goto IL_0012;
                case 4:
                    goto IL_0027;
                case 5:
                case 6:
                    goto IL_0031;
                case 7:
                    goto IL_003b;
                case 9:
                    goto IL_004f;
                case 10:
                    goto IL_0053;
                case 8:
                case 11:
                case 12:
                    goto IL_0066;
                case 13:
                    goto IL_0079;
                case 14:
                case 15:
                    goto IL_0089;
                default:
                    goto IL_0120;
            }
        IL_00eb:
            num4 = num2;
            switch (num)
            {
                case 1:
                    goto IL_0099;
                default:
                    goto IL_0120;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num != 0) & (num4 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_011e: Could not find block for branch target IL_00eb*/
            ;
        }
        bool result = flag;
        if (num4 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_0120:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public short Bit_Set(int Handle, PlcMemory Memory, ushort Block, ushort Address, ushort Bit)
    {
        short num3;
        int num = default(int);
        int num5 = default(int);
        try
        {
        IL_0001:
            ProjectData.ClearProjectError();
            num = 1;
            goto IL_0008;
        IL_0008:
            int num2 = 2;
            if (!Class6.smethod_0())
            {
                goto IL_0012;
            }
            goto IL_0032;
        IL_0012:
            num2 = 3;
            Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
            goto IL_0027;
        IL_0027:
            num2 = 4;
            num3 = -99;
            goto end_IL_0001;
        IL_0032:
            num2 = 6;
            if (Class6.bool_1)
            {
                goto IL_003c;
            }
            goto IL_004e;
        IL_003c:
            num2 = 7;
            short num4 = Class6.smethod_5(Handle, Memory, Block, Address, Bit);
            goto IL_0063;
        IL_004e:
            num2 = 9;
            goto IL_0052;
        IL_0052:
            num2 = 10;
            num4 = Class6.smethod_3(Handle, Memory, Block, Address, Bit);
            goto IL_0063;
        IL_0063:
            num2 = 12;
            if ((Class7.int_1 > 0) & (num4 == 0))
            {
                goto IL_0076;
            }
            goto IL_0086;
        IL_0076:
            num2 = 13;
            checked
            {
                Class6.int_0++;
                goto IL_0086;
            }
        IL_0086:
            num2 = 15;
            num3 = num4;
            goto end_IL_0001;
        IL_0096:
            int num6 = num5 + 1;
            num5 = 0;
            switch (num6)
            {
                case 16:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_0008;
                case 3:
                    goto IL_0012;
                case 4:
                    goto IL_0027;
                case 5:
                case 6:
                    goto IL_0032;
                case 7:
                    goto IL_003c;
                case 9:
                    goto IL_004e;
                case 10:
                    goto IL_0052;
                case 8:
                case 11:
                case 12:
                    goto IL_0063;
                case 13:
                    goto IL_0076;
                case 14:
                case 15:
                    goto IL_0086;
                default:
                    goto IL_0119;
            }
        IL_00e6:
            num5 = num2;
            switch (num)
            {
                case 1:
                    goto IL_0096;
                default:
                    goto IL_0119;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num != 0) & (num5 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_0117: Could not find block for branch target IL_00e6*/
            ;
        }
        short result = num3;
        if (num5 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_0119:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public short Bit_Reset(int Handle, PlcMemory Memory, ushort Block, ushort Address, ushort Bit)
    {
        short num3;
        int num = default(int);
        int num5 = default(int);
        try
        {
        IL_0001:
            ProjectData.ClearProjectError();
            num = 1;
            goto IL_0008;
        IL_0008:
            int num2 = 2;
            if (!Class6.smethod_0())
            {
                goto IL_0012;
            }
            goto IL_0032;
        IL_0012:
            num2 = 3;
            Interaction.MsgBox("请您通过以下联系方式获取通讯驱动授权码：\r\nQQ: 5320 11903\r\nMP: 159 721 99489\r\nE-Mail: liuflamp@126.com", MsgBoxStyle.Exclamation, "注册信息");
            goto IL_0027;
        IL_0027:
            num2 = 4;
            num3 = -99;
            goto end_IL_0001;
        IL_0032:
            num2 = 6;
            if (Class6.bool_1)
            {
                goto IL_003c;
            }
            goto IL_004e;
        IL_003c:
            num2 = 7;
            short num4 = Class6.smethod_6(Handle, Memory, Block, Address, Bit);
            goto IL_0063;
        IL_004e:
            num2 = 9;
            goto IL_0052;
        IL_0052:
            num2 = 10;
            num4 = Class6.smethod_4(Handle, Memory, Block, Address, Bit);
            goto IL_0063;
        IL_0063:
            num2 = 12;
            if ((Class7.int_1 > 0) & (num4 == 0))
            {
                goto IL_0076;
            }
            goto IL_0086;
        IL_0076:
            num2 = 13;
            checked
            {
                Class6.int_0++;
                goto IL_0086;
            }
        IL_0086:
            num2 = 15;
            num3 = num4;
            goto end_IL_0001;
        IL_0096:
            int num6 = num5 + 1;
            num5 = 0;
            switch (num6)
            {
                case 16:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_0008;
                case 3:
                    goto IL_0012;
                case 4:
                    goto IL_0027;
                case 5:
                case 6:
                    goto IL_0032;
                case 7:
                    goto IL_003c;
                case 9:
                    goto IL_004e;
                case 10:
                    goto IL_0052;
                case 8:
                case 11:
                case 12:
                    goto IL_0063;
                case 13:
                    goto IL_0076;
                case 14:
                case 15:
                    goto IL_0086;
                default:
                    goto IL_0119;
            }
        IL_00e6:
            num5 = num2;
            switch (num)
            {
                case 1:
                    goto IL_0096;
                default:
                    goto IL_0119;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num != 0) & (num5 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_0117: Could not find block for branch target IL_00e6*/
            ;
        }
        short result = num3;
        if (num5 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_0119:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public short DataConvert(DataType SourType, object SourData, DataType DestType, ref object DestData, short StartByte = -1)
    {
        short num4;
        int num = default(int);
        int num5 = default(int);
        try
        {
        IL_0001:
            ProjectData.ClearProjectError();
            num = 1;
            goto IL_0008;
        IL_0008:
            int num2 = 2;
            short num3 = Class7.smethod_5(SourType, RuntimeHelpers.GetObjectValue(SourData), DestType, ref DestData, StartByte);
            goto IL_001d;
        IL_001d:
            num2 = 3;
            num4 = num3;
            goto end_IL_0001;
        IL_0026:
            int num6 = num5 + 1;
            num5 = 0;
            switch (num6)
            {
                case 4:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_0008;
                case 3:
                    goto IL_001d;
                default:
                    goto IL_0079;
            }
        IL_0046:
            num5 = num2;
            switch (num)
            {
                case 1:
                    goto IL_0026;
                default:
                    goto IL_0079;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num != 0) & (num5 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_0077: Could not find block for branch target IL_0046*/
            ;
        }
        short result = num4;
        if (num5 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_0079:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public int SetDataBit(int Data, short Bit, bool SetVal)
    {
        int num5;
        int num = default(int);
        int num6 = default(int);
        try
        {
        IL_0001:
            ProjectData.ClearProjectError();
            num = 1;
            goto IL_0008;
        IL_0008:
            int num2 = 2;
            uint num3 = checked((uint)Class7.smethod_11(Data));
            goto IL_0014;
        IL_0014:
            num2 = 3;
            uint num4;
            checked
            {
                num4 = (uint)Math.Round(Math.Pow(2.0, unchecked((double)Bit)));
                goto IL_002e;
            }
        IL_002e:
            num2 = 4;
            if (SetVal)
            {
                goto IL_0034;
            }
            goto IL_004f;
        IL_0034:
            num2 = 5;
            if ((num3 & num4) != num4)
            {
                goto IL_003d;
            }
            goto IL_0070;
        IL_003d:
            num2 = 6;
            num5 = Class7.smethod_12(num3 | num4);
            goto end_IL_0001;
        IL_004f:
            num2 = 9;
            goto IL_0053;
        IL_0053:
            num2 = 10;
            if ((num3 & num4) == num4)
            {
                goto IL_005d;
            }
            goto IL_0070;
        IL_005d:
            num2 = 11;
            num5 = Class7.smethod_12(num3 ^ num4);
            goto end_IL_0001;
        IL_0070:
            num2 = 14;
            num5 = Data;
            goto end_IL_0001;
        IL_0080:
            int num7 = num6 + 1;
            num6 = 0;
            switch (num7)
            {
                case 15:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_0008;
                case 3:
                    goto IL_0014;
                case 4:
                    goto IL_002e;
                case 5:
                    goto IL_0034;
                case 6:
                    goto IL_003d;
                case 9:
                    goto IL_004f;
                case 10:
                    goto IL_0053;
                case 11:
                    goto IL_005d;
                case 7:
                case 8:
                case 12:
                case 13:
                case 14:
                    goto IL_0070;
                default:
                    goto IL_0103;
            }
        IL_00ce:
            num6 = num2;
            switch (num)
            {
                case 1:
                    goto IL_0080;
                default:
                    goto IL_0103;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num != 0) & (num6 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_0101: Could not find block for branch target IL_00ce*/
            ;
        }
        int result = num5;
        if (num6 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_0103:
        throw ProjectData.CreateProjectError(-2146828237);
    }

    public bool GetDataBit(int Data, short Bit)
    {
        bool flag;
        int num = default(int);
        int num5 = default(int);
        try
        {
        IL_0001:
            ProjectData.ClearProjectError();
            num = 1;
            goto IL_0008;
        IL_0008:
            int num2 = 2;
            uint num3 = checked((uint)Class7.smethod_11(Data));
            goto IL_0014;
        IL_0014:
            num2 = 3;
            uint num4;
            checked
            {
                num4 = (uint)Math.Round(Math.Pow(2.0, unchecked((double)Bit)));
                goto IL_002e;
            }
        IL_002e:
            num2 = 4;
            if ((num3 & num4) == num4)
            {
                goto IL_0037;
            }
            goto IL_0041;
        IL_0037:
            num2 = 5;
            flag = true;
            goto end_IL_0001;
        IL_0041:
            num2 = 7;
            goto IL_0044;
        IL_0044:
            num2 = 8;
            flag = false;
            goto end_IL_0001;
        IL_004f:
            int num6 = num5 + 1;
            num5 = 0;
            switch (num6)
            {
                case 6:
                    goto end_IL_0001;
                case 9:
                case 10:
                    goto end_IL_0001;
                case 1:
                    goto IL_0001;
                case 2:
                    goto IL_0008;
                case 3:
                    goto IL_0014;
                case 4:
                    goto IL_002e;
                case 5:
                    goto IL_0037;
                case 7:
                    goto IL_0041;
                case 8:
                    goto IL_0044;
                default:
                    goto IL_00be;
            }
        IL_0089:
            num5 = num2;
            switch (num)
            {
                case 1:
                    goto IL_004f;
                default:
                    goto IL_00be;
            }
        end_IL_0001:;
        }
        catch (object obj) when ((obj is Exception) & (num != 0) & (num5 == 0))
        {
            ProjectData.SetProjectError((Exception)obj);
            /*Error near IL_00bc: Could not find block for branch target IL_0089*/
            ;
        }
        bool result = flag;
        if (num5 != 0)
        {
            ProjectData.ClearProjectError();
        }
        return result;
    IL_00be:
        throw ProjectData.CreateProjectError(-2146828237);
    }
}
