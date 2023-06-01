namespace YamanAlkabra_Rekenmachine
{
    partial class frmYaman_Rekenmachine
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
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(312, 132);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 22);
            this.txtValue1.TabIndex = 0;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(312, 173);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 22);
            this.txtValue2.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(275, 209);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(81, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "+";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(393, 209);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "-";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(393, 249);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "/";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(275, 249);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(81, 23);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "x";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // txtValue3
            // 
            this.txtValue3.Location = new System.Drawing.Point(322, 278);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.ReadOnly = true;
            this.txtValue3.Size = new System.Drawing.Size(100, 22);
            this.txtValue3.TabIndex = 6;
            // 
            // frmYaman_Rekenmachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValue3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Name = "frmYaman_Rekenmachine";
            this.Text = "Yaman_Rekenmachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.TextBox txtValue3;
    }
}

