using WinFormsApp1.数据库封装类;
using WinFormsApp1.数据库支持类;

namespace WinFormsApp1
{
    //窗体类的按钮点击事件

    internal static class Program
    {
        
        public static int mark = 0;//等于0时是窗体一未关闭
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            Application.Run(new Form1());

        }
        private static void OnApplicationExit(object sender, EventArgs e)
        {
            // 执行你需要在应用程序关闭时的操作
            SysLogService.AddSysLog(new SysLog("系统退出", "触发", LogTye.日志信息, login.login1.userid));
            // 例如：关闭数据库连接、保存日志、释放资源等
        }
    }
}