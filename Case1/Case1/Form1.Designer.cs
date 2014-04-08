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
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.Acos = new System.Windows.Forms.Button();
            this.Asin = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.cotan = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.pow2 = new System.Windows.Forms.Button();
            this.log10 = new System.Windows.Forms.Button();
            this.Atan = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstArgumentField
            // 
            this.FirstArgumentField.Location = new System.Drawing.Point(25, 24);
            this.FirstArgumentField.Name = "FirstArgumentField";
            this.FirstArgumentField.Size = new System.Drawing.Size(276, 20);
            this.FirstArgumentField.TabIndex = 0;
            // 
            // SecondArgumentField
            // 
            this.SecondArgumentField.Location = new System.Drawing.Point(307, 24);
            this.SecondArgumentField.Name = "SecondArgumentField";
            this.SecondArgumentField.Size = new System.Drawing.Size(282, 20);
            this.SecondArgumentField.TabIndex = 1;
            // 
            // ThirdArgumentField
            // 
            this.ThirdArgumentField.Location = new System.Drawing.Point(25, 60);
            this.ThirdArgumentField.Name = "ThirdArgumentField";
            this.ThirdArgumentField.Size = new System.Drawing.Size(564, 20);
            this.ThirdArgumentField.TabIndex = 2;
            // 
            // Summ
            // 
            this.Summ.Location = new System.Drawing.Point(79, 147);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(46, 41);
            this.Summ.TabIndex = 3;
            this.Summ.Text = "+";
            this.Summ.UseVisualStyleBackColor = true;
            this.Summ.Click += new System.EventHandler(this.Summ_Click);
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(79, 98);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(46, 42);
            this.Mult.TabIndex = 4;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(27, 98);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(44, 42);
            this.Div.TabIndex = 5;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Deduc
            // 
            this.Deduc.Location = new System.Drawing.Point(27, 146);
            this.Deduc.Name = "Deduc";
            this.Deduc.Size = new System.Drawing.Size(44, 42);
            this.Deduc.TabIndex = 6;
            this.Deduc.Text = "-";
            this.Deduc.UseVisualStyleBackColor = true;
            this.Deduc.Click += new System.EventHandler(this.Deduc_Click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(256, 98);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(45, 42);
            this.sin.TabIndex = 7;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(307, 98);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(46, 42);
            this.cos.TabIndex = 8;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // Acos
            // 
            this.Acos.Location = new System.Drawing.Point(411, 147);
            this.Acos.Name = "Acos";
            this.Acos.Size = new System.Drawing.Size(46, 41);
            this.Acos.TabIndex = 9;
            this.Acos.Text = "Acos";
            this.Acos.UseVisualStyleBackColor = true;
            this.Acos.Click += new System.EventHandler(this.button3_Click);
            // 
            // Asin
            // 
            this.Asin.Location = new System.Drawing.Point(463, 147);
            this.Asin.Name = "Asin";
            this.Asin.Size = new System.Drawing.Size(46, 41);
            this.Asin.TabIndex = 10;
            this.Asin.Text = "Asin";
            this.Asin.UseVisualStyleBackColor = true;
            this.Asin.Click += new System.EventHandler(this.button4_Click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(359, 98);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(46, 42);
            this.tan.TabIndex = 11;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.tan_Click);
            // 
            // cotan
            // 
            this.cotan.Location = new System.Drawing.Point(411, 98);
            this.cotan.Name = "cotan";
            this.cotan.Size = new System.Drawing.Size(46, 42);
            this.cotan.TabIndex = 12;
            this.cotan.Text = "ctan";
            this.cotan.UseVisualStyleBackColor = true;
            this.cotan.Click += new System.EventHandler(this.cotan_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(463, 98);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(46, 42);
            this.sqrt.TabIndex = 13;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // pow
            // 
            this.pow.Location = new System.Drawing.Point(515, 98);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(46, 42);
            this.pow.TabIndex = 14;
            this.pow.Text = "a^b";
            this.pow.UseVisualStyleBackColor = true;
            this.pow.Click += new System.EventHandler(this.pow_Click);
            // 
            // pow2
            // 
            this.pow2.Location = new System.Drawing.Point(307, 147);
            this.pow2.Name = "pow2";
            this.pow2.Size = new System.Drawing.Size(46, 41);
            this.pow2.TabIndex = 15;
            this.pow2.Text = "x^2";
            this.pow2.UseVisualStyleBackColor = true;
            this.pow2.Click += new System.EventHandler(this.pow2_Click);
            // 
            // log10
            // 
            this.log10.Location = new System.Drawing.Point(359, 147);
            this.log10.Name = "log10";
            this.log10.Size = new System.Drawing.Size(46, 41);
            this.log10.TabIndex = 16;
            this.log10.Text = "log10";
            this.log10.UseVisualStyleBackColor = true;
            this.log10.Click += new System.EventHandler(this.log10_Click);
            // 
            // Atan
            // 
            this.Atan.Location = new System.Drawing.Point(515, 147);
            this.Atan.Name = "Atan";
            this.Atan.Size = new System.Drawing.Size(46, 41);
            this.Atan.TabIndex = 17;
            this.Atan.Text = "Atan";
            this.Atan.UseVisualStyleBackColor = true;
            this.Atan.Click += new System.EventHandler(this.Atan_Click);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(256, 146);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(45, 42);
            this.ln.TabIndex = 18;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.ln_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 259);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.Atan);
            this.Controls.Add(this.log10);
            this.Controls.Add(this.pow2);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.cotan);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.Asin);
            this.Controls.Add(this.Acos);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
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
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button Acos;
        private System.Windows.Forms.Button Asin;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button cotan;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button pow2;
        private System.Windows.Forms.Button log10;
        private System.Windows.Forms.Button Atan;
        private System.Windows.Forms.Button ln;
    }
}

