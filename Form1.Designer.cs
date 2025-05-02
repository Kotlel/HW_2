namespace WinForms_homework2
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
            this.Load_btn = new System.Windows.Forms.Button();
            this.Elements_cb = new System.Windows.Forms.ComboBox();
            this.Elements_tb = new System.Windows.Forms.TextBox();
            this.Logo_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_btn
            // 
            this.Load_btn.Location = new System.Drawing.Point(643, 385);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(122, 23);
            this.Load_btn.TabIndex = 0;
            this.Load_btn.Text = "Загрузить";
            this.Load_btn.UseVisualStyleBackColor = true;
            this.Load_btn.Click += new System.EventHandler(this.Load_btn_Click);
            // 
            // Elements_cb
            // 
            this.Elements_cb.FormattingEnabled = true;
            this.Elements_cb.Location = new System.Drawing.Point(205, 93);
            this.Elements_cb.Name = "Elements_cb";
            this.Elements_cb.Size = new System.Drawing.Size(121, 24);
            this.Elements_cb.TabIndex = 1;
            // 
            // Elements_tb
            // 
            this.Elements_tb.Location = new System.Drawing.Point(367, 93);
            this.Elements_tb.Name = "Elements_tb";
            this.Elements_tb.Size = new System.Drawing.Size(357, 22);
            this.Elements_tb.TabIndex = 2;
            // 
            // Logo_pb
            // 
            this.Logo_pb.Location = new System.Drawing.Point(12, 12);
            this.Logo_pb.Name = "Logo_pb";
            this.Logo_pb.Size = new System.Drawing.Size(146, 105);
            this.Logo_pb.TabIndex = 3;
            this.Logo_pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logo_pb);
            this.Controls.Add(this.Elements_tb);
            this.Controls.Add(this.Elements_cb);
            this.Controls.Add(this.Load_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.ComboBox Elements_cb;
        private System.Windows.Forms.TextBox Elements_tb;
        private System.Windows.Forms.PictureBox Logo_pb;
    }
}

