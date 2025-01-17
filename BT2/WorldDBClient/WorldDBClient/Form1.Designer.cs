namespace WorldDBClient
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
			this.btnGetCountryByPopulation = new System.Windows.Forms.Button();
			this.btnGetCountryByCode = new System.Windows.Forms.Button();
			this.txtCityname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnGetCityByName = new System.Windows.Forms.Button();
			this.txtCountryCode = new System.Windows.Forms.TextBox();
			this.btnGetAllCities = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewResults = new System.Windows.Forms.DataGridView();
			this.btnGetCitiesByCountry = new System.Windows.Forms.Button();
			this.txtPopulation = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetCountryByPopulation
			// 
			this.btnGetCountryByPopulation.Location = new System.Drawing.Point(553, 46);
			this.btnGetCountryByPopulation.Name = "btnGetCountryByPopulation";
			this.btnGetCountryByPopulation.Size = new System.Drawing.Size(126, 45);
			this.btnGetCountryByPopulation.TabIndex = 22;
			this.btnGetCountryByPopulation.Text = "Get country by Population";
			this.btnGetCountryByPopulation.UseVisualStyleBackColor = true;
			this.btnGetCountryByPopulation.Click += new System.EventHandler(this.btnGetCountryByPopulation_Click);
			// 
			// btnGetCountryByCode
			// 
			this.btnGetCountryByCode.Location = new System.Drawing.Point(421, 46);
			this.btnGetCountryByCode.Name = "btnGetCountryByCode";
			this.btnGetCountryByCode.Size = new System.Drawing.Size(126, 45);
			this.btnGetCountryByCode.TabIndex = 21;
			this.btnGetCountryByCode.Text = "Get country by code";
			this.btnGetCountryByCode.UseVisualStyleBackColor = true;
			this.btnGetCountryByCode.Click += new System.EventHandler(this.btnGetCountryByCode_Click);
			// 
			// txtCityname
			// 
			this.txtCityname.Location = new System.Drawing.Point(337, 5);
			this.txtCityname.Name = "txtCityname";
			this.txtCityname.Size = new System.Drawing.Size(126, 22);
			this.txtCityname.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(262, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "City Name";
			// 
			// btnGetCityByName
			// 
			this.btnGetCityByName.Location = new System.Drawing.Point(153, 46);
			this.btnGetCityByName.Name = "btnGetCityByName";
			this.btnGetCityByName.Size = new System.Drawing.Size(130, 45);
			this.btnGetCityByName.TabIndex = 18;
			this.btnGetCityByName.Text = "Get city by name";
			this.btnGetCityByName.UseVisualStyleBackColor = true;
			this.btnGetCityByName.Click += new System.EventHandler(this.btnGetCityByName_Click);
			// 
			// txtCountryCode
			// 
			this.txtCountryCode.Location = new System.Drawing.Point(109, 5);
			this.txtCountryCode.Name = "txtCountryCode";
			this.txtCountryCode.Size = new System.Drawing.Size(126, 22);
			this.txtCountryCode.TabIndex = 17;
			// 
			// btnGetAllCities
			// 
			this.btnGetAllCities.Location = new System.Drawing.Point(17, 46);
			this.btnGetAllCities.Name = "btnGetAllCities";
			this.btnGetAllCities.Size = new System.Drawing.Size(130, 45);
			this.btnGetAllCities.TabIndex = 16;
			this.btnGetAllCities.Text = "Get all cities";
			this.btnGetAllCities.UseVisualStyleBackColor = true;
			this.btnGetAllCities.Click += new System.EventHandler(this.btnGetAllCities_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 15;
			this.label1.Text = "Country Code";
			// 
			// dataGridViewResults
			// 
			this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewResults.Location = new System.Drawing.Point(2, 108);
			this.dataGridViewResults.Name = "dataGridViewResults";
			this.dataGridViewResults.RowHeadersWidth = 51;
			this.dataGridViewResults.RowTemplate.Height = 24;
			this.dataGridViewResults.Size = new System.Drawing.Size(795, 331);
			this.dataGridViewResults.TabIndex = 14;
			// 
			// btnGetCitiesByCountry
			// 
			this.btnGetCitiesByCountry.Location = new System.Drawing.Point(289, 46);
			this.btnGetCitiesByCountry.Name = "btnGetCitiesByCountry";
			this.btnGetCitiesByCountry.Size = new System.Drawing.Size(126, 45);
			this.btnGetCitiesByCountry.TabIndex = 13;
			this.btnGetCitiesByCountry.Text = "Get cities by country";
			this.btnGetCitiesByCountry.UseVisualStyleBackColor = true;
			this.btnGetCitiesByCountry.Click += new System.EventHandler(this.btnGetCitiesByCountry_Click);
			// 
			// txtPopulation
			// 
			this.txtPopulation.Location = new System.Drawing.Point(565, 5);
			this.txtPopulation.Name = "txtPopulation";
			this.txtPopulation.Size = new System.Drawing.Size(126, 22);
			this.txtPopulation.TabIndex = 25;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(490, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 16);
			this.label3.TabIndex = 24;
			this.label3.Text = "Population";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 451);
			this.Controls.Add(this.txtPopulation);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnGetCountryByPopulation);
			this.Controls.Add(this.btnGetCountryByCode);
			this.Controls.Add(this.txtCityname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnGetCityByName);
			this.Controls.Add(this.txtCountryCode);
			this.Controls.Add(this.btnGetAllCities);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewResults);
			this.Controls.Add(this.btnGetCitiesByCountry);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnGetCountryByPopulation;
		private System.Windows.Forms.Button btnGetCountryByCode;
		private System.Windows.Forms.TextBox txtCityname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnGetCityByName;
		private System.Windows.Forms.TextBox txtCountryCode;
		private System.Windows.Forms.Button btnGetAllCities;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewResults;
		private System.Windows.Forms.Button btnGetCitiesByCountry;
		private System.Windows.Forms.TextBox txtPopulation;
		private System.Windows.Forms.Label label3;
	}
}

