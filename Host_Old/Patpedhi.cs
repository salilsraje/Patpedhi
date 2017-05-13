using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using Patpedhi.Interfaces;
using Patpedhi.DataStore;
using System.Reflection;

namespace Patpedhi.Host
{
    public class Patpedhi
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        static extern int SetLocaleInfoA(int Locale, int LCType, string lpLCData);

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        static extern int GetSystemDefaultLCID();
        
        [STAThread]
        static void Main()
        {
            #region Check Process running

            Process[] PatpedhiProcess;
            PatpedhiProcess = Process.GetProcessesByName("Patpedhi");
            if (PatpedhiProcess.Length > 1)
            {
                MessageBox.Show("Petpedhi Application is already Running.");
                throw new Exception("Petpedhi Application is already Running.");

            }

            #endregion

            #region Change  System Date Time Settings

            CheckDateSettings();

            #endregion 

            IDataProvider _IDataProvider = new DataProvider();
            
            Assembly UIAssembly;
            UIAssembly = Assembly.LoadFrom("UI.dll");
            Form LoginForm = (Form)UIAssembly.CreateInstance("Patpedhi.UI.MainLoginForm");
            ((IDataProviderConsumer)LoginForm).IDataProvider = _IDataProvider;
            DialogResult dr = LoginForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
            }

        }

        #region General Methods

        private static void CheckDateSettings()
        {
            if (System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern != "dd/MM/yyyy")
            {
                int LOCALE_SSHORTDATE = 0x0000001F;
                int _Locale = GetSystemDefaultLCID();
                int Result = SetLocaleInfoA(_Locale, LOCALE_SSHORTDATE, "dd/MM/yyyy");
                System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
                //("DateTime changed successfully.");
            }
        }

        #endregion
    }
}
