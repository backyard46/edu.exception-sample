using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDU_ExceptionSample
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ★誰も補足しなかったエラーを捕まえる最後の砦

            ////ThreadExceptionイベントハンドラを追加
            //Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            ////ThreadExceptionが発生しないようにする
            //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);

            ////UnhandledExceptionイベントハンドラを追加
            //System.AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ExceptionSample1());
        }

        // ★誰も補足しなかったエラーを捕まえる最後の砦
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                //エラーメッセージを表示する
                MessageBox.Show(((Exception)e.ExceptionObject).Message, "エラー");
            }
            finally
            {
                //アプリケーションを終了する
                Environment.Exit(1);
            }
        }

        // ★誰も補足しなかったエラーを捕まえる最後の砦
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            try
            {
                //エラーメッセージを表示する
                MessageBox.Show(e.Exception.Message, "エラー");
            }
            finally
            {
                //アプリケーションを終了する
                Application.Exit();
            }
        }

    }
}
