namespace msiTest01
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnectDB = new System.Windows.Forms.Button();
            this.comboBox_selectField1 = new System.Windows.Forms.ComboBox();
            this.comboBox_selectValue1 = new System.Windows.Forms.ComboBox();
            this.comboBox_selectField2 = new System.Windows.Forms.ComboBox();
            this.comboBox_selectValue2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_showMsg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnectDB
            // 
            this.btnConnectDB.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDB.Location = new System.Drawing.Point(12, 25);
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.Size = new System.Drawing.Size(133, 52);
            this.btnConnectDB.TabIndex = 0;
            this.btnConnectDB.Text = "Connect";
            this.btnConnectDB.UseVisualStyleBackColor = true;
            this.btnConnectDB.Click += new System.EventHandler(this.btnConnectDB_Click);
            // 
            // comboBox_selectField1
            // 
            this.comboBox_selectField1.Enabled = false;
            this.comboBox_selectField1.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selectField1.FormattingEnabled = true;
            this.comboBox_selectField1.Location = new System.Drawing.Point(166, 33);
            this.comboBox_selectField1.Name = "comboBox_selectField1";
            this.comboBox_selectField1.Size = new System.Drawing.Size(337, 34);
            this.comboBox_selectField1.TabIndex = 1;
            this.comboBox_selectField1.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectField1_SelectedIndexChanged);
            // 
            // comboBox_selectValue1
            // 
            this.comboBox_selectValue1.Enabled = false;
            this.comboBox_selectValue1.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selectValue1.FormattingEnabled = true;
            this.comboBox_selectValue1.Location = new System.Drawing.Point(519, 33);
            this.comboBox_selectValue1.Name = "comboBox_selectValue1";
            this.comboBox_selectValue1.Size = new System.Drawing.Size(428, 34);
            this.comboBox_selectValue1.TabIndex = 2;
            // 
            // comboBox_selectField2
            // 
            this.comboBox_selectField2.Enabled = false;
            this.comboBox_selectField2.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selectField2.FormattingEnabled = true;
            this.comboBox_selectField2.Location = new System.Drawing.Point(166, 85);
            this.comboBox_selectField2.Name = "comboBox_selectField2";
            this.comboBox_selectField2.Size = new System.Drawing.Size(337, 34);
            this.comboBox_selectField2.TabIndex = 3;
            this.comboBox_selectField2.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectField2_SelectedIndexChanged);
            // 
            // comboBox_selectValue2
            // 
            this.comboBox_selectValue2.Enabled = false;
            this.comboBox_selectValue2.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selectValue2.FormattingEnabled = true;
            this.comboBox_selectValue2.Location = new System.Drawing.Point(519, 85);
            this.comboBox_selectValue2.Name = "comboBox_selectValue2";
            this.comboBox_selectValue2.Size = new System.Drawing.Size(428, 34);
            this.comboBox_selectValue2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 448);
            this.dataGridView1.TabIndex = 5;
            // 
            // label_showMsg
            // 
            this.label_showMsg.AutoSize = true;
            this.label_showMsg.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_showMsg.Location = new System.Drawing.Point(172, 36);
            this.label_showMsg.Name = "label_showMsg";
            this.label_showMsg.Size = new System.Drawing.Size(0, 31);
            this.label_showMsg.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.comboBox_selectField1);
            this.groupBox1.Controls.Add(this.comboBox_selectField2);
            this.groupBox1.Controls.Add(this.comboBox_selectValue1);
            this.groupBox1.Controls.Add(this.comboBox_selectValue2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1162, 135);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "欄位二：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "欄位一：";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Segoe Marker", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(989, 50);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(133, 52);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 684);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_showMsg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConnectDB);
            this.Name = "Form1";
            this.Text = "msi@NTUT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectDB;
        private System.Windows.Forms.ComboBox comboBox_selectField1;
        private System.Windows.Forms.ComboBox comboBox_selectValue1;
        private System.Windows.Forms.ComboBox comboBox_selectField2;
        private System.Windows.Forms.ComboBox comboBox_selectValue2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_showMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

