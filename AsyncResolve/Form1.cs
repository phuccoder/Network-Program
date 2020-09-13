using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;


namespace AsyncResolve
{
    public partial class Form1 : Form
    {
        private AsyncCallback OnResolved;

        public Form1()
        {
            InitializeComponent();
            OnResolved = new AsyncCallback(Resolved);// tham chiếu đến phương thức 'Resolved' khi hoạt động bất đồng bộ hoàn thành
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            results.Items.Clear();// xóa list view
            string addr = address.Text;// lấy chuỗi địa chỉ được nhập vào
            Object state = new Object();// object trạng thái
            Dns.BeginResolve(addr, OnResolved, state);// bắt đầu gửi yêu cầu không đồng bộ DNS đến địa chỉ được nhập vào
        
        }
        private void Resolved(IAsyncResult ar)
        {
            string buffer;
            IPHostEntry iphe = Dns.EndResolve(ar);// dùng lưu thông tin DNS của địa chỉ
            buffer = "Host name: " + iphe.HostName;// chuỗi lưu tên miền DNS
            results.Invoke(new Action(() => results.Items.Add(buffer)));// thêm chuỗi buffer vào list view
            foreach (string alias in iphe.Aliases)
            {
                buffer = "Alias: " + alias;// lưu bí danh của tên miền DNS
                // results.Items.Add(buffer); //
                results.Invoke(new Action(() => results.Items.Add(buffer)));// thêm buffer vào list view
            }
            foreach (IPAddress addrs in iphe.AddressList)
            {
                buffer = "Address: " + addrs.ToString();// chuyển ip thành chuỗi lưu vào buffer
                results.Invoke(new Action(() => results.Items.Add(buffer))); // in chuỗi địa chỉ IP
            }
        }  

    }
}
