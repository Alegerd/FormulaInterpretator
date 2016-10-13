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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xInput = new System.Windows.Forms.TextBox();
            this.yInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.MaximumSize = new System.Drawing.Size(634, 177);
            this.MinimumSize = new System.Drawing.Size(634, 177);
            this.Name = "myForm";
            this.Text = "Вычисление  Формулы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.myForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.TextBox yInput;
        private System.Windows.Forms.Button button1;
    }
}

