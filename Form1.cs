using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLFunction;

namespace msiTest01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLFunction.SQLFunction sql;
        private void btnConnectDB_Click(object sender, EventArgs e)//連接資料庫
        {            
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                sql = new SQLFunction.SQLFunction();
                //sql = new SQLFunction.SQLFunction(UID,PSW);
                Cursor.Current = Cursors.Default;
                label_showMsg.Text = "連接成功!";
                groupBox1.Enabled = true;
                comboBox_selectField1.Enabled = true;
                comboBox_selectField2.Enabled = true;
                List<string> fieldName = sql.GetSelectField();
                for (int i = 0; i < fieldName.Count; i++)
                {
                    if (i == 0)
                        comboBox_selectField1.Text = comboBox_selectField2.Text = fieldName[i].ToString();
                    comboBox_selectField1.Items.Add(fieldName[i].ToString());
                    comboBox_selectField2.Items.Add(fieldName[i].ToString());
                }
            }
            catch(Exception ex)
            {
                label_showMsg.Text = "連接失敗!";
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox_selectField1_SelectedIndexChanged(object sender, EventArgs e)//選擇欄位一
        {
            label_showMsg.Text = "";
            comboBox_selectValue1.Enabled = true;
            if (comboBox_selectValue1.Items.Count > 0)
                comboBox_selectValue1.Items.Clear();
            try
            {
                Cursor.Current = Cursors.WaitCursor;               
                List<string> fieldNameValue = sql.GetSelectFieldValue(comboBox_selectField1.Text);
                for (int i = 0; i < fieldNameValue.Count; i++)
                {
                    if (i == 0)
                        comboBox_selectValue1.Text = fieldNameValue[i].ToString();
                    comboBox_selectValue1.Items.Add(fieldNameValue[i].ToString());
                }
            }
            catch (Exception ex)
            {
                label_showMsg.Text = ex.ToString();
            }
            Cursor.Current = Cursors.Default;
        }

        private void comboBox_selectField2_SelectedIndexChanged(object sender, EventArgs e)//選擇欄位二
        {
            if (comboBox_selectField2.Text == comboBox_selectField1.Text)
                label_showMsg.Text = "請選取不同欄位!";
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                label_showMsg.Text = "";
                comboBox_selectValue2.Enabled = true;
                if (comboBox_selectValue2.Items.Count > 0)
                    comboBox_selectValue2.Items.Clear();
                try
                {
                    List<string> fieldNameValue = sql.GetSelectFieldValue(comboBox_selectField2.Text);
                    for (int i = 0; i < fieldNameValue.Count; i++)
                    {
                        if (i == 0)
                            comboBox_selectValue2.Text = fieldNameValue[i].ToString();
                        comboBox_selectValue2.Items.Add(fieldNameValue[i].ToString());
                    }
                }
                catch (Exception ex)
                {
                    label_showMsg.Text = ex.ToString();
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)//按下OK
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable dt = new DataTable();
            dt = sql.GetDataTable(comboBox_selectField1.Text, comboBox_selectValue1.Text, comboBox_selectField2.Text, comboBox_selectValue2.Text);
            dataGridView1.DataSource = dt;
            Cursor.Current = Cursors.Default;
        }

    }
}
