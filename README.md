# 🚗 DVLD - Driving License Management

## 📌 Overview
DVLD (Driving License Management) is a comprehensive system built using **C# (.NET Framework) and SQL Server** to manage driving licenses efficiently. It streamlines the application, issuance, renewal, and tracking of both national and international driving licenses.

## 🏗️ Tech Stack
- **Frontend:** WinForms (C#)
- **Backend:** .NET Framework
- **Database:** SQL Server
- **Architecture:** Three-layer architecture (UI, Business Layer, Data Access Layer)

## ✨ Features
- 📜 **User & Driver Management** 
- 📝 **License Application & Processing**  
- 📄 **International & National License Management**  
- 🔍 **User Authentication & Role Management**  
- 📂 **Document Upload & Verification**  
- 🔄 **License Renewal & Expiry Tracking**
- 🔄 **License Lost & Damaged Tracking**  
- 📜 **Automated Email Notifications**  

## ⚙️ Installation & Setup
### **Prerequisites**
- Visual Studio with .NET Framework
- SQL Server (LocalDB or AWS RDS)

### **Steps**
1. **Clone the repository:**
   ```sh
   git clone https://github.com/marouan-boumchahate/DVLD-Management-System.git
   ```

2. **Install the database backup file to SQL Server**  
   - Restore the backup file and name the database **`DVLD`** using the following SQL command:
   ```sql
   RESTORE DATABASE DVLD  
   FROM DISK = 'backupDirectory\DVLD.bak'  
   WITH MOVE 'YourDatabaseName' TO 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DVLD.mdf',  
   MOVE 'YourDatabaseName_log' TO 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\DVLD.ldf',  
   REPLACE, RECOVERY;
   ```
   - To find the correct logical names inside the backup file, run:
   ```sql
   RESTORE FILELISTONLY FROM DISK = 'backupDirectoryr\DVLD.bak';
   ```

3. **Move the required folders**  
   - Copy and replace the two folders `DVLD - login` & `DVLD - profiles` into your `C:\` directory.

4. **Run the application**  
   - Open the project in **Visual Studio**.
   - Start the application.
   - login information (you must complete the steps number 2 and 3 first):
       + username: marouan_08
       + password: #abc%ABC%2003#

## 🛠️ Contributing
We welcome contributions! To contribute:

1. **Fork** the repository.
2. **Create a new branch** (`feature-branch`).
3. **Commit** your changes.
4. **Push** to your fork and submit a **Pull Request (PR)**.

## 📄 License
This project is licensed under the **Programming Advices License**.

## 👤 Author
**Marouan Boumchahate** | [GitHub](https://github.com/marouan-boumchahate) | [LinkedIn](https://www.linkedin.com/in/marouan-boumchahate-843543249/)

## 📞 Contact
For any inquiries, feel free to reach out:
📧 **marouanboumchahate@gmail.com**
