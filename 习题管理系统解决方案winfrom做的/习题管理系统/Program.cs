using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;
namespace 习题管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frmLogin=new FrmLogin();
            DialogResult loginResult=frmLogin.ShowDialog();
            if (loginResult == DialogResult.OK)
            {                       //登录成功
                Application.Run(new FrmMain());
                frmLogin.Close();
            }
            


            
        }


        public static TeacherInfo teacherInfo = null;                //用来保存用户的信息
    }
}
