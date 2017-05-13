using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Patpedhi.Utilities
{
    public class CustomException : ApplicationException
    {
        private static EventLog LogObject;
        private static int CUSTOMEXCEPTIONNUMBER = 9;        
        const string EventLogLogName = "CustomException";

        static CustomException()
        {
            LogObject = new EventLog(EventLogLogName);            
        }

        public static bool WriteTrace(string exception)
        {
            StringBuilder LogBuilder = new StringBuilder();
            StreamWriter LogWriter;

            try
            {
                if (Directory.Exists(Application.StartupPath + "\\LogPath") == false)
                    Directory.CreateDirectory(Application.StartupPath + "\\LogPath");

                LogWriter = File.AppendText(Application.StartupPath + "\\LogPath\\Trace" + DateTime.Today.ToShortDateString().Replace("/", "-") + ".log");
                LogBuilder.Append("<" + System.DateTime.Now.ToString() + ">");
                LogBuilder.Append("  ");
                LogBuilder.Append(exception);
                LogBuilder.Append("  ");
                LogWriter.WriteLine(LogBuilder.ToString());
                LogWriter.Close();
                return true;

            }
            catch (CustomException tbex)
            {
                return false;
            }
        }

        public static bool WriteError(Exception exception)
        {
            StringBuilder LogBuilder = new StringBuilder();
            StreamWriter LogWriter;

            try
            {
                if (Directory.Exists(Application.StartupPath + "\\LogPath") == false)
                    Directory.CreateDirectory(Application.StartupPath + "\\LogPath");

                LogWriter = File.AppendText(Application.StartupPath + "\\LogPath\\Errors" + DateTime.Today.ToShortDateString().Replace("/", "-") + ".log");
                LogBuilder.Append("<" + System.DateTime.Now.ToString() + ">");
                LogBuilder.Append("  ");
                LogBuilder.Append(exception.Source);
                LogBuilder.Append("  ");
                LogBuilder.Append(exception.Message);
                LogBuilder.Append("  ");
                LogBuilder.Append(exception.StackTrace);
                LogBuilder.Append("  ");
                LogWriter.WriteLine(LogBuilder.ToString());
                LogWriter.Close();
                return true;

            }
            catch (CustomException tbex)
            {
                return false;
            }
        }

        public static void CustomExceptionLog(Exception exception)
        {
            try
            {
                CustomException.LogObject.Source = exception.Source;
                LogObject.WriteEntry("Patpedhi Exception :\n " + exception.Message + " \nInner Exception :\n" + Convert.ToString(exception.InnerException) + "\nStack Trace :\n" + Convert.ToString(exception.StackTrace), EventLogEntryType.Error, CUSTOMEXCEPTIONNUMBER);

            }
            catch (Exception)
            {

            }
        }
    }
}
