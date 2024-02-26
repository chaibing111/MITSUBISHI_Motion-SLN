using MCProtocol;
using System.Diagnostics;

namespace _01_MITS_Dev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Btn_ConnectMSPLC_Click(object sender, EventArgs e)
        {
            try
            {
                var ip = txt_IP.Text;
                var port = Convert.ToInt32(txt_Port.Text);

                PLCData.PLC = new Mitsubishi.McProtocolTcp(ip, port, Mitsubishi.McFrame.MC3E);
                await PLCData.PLC.Open();
                MessageBox.Show("连接成功");
            }
            catch (Exception)
            {

                MessageBox.Show("连接失败");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 写入点位数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
        {
            var type = Mitsubishi.PlcDeviceType.X;
            // 获取软元件名称
            var name = txtSName.Text;
            switch(name)
            {
                case "M":
                    type = Mitsubishi.PlcDeviceType.M;
                    break;

            }
            // 获取软元件地址
            var addressStr = txt_Number.Text;
            var address = Convert.ToInt32(addressStr);
            // 创建PLC操作软件地址的数据对象[读取数据对象的值]
            PLCData<bool> ints = new PLCData<bool>(type, address, 1);
            // 读取数据
            await ints.ReadData();
            Debug.WriteLine($"{name}{address}写入前的数据为：{ints[0]}");
            // 写入数据
            var data = rad_Open.Checked ? true : false;
            ints[0] = data;
            await ints.WriteData();
            // 读取数据
            await ints.ReadData();
            Debug.WriteLine($"{name}{address}写入后的数据为：{ints[0]}");
        }
    }
}