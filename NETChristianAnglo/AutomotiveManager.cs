using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace NETChristianAnglo
{
    /// <summary>
    /// This class provides universal functionality to be used throughout the entire application.
    /// </summary>
    public static class AutomotiveManager
    {
        private static bool _isBeingTested = false;
        private static DialogResult _messageBoxResult = DialogResult.OK;

        /// <summary>
        /// The property is used to retrieve the value of the private class variable isBeingTested
        /// </summary>
        public static bool IsBeingTested
        {
            get { return _isBeingTested; }
        }

        /// <summary>
        /// The property is used to retrieve the value of the private class variable messageBoxResult.
        /// </summary>
        public static DialogResult MessageBoxResult
        {
            get { return _messageBoxResult; }
        }

        /// <summary>
        /// Checking if the value is numeric
        /// </summary>
        /// <param name="stringValue">the string value being parsed</param>
        /// <returns>this method returns true when the stringValue can be parsed to decimal, false when the string cannot be parsed to a decimal.</returns>
        public static bool IsNumeric(string stringValue)
        {
            Decimal result;

            return Decimal.TryParse(stringValue, out result);
        }

        /// <summary>
        /// This method returns the payment for an annuity based on periodic fixed payments and fixed interest rate.
        /// </summary>
        public static decimal Payment(decimal rate, decimal numberOfPaymentPeriods, decimal presentValue, decimal futureValue = 0, decimal type = 0)
        {
            return (rate == 0) ? presentValue / numberOfPaymentPeriods : rate * (futureValue + presentValue * (decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods)) / (((decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods) - 1) * (1 + rate * type));
        }

        /// <summary>
        /// This method is used to display a MessageBox.
        /// </summary>
        public static DialogResult ShowMessage(string text, string caption, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return IsBeingTested ? MessageBoxResult : MessageBox.Show(text, caption, buttons, icon, defaultButton);
        }

        /// <summary>
        /// Produces a textfile where error is logged when an exception happens
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="errorMessage"></param>
        public static void ErrorLog(Exception exception, string errorMessage)
        {
            string applicationPath = Application.StartupPath;
            string errorLogPath = string.Format(@"{0}\{1}", applicationPath, "Logs");
            string errorLogName = string.Format("{0}{1}.log", ConfigurationManager.AppSettings["LogFilePrefix"], DateTime.Now.ToString("MM-dd-yyyy"));
            string filepath = string.Format(@"{0}\{1}", errorLogPath, errorLogName);

            try
            {
                if (!Directory.Exists(errorLogPath))
                {
                    Directory.CreateDirectory(errorLogPath);
                }
                try
                {
                    FileStream stream = new FileStream(filepath, FileMode.Append);
                    StreamWriter writer = new StreamWriter(stream);
                    writer.WriteLine(string.Format("Date: {0}", DateTime.Now.ToString("MM-dd-yyyy")));
                    writer.WriteLine(string.Format("Time: {0}", DateTime.Now.ToShortTimeString()));
                    writer.WriteLine(string.Format("Message: {0}", errorMessage));
                    writer.WriteLine(string.Format("Stack trace: {0}", exception.StackTrace));
                    writer.WriteLine("------------------------------------------");

                    writer.Flush();
                    writer.Close();
                    stream.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("An error occured while writing to the error log file.", "Log File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("An error occured while writing to the error log file.", "Log File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
