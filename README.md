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
- 
### 2. Tải WorkBench giúp tạo connection: https://dev.mysql.com/downloads/workbench/
- 
### 3. Tạo một Connection trong WorkBench:
- 
### 4. Chỉnh sửa một chút ở file world database thầy cung cấp
- Phần tạo bảng City
  - 
- Phần tạo bảng CountryLanguage
  - 
- Tiến hành chạy các dòng lệnh để tạo bảng và insert dữ liệu vào

## Phía Server
### 1. Tạo project
- ![image](https://github.com/user-attachments/assets/b74bfd6d-8593-457a-b664-142d4594a303) 
### 2. Bước 2: Chuẩn bị cấu trúc file
Tạo Folder và File như sau:
- 

### 3. Bước 3: Tạo đối tượng City và Country
- Đối tượng City: Trong file City.cs
  - 
- Đối tượng Country: Trong file Country.cs
  - 

### 4. Bước 4: Kết nối với cơ sở dữ liệu World
- Trong file ConnectDB.cs
  - 

### 5. Bước 5: Tạo các kho lưu trữ cho City và Country
- Trong file CityRepository.cs:
  - 
  - 
  - 

- Trong file CountryRepository,cs:
  - 
  - 

### 6. Bước 6: Tạo dịch vụ: tệp Dịch vụ web ASP.NET (SOAP)
- Trong file: WorldDBServ.asmx:
  - 
### 7. Bước 7: Tiến hành chạy thử nghiệm
- Chạy chương trình: Ta thu được giao diện web
  - 
- Chạy thử chức năng: Get All Cities:
  - 
- Nhấn nút Invoke, ta thu được kết quả sau:
  - 

### 8. Thành công

## Phía người dùng:
### 1. Tạo project
- ![image](https://github.com/user-attachments/assets/ad197368-90be-42d5-badb-9d6c65a9b19f)

  
### 2. Thực hiện kết nối với Server:
- Chuột phải vào project -> Add -> Service References...
  - 
- Dán link localhost chạy ở phía server -> Nhấn Go, đổi tên file. Chú ý: ta phải chạy server trong suốt quá trình thực hiện phía người dùng:
  - 
  - 

### 3. Thực hiện kiểm soát kích thước dữ liệu: Ta phải kiểm soát dữ liệu mà ứng dụng có thể gửi và nhận khi sử dụng một binding
- Trong file App.config, thêm phần tô đậm:
  - 

### 4. Tạo giao diện và đặt tên cho các controller
- 

### 5. Xử lý sự kiện cho các nút
- 
- 
- 
- 
- 
- 

### 6. Chạy thử nghiệm chức năng "Get All Cities"

### 7. Thành công
