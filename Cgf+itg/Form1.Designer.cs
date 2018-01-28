namespace Cgf_itg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.itg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NameNewFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.x3 = new System.Windows.Forms.RadioButton();
            this.x2 = new System.Windows.Forms.RadioButton();
            this.ISX_X = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.But20400 = new System.Windows.Forms.Button();
            this.Diagn20400 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.y2 = new System.Windows.Forms.RadioButton();
            this.y1 = new System.Windows.Forms.RadioButton();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StDir = new System.Windows.Forms.ToolStripStatusLabel();
            this.NameDir = new System.Windows.Forms.ComboBox();
            this.NameDisk = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // itg
            // 
            this.itg.Enabled = false;
            this.itg.Location = new System.Drawing.Point(129, 51);
            this.itg.Name = "itg";
            this.itg.Size = new System.Drawing.Size(75, 23);
            this.itg.TabIndex = 0;
            this.itg.Text = "*.itg";
            this.itg.UseVisualStyleBackColor = true;
            this.itg.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(129, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "*.cfg";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(129, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "new *.itg";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GO
            // 
            this.GO.Enabled = false;
            this.GO.Location = new System.Drawing.Point(129, 133);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(75, 22);
            this.GO.TabIndex = 3;
            this.GO.Text = "GO";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.confirm);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.NameNewFile);
            this.groupBox1.Controls.Add(this.GO);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.itg);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки для файла OBD1_SLP1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Restart";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Enabled = false;
            this.confirm.Location = new System.Drawing.Point(63, 137);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(60, 17);
            this.confirm.TabIndex = 14;
            this.confirm.Text = "confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Visible = false;
            this.confirm.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(117, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.Text = "slp.itg";
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Diagn.cfg";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "obd1_slp.itg";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(129, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "*.itg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NameNewFile
            // 
            this.NameNewFile.Location = new System.Drawing.Point(6, 19);
            this.NameNewFile.Name = "NameNewFile";
            this.NameNewFile.Size = new System.Drawing.Size(117, 20);
            this.NameNewFile.TabIndex = 8;
            this.NameNewFile.Text = "newOBD1_SLP.itg";
            this.NameNewFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.ISX_X);
            this.groupBox2.Location = new System.Drawing.Point(250, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 163);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки для файла OBD1_SLPx";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(287, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 38);
            this.button4.TabIndex = 15;
            this.button4.Text = "OBD1_SLPx";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(382, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(109, 20);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "LP002";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(382, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "LP001";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.x3);
            this.groupBox3.Controls.Add(this.x2);
            this.groupBox3.Location = new System.Drawing.Point(287, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 66);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "x=2 and x=3";
            // 
            // x3
            // 
            this.x3.AutoSize = true;
            this.x3.Location = new System.Drawing.Point(6, 43);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(42, 17);
            this.x3.TabIndex = 11;
            this.x3.Text = "x=3";
            this.x3.UseVisualStyleBackColor = true;
            this.x3.CheckedChanged += new System.EventHandler(this.x3_CheckedChanged);
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Location = new System.Drawing.Point(6, 20);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(42, 17);
            this.x2.TabIndex = 10;
            this.x2.Text = "x=2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.CheckedChanged += new System.EventHandler(this.x2_CheckedChanged);
            // 
            // ISX_X
            // 
            this.ISX_X.Location = new System.Drawing.Point(6, 19);
            this.ISX_X.Multiline = true;
            this.ISX_X.Name = "ISX_X";
            this.ISX_X.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ISX_X.Size = new System.Drawing.Size(275, 110);
            this.ISX_X.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(53, 162);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(161, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "Search";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // But20400
            // 
            this.But20400.Enabled = false;
            this.But20400.Location = new System.Drawing.Point(220, 33);
            this.But20400.Name = "But20400";
            this.But20400.Size = new System.Drawing.Size(109, 23);
            this.But20400.TabIndex = 17;
            this.But20400.Text = "20400 (new)";
            this.But20400.UseVisualStyleBackColor = true;
            this.But20400.Click += new System.EventHandler(this.button8_Click);
            // 
            // Diagn20400
            // 
            this.Diagn20400.Location = new System.Drawing.Point(220, 7);
            this.Diagn20400.Name = "Diagn20400";
            this.Diagn20400.Size = new System.Drawing.Size(109, 20);
            this.Diagn20400.TabIndex = 16;
            this.Diagn20400.Text = "NewFile.itg";
            this.Diagn20400.TextChanged += new System.EventHandler(this.Diagn20400_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.textBox8);
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.textBox7);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(3, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(744, 271);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Настройки для файла OBD_SHGSy";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(7, 204);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox12.Size = new System.Drawing.Size(636, 61);
            this.textBox12.TabIndex = 20;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(310, 109);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox11.Size = new System.Drawing.Size(333, 88);
            this.textBox11.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(649, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 61);
            this.button5.TabIndex = 18;
            this.button5.Text = "OBD_SHGSy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(649, 177);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(89, 20);
            this.textBox10.TabIndex = 17;
            this.textBox10.Text = "LP001";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(649, 142);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(89, 20);
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "PG001002";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(649, 109);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(89, 20);
            this.textBox9.TabIndex = 15;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.y2);
            this.groupBox6.Controls.Add(this.y1);
            this.groupBox6.Location = new System.Drawing.Point(649, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(89, 84);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "y=1 and y=2";
            // 
            // y2
            // 
            this.y2.AutoSize = true;
            this.y2.Location = new System.Drawing.Point(6, 43);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(42, 17);
            this.y2.TabIndex = 11;
            this.y2.Text = "y=2";
            this.y2.UseVisualStyleBackColor = true;
            this.y2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // y1
            // 
            this.y1.AutoSize = true;
            this.y1.Location = new System.Drawing.Point(6, 20);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(42, 17);
            this.y1.TabIndex = 10;
            this.y1.Text = "y=1";
            this.y1.UseVisualStyleBackColor = true;
            this.y1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(310, 19);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(333, 84);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 19);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(298, 178);
            this.textBox6.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 479);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.NameDir);
            this.tabPage1.Controls.Add(this.NameDisk);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.But20400);
            this.tabPage1.Controls.Add(this.Diagn20400);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "20400";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StDir});
            this.statusStrip1.Location = new System.Drawing.Point(3, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(740, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusName";
            // 
            // StDir
            // 
            this.StDir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.StDir.Name = "StDir";
            this.StDir.Size = new System.Drawing.Size(0, 17);
            this.StDir.TextChanged += new System.EventHandler(this.NameDir_SelectedValueChanged_1);
            // 
            // NameDir
            // 
            this.NameDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.NameDir.FormattingEnabled = true;
            this.NameDir.Location = new System.Drawing.Point(53, 6);
            this.NameDir.Name = "NameDir";
            this.NameDir.Size = new System.Drawing.Size(161, 150);
            this.NameDir.Sorted = true;
            this.NameDir.TabIndex = 20;
            this.NameDir.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.NameDir.TextUpdate += new System.EventHandler(this.NameDisk_TextUpdate);
            this.NameDir.SelectedValueChanged += new System.EventHandler(this.NameDir_SelectedValueChanged_1);
            // 
            // NameDisk
            // 
            this.NameDisk.FormattingEnabled = true;
            this.NameDisk.Location = new System.Drawing.Point(6, 6);
            this.NameDisk.Name = "NameDisk";
            this.NameDisk.Size = new System.Drawing.Size(39, 21);
            this.NameDisk.TabIndex = 19;
            this.NameDisk.SelectedIndexChanged += new System.EventHandler(this.NameDisk_SelectedIndexChanged);
            this.NameDisk.TextChanged += new System.EventHandler(this.NameDisk_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "40400";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 479);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание заглушки СЛП для ШГС";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button itg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NameNewFile;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox confirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ISX_X;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton x3;
        private System.Windows.Forms.RadioButton x2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton y2;
        private System.Windows.Forms.RadioButton y1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox Diagn20400;
        private System.Windows.Forms.Button But20400;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox NameDisk;
        private System.Windows.Forms.ComboBox NameDir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StDir;
    }
}

