using FahrenheitAndCelsiusClient.FAndCServ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrenheitAndCelsiusClient
{
	public partial class Form1 : Form
	{
		private FahrenheitAndCelsiusSoapClient serviceClient;
		public Form1()
		{
			InitializeComponent();
			serviceClient = new FahrenheitAndCelsiusSoapClient();
		}

		private void btnCtoF_Click(object sender, EventArgs e)
		{
			try
			{
				double celsius = double.Parse(txtInpC.Text);
				double fahrenheit = serviceClient.CelsiusToFahrenheit(celsius);
				txtOutF.Text = $"{fahrenheit:F2}";
			}
			catch (FormatException)
			{
				MessageBox.Show("Vui lòng nhập một số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnFtoC_Click(object sender, EventArgs e)
		{
			try
			{
				double fahrenheit = double.Parse(txtInpF.Text);
				double celsius = serviceClient.FahrenheitToCelsius(fahrenheit);
				txtOutC.Text = $"{celsius:F2}";
			}
			catch (FormatException)
			{
				MessageBox.Show("Vui lòng nhập một số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
