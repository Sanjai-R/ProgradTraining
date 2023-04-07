CREATE TABLE Location
(
    loc_id INT PRIMARY KEY,
    loc_name VARCHAR(50) NOT NULL,
    loc_address VARCHAR(100),
    loc_city VARCHAR(50),
    loc_state VARCHAR(50),
    loc_country VARCHAR(50)
);

CREATE TABLE Employee
(
    emp_id INT PRIMARY KEY,
    emp_name VARCHAR(50) NOT NULL,
    emp_email VARCHAR(50) NOT NULL,
    emp_phone VARCHAR(20),
    emp_salary DECIMAL(10,2),
    loc_id INT FOREIGN KEY REFERENCES Location(loc_id)
);

INSERT INTO Employee
    (emp_id, emp_name, emp_email, emp_phone, emp_salary, loc_id)
VALUES
    (1, 'Riyaz', 'riyaz@example.com', '1234567890', 50000.00, 1),
    (2, 'Sanjai', 'sanjai@example.com', '0987654321', 45000.00, 1),
    (3, 'Ragul', 'ragul@example.com', '9876543210', 40000.00, 2),
    (4, 'Saran', 'saran@example.com', '2345678901', 55000.00, 3),
    (5, 'Nantha', 'nantha@example.com', '3456789012', 60000.00, 3);

INSERT INTO Location
    (loc_id, loc_name, loc_address, loc_city, loc_state, loc_country)
VALUES
    (1, 'Chennai', 'Saravanampatti', 'Coimbatore', 'Tamil Nadu', 'India'),
    (2, 'Bangalore', 'MG Road', 'Bangalore', 'Karnataka', 'India'),
    (3, 'Mumbai', 'Perungudi', 'Chennai', 'Tamil Nadu', 'India');

INSERT INTO [Location]
VALUES
    (4, 'Delhi', 'Agra', 'delhi', 'New Delhi', 'India');
SELECT *
from [Location];

SELECT Employee.emp_name, Location.loc_name, Location.loc_city
FROM Employee
    JOIN Location ON Employee.loc_id = Location.loc_id;
