# Restaurant Management System

## Features
- **Login Form**: Allows users to securely log in to the system.
- **Home Panel**: Provides a welcoming interface with essential information and quick access to various functionalities.
- **Menu Management**: Allows users to view and manage food items categorized into starters, main courses, drinks, and desserts.
- **Order Management**: Enables users to create, send, and cancel orders.
- **Payment Processing**: Supports multiple payment methods including cash, credit card, and GCash.
- **Order History**: Displays a history of past orders with details.
- **User Profile Management**: Allows users to view and edit their profile information.
- **Expense Tracking**: Shows daily and monthly expenses.

## UI Reference
[POS Restaurant UI System](https://www.figma.com/community/file/1166720104776634157/pos-restaurant-ui-system)

## Color Palette
[Palette](https://colorhunt.co/palette/22283131363f76abaeeeeeee?fbclid=IwZXh0bgNhZW0CMTEAAR1ZGXebpidySBNHtiSQByVBnJGC-nOugzM7wHYVYBg7fEba8yzc6cB5imQ_aem_FpDXZcxaA6wumZQAaY9ceg)

![Color Hunt Palette 22283131363f76abaeeeeeee](https://github.com/user-attachments/assets/5fec0b38-14e2-40bb-bf4a-a1aaa599a140)

## Getting Started

### Prerequisites
- XAMPP (includes MySQL Server and phpMyAdmin)
- MySQL Connector/NET
- .NET Framework 4.7.2 or higher
- Visual Studio 2022

## Database Setup

1. **Install XAMPP**: Download and install XAMPP from the [official website](https://www.apachefriends.org/index.html).
2. **Start MySQL Server**:
   - Open the XAMPP Control Panel.
   - Start the MySQL service by clicking the "Start" button next to MySQL.

3. **Create the Database**:
   - Open phpMyAdmin by clicking the "Admin" button next to MySQL in the XAMPP Control Panel.
   - In phpMyAdmin, click on the "Databases" tab.
   - Create a new database named `RestaurantMSDB` by entering the name and clicking "Create".

4. **Create the Tables**:
   - Select the `RestaurantMSDB` database.
   - Go to the "SQL" tab and run the following SQL commands to create the necessary tables:
     ```sql
     CREATE TABLE users (
         user_id INT AUTO_INCREMENT PRIMARY KEY,
         username VARCHAR(50) NOT NULL UNIQUE,
         password VARCHAR(255) NOT NULL,
         first_name VARCHAR(50),
         last_name VARCHAR(50),
         email VARCHAR(100),
         phone_number VARCHAR(15),
         address VARCHAR(255)
     );

     CREATE TABLE menu_items (
         item_id INT AUTO_INCREMENT PRIMARY KEY,
         name VARCHAR(100) NOT NULL,
         category VARCHAR(50),
         price DECIMAL(10, 2),
         image BLOB
     );

     CREATE TABLE order_history (
         order_id INT AUTO_INCREMENT PRIMARY KEY,
         user_id INT,
         order_number INT,
         order_date DATETIME,
         items TEXT,
         total_amount DECIMAL(10, 2),
         FOREIGN KEY (user_id) REFERENCES users(user_id)
     );
     ```
 
 ### Application Setup
1. **Clone the repository**: https://github.com/your-username-here/RestaurantManagementSystemCS
   
2.  **Open the project in Visual Studio 2022**:
   - Open Visual Studio 2022.
   - Select `File` > `Open` > `Project/Solution` and navigate to the `RestaurantMS` project file.

3. **Update the connection string**:
   - Open `Mainform.vb`.
   - Update the `connectionString` variable with your MySQL server details: Private connectionString As String = "Server=127.0.0.1;userid=root;password='yourpassword';Database=RestaurantMSDB"
     
4. **Build the project**:
   - Go to the `Build` menu and select `Build Solution` or press `Ctrl+Shift+B`.

5. **Run the application**:
   - Press `F5` to run the application.

## Contributing
1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add some feature'`).
5. Push to the branch (`git push origin feature-branch`).
6. Open a pull request.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
