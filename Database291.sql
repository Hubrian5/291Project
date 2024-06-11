use [291Project];

drop table Branches;
drop table Car_Types;
drop table Customers;
drop table Employees;
drop table Rental_Transactions;

create table Customers(
    customer_id int primary key,
    Name varchar(50),
    Street_line1 varchar(50),
    Street_line2 varchar(50),
    city varchar(50),
    province varchar(50),
    phone_number varchar(20)
);

create table Car_Types(
    type_id int primary key,
    type_name varchar(50),
    daily_price decimal(10, 2),
    weekly_price decimal(10, 2),
    monthly_price decimal(10, 2)
);

create table Branches(
    branch_id int primary key,
    name varchar(50),
    city varchar(50)
);

create table Cars(
    car_id int primary key,
    type_id int,
    branch_id int,
    model varchar(50),
    manufacture_date date,
    foreign key(type_id) references Car_Types(type_id),
    foreign key(branch_id) references Branches(branch_id)
);

create table Employees(
    employee_id int primary key,
    branch_id int,
    Name varchar(50),
    position varchar(100),
    salary decimal(10, 2),
    foreign key(branch_id) references Branches(branch_id)
);

create table Rental_Transactions(
    transaction_id int primary key,
    car_id int,
    frombranch_id int,
    tobranch_id int,
    customer_id int,
    employee_id int,
    price decimal(10, 2),
    start_date date,
    end_date date,
    foreign key(car_id) references Cars(car_id),
    foreign key(frombranch_id) references Branches(branch_id),
    foreign key(tobranch_id) references Branches(branch_id),
    foreign key(customer_id) references Customers(customer_id),
    foreign key(employee_id) references Employees(employee_id)
);

-- POPULATING THE DATA
insert into customers (customer_id, name, street_line1, street_line2, city, province, phone_number) values
(1, 'Ruskin Luitel', '123 Elm St', 'Apt 4', 'Edmonton', 'AB', '123-456-7890'),
(2, 'Brian Hu', '456 Oak St', null, 'Calgary', 'AB', '234-567-8901'),
(3, 'Francis Safari', '789 Pine St', 'Suite 100', 'Red Deer', 'AB', '345-678-9012'),
(4, 'Bohdan Z', '101 Maple St', 'Floor 2', 'Toronto', 'ON', '456-789-0123'),
(5, 'John Doe', '202 Birch St', null, 'Kelowna', 'BC', '567-890-1234');


insert into car_types (type_id, type_name, daily_price, weekly_price, monthly_price) values
(10, 'Sedan', 30.00, 180.00, 700.00),
(11, 'SUV', 50.00, 300.00, 1200.00),
(12, 'Truck', 60.00, 360.00, 1400.00),
(13, 'Convertible', 70.00, 420.00, 1600.00),
(14, 'Minivan', 40.00, 240.00, 950.00);


insert into branches (branch_id, name, city) values
(1, 'Downtown Branch', 'Edmonton'),
(2, 'Uptown Branch', 'Calgary'),
(3, 'Central Branch', 'Red Deer'),
(4, 'Eastside Branch', 'Toronto'),
(5, 'Westside Branch', 'Kelowna');


insert into cars (car_id, type_id, branch_id, model, manufacture_date) values
(1, 10, 1, 'Toyota Camry', '2022-01-15'),
(2, 11, 2, 'Honda CR-V', '2021-05-20'),
(3, 12, 3, 'Ford F-150', '2020-11-30'),
(4, 13, 4, 'Mazda MX-5', '2023-03-10'),
(5, 14, 5, 'Chrysler Pacifica', '2019-08-25');


insert into employees (employee_id, branch_id, name, position, salary) values
(1, 1, 'Jason Momoa', 'Manager', 60000.00),
(2, 2, 'Scarlett Johansson', 'Sales Associate', 45000.00),
(3, 3, 'Jamal Blackman', 'Technician', 50000.00),
(4, 4, 'Michael Blackson', 'Branch Manager', 70000.00),
(5, 5, 'Kai Cenat', 'Customer Service', 40000.00);


insert into rental_transactions (transaction_id, car_id, frombranch_id, tobranch_id, customer_id, employee_id, price, start_date, end_date) values
(1, 1, 1, 2, 1, 1, 300.00, '2024-01-10', '2024-01-17'),
(2, 2, 2, 3, 2, 2, 500.00, '2024-02-15', '2024-02-22'),
(3, 3, 3, 4, 3, 3, 600.00, '2024-03-20', '2024-03-27'),
(4, 4, 4, 5, 4, 4, 700.00, '2024-04-25', '2024-05-02'),
(5, 5, 5, 1, 5, 5, 400.00, '2024-05-30', '2024-06-06');
