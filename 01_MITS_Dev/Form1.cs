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
                MessageBox.Show("���ӳɹ�");
            }
            catch (Exception)
            {

                MessageBox.Show("����ʧ��");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// д���λ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
        {
            var type = Mitsubishi.PlcDeviceType.X;
            // ��ȡ��Ԫ������
            var name = txtSName.Text;
            switch(name)
            {
                case "M":
                    type = Mitsubishi.PlcDeviceType.M;
                    break;

            }
            // ��ȡ��Ԫ����ַ
            var addressStr = txt_Number.Text;
            var address = Convert.ToInt32(addressStr);
            // ����PLC���������ַ�����ݶ���[��ȡ���ݶ����ֵ]
            PLCData<bool> ints = new PLCData<bool>(type, address, 1);
            // ��ȡ����
            await ints.ReadData();
            Debug.WriteLine($"{name}{address}д��ǰ������Ϊ��{ints[0]}");
            // д������
            var data = rad_Open.Checked ? true : false;
            ints[0] = data;
            await ints.WriteData();
            // ��ȡ����
            await ints.ReadData();
            Debug.WriteLine($"{name}{address}д��������Ϊ��{ints[0]}");
        }
    }
}