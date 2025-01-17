# Bài 1
## Phía Server
### 1. Tạo project
- ![image](https://github.com/user-attachments/assets/11b73e8d-9943-4e6d-9632-fdb5ed6021f6)
### 2. Tạo file .asmx
- Chuột phải vào project -> Add -> New Item... -> Nhập asmx vào thành tìm kiếm -> Chọn Web Service (ASMX) -> Đặt tên cho file
  - ![Screenshot 2025-01-17 204958](https://github.com/user-attachments/assets/1489d4bd-d269-4f15-bfc8-90b6c1f44fc2)

- Code các chức năng chuyển từ độ C sang F và từ F sang C
  - ![Screenshot 2025-01-17 205032](https://github.com/user-attachments/assets/b180c6ea-b1a4-4636-85d1-b246841c80af)

### 3. Chạy thử nghiệm
- Giao diện sau khi chạy thành công:
  - ![Screenshot 2025-01-17 205523](https://github.com/user-attachments/assets/5523f5aa-c199-43c6-80ba-e9618dc7c772)

- Thử nghiệm chức năng chuyển độ C sang F:
  - ![Screenshot 2025-01-17 205609](https://github.com/user-attachments/assets/b7125f38-1ea2-447d-9a11-5934952f0bac)

- Nhấn invoke, kết quả trả về:
  - ![Screenshot 2025-01-17 205642](https://github.com/user-attachments/assets/ba3871dd-4346-4d58-b1fe-af12e30436d8)

### 4. Thành công

## Phía Client
### 1. Tạo project
- ![image](https://github.com/user-attachments/assets/93adaa2f-779e-4022-98fa-54374a5cbd09)

### 2. Kết nối với Server
- Chuột phải vào project -> Add -> Service References...
  - ![Screenshot 2025-01-17 205901](https://github.com/user-attachments/assets/a76e8653-a028-4f8f-94ea-c28df37f1691)

- Dán link localhost chạy ở phía server -> Nhấn Go, đổi tên file. Chú ý: ta phải chạy server trong suốt quá trình thực hiện phía người dùng:
  - ![Screenshot 2025-01-17 210013](https://github.com/user-attachments/assets/500a5713-33bc-42f4-a08d-d420d59cccd6)

### 3. Thiết kế giao diện
- ![Screenshot 2025-01-17 210235](https://github.com/user-attachments/assets/f7678015-3ffa-424f-8c51-0e2aebc9253d)

### 4. Xử lý sự kiện của các controller
- ![Screenshot 2025-01-17 210858](https://github.com/user-attachments/assets/0b565c11-69c6-486f-bd05-af4895484cca)

### 5. Chạy thử nghiệm
- ![Screenshot 2025-01-17 210814](https://github.com/user-attachments/assets/af66b7b4-697d-49e5-819b-5ca1360a4ca3)

### 6. Thành công

# Bài 2
## Chuẩn bị Database
### 1. Tải MariaDB: https://mariadb.org/
- ![Screenshot 2025-01-17 195857](https://github.com/user-attachments/assets/97a7c2be-e781-4098-a388-b6fc57815d2f)

### 2. Tải WorkBench giúp tạo connection: https://dev.mysql.com/downloads/workbench/
- ![Screenshot 2025-01-17 195959](https://github.com/user-attachments/assets/6003e71f-6205-4422-b4ee-372982d740dc)

### 3. Tạo một Connection trong WorkBench:
- ![Screenshot 2025-01-17 200156](https://github.com/user-attachments/assets/415503d3-529e-402d-99b9-64a61f6e7f39)

### 4. Chỉnh sửa một chút ở file world database thầy cung cấp
- Phần tạo bảng City
  - ![Screenshot 2025-01-17 200337](https://github.com/user-attachments/assets/5d9fdd59-7de5-49a7-8412-d1a7cbfee590)

- Phần tạo bảng CountryLanguage
  - ![Screenshot 2025-01-17 200400](https://github.com/user-attachments/assets/8dfb196c-fcd6-486e-a395-c23d6eed24b2)

- Tiến hành chạy các dòng lệnh để tạo bảng và insert dữ liệu vào

## Phía Server
### 1. Tạo project
- ![image](https://github.com/user-attachments/assets/b74bfd6d-8593-457a-b664-142d4594a303) 
### 2. Bước 2: Chuẩn bị cấu trúc file
Tạo Folder và File như sau:
- ![Screenshot 2025-01-17 192934](https://github.com/user-attachments/assets/b0e3c65a-a227-4e64-a628-76e0815738c1)


### 3. Bước 3: Tạo đối tượng City và Country
- Đối tượng City: Trong file City.cs
  - ![image](https://github.com/user-attachments/assets/b9226332-9d6d-4778-adea-0a8e943c53f3)

- Đối tượng Country: Trong file Country.cs
  - ![image](https://github.com/user-attachments/assets/0ca0e4b3-136b-4e70-a973-a2caefec4f05)


### 4. Bước 4: Kết nối với cơ sở dữ liệu World
- Trong file ConnectDB.cs
  - ![image](https://github.com/user-attachments/assets/07ab76cc-b314-4189-8ac1-4ab4ddfe938c)


### 5. Bước 5: Tạo các kho lưu trữ cho City và Country
- Trong file CityRepository.cs:
```CS
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
```

- Trong file CountryRepository,cs:
```cs
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
```

### 6. Bước 6: Tạo dịch vụ: tệp Dịch vụ web ASP.NET (SOAP)
- Trong file: WorldDBServ.asmx:
  - 
### 7. Bước 7: Tiến hành chạy thử nghiệm
- Chạy chương trình: Ta thu được giao diện web
  - ![Screenshot 2025-01-17 194643](https://github.com/user-attachments/assets/bd778a53-1c52-44f6-8b32-30856ae83ae6)

- Chạy thử chức năng: Get All Cities:
  - ![Screenshot 2025-01-17 194730](https://github.com/user-attachments/assets/228271fd-9ce3-40cc-8838-c857444cf567)

- Nhấn nút Invoke, ta thu được kết quả sau:
  - ![Screenshot 2025-01-17 194858](https://github.com/user-attachments/assets/c9c2c252-4afa-41a9-ab78-9c0ce24b2662)


### 8. Thành công

## Phía người dùng:
### 1. Tạo project
- ![image](https://github.com/user-attachments/assets/ad197368-90be-42d5-badb-9d6c65a9b19f)

  
### 2. Thực hiện kết nối với Server:
- Chuột phải vào project -> Add -> Service References...
  - ![Screenshot 2025-01-17 200808](https://github.com/user-attachments/assets/13879d91-7b73-4775-9854-3c94c39f675a)

- Dán link localhost chạy ở phía server -> Nhấn Go, đổi tên file. Chú ý: ta phải chạy server trong suốt quá trình thực hiện phía người dùng:
  - ![Screenshot 2025-01-17 200901](https://github.com/user-attachments/assets/8ff0ce38-fec4-4f2c-a2f6-298f7e30e385)

  - ![Screenshot 2025-01-17 201034](https://github.com/user-attachments/assets/1a4f0f28-1a1d-406e-8f0a-820717f227b8)


### 3. Thực hiện kiểm soát kích thước dữ liệu: Ta phải kiểm soát dữ liệu mà ứng dụng có thể gửi và nhận khi sử dụng một binding
- Trong file App.config, thêm phần tô đậm:
  - ![Screenshot 2025-01-17 202604](https://github.com/user-attachments/assets/8ed44627-0807-40eb-b7b0-f1371c97d679)


### 4. Tạo giao diện và đặt tên cho các controller
- ![Screenshot 2025-01-17 201316](https://github.com/user-attachments/assets/f4639d7d-771a-47d8-b38e-3bc55a487654)


### 5. Xử lý sự kiện cho các nút
```cs
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
```

### 6. Chạy thử nghiệm chức năng "Get All Cities"
- ![Screenshot 2025-01-17 202653](https://github.com/user-attachments/assets/16e032aa-bf7c-49cd-a501-00c82895f12f)

### 7. Thành công
