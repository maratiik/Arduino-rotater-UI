namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.serPort = new System.IO.Ports.SerialPort(this.components);
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonUpdatePorts = new System.Windows.Forms.Button();
            this.comboPorts = new System.Windows.Forms.ComboBox();
            this.labelArduino = new System.Windows.Forms.Label();
            this.textToPort = new System.Windows.Forms.TextBox();
            this.buttonToPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.buttonSetSpeed = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textRotateAngle = new System.Windows.Forms.TextBox();
            this.textSpeed = new System.Windows.Forms.TextBox();
            this.buttonMotorCheck = new System.Windows.Forms.Button();
            this.toggleSignalStart = new System.Windows.Forms.CheckBox();
            this.buttonSignal = new System.Windows.Forms.Button();
            this.checkManualControl = new System.Windows.Forms.CheckBox();
            this.buttonSetZero = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serPort
            // 
            this.serPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serPort_DataReceived);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(101, 34);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonUpdatePorts
            // 
            this.buttonUpdatePorts.Location = new System.Drawing.Point(12, 52);
            this.buttonUpdatePorts.Name = "buttonUpdatePorts";
            this.buttonUpdatePorts.Size = new System.Drawing.Size(101, 34);
            this.buttonUpdatePorts.TabIndex = 1;
            this.buttonUpdatePorts.Text = "Обновить список портов";
            this.buttonUpdatePorts.UseVisualStyleBackColor = true;
            this.buttonUpdatePorts.Click += new System.EventHandler(this.buttonUpdatePorts_Click);
            // 
            // comboPorts
            // 
            this.comboPorts.FormattingEnabled = true;
            this.comboPorts.Location = new System.Drawing.Point(119, 60);
            this.comboPorts.Name = "comboPorts";
            this.comboPorts.Size = new System.Drawing.Size(121, 21);
            this.comboPorts.TabIndex = 2;
            this.comboPorts.SelectedIndexChanged += new System.EventHandler(this.comboPorts_SelectedIndexChanged);
            // 
            // labelArduino
            // 
            this.labelArduino.AutoSize = true;
            this.labelArduino.Location = new System.Drawing.Point(12, 131);
            this.labelArduino.Name = "labelArduino";
            this.labelArduino.Size = new System.Drawing.Size(45, 13);
            this.labelArduino.TabIndex = 4;
            this.labelArduino.Text = "Debug: ";
            // 
            // textToPort
            // 
            this.textToPort.Location = new System.Drawing.Point(470, 40);
            this.textToPort.Name = "textToPort";
            this.textToPort.Size = new System.Drawing.Size(318, 20);
            this.textToPort.TabIndex = 5;
            // 
            // buttonToPort
            // 
            this.buttonToPort.Location = new System.Drawing.Point(335, 29);
            this.buttonToPort.Name = "buttonToPort";
            this.buttonToPort.Size = new System.Drawing.Size(129, 41);
            this.buttonToPort.TabIndex = 6;
            this.buttonToPort.Text = "Отправить текст на ардуино";
            this.buttonToPort.UseVisualStyleBackColor = true;
            this.buttonToPort.Click += new System.EventHandler(this.buttonToPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Задать скорость в RPM = \"spdVALUE_\" (макс. скорость 300 RPM)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Повернуть в градусах = \"rotVALUE_\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сбросить до начального положения = \"rst_\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Задержать в мс = \"dlyVALUE_\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Команды пишутся одна за одной, между ними обязателен знак \"_\"";
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(335, 188);
            this.buttonRotate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(129, 28);
            this.buttonRotate.TabIndex = 12;
            this.buttonRotate.Text = "Повернуть";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // buttonSetSpeed
            // 
            this.buttonSetSpeed.Location = new System.Drawing.Point(335, 221);
            this.buttonSetSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSetSpeed.Name = "buttonSetSpeed";
            this.buttonSetSpeed.Size = new System.Drawing.Size(129, 28);
            this.buttonSetSpeed.TabIndex = 13;
            this.buttonSetSpeed.Text = "Задать скорость";
            this.buttonSetSpeed.UseVisualStyleBackColor = true;
            this.buttonSetSpeed.Click += new System.EventHandler(this.buttonSetSpeed_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(335, 254);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(129, 28);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textRotateAngle
            // 
            this.textRotateAngle.Location = new System.Drawing.Point(470, 192);
            this.textRotateAngle.Margin = new System.Windows.Forms.Padding(2);
            this.textRotateAngle.Name = "textRotateAngle";
            this.textRotateAngle.Size = new System.Drawing.Size(76, 20);
            this.textRotateAngle.TabIndex = 15;
            // 
            // textSpeed
            // 
            this.textSpeed.Location = new System.Drawing.Point(470, 226);
            this.textSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.textSpeed.Name = "textSpeed";
            this.textSpeed.Size = new System.Drawing.Size(76, 20);
            this.textSpeed.TabIndex = 16;
            // 
            // buttonMotorCheck
            // 
            this.buttonMotorCheck.Location = new System.Drawing.Point(12, 94);
            this.buttonMotorCheck.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMotorCheck.Name = "buttonMotorCheck";
            this.buttonMotorCheck.Size = new System.Drawing.Size(101, 34);
            this.buttonMotorCheck.TabIndex = 18;
            this.buttonMotorCheck.Text = "Проверить мотор";
            this.buttonMotorCheck.UseVisualStyleBackColor = true;
            this.buttonMotorCheck.Click += new System.EventHandler(this.buttonMotorCheck_Click);
            // 
            // toggleSignalStart
            // 
            this.toggleSignalStart.AutoSize = true;
            this.toggleSignalStart.Location = new System.Drawing.Point(536, 424);
            this.toggleSignalStart.Margin = new System.Windows.Forms.Padding(2);
            this.toggleSignalStart.Name = "toggleSignalStart";
            this.toggleSignalStart.Size = new System.Drawing.Size(266, 17);
            this.toggleSignalStart.TabIndex = 19;
            this.toggleSignalStart.Text = "Включать программу после получения сигнала";
            this.toggleSignalStart.UseVisualStyleBackColor = true;
            this.toggleSignalStart.CheckedChanged += new System.EventHandler(this.toggleSignalStart_CheckedChanged);
            // 
            // buttonSignal
            // 
            this.buttonSignal.Location = new System.Drawing.Point(536, 392);
            this.buttonSignal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSignal.Name = "buttonSignal";
            this.buttonSignal.Size = new System.Drawing.Size(144, 28);
            this.buttonSignal.TabIndex = 20;
            this.buttonSignal.Text = "Имитировать сигнал";
            this.buttonSignal.UseVisualStyleBackColor = true;
            this.buttonSignal.Click += new System.EventHandler(this.buttonSignal_Click);
            // 
            // checkManualControl
            // 
            this.checkManualControl.AutoSize = true;
            this.checkManualControl.Location = new System.Drawing.Point(336, 166);
            this.checkManualControl.Name = "checkManualControl";
            this.checkManualControl.Size = new System.Drawing.Size(123, 17);
            this.checkManualControl.TabIndex = 21;
            this.checkManualControl.Text = "Ручное управление";
            this.checkManualControl.UseVisualStyleBackColor = true;
            this.checkManualControl.CheckedChanged += new System.EventHandler(this.checkManualControl_CheckedChanged);
            // 
            // buttonSetZero
            // 
            this.buttonSetZero.Location = new System.Drawing.Point(577, 188);
            this.buttonSetZero.Name = "buttonSetZero";
            this.buttonSetZero.Size = new System.Drawing.Size(103, 28);
            this.buttonSetZero.TabIndex = 22;
            this.buttonSetZero.Text = "Задать ноль";
            this.buttonSetZero.UseVisualStyleBackColor = true;
            this.buttonSetZero.Click += new System.EventHandler(this.buttonSetZero_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Задать ноль = \"zro_\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSetZero);
            this.Controls.Add(this.checkManualControl);
            this.Controls.Add(this.buttonSignal);
            this.Controls.Add(this.toggleSignalStart);
            this.Controls.Add(this.buttonMotorCheck);
            this.Controls.Add(this.textSpeed);
            this.Controls.Add(this.textRotateAngle);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSetSpeed);
            this.Controls.Add(this.buttonRotate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonToPort);
            this.Controls.Add(this.textToPort);
            this.Controls.Add(this.labelArduino);
            this.Controls.Add(this.comboPorts);
            this.Controls.Add(this.buttonUpdatePorts);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonUpdatePorts;
        private System.Windows.Forms.ComboBox comboPorts;
        private System.Windows.Forms.Label labelArduino;
        private System.Windows.Forms.TextBox textToPort;
        private System.Windows.Forms.Button buttonToPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRotate;
        private System.Windows.Forms.Button buttonSetSpeed;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textRotateAngle;
        private System.Windows.Forms.TextBox textSpeed;
        private System.Windows.Forms.Button buttonMotorCheck;
        private System.Windows.Forms.CheckBox toggleSignalStart;
        private System.Windows.Forms.Button buttonSignal;
        private System.Windows.Forms.CheckBox checkManualControl;
        private System.Windows.Forms.Button buttonSetZero;
        private System.Windows.Forms.Label label6;
    }
}

