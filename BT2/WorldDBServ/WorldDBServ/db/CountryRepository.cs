using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldDBServ.entities;

namespace WorldDBServ.db
{
	public class CountryRepository
	{
		private MySqlConnection connection;
		public CountryRepository()
		{
			connection = ConnectDB.getInstance();
		}

		public Country GetCountryByCode(string countryCode)
		{
			connection.Open();
			string sql = "SELECT * FROM country WHERE Code = @Code";
			MySqlCommand cmd = new MySqlCommand(sql, connection);
			cmd.Parameters.AddWithValue("@Code", countryCode);
			MySqlDataReader rdr = cmd.ExecuteReader();

			Country country = null;
			if (rdr.Read())
			{
				country = new Country(
					rdr["Code"].ToString(),
					rdr["Name"].ToString(),
					rdr["Continent"].ToString(),
					rdr["Region"].ToString(),
					float.Parse(rdr["SurfaceArea"].ToString())
				);
			}
			connection.Close();
			return country;
		}

		// Other service: Get countries with population above a threshold
		public List<Country> GetCountriesByPopulation(long populationThreshold)
		{
			connection.Open();
			string sql = "SELECT * FROM country WHERE Population > @Population";
			MySqlCommand cmd = new MySqlCommand(sql, connection);
			cmd.Parameters.AddWithValue("@Population", populationThreshold);
			MySqlDataReader rdr = cmd.ExecuteReader();

			List<Country> countries = new List<Country>();
			while (rdr.Read())
			{
				Country country = new Country(
					rdr["Code"].ToString(),
					rdr["Name"].ToString(),
					rdr["Continent"].ToString(),
					rdr["Region"].ToString(),
					float.Parse(rdr["SurfaceArea"].ToString())
				);
				countries.Add(country);
			}
			connection.Close();
			return countries;
		}
	}
}