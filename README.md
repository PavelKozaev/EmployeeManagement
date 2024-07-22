# EmployeeManagement

## Описание
EmployeeManagement - это консольное приложение, которое позволяет управлять списком сотрудников, хранящихся в формате JSON. Приложение поддерживает операции добавления, обновления, получения и удаления записей сотрудников.

## Функциональные возможности

- **Добавление сотрудника**
- **Обновление данных сотрудника**
- **Получение данных сотрудника по ID**
- **Удаление сотрудника**
- **Получение списка всех сотрудников**

## Формат записи о сотруднике

```json
{
  "Id": 1,
  "FirstName": "John",
  "LastName": "Doe",
  "SalaryPerHour": 100.50
}

## Использование

Добавление сотрудника
- EmployeeManagement.exe -add FirstName:John LastName:Doe Salary:100.50

Обновление данных сотрудника
- EmployeeManagement.exe -update Id:1 FirstName:Jane

Получение данных сотрудника по ID
- EmployeeManagement.exe -get Id:1

Удаление сотрудника
- EmployeeManagement.exe -delete Id:1

Получение списка всех сотрудников
- EmployeeManagement.exe -getall

## Установка и запуск

1. Клонировать репозиторий:
git clone https://github.com/PavelKozaev/EmployeeManagement.git

2. Перейти в директорию проекта:
cd EmployeeManagement

3. Открыть проект в Visual Studio:
Открыть файл EmployeeManagement.sln

4. Настроить аргументы командной строки для отладки в Visual Studio:

- **Перейти в Properties проекта EmployeeManagement**
- **На вкладке Debug в поле Application arguments ввести необходимые аргументы, например:**
-add FirstName:John LastName:Doe Salary:100.50

5. Запуск приложения:
Нажать Start в Visual Studio или запустить исполняемый файл из командной строки.
