namespace Zachet
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.primebutton = new System.Windows.Forms.Button();
            this.windbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.clearBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите число  от 3 до 20";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(332, 148);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // primebutton
            // 
            this.primebutton.Location = new System.Drawing.Point(192, 338);
            this.primebutton.Name = "primebutton";
            this.primebutton.Size = new System.Drawing.Size(75, 23);
            this.primebutton.TabIndex = 3;
            this.primebutton.Text = "Простые";
            this.primebutton.UseVisualStyleBackColor = true;
            this.primebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // windbutton
            // 
            this.windbutton.Location = new System.Drawing.Point(273, 338);
            this.windbutton.Name = "windbutton";
            this.windbutton.Size = new System.Drawing.Size(75, 23);
            this.windbutton.TabIndex = 4;
            this.windbutton.Text = "Передать";
            this.windbutton.UseVisualStyleBackColor = true;
            this.windbutton.Click += new System.EventHandler(this.windbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // clearBut
            // 
            this.clearBut.Location = new System.Drawing.Point(111, 338);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(75, 23);
            this.clearBut.TabIndex = 5;
            this.clearBut.Text = "Очистить";
            this.clearBut.UseVisualStyleBackColor = true;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(380, 393);
            this.Controls.Add(this.clearBut);
            this.Controls.Add(this.windbutton);
            this.Controls.Add(this.primebutton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Zachet";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button primebutton;
        private System.Windows.Forms.Button windbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button clearBut;
    }
}

