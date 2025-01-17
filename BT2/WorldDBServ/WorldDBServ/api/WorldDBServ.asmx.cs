using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WorldDBServ.db;
using WorldDBServ.entities;

namespace WorldDBServ.api
{
	/// <summary>
	/// Summary description for WorldDBServ
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class WorldDBServ : System.Web.Services.WebService
	{

		[WebMethod]
		public List<City> getAllCities()
		{
			CityRepository countryRepository = new CityRepository();
			return countryRepository.getAllCities();
		}
		[WebMethod]
		public Country GetCountryByCode(string countryCode)
		{
			CountryRepository countryRepository = new CountryRepository();
			return countryRepository.GetCountryByCode(countryCode);
		}

		[WebMethod]
		public City GetCityByName(string cityName)
		{
			CityRepository cityRepository = new CityRepository();
			return cityRepository.GetCityByName(cityName);
		}

		[WebMethod]
		public List<City> GetCitiesByCountry(string countryCode)
		{
			CityRepository cityRepository = new CityRepository();
			return cityRepository.GetCitiesByCountry(countryCode);
		}

		[WebMethod]
		public List<Country> GetCountriesByPopulation(long populationThreshold)
		{
			CountryRepository countryRepository = new CountryRepository();
			return countryRepository.GetCountriesByPopulation(populationThreshold);
		}
	}
}
