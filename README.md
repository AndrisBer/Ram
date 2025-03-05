# RAM Information Tool

## 📌 Overview
This is a **Windows Forms Application (C#)** that retrieves and displays RAM information using **WMI (Windows Management Instrumentation)**. The program gathers details such as:
- **Total RAM capacity**
- **RAM Manufacturer**
- **Part Number**
- **Product Version**
- **Product Name**
- **RAM Frequency**

## 🛠 Technologies Used
- **C# (.NET Framework)**
- **Windows Forms (WinForms)**
- **WMI (Windows Management Instrumentation)**

## 🚀 Features
✅ Retrieves real-time RAM specifications
✅ Displays RAM manufacturer, part number, and speed
✅ Simple and user-friendly Windows Forms UI
✅ Uses WMI queries for accurate hardware information

## 📥 Installation & Usage
### **1️⃣ Clone the Repository**
```bash
git clone https://github.com/yourusername/RAM-Info-Tool.git
cd RAM-Info-Tool
```

### **2️⃣ Open in Visual Studio**
- Open `RAM-Info-Tool.sln` in **Visual Studio**
- Ensure you have **.NET Framework** installed

### **3️⃣ Run the Application**
- Click the **Run** button (`F5`) in Visual Studio
- Click the **Check RAM Info** button to display RAM details

## 📸 Screenshot

![ram_p1](https://github.com/user-attachments/assets/dd46db35-1c62-456b-b64d-35995e1a0720)

![ram_p2](https://github.com/user-attachments/assets/5035b948-2308-4ff8-9d7e-1a24ef18aa16)



## 🔧 How It Works
- Uses **`ManagementObjectSearcher`** to query `Win32_PhysicalMemory`
- Retrieves **RAM properties** and displays them in a `TextBox`
- Handles exceptions gracefully and shows error messages if needed

## 🐛 Known Issues
- May require **Administrator Privileges** to access WMI queries
- If multiple RAM sticks are installed, only the **first detected stick** is shown (can be extended to support all sticks)

## 📜 License
This project is open-source under the **MIT License**.

## 👨‍💻 Author
Developed by **Andris Bernatovichs**

---
💡 *Feel free to contribute or suggest improvements!* 🚀

