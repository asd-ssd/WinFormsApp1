namespace WinFormsApp1
{
    //������İ�ť����¼�
    
    internal static class Program
    {

        public static int mark = 0;//����0ʱ�Ǵ���һδ�ر�
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