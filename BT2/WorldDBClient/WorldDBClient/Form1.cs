using System;
using System.Data;
using System.Windows.Forms;
using WorldDBClient.WorldServ;

namespace WorldDBClient
{
	public partial class Form1 : Form
	{
		private WorldDBServSoapClient serviceClient;

		public Form1()
		{
			InitializeComponent();
			serviceClient = new WorldDBServSoapClient();
		}

		private void btnGetAllCities_Click(object sender, EventArgs e)
		{
			try
			{
				var cities = serviceClient.getAllCities();

				if (cities != null && cities.Length > 0)
				{
					// Chuyển đổi City[] thành DataTable
					DataTable table = new DataTable();
					table.Columns.Add("ID", typeof(int));
					table.Columns.Add("Name", typeof(string));
					table.Columns.Add("CountryCode", typeof(string));
					table.Columns.Add("District", typeof(string));
					table.Columns.Add("Population", typeof(int));

					foreach (var city in cities)
					{
						table.Rows.Add(city.Id, city.Name, city.CountryCode, city.District, city.Population);
					}

					// Gán DataTable cho DataGridView
					dataGridViewResults.DataSource = table;
				}
				else
				{
					MessageBox.Show("No cities found for the specified country.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void btnGetCityByName_Click(object sender, EventArgs e)
		{
			try
			{
				string cityName = txtCityname.Text.Trim();
				if (string.IsNullOrEmpty(cityName))
				{
					MessageBox.Show("Please enter a city name.");
					return;
				}

				var city = serviceClient.GetCityByName(cityName);
				if (city != null)
				{
					DataTable table = new DataTable();
					table.Columns.Add("ID");
					table.Columns.Add("Name");
					table.Columns.Add("CountryCode");
					table.Columns.Add("District");
					table.Columns.Add("Population");

					table.Rows.Add(city.Id, city.Name, city.CountryCode, city.District, city.Population);
					dataGridViewResults.DataSource = table;
				}
				else
				{
					MessageBox.Show("City not found.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void btnGetCitiesByCountry_Click(object sender, EventArgs e)
		{
			try
			{
				string countryCode = txtCountryCode.Text.Trim();
				if (string.IsNullOrEmpty(countryCode))
				{
					MessageBox.Show("Please enter a country code.");
					return;
				}

				var cities = serviceClient.GetCitiesByCountry(countryCode);
				if (cities != null && cities.Length > 0)
				{
					DataTable table = new DataTable();
					table.Columns.Add("ID");
					table.Columns.Add("Name");
					table.Columns.Add("CountryCode");
					table.Columns.Add("District");
					table.Columns.Add("Population");

					foreach (var city in cities)
					{
						table.Rows.Add(city.Id, city.Name, city.CountryCode, city.District, city.Population);
					}

					dataGridViewResults.DataSource = table;
				}
				else
				{
					MessageBox.Show("No cities found for the specified country.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void btnGetCountryByCode_Click(object sender, EventArgs e)
		{
			try
			{
				string countryCode = txtCountryCode.Text.Trim();
				if (string.IsNullOrEmpty(countryCode))
				{
					MessageBox.Show("Please enter a country code.");
					return;
				}

				var country = serviceClient.GetCountryByCode(countryCode);
				if (country != null)
				{
					DataTable table = new DataTable();
					table.Columns.Add("Code");
					table.Columns.Add("Name");
					table.Columns.Add("Continent");
					table.Columns.Add("Region");
					table.Columns.Add("SurfaceArea");

					table.Rows.Add(country.Code, country.Name, country.Continent, country.Region, country.SurfaceArea);
					dataGridViewResults.DataSource = table;
				}
				else
				{
					MessageBox.Show("Country not found.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}

		private void btnGetCountryByPopulation_Click(object sender, EventArgs e)
		{
			try
			{
				if (!long.TryParse(txtPopulation.Text.Trim(), out long populationThreshold))
				{
					MessageBox.Show("Please enter a valid population value.");
					return;
				}

				var countries = serviceClient.GetCountriesByPopulation(populationThreshold);
				if (countries != null && countries.Length > 0)
				{
					DataTable table = new DataTable();
					table.Columns.Add("Code");
					table.Columns.Add("Name");
					table.Columns.Add("Continent");
					table.Columns.Add("Region");
					table.Columns.Add("SurfaceArea");

					foreach (var country in countries)
					{
						table.Rows.Add(country.Code, country.Name, country.Continent, country.Region, country.SurfaceArea);
					}

					dataGridViewResults.DataSource = table;
				}
				else
				{
					MessageBox.Show("No countries found with population greater than the specified threshold.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}
		}
	}
}
