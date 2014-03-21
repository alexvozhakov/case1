namespace Case1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstArgumentField = new System.Windows.Forms.TextBox();
            this.SecondArgumentField = new System.Windows.Forms.TextBox();
            this.ThirdArgumentField = new System.Windows.Forms.TextBox();
            this.Summ = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Deduc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstArgumentField
            // 
            this.FirstArgumentField.Location = new System.Drawing.Point(25, 24);
            this.FirstArgumentField.Name = "FirstArgumentField";
            this.FirstArgumentField.Size = new System.Drawing.Size(100, 20);
            this.FirstArgumentField.TabIndex = 0;
            // 
            // SecondArgumentField
            // 
            this.SecondArgumentField.Location = new System.Drawing.Point(162, 24);
            this.SecondArgumentField.Name = "SecondArgumentField";
            this.SecondArgumentField.Size = new System.Drawing.Size(100, 20);
            this.SecondArgumentField.TabIndex = 1;
            // 
            // ThirdArgumentField
            // 
            this.ThirdArgumentField.Location = new System.Drawing.Point(25, 60);
            this.ThirdArgumentField.Name = "ThirdArgumentField";
            this.ThirdArgumentField.Size = new System.Drawing.Size(237, 20);
            this.ThirdArgumentField.TabIndex = 2;
            // 
            // Summ
            // 
            this.Summ.Location = new System.Drawing.Point(177, 194);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(85, 44);
            this.Summ.TabIndex = 3;
            this.Summ.Text = "+";
            this.Summ.UseVisualStyleBackColor = true;
            this.Summ.Click += new System.EventHandler(this.Summ_Click);
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(178, 134);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(84, 42);
            this.Mult.TabIndex = 4;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(25, 134);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(84, 42);
            this.Div.TabIndex = 5;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Deduc
            // 
            this.Deduc.Location = new System.Drawing.Point(25, 194);
            this.Deduc.Name = "Deduc";
            this.Deduc.Size = new System.Drawing.Size(84, 44);
            this.Deduc.TabIndex = 6;
            this.Deduc.Text = "-";
            this.Deduc.UseVisualStyleBackColor = true;
            this.Deduc.Click += new System.EventHandler(this.Deduc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Deduc);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.ThirdArgumentField);
            this.Controls.Add(this.SecondArgumentField);
            this.Controls.Add(this.FirstArgumentField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstArgumentField;
        private System.Windows.Forms.TextBox SecondArgumentField;
        private System.Windows.Forms.TextBox ThirdArgumentField;
        private System.Windows.Forms.Button Summ;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Deduc;
    }
}

