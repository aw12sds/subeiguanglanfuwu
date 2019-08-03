using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace WindowsService2
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        Thread Thread;
        Thread Thread1;
        Thread Thread2;
        Thread Thread3;
        Thread Thread4;
        Thread Thread5;
        Thread Thread6;
        Thread Thread7;
        Thread Thread8;
        Thread Thread9;
        Thread Thread10;
        Thread Thread11;
        Thread Thread12;
        Thread Thread13;
        Thread Thread14;
        Thread Thread15;
        Thread Thread16;
        Thread Thread17;
        Thread Thread18;
        Thread Thread19;
        Thread Thread20;
        Thread Thread21;
        Thread Thread22;
        Thread Thread23;
        Thread Thread24;
        Thread Thread25;
        Thread Thread26;
        Thread Thread27;
        Thread Thread28;
        public string ip60;

        Thread t;
        [DllImport("winmm.dll", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern UInt32 timeGetTime();
        protected override void OnStart(string[] args)
        {
            initip();
            t = new Thread(startthread);
            t.Start();

        }
        public void initip()
        {
            try
            {
                StreamReader sr = new StreamReader(@"C:\60.txt", Encoding.Default);
                String line;
                StringBuilder sb = new StringBuilder();
                while ((line = sr.ReadLine()) != null)
                {
                    sb.Append(line.ToString());
                }
                ip60 = sb.ToString();
                String[] lines = new string[] { ip60 + DateTime.Now.ToString() };
                File.AppendAllLines(@"C:\thread.txt", lines);
            }
            catch(Exception ex)
            {
                String[] lines = new string[] { ex.ToString() + DateTime.Now.ToString() };
                File.AppendAllLines(@"C:\thread.txt", lines);
            }
           
        }
        public void startthread()
        {
            while (true)
            {
                Thread1 = new Thread(ercitaosu02);
                Thread2 = new Thread(ercitaosu03);
                Thread3 = new Thread(ercitaosu04);
                Thread4 = new Thread(ercitaosu05);
                Thread5 = new Thread(ercitaosu06);
                Thread6 = new Thread(ercitaosu07);
                Thread7 = new Thread(ercitaosu08);
                Thread8 = new Thread(ercitaosu09);
                Thread9 = new Thread(ercitaosu10);
                Thread10 = new Thread(ercitaosu11);
                Thread11 = new Thread(ercitaosu12);

                Thread12 = new Thread(ht01);
                Thread13 = new Thread(ht02);
                Thread14 = new Thread(ht03);
                Thread15 = new Thread(ht04);
                Thread16 = new Thread(ht05);
                Thread17 = new Thread(ht06);
                Thread18 = new Thread(ht07);
                Thread19 = new Thread(ht08);
                Thread20 = new Thread(ht09);
                Thread21 = new Thread(ht10);
                Thread22 = new Thread(ht11);

                Thread23 = new Thread(ht12);
                Thread24 = new Thread(ht13);
                Thread25 = new Thread(ht14);
                Thread26 = new Thread(ht15);
                Thread27 = new Thread(ht16);
                Thread28 = new Thread(ht17);


                Thread1.Start();
                Thread1.Join();
                Thread.Sleep(100);
                Thread2.Start();
                Thread2.Join();
                Thread.Sleep(100);
                Thread3.Start();
                Thread3.Join();
                Thread.Sleep(100);
                Thread4.Start();
                Thread4.Join();
                Thread.Sleep(100);
                Thread5.Start();

                Thread5.Join();
                Thread.Sleep(100);
                Thread6.Start();

                Thread6.Join();
                Thread.Sleep(100);
                Thread7.Start();
                Thread7.Join();
                Thread.Sleep(100);
                Thread8.Start();
                Thread8.Join();
                Thread.Sleep(100);
                Thread9.Start();
                Thread9.Join();
                Thread.Sleep(100);
                Thread10.Start();
                Thread10.Join();
                Thread.Sleep(100);
                Thread11.Start();
                Thread11.Join();
                Thread.Sleep(100);
                Thread12.Start();

                Thread12.Join();
                Thread.Sleep(100);
                Thread13.Start();
                Thread13.Join();
                Thread.Sleep(100);
                Thread14.Start();
                Thread14.Join();
                Thread.Sleep(100);
                Thread15.Start();
                Thread15.Join();
                Thread.Sleep(100);
                Thread16.Start();
                Thread16.Join();
                Thread.Sleep(100);
                Thread17.Start();
                Thread17.Join();
                Thread.Sleep(100);
                Thread18.Start();
                Thread18.Join();
                Thread.Sleep(100);
                Thread19.Start();
                Thread19.Join();
                Thread.Sleep(100);
                Thread20.Start();
                Thread20.Join();
                Thread.Sleep(100);
                Thread21.Start();
                Thread21.Join();
                Thread.Sleep(100);
                Thread22.Start();
                Thread22.Join();
                Thread.Sleep(100);
                Thread23.Start();
                Thread23.Join();
                Thread.Sleep(100);
                Thread24.Start();
                Thread24.Join();
                Thread.Sleep(100);
                Thread25.Start();
                Thread25.Join();
                Thread.Sleep(100);
                Thread26.Start();
                Thread26.Join();
                Thread.Sleep(100);
                Thread27.Start();
                Thread27.Join();
                Thread.Sleep(100);
                Thread28.Start();
                Thread28.Join();
                Thread.Sleep(100);
                String[] lines = new string[] { "thread" + DateTime.Now.ToString() };
                File.AppendAllLines(@"C:\thread.txt", lines);
                Thread.Sleep(600000);
            }


        }
        public void ht01()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.151", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套1", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht02()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.151", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 72; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("76"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht1("护套2", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }

        public void ht03()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.161", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套3", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht04()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.166", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套4", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht05()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.171", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套5", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht06()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.176", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套6", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }

        public void ht07()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.181", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套7", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }

        public void ht08()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.186", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套8", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht09()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.191", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套9", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht10()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.196", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套10", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht11()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.201", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套11", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht12()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.206", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 72; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("76"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht1("护套12", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }
        }
        public void ht13()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.211", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套13", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht14()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.216", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套14", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht15()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.221", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套15", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht16()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.226", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套16", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ht17()
        {
            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.60.34", System.Convert.ToUInt16("0"), "10.40.60.231", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 68; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 5; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("72"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }

                    string sql = returnht("护套17", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }

        }
        public void ercitaosu02()
        {

            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.50.11", System.Convert.ToUInt16("0"), "10.40.50.13", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 144; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 7; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("148"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("149"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j + 10] = rd;
                    }
                    string sql = returnsql("二套2", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\ercitaosu.txt", lines);
            }


        }
        public void ercitaosu03()
        {

            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.50.11", System.Convert.ToUInt16("0"), "10.40.50.23", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 144; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 7; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("148"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("149"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j + 10] = rd;
                    }
                    string sql = returnsql("二套3", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\exception.txt", lines);
            }


        }
        public void ercitaosu04()
        {

            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.50.11", System.Convert.ToUInt16("0"), "10.40.50.33", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 144; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 7; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("148"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("149"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j + 10] = rd;
                    }
                    string sql = returnsql("二套4", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\exception.txt", lines);
            }


        }
        public void ercitaosu05()
        {

            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.50.11", System.Convert.ToUInt16("0"), "10.40.50.43", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 144; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 7; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("148"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("149"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j + 10] = rd;
                    }
                    string sql = returnsql("二套5", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\exception.txt", lines);
            }


        }
        public void ercitaosu06()
        {

            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.50.11", System.Convert.ToUInt16("0"), "10.40.50.53", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 144; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 7; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("148"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("149"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j + 10] = rd;
                    }
                    string sql = returnsql("二套6", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\exception.txt", lines);
            }


        }
        public void ercitaosu07()
        {

            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.50.11", System.Convert.ToUInt16("0"), "10.40.50.83", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 144; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 7; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("148"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("149"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j + 10] = rd;
                    }
                    string sql = returnsql("二套7", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\exception.txt", lines);
            }


        }
        public void ercitaosu08()
        {

            try
            {

                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.50.11", System.Convert.ToUInt16("0"), "10.40.50.73", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 144; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 7; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("148"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("149"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j + 10] = rd;
                    }
                    string sql = returnsql("二套8", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\exception.txt", lines);
            }


        }
        public void ercitaosu09()
        {

            try
            {
                int Handle1 = 0;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.50.11", System.Convert.ToUInt16("0"), "10.40.50.83", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 144; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 7; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("148"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("149"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j + 10] = rd;
                    }
                    string sql = returnsql("二套9", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }


            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\exception.txt", lines);
            }


        }

        public void ercitaosu10()
        {

            try
            {

                int Handle1 = 0; ;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.50.11", System.Convert.ToUInt16("0"), "10.40.50.93", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);

                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 144; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }

                    }

                    for (int j = 0; j <= 7; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("148"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j] = rd;
                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("149"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j + 10] = rd;
                    }
                    string sql = returnsql("二套10", arrayo, arrayo1);

                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);



                }
                else
                {
                    EntLink = false;
                }
            }
            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\exception.txt", lines);
            }

        }

        public void ercitaosu11()
        {
            try
            {

                int Handle1 = 0; ;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.50.11", System.Convert.ToUInt16("0"), "10.40.50.103", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 144; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }
                        else
                        {
                            String[] lines2 = new string[] { "句柄为" + Handle1 + ",j为" + j / 4 + "re为" + re + "" };
                            File.AppendAllLines(@"C:\re1.txt", lines2);
                            arrayo[j / 4] = -999;
                        }

                    }

                    for (int j = 0; j <= 7; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("148"), System.Convert.ToUInt16(j + ""), ref rd);
                        if (re == 0)
                        {
                            arrayo1[j] = rd;
                        }
                        else
                        {
                            String[] lines2 = new string[] { "句柄为" + Handle1 + ",j为" + j / 4 + "re为" + re + "" };
                            File.AppendAllLines(@"C:\re2.txt", lines2);
                            arrayo1[j] = -999;
                        }

                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("149"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j + 10] = rd;
                    }
                    string sql = returnsql("二套11", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);


                }
                else
                {
                    EntLink = false;
                    MessageBox.Show("PLC联接失败: " + restr);
                }
            }
            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\exception.txt", lines);
            }

        }

        public void ercitaosu12()
        {
            try
            {

                int Handle1 = 0; ;
                long ScanCount;
                bool EntLink;
                WinTcpS7.PlcClient PLC = new WinTcpS7.PlcClient();
                short re = 0;
                string restr = "";
                re = PLC.EntLink("10.40.50.11", System.Convert.ToUInt16("0"), "10.40.50.113", System.Convert.ToUInt16("102"), System.Convert.ToUInt16(0), System.Convert.ToUInt16(2), "QIU12EA6OYPWPIQT1901C15S7/V34", ref Handle1);
                if (re == 0)
                {
                    EntLink = true;
                    EntLink = true;
                    short i = 0;
                    object[] RD = null;
                    RD = new object[System.Convert.ToUInt16("1")];
                    EntLink = true;
                    bool rd = false;

                    int var1 = 4;
                    WinTcpS7.PlcClient.PlcMemory mry = (WinTcpS7.PlcClient.PlcMemory)var1;
                    var1 = 5;
                    WinTcpS7.PlcClient.DataType typ = (WinTcpS7.PlcClient.DataType)var1;
                    object[] arrayo = new object[40];
                    for (int j = 0; j < arrayo.Length; j++)
                    {
                        arrayo[j] = 0;
                    }
                    object[] arrayo1 = new object[40];
                    for (int j = 0; j <= 144; j = j + 4)
                    {
                        re = PLC.CmdRead(Handle1, mry, typ, System.Convert.ToUInt16("20"), System.Convert.ToUInt16(j + ""), System.Convert.ToUInt16("1"), ref RD);
                        if (re == 0)
                        {
                            arrayo[j / 4] = RD[0];
                        }
                        else
                        {
                            String[] lines2 = new string[] { "句柄为" + Handle1 + ",j为" + j / 4 + "re为" + re + "" };
                            File.AppendAllLines(@"C:\re1.txt", lines2);
                            arrayo[j / 4] = -999;
                        }

                    }

                    for (int j = 0; j <= 7; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("148"), System.Convert.ToUInt16(j + ""), ref rd);
                        if (re == 0)
                        {
                            arrayo1[j] = rd;
                        }
                        else
                        {
                            String[] lines2 = new string[] { "句柄为" + Handle1 + ",j为" + j / 4 + "re为" + re + "" };
                            File.AppendAllLines(@"C:\re2.txt", lines2);
                            arrayo1[j] = -999;
                        }

                    }
                    for (int j = 0; j <= 3; j++)
                    {
                        re = PLC.Bit_Test(Handle1, mry, System.Convert.ToUInt16("20"), System.Convert.ToUInt16("149"), System.Convert.ToUInt16(j + ""), ref rd);
                        arrayo1[j + 10] = rd;
                    }
                    string sql = returnsql("二套12", arrayo, arrayo1);
                    SQLhelp.ExecuteScalar(sql, "subeichejian", CommandType.Text);
                    EntLink = false;
                    re = PLC.DeLink(Handle1);


                }
                else
                {
                    EntLink = false;
                    MessageBox.Show("PLC联接失败: " + restr);
                }
            }
            catch (Exception ex)
            {
                String[] lines = new string[] { ex.ToString() };
                File.AppendAllLines(@"C:\exception.txt", lines);
            }

        }
        public String returnsql(string device, object[] arrayo, object[] arrayo1)
        {
            return "insert into ercitaosu values('" + device + "','" + DateTime.Now.ToString() + "'," + arrayo[0] + "," + arrayo[1] + "," + arrayo[2] + "," + arrayo[3] + "," + arrayo[4] + "," + arrayo[5] + "," + arrayo[6] + "," + arrayo[7] + "," + arrayo[8] + "," + arrayo[9] + "," + arrayo[10] + "," + arrayo[11] + "," + arrayo[12] + "," + arrayo[13] + "," + arrayo[14] + "," + arrayo[15] + "," + arrayo[16] + "," + arrayo[17] + "," + arrayo[18] + "," + arrayo[19] + "," + arrayo[20] + "," + arrayo[21] + "," + arrayo[22] + "," + arrayo[23] + "," + arrayo[24] + "," + arrayo[25] + "," + arrayo[26] + "," + arrayo[27] + "," + arrayo[28] + "," + arrayo[29] + "," + arrayo[30] + "," + arrayo[31] + "," + arrayo[32] + "," + arrayo[33] + "," + arrayo[34] + "," + arrayo[35] + "," + arrayo[36] + ",'" + arrayo1[0] + "','" + arrayo1[1] + "','" + arrayo1[2] + "','" + arrayo1[3] + "','" + arrayo1[4] + "','" + arrayo1[5] + "','" + arrayo1[6] + "','" + arrayo1[7] + "','" + arrayo1[10] + "','" + arrayo1[11] + "','" + arrayo1[12] + "','" + arrayo1[13] + "')";
        }
        public String returnht(string device, object[] arrayo, object[] arrayo1)
        {
            return "insert into ht values('" + device + "','" + DateTime.Now.ToString() + "'," + arrayo[0] + "," + arrayo[1] + "," + arrayo[2] + "," + arrayo[3] + "," + arrayo[4] + "," + arrayo[5] + "," + arrayo[6] + "," + arrayo[7] + "," + arrayo[8] + "," + arrayo[9] + "," + arrayo[10] + "," + arrayo[11] + "," + arrayo[12] + "," + arrayo[13] + "," + "0" + "," + arrayo[14] + "," + arrayo[15] + "," + arrayo[16] + "," + arrayo[17] + ",'" + arrayo1[0] + "','" + arrayo1[1] + "','" + arrayo1[2] + "','" + arrayo1[3] + "','" + arrayo1[4] + "','" + arrayo1[5] + "')";
        }
        public String returnht1(string device, object[] arrayo, object[] arrayo1)
        {
            return "insert into ht values('" + device + "','" + DateTime.Now.ToString() + "'," + arrayo[0] + "," + arrayo[1] + "," + arrayo[2] + "," + arrayo[3] + "," + arrayo[4] + "," + arrayo[5] + "," + arrayo[6] + "," + arrayo[7] + "," + arrayo[8] + "," + arrayo[9] + "," + arrayo[10] + "," + arrayo[11] + "," + arrayo[12] + "," + arrayo[13] + "," + arrayo[14] + "," + arrayo[15] + "," + arrayo[16] + "," + arrayo[17] + "," + arrayo[17] + ",'" + arrayo1[0] + "','" + arrayo1[1] + "','" + arrayo1[2] + "','" + arrayo1[3] + "','" + arrayo1[4] + "','" + arrayo1[5] + "')";
        }
        protected override void OnStop()
        {
        }
        public void ondebug()
        {
            OnStart(null);
        }
    }
}
