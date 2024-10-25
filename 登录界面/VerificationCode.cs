using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.登录界面
{
    class VerificationCode
    {
        ///生成随机验证字符串
        public static string CreateRandomCode(int CodeLength)
        {
            int rand;
            char code;
            string randomCode = String.Empty;//随机验证码
            //生成特定长度的验证码
            Random random = new Random();
            for (int i = 0; i < CodeLength; i++)
            {
                rand = random.Next();
                if (rand % 3 == 1)
                {
                    code = (char)('A' + (char)(rand % 26));//随机取字母
                }
                else if (rand % 3 == 2)
                {
                    code = (char)('a' + (char)(rand % 26));
                }
                else
                {
                    code = (char)('0' + (char)(rand % 10));
                }
                randomCode += code.ToString();
            }
            return randomCode;
        }
        ///创建图片
        public static void CreateImage(string strValidCode, PictureBox pbox)
        {
            try
            {
                int RandAnlge = 45;//旋转角度
                int MapWidth = (int)(strValidCode.Length * 21);
                Bitmap map = new Bitmap(MapWidth, 28);//创建图片背景
                Graphics graph = Graphics.FromImage(map);
                graph.Clear(Color.AliceBlue);//清除话画面，填充背景颜色
                graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1);//画一个边框
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//模式
                Random rand = new Random();
                //背景噪点生成
                Pen blackPen = new Pen(Color.LightGray, 0);
                for (int i = 0; i <= 50; i++)
                {
                    int x = rand.Next(0, map.Width);
                    int y = rand.Next(0, map.Height);
                    graph.DrawRectangle(blackPen, x, y, 1, 1);
                }
                //验证码选装防止机器识别
                char[] chars = strValidCode.ToCharArray();//拆散字符串组成单字符数组
                //文字居中
                StringFormat format = new StringFormat(StringFormatFlags.NoWrap);
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                //定义颜色
                Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple, Color.Green };
                //定义字体
                string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };
                for (int i = 0; i < chars.Length; i++)
                {
                    int cindex = rand.Next(7);
                    int findex = rand.Next(5);
                    Font f = new System.Drawing.Font(font[findex], 13, System.Drawing.FontStyle.Bold);//字体样式，大小
                    Brush b = new System.Drawing.SolidBrush(c[cindex]);
                    Point dot = new Point(16, 16);
                    float angle = rand.Next(-RandAnlge, RandAnlge);//旋转度数
                    graph.TranslateTransform(dot.X, dot.Y);//移动光标到指定位置
                    graph.RotateTransform(angle);
                    graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);
                    graph.RotateTransform(-angle);//转回去
                    graph.TranslateTransform(2, -dot.Y);//移动光标到指定位置
                }
                pbox.Image = map;
            }
            catch
            {
                MessageBox.Show("验证图片创建错误");
            }
        }
    }

}
