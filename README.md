<div align="center">

# 🎓 University Management System

### A desktop academic administration system built with C# and Windows Forms, designed around secure, role based access for Students, Teachers, and Admins

<p>
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/.NET%20Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET Framework" />
  <img src="https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms" />
  <img src="https://img.shields.io/badge/SQL%20Server%20LocalDB-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" alt="SQL Server LocalDB" />
</p>

<p>
  <img src="https://img.shields.io/badge/license-MIT-blue?style=flat-square" alt="license" />
</p>

**[Overview](#-overview)** &nbsp;|&nbsp; **[Features](#-key-features)** &nbsp;|&nbsp; **[Tech Stack](#-tech-stack)** &nbsp;|&nbsp; **[Project Structure](#-project-structure)** &nbsp;|&nbsp; **[Application Preview](#-application-preview)**

</div>

---

## 📖 Overview

The **University Management System** is a desktop application built to streamline everyday academic administration for a university. It is structured around three distinct user roles, **Students, Teachers, and Admins**, each with its own dedicated set of screens and permissions, so every user only sees and controls what their role is meant to.

The system was built with **C# in Visual Studio using Windows Forms (.NET Framework)**, with **SQL Server** as the backing database, connected through **ADO.NET**. It covers the core academic workflow end to end: account registration and approval, secure login, course registration, faculty assigned results, and full administrative control over users and courses.

---

## ✨ Key Features

### 🎓 Student Portal
- View personal profile details and the registered course schedule
- Access academic results uploaded by teachers
- Register for available courses during the window enabled by the Admin
- Mandatory profile completion before accessing the rest of the system
- Secure password change

### 👨‍🏫 Teacher Portal
- View personal profile and assigned course schedules
- Upload and manage student results for assigned courses
- Mandatory profile completion before accessing the rest of the system
- Secure password change

### 🔧 Admin Panel
- Review and approve incoming Student/Teacher sign up requests
- View and update details of every registered Student and Teacher
- Add and remove Students, Teachers, and Admin accounts
- Add new courses, including schedule, credit, and semester details
- Enroll students into courses and toggle course registration availability
- Enroll teachers into the courses they will manage and grade

### 🔐 Access Control
- Separate, role specific login and dashboard flow for each user type
- Course registration is only open to students when the Admin explicitly enables it
- New Student and Teacher accounts require Admin approval before activation

---

## 🧰 Tech Stack

<table>
<tr>
<td valign="top" width="50%">

**Application**
- 🟣 C#
- 🪟 Windows Forms (.NET Framework)
- 🧩 Visual Studio

</td>
<td valign="top" width="50%">

**Data Layer**
- 🗄️ Microsoft SQL Server (LocalDB)
- 🔗 ADO.NET (`System.Data.SqlClient`)
- 📄 Structured schema across Student, Teacher, Admin, Courses, and Enrollment tables

</td>
</tr>
</table>

---

## 📂 Project Structure

```
University_Management_System/
├── University_Management_System.sln    # Visual Studio solution file
│
├── University_Management_System/       # Windows Forms application project
│   ├── Program.cs                      # Application entry point
│   ├── Login.cs                        # Authentication and role based routing
│   ├── Registration.cs                 # New Student/Teacher sign up
│   ├── DataAccess.cs                   # Shared SQL Server connection layer
│   │
│   ├── Admin.cs                        # Admin dashboard
│   ├── A_options.cs                    # Admin side menu / navigation
│   ├── MaintainUser.cs                 # Add/remove Students, Teachers, Admins
│   ├── AddCourse.cs                    # Course creation
│   ├── EnrollStudent.cs                # Student to course enrollment
│   ├── EnrollTeacher.cs                # Teacher to course assignment
│   │
│   ├── Student.cs                      # Student dashboard
│   ├── S_options.cs                    # Student side menu / navigation
│   ├── StudentData.cs                  # Student profile / information view
│   ├── RegisterCourse.cs               # Student course registration
│   ├── SeeResults.cs                   # Student results view
│   ├── PasswordStudent.cs              # Student password change
│   │
│   ├── Teacher.cs                      # Teacher dashboard
│   ├── T_options.cs                    # Teacher side menu / navigation
│   ├── TeacherData.cs                  # Teacher profile / information view
│   ├── UploadResult.cs                 # Teacher result upload
│   ├── PasswordTeacher.cs              # Teacher password change
│   │
│   ├── AboutMe.cs                      # About / project info screen
│   ├── Properties/                     # Assembly info, resources, settings
│   ├── ICONS/                          # UI icons used across the forms
│   └── DATABASE/                       # Local SQL Server database files (.mdf/.ldf)
│
├── Student_Table.sql                   # Student schema
├── Teacher_Table.sql                   # Teacher schema
├── Admin_Table.sql                     # Admin schema
├── Courses_Table.sql                   # Courses schema
├── Enrollment_Table.sql                # Enrollment schema
└── LICENSE                             # MIT license
```

---

## 🚀 Getting Started

### Prerequisites
- Visual Studio (with .NET Framework and Windows Forms workload)
- SQL Server or SQL Server LocalDB

### Setup

1. Clone the repository
   ```bash
   git clone https://github.com/nasir-sarkar/University_Management_System.git
   ```
2. Open `University_Management_System.sln` in Visual Studio
3. Attach the included database (`University_Management_System/DATABASE/University.mdf`) in SQL Server, or recreate the schema using the provided `.sql` files (`Student_Table.sql`, `Teacher_Table.sql`, `Admin_Table.sql`, `Courses_Table.sql`, `Enrollment_Table.sql`)
4. Update the connection string in `DataAccess.cs` to point to your local SQL Server / LocalDB instance
5. Build and run the solution from Visual Studio

---

## 📸 Application Preview

### 1. Login
![login](https://github.com/user-attachments/assets/12d071bf-f154-458e-a3b4-99b2f3dce8a4)

### 2. Signup
![Signup](https://github.com/user-attachments/assets/be4bbaa2-ba43-4c58-9722-9cbfa2b99866)

### 3.1 Student's Profile
![Student](https://github.com/user-attachments/assets/2aeed83d-1154-44a5-86a1-0e1af9f874f2)

### 3.2 See Results
![SeeResult](https://github.com/user-attachments/assets/55eb759c-34ad-4f66-9aef-dbee3d053b12)

### 3.3 Course Registration
![DoRegistration](https://github.com/user-attachments/assets/f55f1cb0-0b03-4f52-98d9-56832698ea6f)

### 3.4 Student's Information
![StudentInfo](https://github.com/user-attachments/assets/1ba6fca4-4722-42a9-a2e5-c8d5763b266c)

### 3.5 Change Password
![StudentPassword](https://github.com/user-attachments/assets/4df8aa5f-07e8-4310-a53d-9df8cafb116b)

### 4.1 Teacher's Profile
![Teacher](https://github.com/user-attachments/assets/2617cc9e-2ede-4fdd-ac1a-ff47eb229e34)

### 4.2 Upload Results
![UploadResult](https://github.com/user-attachments/assets/ce3682e1-6392-43df-87fb-296d5da1ee58)

### 4.3 Teacher's Information
![TeacherInfo](https://github.com/user-attachments/assets/4ccbb683-e1c3-4ce3-9fc6-ed8339f8991a)

### 4.4 Change Password
![TeacherPassword](https://github.com/user-attachments/assets/9d17d91c-bb97-410b-bc88-b717351ab845)

### 5.1 Admin Panel
![Admin](https://github.com/user-attachments/assets/1c92322b-1d2a-454f-9945-1d71ebfd7511)

### 5.2 Maintain Users (Add/Delete)
![MaintainUser](https://github.com/user-attachments/assets/1e89f00e-5d4e-4b32-92f5-a22688b499ee)

### 5.3 Add Courses
![AddCourse](https://github.com/user-attachments/assets/4deaf373-18a4-4edf-926f-3ceb8811c492)

### 5.4 Enroll Students
![EnrollStudent](https://github.com/user-attachments/assets/7c6d9eb2-650b-4bfe-a31b-71c5a868679f)

### 5.5 Enroll Teachers
![EnrollTeacher](https://github.com/user-attachments/assets/b207b2a6-3804-406f-91ad-b8fecb049bb1)

---

## 👨‍💻 Author

**[Nasir Sarkar](https://nasir-sarkar.vercel.app/)**

---

<div align="center">

If you found this project interesting, consider giving it a ⭐!

</div>
