using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Example
{
    public partial class Form1 : Form
    {
        static string messageFromBord = "";
        static Double currentBalance = 0;
        static string[] bookList= { "",""};

        public Form1()
        {
            InitializeComponent();
        }

        private void BorrowHidden_TextChanged(object sender, EventArgs e)
        {
            if (BorrowPage_StuInfoBlock.Text.Trim().Length >= 35&TabControl.SelectedIndex==1)
            {
                if (BorrowPage_StuInfoBlock.Text.Substring(0, 35) == "10010000100001111111000111101010101")
                {
                    BorrowPage_NameTextBlock.Text = "james";
                    BorrowPage_ClassTextBlock.Text = "物联网";
                    BorrowPage_DepartTextBlock.Text = "信息工程系";
                    BorrowPage_StuInfoBlock.Text = "";
                    pictureBox.BackgroundImage = WinForm_Example.Properties.Resources.pic;
                    //show currentBalance
                    //RechargePage_MoneyBlock.Text = currentBalance.ToString();
                    timer1.Enabled = false;
                }
            }
        }      
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                RechargePage_stuInfoBox.Focus();
            }
            if (TabControl.SelectedIndex == 1)
            {
                
                BorrowPage_NameTextBlock.Text = "";
                BorrowPage_ClassTextBlock.Text = "";
                BorrowPage_DepartTextBlock.Text = "";
                //TODO: Don't forget clear pic
                BookInfo_TextBox.Focus();
            }
            if (TabControl.SelectedIndex == 2)
            {
                ReturnPage_HiddenBox_stuInfo.Focus();
                
            }
            timer1.Enabled = true;
        }
        
        private void Borrow_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("借阅成功");
            timer1.Enabled = true;
            //RechargePage_HiddenLable.Focus();

            BorrowPage_NameTextBlock.Text = "";
            BorrowPage_ClassTextBlock.Text = "";
            BorrowPage_DepartTextBlock.Text = "";
            pictureBox.BackgroundImage = null;
            //Clear DataGridView
            dataSet1.Tables[0].Rows.Clear();
            /*DataTable dt = (DataTable)dataGridView1.DataSource;
            dt.Rows.Clear();
            dataGridView1.DataSource = dt;
            BorrowPage_StuInfoBlock.Focus(); 
            */
            dataGridView1.Refresh();
            messageFromBord = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void Button1_Click(object sender, EventArgs e)
        {
            currentBalance += Convert.ToDouble( RechargePage_TextBox.Text.Trim());
            serialPort1.WriteLine(RechargePage_TextBox.Text.Trim());
            //MessageBox.Show("充值成功\n" + "当前余额 : " + RechargePage_CurrentMoneyLable.Text);
            //RechargePage_MoneyBlock.Text = currentBalance.ToString();
            timer1.Enabled = true;
            MessageBox.Show("充值成功,当前余额："+currentBalance.ToString()+"元");
            RechargePage_MoneyBlock.Text = "";
            RechargePage_TextBox.Text = "";
            
            RechargePage_stuInfoBox.Focus();
            timer1.Enabled = true;
            //RechargePage_stuInfoBox.Text = "";

        }
        
        private void BookInfo_lable_TextChanged(object sender, EventArgs e) {}

        private void BookInfo_TextBox_TextChanged(object sender, EventArgs e)
        {      
            if (BookInfo_TextBox.Text == "9787111298076") 
            {
                DataRow d1 = dataSet1.Tables[0].NewRow();
                d1[0] = "Linux操作系统案列教程";
                d1[1] = "彭颖慧";
                d1[2] = "机械工业出版社";
                d1[3] = DateTime.Now.ToString();
                dataSet1.Tables[0].Rows.Add(d1);
                bookList[0] = "9787111298076";
                dataGridView1.DataSource = dataSet1.Tables[0];
                dataGridView1.Refresh();

                BookInfo_TextBox.Text = "";
            }

            if (BookInfo_TextBox.Text == "9787111404446")
            {
                DataRow d2 = dataSet1.Tables[0].NewRow();
                d2[0] = "RFID技术与应用";
                d2[1] = "方龙雄";
                d2[2] = "机械工业出版社";
                d2[3] = DateTime.Now.ToShortDateString();
                dataSet1.Tables[0].Rows.Add(d2);
                bookList[1] = "9787111404446";
                dataGridView1.DataSource = dataSet1.Tables[0];
                dataGridView1.Refresh();

                BookInfo_TextBox.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (messageFromBord.Length > 0)
            {
                if (TabControl.SelectedIndex == 0)
                {
                    
                    RechargePage_stuInfoBox.Text = messageFromBord;
                    messageFromBord = "";
                }
                if (TabControl.SelectedIndex == 1)
                {
                    BorrowPage_StuInfoBlock.Text = messageFromBord;
                    messageFromBord = "";
                }
                if (TabControl.SelectedIndex == 2)
                {
                    ReturnPage_HiddenBox_stuInfo.Text = messageFromBord;
                    messageFromBord = "";
                }
               // timer1.Enabled = false;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            messageFromBord = serialPort1.ReadLine();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM8";
            serialPort1.BaudRate = 9600;
            serialPort1.Open();
        }

        private void RechargePage_HiddenLable_TextChanged(object sender, EventArgs e)
        {
           
            //RechargePage_MoneyBlock.Text = currentBalance.ToString();
        }

        private void ReturnPage_ReturnButton_Click(object sender, EventArgs e){}

        private void ReturnPage_HiddenLabel_TextChanged(object sender, EventArgs e){}

        private void pictureBox3_Click(object sender, EventArgs e){}

        private void pictureBox1_Click(object sender, EventArgs e){}

        private void ReturnPage_HiddenBox_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ReturnPage_NameLable.Text = "James";
            ReturnPage_ClassLabel.Text = "物联网";
            ReturnPage_DepartLabel.Text = "信息工程系";
            pictureBox1.BackgroundImage = Properties.Resources.pic;
           
            if (bookList[0].Length > 12)
            {
                DataRow d1 = dataSet2.Tables[0].NewRow();
                d1[0] = "Linux操作系统案列教程";
                d1[1] = "彭颖慧";
                d1[2] = "机械工业出版社";
                d1[3] = DateTime.Now.ToString();
                d1[4] ="9787111298076";
                dataSet2.Tables[0].Rows.Add(d1);
                bookList[0] = ""; 
                dataGridView2.DataSource = dataSet2.Tables[0];
                dataGridView2.Refresh();

                ReturnPage_HiddenBox_stuInfo.Text = "";
            }

            if (bookList[1].Length>12)
            {
                DataRow d2 = dataSet2.Tables[0].NewRow();
                d2[0] = "RFID技术与应用";
                d2[1] = "方龙雄";
                d2[2] = "机械工业出版社";
                d2[3] = DateTime.Now.ToShortDateString();
                d2[4] = "9787111404446";
                dataSet2.Tables[0].Rows.Add(d2);
                bookList[1] = ""; 
                dataGridView2.DataSource = dataSet2.Tables[0];
                dataGridView2.Refresh();

                ReturnPage_HiddenBox_stuInfo.Text = "";
            }

            ReturnPage_HiddenBox_bookInfo.Focus();
        }

        private void ReturnPage_HiddenBox_bookInfo_TextChanged(object sender, EventArgs e)
        {
            if (ReturnPage_HiddenBox_bookInfo.Text.Length != 13)
                return;
            dataSet2.Tables[0].Rows.Remove(dataSet2.Tables[0].Select("id=" + "'" + ReturnPage_HiddenBox_bookInfo.Text.Trim() + "'")[0]);
            dataGridView2.Refresh();
            ReturnPage_HiddenBox_bookInfo.Text = "";
            MessageBox.Show("归还成功");
        }

        private void RechargePage_stuInfoBox_TextChanged(object sender, EventArgs e)
        {
            if (RechargePage_stuInfoBox.Text.Trim().Length < 10& RechargePage_stuInfoBox.Text.Trim().Length>0)
            {
                currentBalance = Convert.ToDouble(RechargePage_stuInfoBox.Text.Trim());
                RechargePage_MoneyBlock.Text = currentBalance.ToString();
                timer1.Enabled = false;
            }
            RechargePage_stuInfoBox.Text = "";
        }
    }
}
