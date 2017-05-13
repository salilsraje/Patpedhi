using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using Patpedhi.Interfaces;
using Patpedhi.DataStore;
using System.Reflection;
using Patpedhi.Utilities;
using System.Threading;


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
            try
            {

                #region Change  System Date Time Settings

                CheckDateSettings();

                #endregion
                                
                IDataProvider _IDataProvider = new DataProvider();

                Assembly UIAssembly;
                UIAssembly = Assembly.LoadFrom("UI.dll");
                Form LoginForm = (Form)UIAssembly.CreateInstance("Patpedhi.UI.MainLoginForm");
                ((IDataProviderConsumer)LoginForm).IDataProvider = _IDataProvider;
                DialogResult dr = LoginForm.ShowDialog();
                if(dr == DialogResult.Cancel)
                    Environment.Exit(Environment.ExitCode);
            
                if (dr == DialogResult.OK)
                {
                    LoginForm.Close();
                    Form ActivatedForm = null;
                    ActivatedForm = (Form)UIAssembly.CreateInstance("Patpedhi.UI.MainForm");
                    if (LoginInfo.YearId != 0)
                    {
                        ((Form)ActivatedForm).Text = "MainForm Financial Year - " + LoginInfo.YearCode;
                    }
                    ((IDataProviderConsumer)ActivatedForm).IDataProvider = _IDataProvider;
                    ActivatedForm.Show();

                }
                //else if (dr != DialogResult.Retry)
                //{
                //    Environment.Exit(Environment.ExitCode);
                //}
                
                Application.Run();
            }
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);    
            }
        }

        #region General Methods

        private static void CheckDateSettings()
        {
            try
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
            catch (Exception ex)
            {
                CustomException.CustomExceptionLog(ex);
            }
        }

        #endregion
    }
}
