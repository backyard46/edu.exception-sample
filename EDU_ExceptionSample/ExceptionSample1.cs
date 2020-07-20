using System;
using System.Windows.Forms;

namespace EDU_ExceptionSample
{
    public partial class ExceptionSample1 : Form
    {
        public ExceptionSample1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 指定された値をゼロで割る。
        /// </summary>
        /// <param name="numerator">分母にする数値。</param>
        /// <returns>ゼロで割った答え。</returns>
        private int ZeroDivide(int numerator)
        {
            int answer = 0;
            int denominator = 0;
            answer = numerator / denominator;
            return answer;
        }

        /// <summary>
        /// ゼロ除算をエラー処理なしで実行する
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void DivByZeroButton_Click(object sender, EventArgs e)
        {
            int answer = 0;
            answer = ZeroDivide(1234);
            MessageLog.Text += "[DivByZero] 1234 / 0 = " + answer.ToString();
        }

        /// <summary>
        /// エラー処理ありで実行する。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void DivByZeroButtonNew_Click(object sender, EventArgs e)
        {
            int answer = 0;
            try
            {
                ZeroDivide(1234);
            }
            catch (YamaneException ex)
            {
                MessageLog.Text += "[DivByZero] Error: " + ex.Message + "\r\n";
            }
            catch (DivideByZeroException ex)
            {
                MessageLog.Text += "[DivByZero] Error: " + ex.Message + "\r\n";
            }
            finally
            {
                MessageLog.Text += "[DivByZero] 1234 / 0 = " + answer.ToString();
            }
        }

        /// <summary>
        /// サブフォームを表示する。
        /// </summary>
        /// <param name="sender">イベント呼び出し元オブジェクト</param>
        /// <param name="e">e</param>
        private void ShowSubFormButton_Click(object sender, EventArgs e)
        {
            SubForm childForm = new SubForm();
            try
            { 
                // ShowDialogだとどうなるか試して見ましょう

                //childForm.Show();
                childForm.ShowDialog();
            }
            catch
            {
                MessageLog.Text += "[SubForm] 何かエラー発生！";
            }
        }
    }
}
