namespace test
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.otv_lbl = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.one_txt = new System.Windows.Forms.TextBox();
            this.two_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Первое число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Второе число";
            // 
            // otv_lbl
            // 
            this.otv_lbl.AutoSize = true;
            this.otv_lbl.Location = new System.Drawing.Point(30, 237);
            this.otv_lbl.Name = "otv_lbl";
            this.otv_lbl.Size = new System.Drawing.Size(0, 13);
            this.otv_lbl.TabIndex = 2;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(107, 183);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 3;
            this.ok_btn.Text = "Рассчитать";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // one_txt
            // 
            this.one_txt.Location = new System.Drawing.Point(151, 50);
            this.one_txt.Name = "one_txt";
            this.one_txt.Size = new System.Drawing.Size(100, 20);
            this.one_txt.TabIndex = 4;
            // 
            // two_txt
            // 
            this.two_txt.Location = new System.Drawing.Point(151, 106);
            this.two_txt.Name = "two_txt";
            this.two_txt.Size = new System.Drawing.Size(100, 20);
            this.two_txt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 295);
            this.Controls.Add(this.two_txt);
            this.Controls.Add(this.one_txt);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.otv_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label otv_lbl;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox one_txt;
        private System.Windows.Forms.TextBox two_txt;
    }
}

