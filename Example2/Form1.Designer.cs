namespace Example2
{
    partial class Form1
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
            this.label_Astana = new System.Windows.Forms.Label();
            this.label_Almaty = new System.Windows.Forms.Label();
            this.label_Aktobe = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Taraz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Astana
            // 
            this.label_Astana.AutoSize = true;
            this.label_Astana.Location = new System.Drawing.Point(337, 121);
            this.label_Astana.Name = "label_Astana";
            this.label_Astana.Size = new System.Drawing.Size(70, 25);
            this.label_Astana.TabIndex = 0;
            this.label_Astana.Text = "label1";
            // 
            // label_Almaty
            // 
            this.label_Almaty.AutoSize = true;
            this.label_Almaty.Location = new System.Drawing.Point(337, 186);
            this.label_Almaty.Name = "label_Almaty";
            this.label_Almaty.Size = new System.Drawing.Size(70, 25);
            this.label_Almaty.TabIndex = 1;
            this.label_Almaty.Text = "label2";
            // 
            // label_Aktobe
            // 
            this.label_Aktobe.AutoSize = true;
            this.label_Aktobe.Location = new System.Drawing.Point(337, 264);
            this.label_Aktobe.Name = "label_Aktobe";
            this.label_Aktobe.Size = new System.Drawing.Size(70, 25);
            this.label_Aktobe.TabIndex = 2;
            this.label_Aktobe.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Taraz
            // 
            this.label_Taraz.AutoSize = true;
            this.label_Taraz.Location = new System.Drawing.Point(337, 335);
            this.label_Taraz.Name = "label_Taraz";
            this.label_Taraz.Size = new System.Drawing.Size(70, 25);
            this.label_Taraz.TabIndex = 4;
            this.label_Taraz.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 678);
            this.Controls.Add(this.label_Taraz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Aktobe);
            this.Controls.Add(this.label_Almaty);
            this.Controls.Add(this.label_Astana);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Astana;
        private System.Windows.Forms.Label label_Almaty;
        private System.Windows.Forms.Label label_Aktobe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Taraz;
    }
}

