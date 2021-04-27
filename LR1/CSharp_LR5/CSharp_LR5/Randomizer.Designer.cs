namespace CSharp_LR5
{
    partial class Randomizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Randomizer));
            this.start_btn = new System.Windows.Forms.Button();
            this.db_conn_btn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pause_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.amps_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amps_2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.amps_3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.amps_4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.amps_5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.voltage_feeder = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.White;
            this.start_btn.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Image = ((System.Drawing.Image)(resources.GetObject("start_btn.Image")));
            this.start_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.start_btn.Location = new System.Drawing.Point(19, 135);
            this.start_btn.Name = "start_btn";
            this.start_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.start_btn.Size = new System.Drawing.Size(212, 61);
            this.start_btn.TabIndex = 42;
            this.start_btn.Text = "Старт";
            this.start_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Visible = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // db_conn_btn
            // 
            this.db_conn_btn.BackColor = System.Drawing.Color.White;
            this.db_conn_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.db_conn_btn.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_conn_btn.Image = ((System.Drawing.Image)(resources.GetObject("db_conn_btn.Image")));
            this.db_conn_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.db_conn_btn.Location = new System.Drawing.Point(19, 68);
            this.db_conn_btn.Name = "db_conn_btn";
            this.db_conn_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.db_conn_btn.Size = new System.Drawing.Size(212, 61);
            this.db_conn_btn.TabIndex = 41;
            this.db_conn_btn.Text = "Подключиться к БД";
            this.db_conn_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.db_conn_btn.UseVisualStyleBackColor = false;
            this.db_conn_btn.Click += new System.EventHandler(this.db_conn_btn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Gilroy Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(544, 37);
            this.label15.TabIndex = 40;
            this.label15.Text = "Симулятор энергосистемы завода";
            // 
            // pause_btn
            // 
            this.pause_btn.BackColor = System.Drawing.Color.White;
            this.pause_btn.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_btn.Image = ((System.Drawing.Image)(resources.GetObject("pause_btn.Image")));
            this.pause_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pause_btn.Location = new System.Drawing.Point(19, 135);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pause_btn.Size = new System.Drawing.Size(212, 61);
            this.pause_btn.TabIndex = 43;
            this.pause_btn.Text = "Пауза";
            this.pause_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pause_btn.UseVisualStyleBackColor = false;
            this.pause_btn.Visible = false;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "А";
            // 
            // amps_1
            // 
            this.amps_1.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amps_1.Location = new System.Drawing.Point(63, 263);
            this.amps_1.Name = "amps_1";
            this.amps_1.ReadOnly = true;
            this.amps_1.Size = new System.Drawing.Size(50, 30);
            this.amps_1.TabIndex = 45;
            this.amps_1.Text = "0";
            this.amps_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ток:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gilroy Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 37);
            this.label3.TabIndex = 47;
            this.label3.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gilroy Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 37);
            this.label4.TabIndex = 51;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(266, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "А";
            // 
            // amps_2
            // 
            this.amps_2.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amps_2.Location = new System.Drawing.Point(210, 263);
            this.amps_2.Name = "amps_2";
            this.amps_2.ReadOnly = true;
            this.amps_2.Size = new System.Drawing.Size(50, 30);
            this.amps_2.TabIndex = 49;
            this.amps_2.Text = "0";
            this.amps_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(162, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ток:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gilroy Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 37);
            this.label7.TabIndex = 55;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(418, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 22);
            this.label8.TabIndex = 54;
            this.label8.Text = "А";
            // 
            // amps_3
            // 
            this.amps_3.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amps_3.Location = new System.Drawing.Point(362, 263);
            this.amps_3.Name = "amps_3";
            this.amps_3.ReadOnly = true;
            this.amps_3.Size = new System.Drawing.Size(50, 30);
            this.amps_3.TabIndex = 53;
            this.amps_3.Text = "0";
            this.amps_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(314, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 22);
            this.label9.TabIndex = 52;
            this.label9.Text = "Ток:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gilroy Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(505, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 37);
            this.label10.TabIndex = 59;
            this.label10.Text = "4";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(568, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 22);
            this.label11.TabIndex = 58;
            this.label11.Text = "А";
            // 
            // amps_4
            // 
            this.amps_4.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amps_4.Location = new System.Drawing.Point(512, 263);
            this.amps_4.Name = "amps_4";
            this.amps_4.ReadOnly = true;
            this.amps_4.Size = new System.Drawing.Size(50, 30);
            this.amps_4.TabIndex = 57;
            this.amps_4.Text = "0";
            this.amps_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(464, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 22);
            this.label12.TabIndex = 56;
            this.label12.Text = "Ток:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Gilroy Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(655, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 37);
            this.label13.TabIndex = 63;
            this.label13.Text = "5";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(718, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 22);
            this.label14.TabIndex = 62;
            this.label14.Text = "А";
            // 
            // amps_5
            // 
            this.amps_5.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amps_5.Location = new System.Drawing.Point(662, 263);
            this.amps_5.Name = "amps_5";
            this.amps_5.ReadOnly = true;
            this.amps_5.Size = new System.Drawing.Size(50, 30);
            this.amps_5.TabIndex = 61;
            this.amps_5.Text = "0";
            this.amps_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(614, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 22);
            this.label16.TabIndex = 60;
            this.label16.Text = "Ток:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Gilroy Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(828, 214);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 37);
            this.label17.TabIndex = 67;
            this.label17.Text = "Фидер";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(953, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 22);
            this.label18.TabIndex = 66;
            this.label18.Text = "В";
            // 
            // voltage_feeder
            // 
            this.voltage_feeder.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voltage_feeder.Location = new System.Drawing.Point(897, 263);
            this.voltage_feeder.Name = "voltage_feeder";
            this.voltage_feeder.ReadOnly = true;
            this.voltage_feeder.Size = new System.Drawing.Size(50, 30);
            this.voltage_feeder.TabIndex = 65;
            this.voltage_feeder.Text = "0";
            this.voltage_feeder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("GOST type A", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(784, 266);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 22);
            this.label19.TabIndex = 64;
            this.label19.Text = "Напряжение: ";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.BackColor = System.Drawing.Color.Transparent;
            this.timer.Font = new System.Drawing.Font("Gilroy Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.Location = new System.Drawing.Point(237, 148);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(351, 28);
            this.timer.TabIndex = 68;
            this.timer.Text = "Отправка показаний через: -";
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 336);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.voltage_feeder);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.amps_5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.amps_4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.amps_3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amps_2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amps_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pause_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.db_conn_btn);
            this.Controls.Add(this.label15);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1037, 375);
            this.MinimumSize = new System.Drawing.Size(1037, 375);
            this.Name = "Randomizer";
            this.Text = "Randomizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Randomizer_FormClosing);
            this.Load += new System.EventHandler(this.Randomizer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button db_conn_btn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amps_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amps_2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox amps_3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox amps_4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox amps_5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox voltage_feeder;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label timer;
    }
}