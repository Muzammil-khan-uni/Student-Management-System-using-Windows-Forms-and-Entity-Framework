# Student Management System using Windows Forms and Entity Framework With SQL

LOAD:

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System-using-Windows-Forms-and-Entity-Framework/blob/main/Output%20SS/LOAD.png)

ADD:

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System-using-Windows-Forms-and-Entity-Framework/blob/main/Output%20SS/ADD.png)

UPDATE:

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System-using-Windows-Forms-and-Entity-Framework/blob/main/Output%20SS/UPDATE.png)

DELETE:

![image alt](https://github.com/Muzammil-khan-uni/Student-Management-System-using-Windows-Forms-and-Entity-Framework/blob/main/Output%20SS/DELETE.png)

This is a CRUD (Create, Read, Update, Delete) desktop application built using C# Windows Forms and Entity Framework to manage student records. The application connects to a database using Entity Framework and allows users to insert, update, delete, view, and clear student data.

Technologies Used:

Language: C# (.NET Framework)

GUI Framework: Windows Forms

ORM (Database Access): Entity Framework (Code First or Database First)

Database: SQL Server

IDE: Visual Studio

Features and Functionalities:

1. Load Data:

Fetches all student records from the database.

Displays data in a DataGridView for easy viewing.

Can be triggered at application startup and using the "Load" button.

2. Insert Student Record:

User inputs data in the following fields:

First Name

Last Name

Age

Student ID

On clicking "Insert", a new Student object is created and added to the database.

After insertion, the data grid is refreshed, and a confirmation message is shown.

3. Update Student Record:

Takes the input StudentID and updates the corresponding record with new FirstName, LastName, and Age.

Uses AddOrUpdate() method provided by Entity Framework to either add or update the student record based on primary key.

Refreshes the DataGridView after updating.

4. Delete Student Record:

Takes the input StudentID.

Searches for a student with the given ID.

If found, deletes the student from the database and shows a success message.

If not found, displays an error message.

5. Clear Form Inputs:

Clears all text fields (FirstName, LastName, Age, StudentID) using the "Clear" button.

Database Schema (Assumed based on Entity Framework):

Entity: Student

Properties:

StudentID (Primary Key, int)

FirstName (string)

LastName (string)

Age (int)

User Interface Description:

A DataGridView at the top to display the list of students.

Labels and text boxes below to input FirstName, LastName, Age, and StudentID.

Five buttons for actions:

Insert

Update

Delete

Clear

Load

Execution Flow:

On form load, all student records are fetched and displayed.

User performs actions via button clicks.

Each button event performs specific database operation using Entity Framework.

After each operation (except Clear), the DataGridView is refreshed to reflect the updated data.

Advantages of This Project:

Provides a hands-on example of using Entity Framework in Windows Forms.

Demonstrates real-world CRUD operations.

Teaches form design, data binding, and interaction between UI and database.

Easy to expand for more features like search, pagination, or validation.

