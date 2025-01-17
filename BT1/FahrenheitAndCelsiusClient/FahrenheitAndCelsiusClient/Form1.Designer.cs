namespace FahrenheitAndCelsiusClient
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtInpC = new System.Windows.Forms.TextBox();
			this.btnCtoF = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOutF = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtOutC = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtInpF = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnFtoC = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(94, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "C";
			// 
			// txtInpC
			// 
			this.txtInpC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInpC.Location = new System.Drawing.Point(135, 32);
			this.txtInpC.Name = "txtInpC";
			this.txtInpC.Size = new System.Drawing.Size(157, 38);
			this.txtInpC.TabIndex = 1;
			this.txtInpC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnCtoF
			// 
			this.btnCtoF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCtoF.Location = new System.Drawing.Point(169, 172);
			this.btnCtoF.Name = "btnCtoF";
			this.btnCtoF.Size = new System.Drawing.Size(170, 56);
			this.btnCtoF.TabIndex = 2;
			this.btnCtoF.Text = "C to F";
			this.btnCtoF.UseVisualStyleBackColor = true;
			this.btnCtoF.Click += new System.EventHandler(this.btnCtoF_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(360, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "to";
			// 
			// txtOutF
			// 
			this.txtOutF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOutF.Location = new System.Drawing.Point(521, 32);
			this.txtOutF.Name = "txtOutF";
			this.txtOutF.ReadOnly = true;
			this.txtOutF.Size = new System.Drawing.Size(157, 38);
			this.txtOutF.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(480, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "F";
			// 
			// txtOutC
			// 
			this.txtOutC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOutC.Location = new System.Drawing.Point(521, 91);
			this.txtOutC.Name = "txtOutC";
			this.txtOutC.ReadOnly = true;
			this.txtOutC.Size = new System.Drawing.Size(157, 38);
			this.txtOutC.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(480, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 32);
			this.label4.TabIndex = 9;
			this.label4.Text = "C";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(360, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 32);
			this.label5.TabIndex = 8;
			this.label5.Text = "to";
			// 
			// txtInpF
			// 
			this.txtInpF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInpF.Location = new System.Drawing.Point(135, 91);
			this.txtInpF.Name = "txtInpF";
			this.txtInpF.Size = new System.Drawing.Size(157, 38);
			this.txtInpF.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(94, 94);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 32);
			this.label6.TabIndex = 6;
			this.label6.Text = "F";
			// 
			// btnFtoC
			// 
			this.btnFtoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFtoC.Location = new System.Drawing.Point(415, 172);
			this.btnFtoC.Name = "btnFtoC";
			this.btnFtoC.Size = new System.Drawing.Size(170, 56);
			this.btnFtoC.TabIndex = 11;
			this.btnFtoC.Text = "F to C";
			this.btnFtoC.UseVisualStyleBackColor = true;
			this.btnFtoC.Click += new System.EventHandler(this.btnFtoC_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnFtoC);
			this.Controls.Add(this.txtOutC);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtInpF);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtOutF);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCtoF);
			this.Controls.Add(this.txtInpC);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtInpC;
		private System.Windows.Forms.Button btnCtoF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtOutF;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtOutC;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtInpF;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnFtoC;
	}
}

