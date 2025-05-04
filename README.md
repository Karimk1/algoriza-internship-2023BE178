# Vezeeta Website – Backend Solution

The **Vezeeta Website** project is a robust backend system designed to streamline healthcare services by providing efficient management tools for administrators, doctors, and patients. This solution ensures secure access, optimized appointment booking, and centralized management of key entities within the healthcare ecosystem.

---

## 🚀 Features

### 🔧 Admin Dashboard
- Displays real-time statistics: number of doctors, patients, and request statuses.
- Highlights top-performing specializations and doctors.
- Filter analytics by time: Last 24 hours, week, month, and year.

### 👨‍⚕️ Doctor & Patient Management
- Add, view, edit, and delete doctors and patients.
- Includes input validation to ensure data consistency.

### 🎟️ Discount Code Management
- Admins can add, update, delete, or deactivate discount codes.
- Monitor discount code usage across booking requests.

### 🔐 Authentication
- Secure login system with credential validation.
- Registration and login functionality for doctors and patients.
- Implements JWT-based token authentication for session management.

### 📅 Booking Management
- Book, view, filter, and cancel appointments.
- Filter by date or doctor.
- Prevents slot conflicts via real-time availability management.

### ⚙️ Settings
- Define doctors' availability and appointment pricing.
- Manage booked slots to avoid overlapping appointments.

### 🔍 Doctor Search & Booking (for Patients)
- Search for doctors by specialization and availability.
- Book appointments and apply discount codes during booking.

---

## 🛠️ Technical Implementation

- **Framework**: Built using **.NET Core** with **Onion Architecture** for scalability and maintainability.
- **API Testing**: Integrated with **Swagger** for seamless endpoint testing and documentation.
- **Authentication**: Uses **ASP.NET Identity** and **JWT Tokens** for secure access control.
- **Database**: 
  - Designed with clean coding principles and proper entity relationships.
  - Avoids stored procedures to ensure transparency and ease of maintenance.

---

## 📂 Project Structure

The project follows Onion Architecture:
- **Core Layer**: Contains business logic and entities.
- **Application Layer**: Handles use cases and service interfaces.
- **Infrastructure Layer**: Manages data access and external dependencies.
- **Web API Layer**: Exposes RESTful endpoints for client interactions.

---

## 🧪 API Documentation

You can access and test all endpoints using **Swagger UI** once the application is running.

---

## ✅ Status

This project is actively maintained and can serve as a foundation for healthcare appointment platforms or similar management systems.


https://drive.google.com/file/d/1U8dtvOP275klGfqVetv8IZkF6dOLT_D2/view?usp=sharing

To run my asp.net web api:

1- you need to download my database file using the mentioned link.

2- you need to restore it using SSMS.

3- you need to change the server name in appsettings.json

4- you may need to add this line 

"TrustServerCertificate=True"

at the end of the connection line in the same file. 

