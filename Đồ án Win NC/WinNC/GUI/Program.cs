using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
       public static clsNhanVien_DTO NV_Login = new clsNhanVien_DTO();
        public static string convertToCurrency(int n)
        {
            if (n < 1000)
            {
                return n.ToString();
            }

            string s = "";
            s = (n % 1000).ToString("d3");
            n /= 1000;
            while (n > 0)
            {
                s = "," + s;
                if (n % 1000 < 1000 && n / 1000 == 0)
                    s = (n % 1000).ToString() + s;
                else
                    s = (n % 1000).ToString("d3") + s;
                n /= 1000;

            }
            return s;
        }

        public static int convertToInt(string s)
        {
            try
            {
                string temp = "";
                int i = 0;
                int n = s.Length;
                while (i < n)
                {
                    if (s[i] != ',')
                    {
                        temp += s[i];
                    }
                    i++;
                }

                return Convert.ToInt32(temp);
            }
            catch
            {
                return -1;
            }
            
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
