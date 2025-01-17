using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WorldDBServ.entities;

namespace WorldDBServ.db
{
	public class CityRepository
	{
		private MySqlConnection connection;
		public CityRepository()
		{
			connection = ConnectDB.getInstance();
		}

		public List<City> getAllCities()
		{
			connection.Open();
			string sql = "select * from city";
			MySqlCommand cmd = new MySqlCommand(sql, connection);
			MySqlDataReader rdr = cmd.ExecuteReader();
			List<City> cities = new List<City>();
			while (rdr.Read())
			{
				City city = new City(
					int.Parse(rdr[0].ToString()),
						rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(),
						int.Parse(rdr[4].ToString())
					);
				cities.Add(city);
			}
			connection.Close();
			return cities;
		}
		

		// Get city by name
		public City GetCityByName(string cityName)
		{
			connection.Open();
			string sql = "SELECT * FROM city WHERE Name = @Name";
			MySqlCommand cmd = new MySqlCommand(sql, connection);
			cmd.Parameters.AddWithValue("@Name", cityName);
			MySqlDataReader rdr = cmd.ExecuteReader();

			City city = null;
			if (rdr.Read())
			{
				city = new City(
					int.Parse(rdr["ID"].ToString()),
					rdr["Name"].ToString(),
					rdr["CountryCode"].ToString(),
					rdr["District"].ToString(),
					int.Parse(rdr["Population"].ToString())
				);
			}
			connection.Close();
			return city;
		}

		// Get all cities of a specific country
		public List<City> GetCitiesByCountry(string countryCode)
		{
			connection.Open();
			string sql = "SELECT * FROM city WHERE CountryCode = @CountryCode";
			MySqlCommand cmd = new MySqlCommand(sql, connection);
			cmd.Parameters.AddWithValue("@CountryCode", countryCode);
			MySqlDataReader rdr = cmd.ExecuteReader();

			List<City> cities = new List<City>();
			while (rdr.Read())
			{
				City city = new City(
					int.Parse(rdr["ID"].ToString()),
					rdr["Name"].ToString(),
					rdr["CountryCode"].ToString(),
					rdr["District"].ToString(),
					int.Parse(rdr["Population"].ToString())
				);
				cities.Add(city);
			}
			connection.Close();
			return cities;
		}
	}
}