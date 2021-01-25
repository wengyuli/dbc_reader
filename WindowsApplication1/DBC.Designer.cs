namespace WindowsApplication1
{
    partial class DBC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadDBC = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SignalIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startBit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalLen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialogDBC = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadDBC
            // 
            this.btnLoadDBC.Location = new System.Drawing.Point(22, 17);
            this.btnLoadDBC.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLoadDBC.Name = "btnLoadDBC";
            this.btnLoadDBC.Size = new System.Drawing.Size(174, 53);
            this.btnLoadDBC.TabIndex = 0;
            this.btnLoadDBC.Text = "加载DBC文件";
            this.btnLoadDBC.UseVisualStyleBackColor = true;
            this.btnLoadDBC.Click += new System.EventHandler(this.btnLoadDBC_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(208, 17);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(174, 53);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "暂停";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.channel,
            this.transDirection,
            this.message,
            this.ID,
            this.PGN,
            this.frameType,
            this.dataLength,
            this.frameData,
            this.note});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(2094, 489);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // index
            // 
            this.index.HeaderText = "序号";
            this.index.MinimumWidth = 10;
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.index.Width = 50;
            // 
            // channel
            // 
            this.channel.HeaderText = "通道号";
            this.channel.MinimumWidth = 10;
            this.channel.Name = "channel";
            this.channel.ReadOnly = true;
            this.channel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.channel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.channel.Width = 50;
            // 
            // transDirection
            // 
            this.transDirection.HeaderText = "传输方向";
            this.transDirection.MinimumWidth = 10;
            this.transDirection.Name = "transDirection";
            this.transDirection.ReadOnly = true;
            this.transDirection.Width = 200;
            // 
            // message
            // 
            this.message.HeaderText = "消息名";
            this.message.MinimumWidth = 10;
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Width = 200;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // PGN
            // 
            this.PGN.HeaderText = "PGN(H)";
            this.PGN.MinimumWidth = 10;
            this.PGN.Name = "PGN";
            this.PGN.ReadOnly = true;
            this.PGN.Width = 200;
            // 
            // frameType
            // 
            this.frameType.HeaderText = "帧类型";
            this.frameType.MinimumWidth = 10;
            this.frameType.Name = "frameType";
            this.frameType.ReadOnly = true;
            this.frameType.Width = 200;
            // 
            // dataLength
            // 
            this.dataLength.HeaderText = "信号数";
            this.dataLength.MinimumWidth = 10;
            this.dataLength.Name = "dataLength";
            this.dataLength.ReadOnly = true;
            this.dataLength.Width = 200;
            // 
            // frameData
            // 
            this.frameData.HeaderText = "帧数据";
            this.frameData.MinimumWidth = 10;
            this.frameData.Name = "frameData";
            this.frameData.ReadOnly = true;
            this.frameData.Width = 200;
            // 
            // note
            // 
            this.note.HeaderText = "注释";
            this.note.MinimumWidth = 10;
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 200;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(2094, 1197);
            this.splitContainer1.SplitterDistance = 489;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SignalIndex,
            this.SignalID,
            this.SignalName,
            this.SignalFormat,
            this.SignalType,
            this.startBit,
            this.SignalLen,
            this.SignalFactor,
            this.SignalOffset,
            this.SignalMin,
            this.SignalMax,
            this.rawValue,
            this.SignalValue,
            this.SignalUnit,
            this.SignalNote});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 20;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(2094, 700);
            this.dataGridView2.TabIndex = 4;
            // 
            // SignalIndex
            // 
            this.SignalIndex.HeaderText = "序号";
            this.SignalIndex.MinimumWidth = 10;
            this.SignalIndex.Name = "SignalIndex";
            this.SignalIndex.Width = 40;
            // 
            // SignalID
            // 
            this.SignalID.HeaderText = "ID";
            this.SignalID.MinimumWidth = 10;
            this.SignalID.Name = "SignalID";
            this.SignalID.Width = 40;
            // 
            // SignalName
            // 
            this.SignalName.HeaderText = "信号名";
            this.SignalName.MinimumWidth = 10;
            this.SignalName.Name = "SignalName";
            this.SignalName.Width = 68;
            // 
            // SignalFormat
            // 
            this.SignalFormat.HeaderText = "格式";
            this.SignalFormat.MinimumWidth = 10;
            this.SignalFormat.Name = "SignalFormat";
            this.SignalFormat.Width = 50;
            // 
            // SignalType
            // 
            this.SignalType.HeaderText = "类型";
            this.SignalType.MinimumWidth = 10;
            this.SignalType.Name = "SignalType";
            this.SignalType.Width = 50;
            // 
            // startBit
            // 
            this.startBit.HeaderText = "起始位";
            this.startBit.MinimumWidth = 10;
            this.startBit.Name = "startBit";
            this.startBit.Width = 68;
            // 
            // SignalLen
            // 
            this.SignalLen.HeaderText = "位长度";
            this.SignalLen.MinimumWidth = 10;
            this.SignalLen.Name = "SignalLen";
            this.SignalLen.Width = 68;
            // 
            // SignalFactor
            // 
            this.SignalFactor.HeaderText = "转换因子";
            this.SignalFactor.MinimumWidth = 10;
            this.SignalFactor.Name = "SignalFactor";
            this.SignalFactor.Width = 200;
            // 
            // SignalOffset
            // 
            this.SignalOffset.HeaderText = "偏移量";
            this.SignalOffset.MinimumWidth = 10;
            this.SignalOffset.Name = "SignalOffset";
            this.SignalOffset.Width = 68;
            // 
            // SignalMin
            // 
            this.SignalMin.HeaderText = "最小值";
            this.SignalMin.MinimumWidth = 10;
            this.SignalMin.Name = "SignalMin";
            this.SignalMin.Width = 68;
            // 
            // SignalMax
            // 
            this.SignalMax.HeaderText = "最大值";
            this.SignalMax.MinimumWidth = 10;
            this.SignalMax.Name = "SignalMax";
            this.SignalMax.Width = 68;
            // 
            // rawValue
            // 
            this.rawValue.HeaderText = "原始值";
            this.rawValue.MinimumWidth = 10;
            this.rawValue.Name = "rawValue";
            this.rawValue.Width = 68;
            // 
            // SignalValue
            // 
            this.SignalValue.HeaderText = "实际值";
            this.SignalValue.MinimumWidth = 10;
            this.SignalValue.Name = "SignalValue";
            this.SignalValue.Width = 68;
            // 
            // SignalUnit
            // 
            this.SignalUnit.HeaderText = "单位";
            this.SignalUnit.MinimumWidth = 10;
            this.SignalUnit.Name = "SignalUnit";
            this.SignalUnit.Width = 50;
            // 
            // SignalNote
            // 
            this.SignalNote.HeaderText = "注释";
            this.SignalNote.MinimumWidth = 10;
            this.SignalNote.Name = "SignalNote";
            this.SignalNote.Width = 200;
            // 
            // openFileDialogDBC
            // 
            this.openFileDialogDBC.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadDBC);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2094, 115);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2094, 1197);
            this.panel2.TabIndex = 6;
            // 
            // DBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2094, 1312);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DBC";
            this.Text = "AVL Puma Reader";
            this.Load += new System.EventHandler(this.FrmDBC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadDBC;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog openFileDialogDBC;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn startBit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalLen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalNote;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn channel;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameData;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
    }
}