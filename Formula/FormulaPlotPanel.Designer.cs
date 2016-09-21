namespace Formula
{
    partial class FormulaPlotPanel
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
            this.formulaPlotPB = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.formulaLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formulaPlotPB)).BeginInit();
            this.SuspendLayout();
            // 
            // formulaPlotPB
            // 
            this.formulaPlotPB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.formulaPlotPB.Location = new System.Drawing.Point(13, 13);
            this.formulaPlotPB.Name = "formulaPlotPB";
            this.formulaPlotPB.Size = new System.Drawing.Size(600, 360);
            this.formulaPlotPB.TabIndex = 0;
            this.formulaPlotPB.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(620, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(58, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Формула:";
            // 
            // formulaLabel
            // 
            this.formulaLabel.AutoSize = true;
            this.formulaLabel.Location = new System.Drawing.Point(623, 30);
            this.formulaLabel.Name = "formulaLabel";
            this.formulaLabel.Size = new System.Drawing.Size(0, 13);
            this.formulaLabel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Построить график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormulaPlotPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.formulaLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.formulaPlotPB);
            this.Name = "FormulaPlotPanel";
            this.Text = "FormulaPlotPanel";
            ((System.ComponentModel.ISupportInitialize)(this.formulaPlotPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox formulaPlotPB;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label formulaLabel;
        private System.Windows.Forms.Button button1;
    }
}