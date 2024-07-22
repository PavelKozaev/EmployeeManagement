# EmployeeManagement

## ��������
EmployeeManagement - ��� ���������� ����������, ������� ��������� ��������� ������� �����������, ���������� � ������� JSON. ���������� ������������ �������� ����������, ����������, ��������� � �������� ������� �����������.

## �������������� �����������

- **���������� ����������**
- **���������� ������ ����������**
- **��������� ������ ���������� �� ID**
- **�������� ����������**
- **��������� ������ ���� �����������**

## �������������

���������� ����������
- dotnet EmployeeManagement.dll -add FirstName:John LastName:Doe Salary:100.50

���������� ������ ����������
- dotnet EmployeeManagement.dll -update Id:1 FirstName:Jane

��������� ������ ���������� �� ID
- dotnet EmployeeManagement.dll -get Id:1

�������� ����������
- dotnet EmployeeManagement.dll -delete Id:1

��������� ������ ���� �����������
- dotnet EmployeeManagement.dll -getall

## ��������� � ������

1. ����������� �����������:
git clone https://github.com/PavelKozaev/EmployeeManagement.git

2. ������� � ���������� �������:
cd EmployeeManagement

3. ������� ������ � Visual Studio:
������� ���� EmployeeManagement.sln

4. ��������� ��������� ��������� ������ ��� ������� � Visual Studio:

- **������� � Properties ������� EmployeeManagement**
- **�� ������� Debug � ���� Application arguments ������ ����������� ���������, ��������:**
-add FirstName:John LastName:Doe Salary:100.50

5. ������ ����������:
������ Start � Visual Studio ��� ��������� ����������� ���� �� ��������� ������.

## ������ ������ � ����������

```json
{
  "Id": 1,
  "FirstName": "John",
  "LastName": "Doe",
  "SalaryPerHour": 100.50
}