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
        private bool isConnected = false;
        public Home()
        {
            InitializeComponent();
        }

        private void Connect(object sender, EventArgs e)
        {
            try
            {
                string response = string.Empty;
                if (!isConnected)
                {
                    // Create IBMQueueManager
                    IBMQueueManager iBMQueueManager = new IBMQueueManager();

                    //Create Hashtable for pass properties
                    Hashtable props = new Hashtable();
                    // Host name(IP Address)
                    props.Add(MQC.HOST_NAME_PROPERTY, txtIpAddress.Text);
                    // Port
                    props.Add(MQC.PORT_PROPERTY, txtPort.Text);
                    // Channel name
                    props.Add(MQC.CHANNEL_PROPERTY, txtCName.Text);
                    // User name
                    props.Add(MQC.USER_ID_PROPERTY, txtUserID.Text);
                    // Password
                    props.Add(MQC.PASSWORD_PROPERTY, txtPassword.Text);

                    // Start connection

                    response = IBMQueueManager.ConnectMQ(txtQMName.Text, txtQName.Text, props);

                    //Set connetion status
                    lblConnectStstus.ForeColor = Color.Green;
                    lblConnectStstus.Text = "Connected";
                    isConnected = true;
                    EnableDisableField(true);
                }
                else
                {
                    //Set connetion status
                    lblConnectStstus.ForeColor = Color.Red;
                    lblConnectStstus.Text = "Not connected";
                    IBMQueueManager.queueManager.Disconnect();
                    isConnected = false;
                    EnableDisableField(false);
                    response = "Disconnected successfully";
                }

                //MessageBox.Show(response, "IBM MQ manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MQException exp)
            {
                MQQueueLogger.AddError(exp);
                string errorMessage = string.Empty;
                if (exp.Message == EnumIBMMQExceptions.MQRC_HOST_NOT_AVAILABLE.ToString())
                {
                    errorMessage = "Host not available, please check IP Address and port.";
                }
                else if (exp.Message == EnumIBMMQExceptions.MQRC_UNKNOWN_CHANNEL_NAME.ToString())
                {
                    errorMessage = "Unknown channel name, please check channel name.";
                }
                else if (exp.Message == EnumIBMMQExceptions.MQRC_Q_MGR_NAME_ERROR.ToString())
                {
                    errorMessage = "Invalid queue manager name, please check the queue manager name.";
                }
                else if (exp.Message == EnumIBMMQExceptions.MQRC_NOT_AUTHORIZED.ToString())
                {
                    errorMessage = "Authentication failed, please check user name and password.";
                }
                else
                {
                    errorMessage = exp.Message;
                }
                //Set connetion status
                lblConnectStstus.ForeColor = Color.Red;
                lblConnectStstus.Text = "Connection failed";
                MessageBox.Show(string.Format("Error in connecting  \n\n Error message: {0} \n\n ", errorMessage), "IBM MQ manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception ex)
            {
                MQQueueLogger.AddError(ex);
                MessageBox.Show(string.Format("Error in connecting  \n\n Error message: {0} \n\n ", ex.Message), "IBM MQ manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GetMessage(object sender, EventArgs e)
        {
            try
            {
                txtGetMessage.ResetText();
                if (IBMQueueManager.queueManager != null)
                {
                    txtGetMessage.Text = IBMQueueManager.ReadMsg();
                }
                else
                {
                    MessageBox.Show("You are not connected to  the IBM MQ Manager please connect", "IBM MQ manger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (MQException exp)
            {
                MQQueueLogger.AddError(exp);
                string errorMessage = string.Empty;
                if (exp.Message == EnumIBMMQExceptions.MQRC_NO_MSG_AVAILABLE.ToString())
                {
                    errorMessage = "The queue is empty, No messages to get from the queue";
                    MessageBox.Show(string.Format("Error getting message \n\n Error message: {0} \n\n ", errorMessage), "IBM MQ manger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    errorMessage = exp.Message;
                    MessageBox.Show("Error getting message", "IBM MQ manger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MQQueueLogger.AddError(ex);
                MessageBox.Show("Error getting message", "IBM MQ manger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PutMessage(object sender, EventArgs e)
        {
            try
            {
                string response = string.Empty;

                if (IBMQueueManager.queueManager != null)
                {
                    response = IBMQueueManager.WriteMsg(txtPutMessage.Text);
                    MessageBox.Show(response, "IBM MQ manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPutMessage.ResetText();
                }
                else
                {
                    MessageBox.Show("You are not connected to  the IBM MQ Manager please connect", "IBM MQ manger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (MQException exp)
            {
                MQQueueLogger.AddError(exp);
                MessageBox.Show("Error sending message", "IBM MQ manger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MQQueueLogger.AddError(ex);
                MessageBox.Show("Error sending message", "IBM MQ manger", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void EnableDisableField(bool disabled)
        {
            if (disabled)
            {
                btnConnect.Text = "Disconnect";
            }
            else
            {
                btnConnect.Text = "Connect";
            }
            txtCName.ReadOnly = disabled;
            txtIpAddress.ReadOnly = disabled;
            txtPassword.ReadOnly = disabled;
            txtPort.ReadOnly = disabled;
            txtQMName.ReadOnly = disabled;
            txtQName.ReadOnly = disabled;
            txtUserID.ReadOnly = disabled;
            txtPutMessage.ReadOnly = !disabled;
            btnGetMessage.Enabled = disabled;
            btnPutMessage.Enabled = disabled;
        }
    }
}
