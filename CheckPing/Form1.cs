using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace CheckPing
{
    public partial class Form1 : Form
    {
        Ping p;
        int br = 0;
        public Form1()
        {
            InitializeComponent();
            txtInput.Focus();
        }
        void constructListview()
        {
            lvResult.Clear();
            lvResult.Columns.Add("Lần gởi", 50);
            lvResult.Columns.Add("Địa chỉ", 200);
            lvResult.Columns.Add("Kết quả", 300);
        }
        void check()
        {
            int success = 0;
            int count = 1; // biến đếm lặp
            int numPacket = 4;
            List<int> roundtrip = new List<int>(); // Mảng để chứa các giá trị roundtrip
            int timeout = 4000;
            int size = 32;
            if (txtSize.Text != String.Empty)
            {
                try
                {
                    numPacket = Convert.ToInt32(txtSize.Text);
                }
                catch
                {
                    MessageBox.Show("Số gói tin là một số nguyên cụ thể!", "Thông báo!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }
            }
            if (txtSize.Text != String.Empty)
            {
                try
                {
                    size = Convert.ToInt32(txtSize.Text);
                }
                catch
                {
                    MessageBox.Show("Kích thước gói tin là một số nguyên cụ thể!", "Thông báo!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }
                if (size < 0 || size > 65500)
                {
                    MessageBox.Show("Kích thước gói tin không được nhỏ hơn 0 và lớn hơn 65500", "Thông báo!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                }
            }
            byte[] buffer = new byte[size];
            string ip = txtInput.Text; //Lấy giá trị ip hoặc hostname nhập vào
            if (ip == string.Empty)
            {
                MessageBox.Show("Nhập hostname hoặc địa chỉ ip để bắt đầu", "Thông báo!",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }// Xử lí trường hợp không nhập
            while (count <= numPacket)
            {
                if (chbxContinous.Checked == true)
                {
                    numPacket++;
                }
                Application.DoEvents();
                if (br == 1) break;
                p = new Ping();
                PingReply pr;
                try
                {
                    pr = p.Send(ip, timeout, buffer); //Gửi yêu cầu bằng phương thức send
                                                      //Trường hợp destination host uncreachable
                    if (pr.Status == IPStatus.DestinationHostUnreachable)
                    {
                        string thongbao = "Destination Host Unreachable!";
                        addtoLv(ip, thongbao, Color.Purple, count);
                        success++;
                    }
                    //Trường hợp request timeout
                    if (pr.Status == IPStatus.TimedOut)
                    {
                        string thongbao = "Oops! Request Timeout!";
                        addtoLv(ip, thongbao, Color.Red, count);
                    }
                    //Trường hợp reply
                    if (pr.Status == IPStatus.Success)
                    {
                        string thongbao = "Ping success!";
                        addtoLv(ip, thongbao, Color.Green, count);
                        success++;
                        if (pr.RoundtripTime != 0)
                            roundtrip.Add(Convert.ToInt32(pr.RoundtripTime));
                    }
                    // Trường hợp không biết lí do tại sao
                    if (pr.Status == IPStatus.Unknown)
                    {
                        string thongbao = "Chưa biết nguyên nhân !";
                        addtoLv(ip, thongbao, Color.Green, count);
                    }
                    //Kiểm tra xuất ra chi tiết từng lần gởi
                    lvDetail.Items.Add("Lần phản hồi: " + count, 200);
                    if (pr.Address != null)
                    {
                        lvDetail.Items.Add("Reply from: " + pr.Address.ToString());
                    }
                    if (pr.RoundtripTime != 0)
                    {
                        lvDetail.Items.Add("Thời gian hồi đáp: " +
                       pr.RoundtripTime.ToString() + " ms", 200);
                    }
                    if (pr.Options != null)
                    {
                        lvDetail.Items.Add("Thời gian sống của gói tin: " +
                       pr.Options.Ttl.ToString(), 200); // toi da 255, mặc định 128
                    }
                    if (pr.Status == IPStatus.Success)
                    {
                        lvDetail.Items.Add("Kích thước gói tin: " +
                       pr.Buffer.Length.ToString() + " byte", 200);
                    }
                    if (pr.Status == IPStatus.Success || pr.Status ==
                   IPStatus.DestinationHostUnreachable)
                        lvDetail.Items.Add("_____________________");
                }
                catch
                {
                    MessageBox.Show("IP hoặc Host không tồn tại ! Mời nhập lại!", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                count++; // tăng biến đếm
            }
            //Hiển thị trong lvThongke
            count = count - 1; // số lần gửi
            int lost = count - success; // số lần gửi không nhận được phản hồi.
            double phantramlost = Math.Round((((double)lost / (double)numPacket) * 100), 0); // tính phần trăm lần mất , làm tròn
            lvThongke.Items.Add("Gửi = " + (count).ToString() + ", Nhận = " + success.ToString() 
                                    + ", Mất = " + lost.ToString() + " ( " + phantramlost.ToString() + "% Mất)");
        if (roundtrip.Count != 0)
            {
                lvThongke.Items.Add("Approximate round trip times in mili-second: ");
                int max = roundtrip.Max();
                int min = roundtrip.Min();
                int avegare = (min + max) / 2;
                lvThongke.Items.Add("Minimun = " + min.ToString() + "ms, Maximum = " +
                                        max.ToString() + "ms, Average = " + avegare.ToString() + "ms");
            }
            br = 0; // sau khi thêm thì trả br lại giá trị 0
        }
        //Thêm vào listview
        void addtoLv(string ip, string thongbao, Color color, int count)
        {
            ListViewItem address = new ListViewItem(count.ToString());
            ListViewItem.ListViewSubItem result = new ListViewItem.ListViewSubItem(address, ip);
            ListViewItem.ListViewSubItem result1 = new
            ListViewItem.ListViewSubItem(address, thongbao);
            address.SubItems.Add(result);
            address.SubItems.Add(result1);
            lvResult.Items.Add(address);
            address.ForeColor = color;
        }
      
       
        //Xử lí đóng form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Thông báo!",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void chbxContinous_CheckedChanged(object sender, EventArgs e)
        {
        }
       

        private void btcheck_Click(object sender, EventArgs e)
        {
            btcheck.Enabled = false; // sau khi nhấn thì không được nhấn nữa, tránh trường hợp người dùng nhấn nhiều lần khi vòng lặp đang chạy
            lvDetail.Clear(); //xóa trống lvDetail
            constructListview(); //thiết lập lvRessult
            lvThongke.Clear(); // xóa trống lvThongke
            check(); // chạy hàm check
            btcheck.Enabled = true; //sau khi chạy hàm check xong thì enable trở lại
            chbxContinous.Checked = false; //reset chbxContinous về trạng thái chưa check
            txtSize.Clear(); //xóa trống txtSize
            txtSize.Clear(); // xóa trống txtNumpacket
            txtInput.Focus(); //focus vào txtInput
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            lvDetail.Clear(); //xóa trống lvDetail
            constructListview(); //thiết lập lvRessult
            lvThongke.Clear(); // xóa trống lvThongke
            chbxContinous.Checked = false; //reset chbxContinous về trạng thái chưa check
            txtSize.Clear(); //xóa trống txtSize
            txtSize.Clear(); // xóa trống txtNumpacket
            txtInput.Clear(); // xóa trống txtInput
            txtInput.Focus(); //focus vào txtInput
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) // nhấn esc
                br = 1;
        }
    }
        
}
