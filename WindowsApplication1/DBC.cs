using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsApplication1
{

    public partial class DBC : Form
    {

        //// 处理帧发送
        public void onsend(IntPtr  ctx, IntPtr  pojbj)
        {
            Ctx info = (Ctx)Marshal.PtrToStructure(ctx, typeof(Ctx));
            VCI_CAN_OBJ obj = (VCI_CAN_OBJ)Marshal.PtrToStructure(pojbj, typeof(VCI_CAN_OBJ));
            //if (Form1.VCI_Transmit(m_devInfo.nDevType, m_devInfo.nDevIndex, m_devInfo.nChIndex, ref obj, 1) == 0)
            //{
            //    ;
            //}
        }


        // 多帧处理完会进入该函数
        public void onMultiTransDoneFunc(IntPtr ctx,ref DBCMessage pMsg, ref Byte data,UInt16 nLen,Byte nDirection)
        {
            Ctx info = (Ctx)Marshal.PtrToStructure(ctx, typeof(Ctx));
            if (ctx !=null)
            {

            }
        }
 
        public delegate void Onsend(IntPtr ctx, IntPtr pojbj);
        public delegate void OnMultiTransDone(IntPtr ctx, ref DBCMessage pMsg, ref Byte data, UInt16 nLen, Byte nDirection);

        [DllImport("LibDBCManager.dll")]
        static extern Int32 DBC_Init();
        [DllImport("LibDBCManager.dll")]
        static extern void DBC_Release(UInt32 hDBChandle);
        [DllImport("LibDBCManager.dll")]
        static extern bool DBC_LoadFile(Int32 hDBC, ref FileInfo fileinfo);

        [DllImport("LibDBCManager.dll")]
        static extern bool DBC_GetFirstMessage(Int32 hDBC, IntPtr pMsg);
        //static extern bool DBC_GetFirstMessage(Int32 hDBC, ref DBCMessage pMsg);
        [DllImport("LibDBCManager.dll")]
        //static extern bool DBC_GetNextMessage(Int32 hDBC, ref DBCMessage pMsg);
        static extern bool DBC_GetNextMessage(Int32 hDBC, IntPtr pMsg);
        [DllImport("LibDBCManager.dll")]
        static extern bool DBC_GetMessageById(UInt32 hDBC, UInt32 nID, ref DBCMessage pMsg);
        [DllImport("LibDBCManager.dll")]
        static extern UInt32 DBC_GetMessageCount(Int32 hDBC);

        //此函数用以解析帧数据，返回解析结果.返回值为 true 表示解析成功， false 表示失败。
        [DllImport("LibDBCManager.dll")]
        static extern bool DBC_Analyse(UInt32 hDBC, IntPtr pOb, ref DBCMessage pMsg);

        //用户需要调用该函数把接收到的帧数据传进来， 涉及多帧传输必须要调用， 否则无法实
        //现报文交互， 可以实现为接收到每一个帧都调用该函数一次。
        [DllImport("LibDBCManager.dll")]
        static extern void DBC_OnReceive(UInt32 hDBC, IntPtr pObj);

        //此函数用以设置实际发送数据的回调函数, 涉及数据发送时必须设置，只需要设置一次
        [DllImport("LibDBCManager.dll")]
        static extern void DBC_SetSender(Int32 hDBC, Onsend sender, IntPtr ctx);

        //
        [DllImport("LibDBCManager.dll")]
        static extern void DBC_SetOnMultiTransDoneFunc(UInt32 hDBC, OnMultiTransDone func, IntPtr ctx);

        [DllImport("LibDBCManager.dll")]
        static extern bool DBC_Send(UInt32 hDBC, ref DBCMessage pMsg);

        public string filename;
        private int m_hDBC;
        public  Ctx m_ctx;
        public DevInfo m_devInfo = new DevInfo();
       
        public System.IO.FileInfo info;
        private List<DBCMessage> m_vMsg=new List<DBCMessage>();

        public DBC()
        {
            InitializeComponent();
            m_hDBC = -1;
            m_devInfo.nDevType = Form1.m_devtype;
            m_devInfo.nDevIndex = Form1.m_devind;
            m_devInfo.nChIndex = Form1.m_canind;
        }
        

        private void FrmDBC_Load(object sender, EventArgs e)
        {
             m_hDBC = DBC_Init();
            if (m_hDBC==-1)
            {
                MessageBox.Show("生成DBC句柄失败");
            }
            //Marshal.
            m_ctx.powner = this.Handle;
            m_ctx.devinfo = m_devInfo;

            IntPtr pt = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Ctx)));

            DBC_SetSender(m_hDBC, onsend, pt);

            //DBC_SetOnMultiTransDoneFunc(m_hDBC, OnMultiTransDone, pt);
        }

        public void ReadAllMessage()
        {
           
            IntPtr pt = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(DBCMessage)));
            if (DBC_GetFirstMessage(m_hDBC,pt))
            {
                DBCMessage msg = (DBCMessage)Marshal.PtrToStructure(pt, typeof(DBCMessage));
                m_vMsg.Add(msg);
                int index1= dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index1].Cells[3].Value = Regex.Replace(System.Text.Encoding.Default.GetString(msg.strName), @"\0", string.Empty);
                //this.dataGridView1.Rows[index].Cells[4].Value = new string(msg.strName);
                //this.dataGridView1.Rows[index].Cells[4].Value = Convert.ToBase64String(msg.strName);
                //this.dataGridView1.Rows[index].Cells[4].Value = System.Text.Encoding.ASCII.GetString(msg.strName);
                //this.dataGridView1.Rows[index].Cells[4].Value = msg.strName;
                //this.dataGridView1.Rows[index].Cells[4].Value = System.Convert.ToString((Int32)msg.nID, 16);

                this.dataGridView1.Rows[index1].Cells[4].Value = msg.nID;
                if(msg.nExtend==0)
                {
                    this.dataGridView1.Rows[index1].Cells[6].Value = "标准帧";
                }
                else
                {
                    this.dataGridView1.Rows[index1].Cells[6].Value = "扩展帧";
                }
                
                this.dataGridView1.Rows[index1].Cells[9].Value = Regex.Replace(System.Text.Encoding.Default.GetString(msg.strComment), @"\0", string.Empty);
                this.dataGridView1.Rows[index1].Cells[7].Value = msg.nSignalCount;
                for (int i=0;i<msg.nSignalCount;i++)
                {
                    int index2= dataGridView2.Rows.Add();
                    this.dataGridView2.Rows[index2].Cells[14].Value = Regex.Replace(System.Text.Encoding.Default.GetString(msg.vSignals[i].strComment), @"\0", string.Empty);
                    this.dataGridView2.Rows[index2].Cells[13].Value = Regex.Replace(System.Text.Encoding.Default.GetString(msg.vSignals[i].unit),@"\0", string.Empty);
                    this.dataGridView2.Rows[index2].Cells[12].Value = msg.vSignals[i].nValue;
                    this.dataGridView2.Rows[index2].Cells[11].Value = msg.vSignals[i].nRawValue;
                    this.dataGridView2.Rows[index2].Cells[10].Value = msg.vSignals[i].nMax;
                    this.dataGridView2.Rows[index2].Cells[9].Value = msg.vSignals[i].nMin;
                    this.dataGridView2.Rows[index2].Cells[8].Value = msg.vSignals[i].nOffset;
                    this.dataGridView2.Rows[index2].Cells[7].Value = msg.vSignals[i].nFactor;
                    this.dataGridView2.Rows[index2].Cells[6].Value = msg.vSignals[i].nLen;
                    this.dataGridView2.Rows[index2].Cells[5].Value = msg.vSignals[i].nStartBit;
                    this.dataGridView2.Rows[index2].Cells[4].Value = msg.vSignals[i].is_signed;
                    this.dataGridView2.Rows[index2].Cells[3].Value = msg.vSignals[i].is_motorola;
                    this.dataGridView2.Rows[index2].Cells[2].Value = Regex.Replace(System.Text.Encoding.Default.GetString(msg.vSignals[i].strName), @"\0", string.Empty);
                    this.dataGridView2.Rows[index2].Cells[1].Value = msg.nID;
                    this.dataGridView2.Rows[index2].Cells[0].Value = Regex.Replace(System.Text.Encoding.Default.GetString(msg.vSignals[i].strValDesc), @"\0", string.Empty);
                }


                Marshal.DestroyStructure(pt, typeof(DBCMessage));//释放内存
                pt = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(DBCMessage)));

                while (DBC_GetNextMessage(m_hDBC,pt))
                {   
                    
                    msg = (DBCMessage)Marshal.PtrToStructure(pt, typeof(DBCMessage));
                    m_vMsg.Add(msg);

                    index1 = dataGridView1.Rows.Add();
                    
                    this.dataGridView1.Rows[index1].Cells[3].Value = Regex.Replace(System.Text.Encoding.Default.GetString(msg.strName), @"\0", string.Empty);
                    this.dataGridView1.Rows[index1].Cells[4].Value = msg.nID;
                    if (msg.nExtend == 0)
                    {
                        this.dataGridView1.Rows[index1].Cells[6].Value = "标准帧";
                    }
                    else
                    {
                        this.dataGridView1.Rows[index1].Cells[6].Value = "扩展帧";
                    }
                    this.dataGridView1.Rows[index1].Cells[9].Value = Regex.Replace(System.Text.Encoding.Default.GetString(msg.strComment), @"\0", string.Empty);
                    this.dataGridView1.Rows[index1].Cells[7].Value = msg.nSignalCount;
                    //Marshal.FreeHGlobal(pt1);//释放内存
                    Marshal.DestroyStructure(pt, typeof(DBCMessage));
                    pt = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(DBCMessage)));
                }
               
            }

        }
        
      unsafe   private void btnLoadDBC_Click(object sender, EventArgs e)
        {
            openFileDialogDBC.InitialDirectory = @"C:\Users\pechc\Desktop";
            openFileDialogDBC.Filter = "DBC文件|*.dbc";
            openFileDialogDBC.RestoreDirectory = true  ;// *如果值为false，那么下一次选择文件的初始目录是上一次你选择的那个目录，
            openFileDialogDBC.FilterIndex = 1;
            if (openFileDialogDBC .ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialogDBC .FileName;
                string strFile = Path.GetFullPath(openFileDialogDBC.FileName);//不能只取得路径
                if (strFile==null)
                {
                    MessageBox.Show("路径为空");
                    return;
                }
                FileInfo fileInfo;
                byte[] str = System.Text.Encoding.Default.GetBytes(strFile);
                Marshal.Copy(str, 0, (IntPtr)fileInfo.strFilePath, str.Length);
                //Marshal.StructureToPtr(str, (IntPtr)fileInfo.strFilePath, true);
               

                fileInfo.nType = ProtocolType.DBC_CAN;
                fileInfo.merge = 0;

               // IntPtr pt = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(FileInfo)));

               // Marshal.StructureToPtr(fileInfo ,)

                if (!DBC_LoadFile(m_hDBC,ref fileInfo))
                {
                    MessageBox.Show("加载文件错误");
                    return;
                }
                uint nCount = DBC_GetMessageCount(m_hDBC);
                if (DBC_GetMessageCount(m_hDBC)==0)
                {
                    MessageBox.Show("文件中不含有消息");
                }
                ReadAllMessage();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowIndex = dataGridView1.CurrentCell.RowIndex;
            if(RowIndex >-1)
            {
                for (int i = 0; i < m_vMsg.Count; i++)
                {
                    if (m_vMsg[i].nID == Convert.ToUInt32(dataGridView1.Rows[RowIndex].Cells["ID"].Value))
                    {
                        dataGridView2.Rows.Clear();
                        
                        for(int j=0;j<m_vMsg[i].nSignalCount;j++)
                        {
                            int dgv2index = dataGridView2.Rows.Add();
                            this.dataGridView2.Rows[dgv2index].Cells[14].Value = Regex.Replace(System.Text.Encoding.Default.GetString(m_vMsg[i].vSignals[j].strComment), @"\0", string.Empty);
                            this.dataGridView2.Rows[dgv2index].Cells[13].Value = Regex.Replace(System.Text.Encoding.Default.GetString(m_vMsg[i].vSignals[j].unit), @"\0", string.Empty);
                            this.dataGridView2.Rows[dgv2index].Cells[12].Value = m_vMsg[i].vSignals[j].nValue;
                            this.dataGridView2.Rows[dgv2index].Cells[11].Value = m_vMsg[i].vSignals[j].nRawValue;
                            this.dataGridView2.Rows[dgv2index].Cells[10].Value = m_vMsg[i].vSignals[j].nMax;
                            this.dataGridView2.Rows[dgv2index].Cells[9].Value = m_vMsg[i].vSignals[j].nMin;
                            this.dataGridView2.Rows[dgv2index].Cells[8].Value = m_vMsg[i].vSignals[j].nOffset;
                            this.dataGridView2.Rows[dgv2index].Cells[7].Value = m_vMsg[i].vSignals[j].nFactor;
                            this.dataGridView2.Rows[dgv2index].Cells[6].Value = m_vMsg[i].vSignals[j].nLen;
                            this.dataGridView2.Rows[dgv2index].Cells[5].Value = m_vMsg[i].vSignals[j].nStartBit;
                            this.dataGridView2.Rows[dgv2index].Cells[4].Value = m_vMsg[i].vSignals[j].is_signed;
                            this.dataGridView2.Rows[dgv2index].Cells[3].Value = m_vMsg[i].vSignals[j].is_motorola;
                            this.dataGridView2.Rows[dgv2index].Cells[2].Value = Regex.Replace(System.Text.Encoding.Default.GetString(m_vMsg[i].vSignals[j].strName), @"\0", string.Empty);
                            this.dataGridView2.Rows[dgv2index].Cells[1].Value = m_vMsg[i].nID;
                            this.dataGridView2.Rows[dgv2index].Cells[0].Value = Regex.Replace(System.Text.Encoding.Default.GetString(m_vMsg[i].vSignals[j].strValDesc), @"\0", string.Empty);
                        }
                    }
                }
            }
            
        }
    }
}
