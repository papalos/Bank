using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Deposit
    {
        /* фиксированная ставка годовых */
        private static float _rate;
        /* название банка */
        private static string _title;
        /* дата открытия вклада */
        private string _date;
        /* срок вклада в годах, max=10*/
        private int _period;
        /* ФИО держателя вклада */
        private string _name;
        /* сумма вклада */
        private double _cash;

        /* БД всех созданных депозитов */
        private static List<Deposit> poolDeposit = new List<Deposit>();

        /* --------- Конструкторы ------------------- */
        static Deposit() {
            _rate = 0.12f;
            _title = "Afanasev Credit System";
        }

        public Deposit(string date, string name, double cash, int period)
        {
            if (date.Length == 10) { _date = date; }
            else { throw new Exception("Неверный формат даты!"); }

            if(period>0 && period < 11) { _period = period; }
            else { throw  new Exception("Продолжительность вклада не соответствует установленной!");  }
            
            _name = name;

            if (cash > 0) { _cash = cash; }
            else { throw new Exception("Сумма вклада должна быть больше нуля!"); }
        }
        /* ------------------------------------------------------- */


        /* ------------------------ Геттеры ----------------------------- */
        public static float rate { get { return _rate; } }
        public static string title { get { return _title; } }
        public  string date { get { return _date; } }
        public string name { get { return _name; } }
        public double cash { get { return _cash; } }
        public int period { get { return _period; } }

               
        /* Фабрика создает депозит и заносит его в базу данных */
        public static void createDeposit(string date, string name, double cash, int period)
        {
            poolDeposit.Add(new Deposit(date, name, cash, period));
        }

        /* Сведения о всех открытых Вкладах из списка */
        public static string infoAllDeposits()
        {
            string fullInfo = "";
            for(int i = 0; i < poolDeposit.Count(); i++)
            {
                fullInfo += "№"+ i + "  " + poolDeposit[i].date + ", " + poolDeposit[i].name + ", сумма вклада: " + poolDeposit[i].cash + ", срок вклада в годах: " + poolDeposit[i].period + Environment.NewLine;
            }
            return fullInfo;
        }
        
        
        /* формирует сообщение с суммой вклада по истечению периода */

        public static string infoCloseDeposit(int i)
        {
            string infoMSG = "Счет №" + i + " закрыт, выплаты составили: " + poolDeposit[i].closeDeposit();
            poolDeposit.RemoveAt(i);
            return infoMSG;
            
        }

        /* расчет суммы вклада по истечению периода */
        private double closeDeposit()
        {
            int i = _period;
            double sum = _cash;
            while (i > 0)
            {
                sum += (sum * _rate);
                i--;
            }
            return sum;
        }
    }
}
