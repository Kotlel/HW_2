namespace WinForms_homework2
{
    partial class LoadFileForm
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
            this.XML_btn = new System.Windows.Forms.Button();
            this.JSON_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XML_btn
            // 
            this.XML_btn.Location = new System.Drawing.Point(292, 104);
            this.XML_btn.Name = "XML_btn";
            this.XML_btn.Size = new System.Drawing.Size(162, 23);
            this.XML_btn.TabIndex = 0;
            this.XML_btn.Text = "загрузить xml";
            this.XML_btn.UseVisualStyleBackColor = true;
            this.XML_btn.Click += new System.EventHandler(this.XML_btn_Click);
            // 
            // JSON_btn
            // 
            this.JSON_btn.Location = new System.Drawing.Point(292, 152);
            this.JSON_btn.Name = "JSON_btn";
            this.JSON_btn.Size = new System.Drawing.Size(162, 23);
            this.JSON_btn.TabIndex = 1;
            this.JSON_btn.Text = "загрузить json";
            this.JSON_btn.UseVisualStyleBackColor = true;
            this.JSON_btn.Click += new System.EventHandler(this.JSON_btn_Click);
            // 
            // LoadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JSON_btn);
            this.Controls.Add(this.XML_btn);
            this.Name = "LoadFileForm";
            this.Text = "LoadFileForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button XML_btn;
        private System.Windows.Forms.Button JSON_btn;
    }
}