using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* После заполнение полей и нажатия кнопки на первой вкладке
         * создается объект Deposit и помещается в статический List
         * формируется сообщение со всеми объектами списка и выводятся во второй вкладке */
        private void button1_Click(object sender, EventArgs e)
        {
            Deposit.createDeposit(date.Text, name.Text, int.Parse(cash.Text), int.Parse(period.Text));
            textBox1.Text = Deposit.infoAllDeposits();
        }

        /* На второй вкладке по номеру депозита можно удалить его из списка
         * и посмотреть итоговое значение вклада */
        private void button2_Click(object sender, EventArgs e)
        {
            info.Text = Deposit.infoCloseDeposit(int.Parse(numDeposit.Text));
            textBox1.Text = Deposit.infoAllDeposits();
        }

        /* Вкладка для проверки работы с математическими функциями задачи 3 */
        private void button3_Click(object sender, EventArgs e)
        {
            if (Fac.Checked)
            {
                number.Text = MathEx.Fact(int.Parse(number.Text)).ToString();
            }
            else if (Reciproc.Checked)
            {
                number.Text = MathEx.Reciprocal(int.Parse(number.Text)).ToString();
            }
            else if (FracPart.Checked)
            {
                try
                {
                    number.Text = MathEx.FracPart(double.Parse(number.Text)).ToString();
                }
                catch (FormatException)
                {
                    err2.Text = "Неверный формат данных! Дробная часть отделяется запятой.";
                }
                
            }
            else if (IsEven.Checked)
            {
                number.Text = MathEx.IsEven(int.Parse(number.Text)).ToString();
            }
            else if (IsOdd.Checked)
            {
                number.Text = MathEx.IsOdd(int.Parse(number.Text)).ToString();
            }
            else if (Crt.Checked)
            {
                number.Text = MathEx.Crt(int.Parse(number.Text)).ToString();
            }
            else if (DegToRad.Checked)
            {
                number.Text = MathEx.DegToRad(int.Parse(number.Text)).ToString();
            }
            else if (RadToDeg.Checked)
            {
                try
                {
                    number.Text = MathEx.RadToDeg(double.Parse(number.Text)).ToString();
                }
                catch (FormatException)
                {
                    err2.Text = "Неверный формат данных! Дробная часть отделяется запятой.";
                }
                
            }
            else
            {
                throw new Exception("Не выбрано ни одной операции");
            }
        }
    }
}
