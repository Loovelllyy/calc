
namespace test1
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnDif = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSeg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(79, 210);
            this.input1.Multiline = true;
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 31);
            this.input1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "input num1";
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(251, 210);
            this.input2.Multiline = true;
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 31);
            this.input2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "input num1";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox3.Location = new System.Drawing.Point(402, 235);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(106, 47);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "=";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.result.Location = new System.Drawing.Point(577, 210);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(172, 92);
            this.result.TabIndex = 10;
            this.result.Text = "result will be here";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(20, 16);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(48, 23);
            this.btnSum.TabIndex = 5;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnDif
            // 
            this.btnDif.Location = new System.Drawing.Point(96, 16);
            this.btnDif.Name = "btnDif";
            this.btnDif.Size = new System.Drawing.Size(48, 23);
            this.btnDif.TabIndex = 6;
            this.btnDif.Text = "-";
            this.btnDif.UseVisualStyleBackColor = true;
            this.btnDif.Click += new System.EventHandler(this.btnDif_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(170, 16);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(48, 23);
            this.btnMult.TabIndex = 7;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnSeg
            // 
            this.btnSeg.Location = new System.Drawing.Point(241, 16);
            this.btnSeg.Name = "btnSeg";
            this.btnSeg.Size = new System.Drawing.Size(48, 23);
            this.btnSeg.TabIndex = 8;
            this.btnSeg.Text = "/";
            this.btnSeg.UseVisualStyleBackColor = true;
            this.btnSeg.Click += new System.EventHandler(this.btnSeg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeg);
            this.groupBox1.Controls.Add(this.btnMult);
            this.groupBox1.Controls.Add(this.btnDif);
            this.groupBox1.Controls.Add(this.btnSum);
            this.groupBox1.Location = new System.Drawing.Point(63, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 53);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "choise action";
            this.groupBox1.MouseCaptureChanged += new System.EventHandler(this.clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Name Programm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnDif;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSeg;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

