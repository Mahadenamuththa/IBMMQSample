using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBMMQ.Client
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            try
            {
                IBMQueueManager iBMQueueManager = new IBMQueueManager();
                lblConnectionStatus.Text = iBMQueueManager.ConnectMQ("QM_TEST", "QM_TEST.LOCAL.ONE", "QM_TEST.SVRCONN/TCP/DESKTOP-8CH23R4(1421)");
            }
            catch (Exception ex)
            {
                MQQueueLogger.AddError(ex);
                MessageBox.Show(ex.Message); 
            }

        }
    }
}
