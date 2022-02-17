using IBM.WMQ;
using System;
using System.Collections;

namespace IBMMQ.Client
{
    public class IBMQueueManager
    {
        #region Public properties
        public static MQQueueManager queueManager;
        #endregion
        #region Private properties  

        private static MQQueue queue;

        private static MQMessage queueMessage;

        private static MQPutMessageOptions queuePutMessageOptions;

        private static MQGetMessageOptions queueGetMessageOptions;



        private static string _queueName = string.Empty;

        private static string _queueManagerName = string.Empty;

        private static string qhannelInfo = string.Empty;

        private static string qhannelName = string.Empty;

        private static string transportType = string.Empty;

        private static string connectionName = string.Empty;

        private static string message;
        #endregion


        #region Public methods
        public static string ConnectMQ(string queueManagerName, string queueName, Hashtable props)
        {
            string strReturn = string.Empty;
            _queueManagerName = queueManagerName;
            _queueName = queueName;

            try
            {
                queueManager = new MQQueueManager(queueManagerName, props);
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

        public static string WriteMsg(string strInputMsg)
        {
            string strReturn = "";

            try
            {
                if (queueManager != null)
                {
                    queue = queueManager.AccessQueue(_queueName, MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING);

                    message = strInputMsg;

                    queueMessage = new MQMessage();

                    queueMessage.WriteString(message);

                    queueMessage.Format = MQC.MQFMT_STRING;

                    queuePutMessageOptions = new MQPutMessageOptions();

                    queue.Put(queueMessage, queuePutMessageOptions);

                    strReturn = string.Format("Message sent to the {0} queue successfully", _queueName);
                }
            }
            catch (MQException MQexp)
            {
                strReturn = "Exception: " + MQexp.Message;
                MQQueueLogger.AddError(MQexp);
            }
            catch (Exception exp)
            {
                strReturn = "Exception: " + exp.Message;
                MQQueueLogger.AddError(exp);

            }

            return strReturn;

        }

        public static string ReadMsg()
        {

            string strReturn = "";
            try
            {
                if (queueManager != null)
                {
                    queue = queueManager.AccessQueue(_queueName, MQC.MQOO_INPUT_AS_Q_DEF + MQC.MQOO_FAIL_IF_QUIESCING);

                    queueMessage = new MQMessage();

                    queueMessage.Format = MQC.MQFMT_STRING;

                    queueGetMessageOptions = new MQGetMessageOptions();

                    queue.Get(queueMessage, queueGetMessageOptions);
                    if (queueMessage.MessageLength > 0)
                    {
                        strReturn = queueMessage.ReadString(queueMessage.MessageLength);
                    }
                    else
                    {
                        strReturn = string.Empty;
                    }
                }
                else
                {
                    strReturn = string.Format("You are not connected to  the IBM MQ Manager please connect");
                }

            }
            catch (MQException MQexp)
            {
                MQQueueLogger.AddError(MQexp);
                throw;
            }
            catch (Exception exp)
            {
                MQQueueLogger.AddError(exp);
                throw;
            }

            return strReturn;

        }
        #endregion
    }
}
