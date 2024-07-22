# EmployeeManagement

## ��������
EmployeeManagement - ��� ���������� ����������, ������� ��������� ��������� ������� �����������, ���������� � ������� JSON. ���������� ������������ �������� ����������, ����������, ��������� � �������� ������� �����������.

## �������������� �����������

- **���������� ����������**
- **���������� ������ ����������**
- **��������� ������ ���������� �� ID**
- **�������� ����������**
- **��������� ������ ���� �����������**

## ������ ������ � ����������

```json
{
  "Id": 1,
  "FirstName": "John",
  "LastName": "Doe",
  "SalaryPerHour": 100.50
}

## �������������

���������� ����������
- EmployeeManagement.exe -add FirstName:John LastName:Doe Salary:100.50

���������� ������ ����������
- EmployeeManagement.exe -update Id:1 FirstName:Jane

��������� ������ ���������� �� ID
- EmployeeManagement.exe -get Id:1

�������� ����������
- EmployeeManagement.exe -delete Id:1

��������� ������ ���� �����������
- EmployeeManagement.exe -getall

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
