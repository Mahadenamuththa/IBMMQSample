using IBM.WMQ;
using System;
using System.Collections;

namespace IBMMQ.Client
{
    public class IBMQueueManager
    {
        #region Private properties
        private static MQQueueManager queueManager;

        private static MQQueue queue;

        private static MQMessage queueMessage;

        private static MQPutMessageOptions queuePutMessageOptions;

        private static MQGetMessageOptions queueGetMessageOptions;



        private static string QueueName;

        private static string QueueManagerName;

        private static string ChannelInfo;

        private static string channelName;

        private static string transportType;

        private static string connectionName;

        private static string message;
        #endregion

        #region Constructor
        public IBMQueueManager()
        {

            //Initialisation
            QueueManagerName = "QM_TEST";

            QueueName = "QM_TEST.LOCAL.ONE";

            ChannelInfo = "QM_TEST.SVRCONN/TCP/DESKTOP-8CH23R4(1421)";
        }
        #endregion

        #region Public methods
        public string ConnectMQ(string strQueueManagerName, string strQueueName, string strChannelInfo)
        {

            //

            QueueManagerName = strQueueManagerName;

            QueueName = strQueueName;

            ChannelInfo = strChannelInfo;

            //

            char[] separator = { '/' };

            string[] ChannelParams;

            ChannelParams = ChannelInfo.Split(separator);

            channelName = ChannelParams[0];

            transportType = ChannelParams[1];

            connectionName = ChannelParams[2];

            Hashtable props = new Hashtable();

            props.Add(MQC.HOST_NAME_PROPERTY, "127.0.0.1");
            props.Add(MQC.PORT_PROPERTY, 1421);
            props.Add(MQC.CHANNEL_PROPERTY, channelName);
            props.Add(MQC.USER_ID_PROPERTY, "SLTESTUSER");
            //props.Add(MQC.PASSWORD_PROPERTY, "12345678");

            String strReturn = "";

            try
            {
                queueManager = new MQQueueManager(QueueManagerName, props);
                strReturn = "Connected Successfully";
            }
            catch (MQException exp)
            {
                MQQueueLogger.AddError(exp);
                throw;
            }
            catch (Exception ex)
            {
                MQQueueLogger.AddError(ex);
                throw;
            }
            return strReturn;
        }

        public string WriteMsg(string strInputMsg)
        {
            string strReturn = "";

            try

            {

                queue = queueManager.AccessQueue(QueueName,

                MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING);

                message = strInputMsg;

                queueMessage = new MQMessage();

                queueMessage.WriteString(message);

                queueMessage.Format = MQC.MQFMT_STRING;

                queuePutMessageOptions = new MQPutMessageOptions();

                queue.Put(queueMessage, queuePutMessageOptions);

                strReturn = "Message sent to the queue successfully";

            }
            catch (MQException MQexp)
            {
                strReturn = "Exception: " + MQexp.Message;
            }
            catch (Exception exp)
            {
                strReturn = "Exception: " + exp.Message;

            }

            return strReturn;

        }

        public string ReadMsg()
        {

            String strReturn = "";

            try
            {

                queue = queueManager.AccessQueue(QueueName,

                MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_FAIL_IF_QUIESCING);

                queueMessage = new MQMessage();

                queueMessage.Format = MQC.MQFMT_STRING;

                queueGetMessageOptions = new MQGetMessageOptions();

                queue.Get(queueMessage, queueGetMessageOptions);

                strReturn =

                queueMessage.ReadString(queueMessage.MessageLength);

            }
            catch (MQException MQexp)
            {

                strReturn = "Exception : " + MQexp.Message;

            }

            catch (Exception exp)
            {

                strReturn = "Exception: " + exp.Message;

            }

            return strReturn;

        }
        #endregion
    }
}
