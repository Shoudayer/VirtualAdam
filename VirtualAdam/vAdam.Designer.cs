namespace VirtualAdam
{
    partial class vAdam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vAdam));
            this.tb_log = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_rep = new System.Windows.Forms.TextBox();
            this.tb_addr2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.numAddr17 = new System.Windows.Forms.NumericUpDown();
            this.numAddr50 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAddr17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddr50)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_log
            // 
            this.tb_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_log.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_log.Location = new System.Drawing.Point(16, 31);
            this.tb_log.Margin = new System.Windows.Forms.Padding(4);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(478, 148);
            this.tb_log.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Flush";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_addr
            // 
            this.tb_addr.Location = new System.Drawing.Point(272, 252);
            this.tb_addr.Margin = new System.Windows.Forms.Padding(4);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.ReadOnly = true;
            this.tb_addr.Size = new System.Drawing.Size(48, 22);
            this.tb_addr.TabIndex = 2;
            this.tb_addr.Text = "0x17";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Module 4017 à l\'adresse :";
            // 
            // tb_rep
            // 
            this.tb_rep.Location = new System.Drawing.Point(16, 208);
            this.tb_rep.Margin = new System.Windows.Forms.Padding(4);
            this.tb_rep.Name = "tb_rep";
            this.tb_rep.Size = new System.Drawing.Size(474, 22);
            this.tb_rep.TabIndex = 4;
            // 
            // tb_addr2
            // 
            this.tb_addr2.Location = new System.Drawing.Point(272, 294);
            this.tb_addr2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_addr2.Name = "tb_addr2";
            this.tb_addr2.ReadOnly = true;
            this.tb_addr2.Size = new System.Drawing.Size(48, 22);
            this.tb_addr2.TabIndex = 2;
            this.tb_addr2.Text = "0x21";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Module 4050 à l\'adresse :";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(374, 291);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Counter";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // numAddr17
            // 
            this.numAddr17.Location = new System.Drawing.Point(206, 252);
            this.numAddr17.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAddr17.Name = "numAddr17";
            this.numAddr17.Size = new System.Drawing.Size(59, 22);
            this.numAddr17.TabIndex = 6;
            this.numAddr17.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numAddr17.ValueChanged += new System.EventHandler(this.numAddr17_ValueChanged);
            // 
            // numAddr50
            // 
            this.numAddr50.Location = new System.Drawing.Point(206, 294);
            this.numAddr50.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAddr50.Name = "numAddr50";
            this.numAddr50.Size = new System.Drawing.Size(59, 22);
            this.numAddr50.TabIndex = 6;
            this.numAddr50.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numAddr50.ValueChanged += new System.EventHandler(this.numAddr50_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trames répondues :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trame passées :";
            // 
            // vAdam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 336);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numAddr50);
            this.Controls.Add(this.numAddr17);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tb_rep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_addr2);
            this.Controls.Add(this.tb_addr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_log);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "vAdam";
            this.Text = "ADAM virtuel";
            this.Load += new System.EventHandler(this.vAdam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAddr17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAddr50)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.TextBox tb_rep;
        private System.Windows.Forms.TextBox tb_addr2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numAddr17;
        private System.Windows.Forms.NumericUpDown numAddr50;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;


    }
}

