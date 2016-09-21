namespace Formula
{
    partial class myForm
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
            this.input = new System.Windows.Forms.TextBox();
            this.inputBtn = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xInput = new System.Windows.Forms.TextBox();
            this.yInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Z =";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(52, 33);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(307, 20);
            this.input.TabIndex = 1;
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(384, 59);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(117, 50);
            this.inputBtn.TabIndex = 2;
            this.inputBtn.Text = "Вычислить";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(384, 33);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(189, 20);
            this.output.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "X =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Y =";
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(52, 59);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(200, 20);
            this.xInput.TabIndex = 7;
            // 
            // yInput
            // 
            this.yInput.Location = new System.Drawing.Point(52, 86);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(200, 20);
            this.yInput.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "График";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 139);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(634, 177);
            this.MinimumSize = new System.Drawing.Size(634, 177);
            this.Name = "myForm";
            this.Text = "Вычисление  Формулы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.Button button1;
    }
}

