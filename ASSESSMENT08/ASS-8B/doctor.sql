
-- Creating a database 
CREATE DATABASE DOCTOR;

-- Creating a Table for the doctor 
CREATE TABLE DOCTOR_INFO(
    DOCTOR_ID INT PRIMARY KEY,
    DOCTOR_NAME VARCHAR(30),
    SPECIALISATION VARCHAR(20)
)

-- inserting some values to the table 
INSERT INTO DOCTOR_INFO
VALUES 
(5001, 'Dr Ram', 'orthopediac'),
(5002, 'Dr Shyam','General Medicine'),
(5003, 'Dr Krishna', 'ENT'),
(5004, 'Dr Akbar', 'pediatrician'),
(5005, 'Dr Shalini', 'Gynecologist');
