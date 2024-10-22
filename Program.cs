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
            Application.Run(new Form1());
        }
    }
}