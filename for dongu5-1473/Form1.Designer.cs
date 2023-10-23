namespace for_dongu5_1473
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
            this.btnYaz = new System.Windows.Forms.Button();
            this.txtSayı1 = new System.Windows.Forms.TextBox();
            this.txtSayı2 = new System.Windows.Forms.TextBox();
            this.txtSayı3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnYaz
            // 
            this.btnYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYaz.Location = new System.Drawing.Point(23, 266);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(148, 78);
            this.btnYaz.TabIndex = 0;
            this.btnYaz.Text = "YAZ";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // txtSayı1
            // 
            this.txtSayı1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayı1.Location = new System.Drawing.Point(23, 55);
            this.txtSayı1.Name = "txtSayı1";
            this.txtSayı1.Size = new System.Drawing.Size(148, 22);
            this.txtSayı1.TabIndex = 1;
            // 
            // txtSayı2
            // 
            this.txtSayı2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayı2.Location = new System.Drawing.Point(23, 138);
            this.txtSayı2.Name = "txtSayı2";
            this.txtSayı2.Size = new System.Drawing.Size(148, 22);
            this.txtSayı2.TabIndex = 2;
            // 
            // txtSayı3
            // 
            this.txtSayı3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayı3.Location = new System.Drawing.Point(23, 219);
            this.txtSayı3.Name = "txtSayı3";
            this.txtSayı3.Size = new System.Drawing.Size(148, 22);
            this.txtSayı3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DEĞİŞİM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "BİTİŞ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "BAŞLANGİÇ";
            // 
            // lbSayilar
            // 
            this.lbSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.ItemHeight = 16;
            this.lbSayilar.Location = new System.Drawing.Point(198, 55);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(142, 276);
            this.lbSayilar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 379);
            this.Controls.Add(this.lbSayilar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayı3);
            this.Controls.Add(this.txtSayı2);
            this.Controls.Add(this.txtSayı1);
            this.Controls.Add(this.btnYaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.TextBox txtSayı1;
        private System.Windows.Forms.TextBox txtSayı2;
        private System.Windows.Forms.TextBox txtSayı3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbSayilar;
    }
}

