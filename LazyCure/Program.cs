using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using LifeIdea.LazyCure.Core;
using LifeIdea.LazyCure.UI;
using System.Globalization;



namespace LifeIdea.LazyCure
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string logPath = Application.StartupPath + @"\LazyCure.log";
            System.IO.TextWriter logWriter = new System.IO.StreamWriter(System.IO.File.Open(logPath, System.IO.FileMode.Append, System.IO.FileAccess.Write, System.IO.FileShare.Write));
            Log.TextWriter = logWriter;
            CultureInfo info = new CultureInfo(Application.CurrentCulture.LCID);
            info.DateTimeFormat.LongTimePattern = "H:mm:ss";
            Application.CurrentCulture = info;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Driver driver = new Driver();
            try
            {
                LazyCureSettings settings = new LazyCureSettings();
                driver.TimeLogsFolder = settings.TimeLogsFolder;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while reading application settings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Application.Run(new Main(driver));
            logWriter.Close();
        }
    }
}
