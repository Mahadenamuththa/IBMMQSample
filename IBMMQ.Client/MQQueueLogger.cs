using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IBMMQ.Client
{
    public class MQQueueLogger
    {
        private static readonly ILog logger = log4net.LogManager.GetLogger(typeof(MQQueueLogger));
        #region Constructor
        static MQQueueLogger()
        {
            XmlConfigurator.Configure();
        }
        #endregion

        #region Public Methods
        public static bool AddError(Exception ex)
        {

            if (ex != null)
            {
                StackTrace exTrace = new StackTrace(ex, true);
                // Class name
                string className = string.Format("Class name: {0}", exTrace.GetFrame(exTrace.FrameCount - 1).GetMethod().ReflectedType.Name);
                // Method name
                string methodName = string.Empty;
                if (exTrace.GetFrame(exTrace.FrameCount - 1).GetMethod().MemberType == MemberTypes.Method)
                {
                    methodName = string.Format("Method name: {0}", exTrace.GetFrame(exTrace.FrameCount - 1).GetMethod().Name);
                }
                else
                {
                    methodName = string.Format("Method name: {0}", exTrace.GetFrame(exTrace.FrameCount - 1).GetMethod().MemberType.ToString());
                }
                // Line number
                string lineNumber = string.Format("Line number: {0}", exTrace.GetFrame(exTrace.FrameCount - 1).GetFileLineNumber());
                // Exception message
                string exception = string.Format("Exception message: {0}", ex.Message + Environment.NewLine + ex.StackTrace);
                // Inner exception message
                string innerException = ex.InnerException != null ? Environment.NewLine + string.Format("Inner exception: {0}", ex.InnerException) : string.Empty;


                string errorDetails = Environment.NewLine + className
                                    + Environment.NewLine + methodName
                                    + Environment.NewLine + lineNumber
                                    + Environment.NewLine + exception
                                    + innerException
                                    + Environment.NewLine;
                logger.Error(errorDetails);
            }
            return true;
        }
        public static bool AddInfo(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                logger.Info(message);
            }
            return true;
        }
        #endregion
    }
}
