using IBM.WMQ;
using System;

namespace IBMMQ.Client
{
    public class IBMQueueManager
    {
        #region Private properties
        private MQQueueManager queueManager;

        private MQQueue queue;

        private MQMessage queueMessage;

        private MQPutMessageOptions queuePutMessageOptions;

        private MQGetMessageOptions queueGetMessageOptions;



        private static string QueueName;

        private static string QueueManagerName;

        private static string ChannelInfo;

        private string channelName;

        private string transportType;

        private string connectionName;

        private string message;
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


            String strReturn = "";

            try
            {
                queueManager = new MQQueueManager(QueueManagerName, channelName, connectionName);
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
