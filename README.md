# Bài 1
## Phía Server
### 1. Tạo project
- ![image](https://github.com/user-attachments/assets/606be0f9-8374-4337-85ec-bcc1dc5c886d)
### 2. Tạo file .asmx
- Chuột phải vào project -> Add -> New Item... -> Nhập asmx vào thành tìm kiếm -> Chọn Web Service (ASMX) -> Đặt tên cho file
  - ![image](https://github.com/user-attachments/assets/22c33b0b-43e2-4122-8e25-e30ac0af4b26)
- Code các chức năng chuyển từ độ C sang F và từ F sang C
  - ![image](https://github.com/user-attachments/assets/e6e5b758-af00-4aa9-a1d0-78f13df7ea9d)
### 3. Chạy thử nghiệm
- Giao diện sau khi chạy thành công:
  - ![image](https://github.com/user-attachments/assets/09206408-5594-4262-9333-e798552a41af)
- Thử nghiệm chức năng chuyển độ C sang F:
  - ![image](https://github.com/user-attachments/assets/286d8576-d3b2-4e5a-bba7-2a7aa95ca0aa)
- Nhấn invoke, kết quả trả về:
  - ![image](https://github.com/user-attachments/assets/5e32f164-8dd5-44e7-813b-c968453661fa)
### 4. Thành công

## Phía Client
### 1. Tạo project
- ![image](https://github.com/user-attachments/assets/bf4cc3fd-b39e-4b29-b306-0d3ebf1f88ff)
### 2. Kết nối với Server
- Chuột phải vào project -> Add -> Service References...
  - ![image](https://github.com/user-attachments/assets/fdd42c12-cadf-4bc1-b120-5620f30d9007)
- Dán link localhost chạy ở phía server -> Nhấn Go, đổi tên file. Chú ý: ta phải chạy server trong suốt quá trình thực hiện phía người dùng:
  - ![image](https://github.com/user-attachments/assets/5500de01-c7d4-4ba2-a4fa-f8eef52fed24)
### 3. Thiết kế giao diện
- ![image](https://github.com/user-attachments/assets/baceb306-15a6-4eff-9118-294cf37d9a32)
### 4. Xử lý sự kiện của các controller
- ![image](https://github.com/user-attachments/assets/5f857075-692f-4f12-a709-fe1a9fd041d4)

### 5. Chạy thử nghiệm
- ![image](https://github.com/user-attachments/assets/42f4fc2c-85ef-4195-bf50-5dad2451aa2b)

### 6. Thành công

# Bài 2
## Chuẩn bị Database
### 1. Tải MariaDB: https://mariadb.org/
- ![image](https://github.com/user-attachments/assets/f3ffebb8-26de-4b8b-bf79-857e4350195b)
### 2. Tải WorkBench giúp tạo connection: https://dev.mysql.com/downloads/workbench/
- ![image](https://github.com/user-attachments/assets/cd70ba34-df01-4bc7-9566-5e8bac851cf9)
### 3. Tạo một Connection trong WorkBench:
- ![image](https://github.com/user-attachments/assets/5b335e1b-8701-4aab-a539-78c7b9fa42a4)
### 4. Chỉnh sửa một chút ở file world database thầy cung cấp
- Phần tạo bảng City
  - ![image](https://github.com/user-attachments/assets/f8728cf9-2911-430c-a8b7-45a9614caa7c)
- Phần tạo bảng CountryLanguage
  - ![image](https://github.com/user-attachments/assets/ee12a206-390c-43ee-912f-040ff0770ac6)
- Tiến hành chạy các dòng lệnh để tạo bảng và insert dữ liệu vào

## Phía Server
### 1. Tạo project
- ![image](https://github.com/user-attachments/assets/606be0f9-8374-4337-85ec-bcc1dc5c886d)
- 
### 2. Bước 2: Chuẩn bị cấu trúc file
Tạo Folder và File như sau:
- ![image](https://github.com/user-attachments/assets/c82eed93-540d-493e-8ff9-d07583e29a36)

### 3. Bước 3: Tạo đối tượng City và Country
- Đối tượng City: Trong file City.cs
  - ![image](https://github.com/user-attachments/assets/919de2a1-fcd7-488b-86c5-528dcc01b417)
- Đối tượng Country: Trong file Country.cs
  - ![image](https://github.com/user-attachments/assets/a75766ac-e370-4db6-a69b-c1b66d5a03af)

### 4. Bước 4: Kết nối với cơ sở dữ liệu World
- Trong file ConnectDB.cs
  - ![image](https://github.com/user-attachments/assets/cd619cc4-cdea-4212-ad38-21d8a319c368)

### 5. Bước 5: Tạo các kho lưu trữ cho City và Country
- Trong file CityRepository.cs:
  - ![image](https://github.com/user-attachments/assets/49f200e1-04d9-40bc-9c72-a0b4198fb613)
  - ![image](https://github.com/user-attachments/assets/8c638501-edc1-41a2-9572-cbf56dc5ce3b)
  - ![image](https://github.com/user-attachments/assets/c4167742-796f-40ea-b068-1ab57a9f390a)

- Trong file CountryRepository,cs:
  - ![image](https://github.com/user-attachments/assets/d521a299-dc48-4699-856f-9030ea36ce22)
  - ![image](https://github.com/user-attachments/assets/82b07120-6e05-4224-b686-b98a25904c57)

### 6. Bước 6: Tạo dịch vụ: tệp Dịch vụ web ASP.NET (SOAP)
- Trong file: WorldDBServ.asmx:
  - ![image](https://github.com/user-attachments/assets/8a7f0d53-d27a-44da-923d-4c16d5c87883)
### 7. Bước 7: Tiến hành chạy thử nghiệm
- Chạy chương trình: Ta thu được giao diện web
  - ![image](https://github.com/user-attachments/assets/61d809db-ce7a-45c6-a711-0e1e35d41495)
- Chạy thử chức năng: Get All Cities:
  - ![image](https://github.com/user-attachments/assets/f24c7d4b-0b57-4c6c-8ff5-9298f27a6d0b)
- Nhấn nút Invoke, ta thu được kết quả sau:
  - ![image](https://github.com/user-attachments/assets/192e85e6-2899-41d1-8bbc-d37eb7c74242)

### 8. Thành công

## Phía người dùng:
### 1. Tạo project
- ![image](https://github.com/user-attachments/assets/bf4cc3fd-b39e-4b29-b306-0d3ebf1f88ff)
  
### 2. Thực hiện kết nối với Server:
- Chuột phải vào project -> Add -> Service References...
  - ![image](https://github.com/user-attachments/assets/b0d67329-1b32-469d-8791-946efcb7adef)
- Dán link localhost chạy ở phía server -> Nhấn Go, đổi tên file. Chú ý: ta phải chạy server trong suốt quá trình thực hiện phía người dùng:
  - ![image](https://github.com/user-attachments/assets/7d8495ba-1d71-400f-84c9-2a91a16f6765)
  - ![image](https://github.com/user-attachments/assets/798b2ffe-3d64-4c2d-9a15-4a8706d8ea1d)

### 3. Thực hiện kiểm soát kích thước dữ liệu: Ta phải kiểm soát dữ liệu mà ứng dụng có thể gửi và nhận khi sử dụng một binding
- Trong file App.config, thêm phần tô đậm:
  - ![image](https://github.com/user-attachments/assets/0e2c7e6a-f214-4f28-9a8b-a3fc4f1ef9db)

### 4. Tạo giao diện và đặt tên cho các controller
- ![image](https://github.com/user-attachments/assets/de0b4370-89b7-4a5a-8f5d-56fe642c7300)

### 5. Xử lý sự kiện cho các nút
- ![image](https://github.com/user-attachments/assets/ed05805b-5f2e-49ef-8633-8c5a5c9f1ced)
- ![image](https://github.com/user-attachments/assets/14f534ec-0578-439c-b081-b153d0ff719e)
- ![image](https://github.com/user-attachments/assets/2ebcede8-9bdf-4553-9cf6-f169d432f501)
- ![image](https://github.com/user-attachments/assets/aab4d045-1602-4028-ade7-2f2ed84281bb)
- ![image](https://github.com/user-attachments/assets/ddf97521-64bc-4f5e-b7bb-500cd44a49c0)
- ![image](https://github.com/user-attachments/assets/dabd5e14-d3e0-42fb-ae05-b323d18230f4)

### 6. Chạy thử nghiệm chức năng "Get All Cities"
![image](https://github.com/user-attachments/assets/e4370dae-561e-4fd7-b378-4c50b49dbb84)

### 7. Thành công
