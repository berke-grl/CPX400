using cpx400.DEVICES;
using cpx400.Properties;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;
using Timer = System.Windows.Forms.Timer;

namespace cpx400
{
    public partial class Form1 : Form
    {
        CPX400 cpx400 = new cpx400.DEVICES.CPX400();
        Timer timer = new Timer();
        TimeSpan ts = new TimeSpan(0, 0, 0, 0, 500);


        static string  resourceName = "TCPIP::192.168.1.100::9221::SOCKET";

        public Form1() 
        {

            InitializeComponent();
     
         


        }




        private void getMeasurement(object sender, EventArgs e)
        {
            double value = 0;
            label3.Text = value.ToString();
            Int32 mesurementType = rbtn_amper.Checked ? 0 : 1; //0 for amper 1 for voltage
            if (rbtn_chname1.Checked)
            {
                cpx400.Measure("1", mesurementType, ref value);
                label3.Text = "Measurement :" + value;
            }
            else
            {

                cpx400.Measure("2", mesurementType, ref value);

                label3.Text = "Measurement :" + value;
            };

        }
        private String getCurrentTime()
        {
            return Environment.NewLine + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            string statusCode = cpx400.Initialize();
            btn_Connect.Text = "Connected";
            lbl_status.Text = statusCode;                                      
            Color activeColor = Color.Red;
            if (statusCode.Equals("Success"))                                
            {
                timer.Interval = ts.Milliseconds;
                timer.Tick += getMeasurement;
                timer.Start();


                richTextBox1.AppendText(getCurrentTime() + " Successfully connected to Device");
                btn_close.Enabled = true;
                btn_close.BackColor = Color.FromArgb(230, 72, 72);

                btn_reset.Enabled = true;
                btn_reset.BackColor = Color.FromArgb(41, 52, 98);

                groupBox1.Enabled = true;
                groupBox1.ForeColor = Color.Black;

                gb_chanelNames.Enabled = true;


                foreach (Control i in groupBox1.Controls)
                {
                    i.ForeColor = Color.Black;

                }
            }
            else
            {
                btn_Connect.Text = "Connection Error";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            cpx400.ResetOutputProtection("1");
            cpx400.ResetOutputProtection("2");

            cpx400.Close();

            richTextBox1.AppendText(getCurrentTime() + " CLOSE ");

            groupBox1.Enabled = false;
            btn_Connect.Text = "RECONNECT";

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cpx400.ResetOutputProtection("1");
            cpx400.ResetOutputProtection("2");

            cpx400.Reset();

            richTextBox1.Clear();
            richTextBox1.AppendText(getCurrentTime() + " RESET ");
        }

        private bool enable = false;
        private void btn_COE_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                btn_COE.BackColor = Color.FromArgb(230, 72, 72);
                btn_COE.Text = " Output Disabled";
                richTextBox1.AppendText(getCurrentTime() + " Configure Output Disabled (chanel: 1)");

                enable = false;
            }
            else
            {
                btn_COE.BackColor = Color.FromArgb(91, 179, 24);
                btn_COE.Text = " Output Enabled";
                richTextBox1.AppendText(getCurrentTime() + " Configure Output Enabled (chanel: 2)");

                enable = true;
            }

            if (rbtn_chname1.Checked && enable)
            {

                cpx400.ConfigureOutputEnabled("1", true); 

            }
            else if (rbtn_chname1.Checked && !enable)
            {
                cpx400.ConfigureOutputEnabled("1", false);

            }
            else if (rbtn_chname2.Checked && enable)
            {
                cpx400.ConfigureOutputEnabled("2", true);

            }
            else if (rbtn_chname2.Checked && !enable)
            {
                cpx400.ConfigureOutputEnabled("2", false);

            }
            else
            {
                MessageBox.Show("invalid operation");
            }
        }

        private void btn_CCL_Click(object sender, EventArgs e)
        {
            double limit = (double)nud_CCL_limit.Value;
            long behavior = (long)nud_CCL_behavior.Value;
            if (rbtn_chname1.Checked == true)
            {
                cpx400.ConfigureCurrentLimit("1", behavior, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure Current Limit (chanel: 1)");

            }
            else
            {
                cpx400.ConfigureCurrentLimit("2", behavior, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure Current Limit (chanel: 2)");
            }
        }

        private void btn_COVP_Click(object sender, EventArgs e)
        {
            double limit = (double)nud_COVP_limit.Value;

            if (rbtn_chname1.Checked && rbtn_COVP_true.Checked == true)
            {
                cpx400.ConfigureOVP("1", true, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OVP (chanel: 1)");

            }
            else if (rbtn_chname1.Checked && rbtn_COVP_true.Checked == false)
            {
                cpx400.ConfigureOVP("1", false, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OVP (chanel: 1)");

            }
            else if (rbtn_chname2.Checked && rbtn_COVP_true.Checked == true)
            {
                cpx400.ConfigureOVP("2", true, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OVP (chanel: 2)");

            }
            else if (rbtn_chname2.Checked && rbtn_COVP_true.Checked == false)
            {
                cpx400.ConfigureOVP("2", false, limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OVP (chanel: 2)");

            }
            else
            {
                MessageBox.Show("invalid operation");
            }
        }

        private void btn_CVL_Click(object sender, EventArgs e)
        {
            double level = (double)nud_CVL_level.Value;
            if(rbtn_chname1.Checked)
            {
              cpx400.ConfigureVoltageLevel("1", level);
                richTextBox1.AppendText(getCurrentTime() + " Configure Voltage Level (chanel: 1)");

            }
            else
            {
               cpx400.ConfigureVoltageLevel("2", level);
                richTextBox1.AppendText(getCurrentTime() + " Configure Voltage Level (chanel: 2)");

            }
        }

        private void btn_COCP_click(object sender, EventArgs e)
        {
            double limit = (double)nud_COCP_limit.Value;
            if (rbtn_chname1.Checked)
            {
               cpx400.CPX400_ConfigureOCP("1", limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OCP (chanel: 1)");

            }
            else
            {
               cpx400.CPX400_ConfigureOCP("2", limit);
                richTextBox1.AppendText(getCurrentTime() + " Configure OCP (chanel: 2)");

            }
        }

        private void rbtn_chname1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_chname1.Checked)
            {
                lbl_chanelName.Text = "SELECTED CHANEL = 1";
            }
            else
            {
                lbl_chanelName.Text = "SELECTED CHANEL = 2";

            }
        }

    }
}