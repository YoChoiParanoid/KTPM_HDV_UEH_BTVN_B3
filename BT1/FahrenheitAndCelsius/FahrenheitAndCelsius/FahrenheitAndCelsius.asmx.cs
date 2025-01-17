using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace FahrenheitAndCelsius
{
	/// <summary>
	/// Summary description for FahrenheitAndCelsius
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class FahrenheitAndCelsius : System.Web.Services.WebService
	{
		// Chuyển từ độ Fahrenheit sang độ Celsius
		[WebMethod]
		public double FahrenheitToCelsius(double fahrenheit)
		{
			return (fahrenheit - 32) * 5 / 9;
		}

		// Chuyển từ độ Celsius sang độ Fahrenheit
		[WebMethod]
		public double CelsiusToFahrenheit(double celsius)
		{
			return (celsius * 9 / 5) + 32;
		}
	}
}
