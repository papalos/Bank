namespace Bank
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cash = new System.Windows.Forms.TextBox();
            this.period = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.info = new System.Windows.Forms.Label();
            this.numDeposit = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.number = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadToDeg = new System.Windows.Forms.RadioButton();
            this.DegToRad = new System.Windows.Forms.RadioButton();
            this.Crt = new System.Windows.Forms.RadioButton();
            this.IsOdd = new System.Windows.Forms.RadioButton();
            this.IsEven = new System.Windows.Forms.RadioButton();
            this.FracPart = new System.Windows.Forms.RadioButton();
            this.Reciproc = new System.Windows.Forms.RadioButton();
            this.Fac = new System.Windows.Forms.RadioButton();
            this.err2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Blue;
            this.tabPage1.Controls.Add(this.cash);
            this.tabPage1.Controls.Add(this.period);
            this.tabPage1.Controls.Add(this.date);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Создать Вклад";
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(215, 179);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(248, 22);
            this.cash.TabIndex = 5;
            this.cash.Text = "Сумма Вклада";
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(17, 179);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(173, 22);
            this.period.TabIndex = 4;
            this.period.Text = "Срок вклада";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(17, 92);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(173, 22);
            this.date.TabIndex = 3;
            this.date.Text = "день.месяц.год";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(215, 92);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(381, 22);
            this.name.TabIndex = 2;
            this.name.Text = "Ф.И.О.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(274, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Afanasev Credit System";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(552, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать Вклад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Blue;
            this.tabPage2.Controls.Add(this.info);
            this.tabPage2.Controls.Add(this.numDeposit);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Управление Вкладом";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.ForeColor = System.Drawing.Color.GreenYellow;
            this.info.Location = new System.Drawing.Point(20, 290);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(163, 17);
            this.info.TabIndex = 3;
            this.info.Text = "Информация по вкладу";
            // 
            // numDeposit
            // 
            this.numDeposit.Location = new System.Drawing.Point(470, 206);
            this.numDeposit.Name = "numDeposit";
            this.numDeposit.Size = new System.Drawing.Size(110, 22);
            this.numDeposit.TabIndex = 2;
            this.numDeposit.Text = "Номер Вклада";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(643, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Закрыть Счет\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(749, 160);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Blue;
            this.tabPage3.Controls.Add(this.err2);
            this.tabPage3.Controls.Add(this.number);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(800, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Математика";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(103, 35);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(242, 22);
            this.number.TabIndex = 2;
            this.number.Text = "Число";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(633, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 44);
            this.button3.TabIndex = 1;
            this.button3.Text = "Рассчитать";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadToDeg);
            this.groupBox1.Controls.Add(this.DegToRad);
            this.groupBox1.Controls.Add(this.Crt);
            this.groupBox1.Controls.Add(this.IsOdd);
            this.groupBox1.Controls.Add(this.IsEven);
            this.groupBox1.Controls.Add(this.FracPart);
            this.groupBox1.Controls.Add(this.Reciproc);
            this.groupBox1.Controls.Add(this.Fac);
            this.groupBox1.ForeColor = System.Drawing.Color.YellowGreen;
            this.groupBox1.Location = new System.Drawing.Point(413, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операции";
            // 
            // RadToDeg
            // 
            this.RadToDeg.AutoSize = true;
            this.RadToDeg.Location = new System.Drawing.Point(16, 217);
            this.RadToDeg.Name = "RadToDeg";
            this.RadToDeg.Size = new System.Drawing.Size(95, 21);
            this.RadToDeg.TabIndex = 0;
            this.RadToDeg.Text = "В градусы";
            this.RadToDeg.UseVisualStyleBackColor = true;
            // 
            // DegToRad
            // 
            this.DegToRad.AutoSize = true;
            this.DegToRad.Location = new System.Drawing.Point(16, 190);
            this.DegToRad.Name = "DegToRad";
            this.DegToRad.Size = new System.Drawing.Size(100, 21);
            this.DegToRad.TabIndex = 0;
            this.DegToRad.Text = "В радианы";
            this.DegToRad.UseVisualStyleBackColor = true;
            // 
            // Crt
            // 
            this.Crt.AutoSize = true;
            this.Crt.Location = new System.Drawing.Point(16, 163);
            this.Crt.Name = "Crt";
            this.Crt.Size = new System.Drawing.Size(157, 21);
            this.Crt.TabIndex = 0;
            this.Crt.Text = "Кубический корень";
            this.Crt.UseVisualStyleBackColor = true;
            // 
            // IsOdd
            // 
            this.IsOdd.AutoSize = true;
            this.IsOdd.Location = new System.Drawing.Point(16, 136);
            this.IsOdd.Name = "IsOdd";
            this.IsOdd.Size = new System.Drawing.Size(107, 21);
            this.IsOdd.TabIndex = 0;
            this.IsOdd.Text = "Нечетность";
            this.IsOdd.UseVisualStyleBackColor = true;
            // 
            // IsEven
            // 
            this.IsEven.AutoSize = true;
            this.IsEven.Location = new System.Drawing.Point(16, 109);
            this.IsEven.Name = "IsEven";
            this.IsEven.Size = new System.Drawing.Size(91, 21);
            this.IsEven.TabIndex = 0;
            this.IsEven.Text = "Четность";
            this.IsEven.UseVisualStyleBackColor = true;
            // 
            // FracPart
            // 
            this.FracPart.AutoSize = true;
            this.FracPart.Location = new System.Drawing.Point(16, 82);
            this.FracPart.Name = "FracPart";
            this.FracPart.Size = new System.Drawing.Size(129, 21);
            this.FracPart.TabIndex = 0;
            this.FracPart.Text = "Дробная часть";
            this.FracPart.UseVisualStyleBackColor = true;
            // 
            // Reciproc
            // 
            this.Reciproc.AutoSize = true;
            this.Reciproc.Location = new System.Drawing.Point(16, 55);
            this.Reciproc.Name = "Reciproc";
            this.Reciproc.Size = new System.Drawing.Size(162, 21);
            this.Reciproc.TabIndex = 0;
            this.Reciproc.Text = "Обратное значение";
            this.Reciproc.UseVisualStyleBackColor = true;
            // 
            // Fac
            // 
            this.Fac.AutoSize = true;
            this.Fac.Checked = true;
            this.Fac.Location = new System.Drawing.Point(16, 28);
            this.Fac.Name = "Fac";
            this.Fac.Size = new System.Drawing.Size(104, 21);
            this.Fac.TabIndex = 0;
            this.Fac.TabStop = true;
            this.Fac.Text = "Факториал";
            this.Fac.UseVisualStyleBackColor = true;
            // 
            // err2
            // 
            this.err2.AutoSize = true;
            this.err2.ForeColor = System.Drawing.Color.OrangeRed;
            this.err2.Location = new System.Drawing.Point(39, 309);
            this.err2.Name = "err2";
            this.err2.Size = new System.Drawing.Size(85, 17);
            this.err2.TabIndex = 3;
            this.err2.Text = "ошибок нет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(853, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cash;
        private System.Windows.Forms.TextBox period;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.TextBox numDeposit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadToDeg;
        private System.Windows.Forms.RadioButton DegToRad;
        private System.Windows.Forms.RadioButton Crt;
        private System.Windows.Forms.RadioButton IsOdd;
        private System.Windows.Forms.RadioButton IsEven;
        private System.Windows.Forms.RadioButton FracPart;
        private System.Windows.Forms.RadioButton Reciproc;
        private System.Windows.Forms.RadioButton Fac;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label err2;
    }
}

