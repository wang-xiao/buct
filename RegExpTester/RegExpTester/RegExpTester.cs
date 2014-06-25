using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegExpTester
{
    static class RegExpTester
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmRegExpTester());
            // 试试修改这里。。。
        }
    }
}