using IBM.WMQ;
using System;
using System.Collections;
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


        }

        private void Connect(object sender, EventArgs e)
        {
            try
            {
                lblConnectionStatus.ResetText();
                txtConnectionStatus.ResetText();
                lblConnectionStatus.Text = "Connecting...";
                txtConnectionStatus.Text = "Connecting...";
                IBMQueueManager iBMQueueManager = new IBMQueueManager();
                Hashtable props = new Hashtable();

                char[] separator = { '/' };

                string[] ChannelParams;

                ChannelParams = txtCName.Text.Split(separator);

                string channelName = ChannelParams[0];

                //string transportType = ChannelParams[1];
                //string connectionName = ChannelParams[2];

                props.Add(MQC.HOST_NAME_PROPERTY, txtIpAddress.Text);
                props.Add(MQC.PORT_PROPERTY, txtPort.Text);
                props.Add(MQC.CHANNEL_PROPERTY, channelName);
                props.Add(MQC.USER_ID_PROPERTY, txtUserID.Text);
                props.Add(MQC.PASSWORD_PROPERTY, txtPassword.Text);
                lblConnectionStatus.Text = iBMQueueManager.ConnectMQ(props);
            }
            catch (Exception ex)
            {
                MQQueueLogger.AddError(ex);
                lblConnectionStatus.Text = ex.Message;
                txtConnectionStatus.Text = ex.Message;
            }
        }
    }
}
