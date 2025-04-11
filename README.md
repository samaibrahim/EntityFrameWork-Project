## 📘 Entity Framework + WinForms CRUD Application

### 👋 Overview  
This is a Windows Forms desktop application that uses **Entity Framework** to connect to a **SQL Server database**. The app allows users to perform basic **CRUD operations** (Create, Read, Update, Delete) through an intuitive graphical interface.

---

### 💡 Features

- ✅ **Entity Framework (Code First / Database First)** integration  
- ✅ **WinForms Menu UI** to select from multiple database tables  
- ✅ Insert new records  
- ✅ Update existing data  
- ✅ Delete unwanted rows  
- ✅ View all records in a `DataGridView`  
- ✅ ComboBoxes for foreign key selections (like Instructor or Course)

---

### 🛠️ Technologies Used

- C#  
- Windows Forms  
- Entity Framework  
- SQL Server  
- .NET Framework / .NET Core

---

### 📂 How It Works

1. The application starts with a **menu interface**.
2. The user selects a **table** (e.g., Students, Courses, Instructors).
3. Based on the selection, a form appears that allows:
   - Inserting new records
   - Updating selected entries
   - Deleting selected rows
   - Viewing data in a grid
4. All operations are done using **EF DbContext**.

---

### 🔧 Getting Started

1. Clone the repo  
   ```bash
   git clone https://github.com/samaibrahim/your-repo-name.git
   ```

2. Open the `.sln` file in **Visual Studio**.

3. Update the connection string in `App.config` (or `appsettings.json`) to match your SQL Server.

4. Run the project.

---

### ✨ Author

- 👩‍💻 **Sama Ibrahim**  
- 💼 ITI 9-Month Web Development Track  
- 📢 [LinkedIn](https://www.linkedin.com/in/sama-ibrahim-abdelhamid/) | [GitHub](https://github.com/samaibrahim)

