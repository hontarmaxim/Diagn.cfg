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
            this.itg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.GO = new System.Windows.Forms.Button();
            this.Linkitg = new System.Windows.Forms.TextBox();
            this.Linkcfg = new System.Windows.Forms.TextBox();
            this.Linknew = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameNewFile = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itg
            // 
            this.itg.Enabled = false;
            this.itg.Location = new System.Drawing.Point(345, 16);
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
            this.button2.Location = new System.Drawing.Point(345, 45);
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
            this.button3.Location = new System.Drawing.Point(426, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "new *.itg";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GO
            // 
            this.GO.Location = new System.Drawing.Point(524, 16);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(75, 51);
            this.GO.TabIndex = 3;
            this.GO.Text = "GO";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.button4_Click);
            // 
            // Linkitg
            // 
            this.Linkitg.Enabled = false;
            this.Linkitg.Location = new System.Drawing.Point(6, 18);
            this.Linkitg.Name = "Linkitg";
            this.Linkitg.Size = new System.Drawing.Size(333, 20);
            this.Linkitg.TabIndex = 4;
            this.Linkitg.Text = "путь к архиву ";
            // 
            // Linkcfg
            // 
            this.Linkcfg.Enabled = false;
            this.Linkcfg.Location = new System.Drawing.Point(6, 47);
            this.Linkcfg.Name = "Linkcfg";
            this.Linkcfg.Size = new System.Drawing.Size(333, 20);
            this.Linkcfg.TabIndex = 5;
            this.Linkcfg.Text = "путь к архиву ";
            // 
            // Linknew
            // 
            this.Linknew.Enabled = false;
            this.Linknew.Location = new System.Drawing.Point(6, 76);
            this.Linknew.Name = "Linknew";
            this.Linknew.Size = new System.Drawing.Size(333, 20);
            this.Linknew.TabIndex = 6;
            this.Linknew.Text = "для хранения временных файлов и нового файла";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Linkitg);
            this.groupBox1.Controls.Add(this.NameNewFile);
            this.groupBox1.Controls.Add(this.GO);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.Linknew);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.itg);
            this.groupBox1.Controls.Add(this.Linkcfg);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 102);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // NameNewFile
            // 
            this.NameNewFile.Location = new System.Drawing.Point(345, 76);
            this.NameNewFile.Name = "NameNewFile";
            this.NameNewFile.Size = new System.Drawing.Size(75, 20);
            this.NameNewFile.TabIndex = 8;
            this.NameNewFile.Text = "1.itg";
            this.NameNewFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 177);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Go";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button itg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.TextBox Linkitg;
        private System.Windows.Forms.TextBox Linkcfg;
        private System.Windows.Forms.TextBox Linknew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NameNewFile;
    }
}

