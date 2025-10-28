CREATE DATABASE LTTQ_BTL_DB;
GO
USE LTTQ_BTL_DB;
GO

-- ==============================
-- Table: Role
-- ==============================
CREATE TABLE Role (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    name VARCHAR(50) NOT NULL
);
GO

-- ==============================
-- Table: User
-- ==============================
CREATE TABLE [User] (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    username NVARCHAR(100) NOT NULL UNIQUE,
    [password] VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),
    update_at DATETIME DEFAULT GETDATE(),
    role_id UNIQUEIDENTIFIER NOT NULL,
    FOREIGN KEY (role_id) REFERENCES Role(id)
);
GO

-- ==============================
-- Table: Student
-- ==============================
CREATE TABLE Student (
    id UNIQUEIDENTIFIER PRIMARY KEY,
    full_name NVARCHAR(100) NOT NULL,
    birth_date DATE,
    gender NVARCHAR(10),
    phone_number VARCHAR(20),
    email VARCHAR(100),
    address NVARCHAR(255),
    FOREIGN KEY (id) REFERENCES [User](id)
);
GO

-- ==============================
-- Table: Teacher
-- ==============================
CREATE TABLE Teacher (
    id UNIQUEIDENTIFIER PRIMARY KEY,
    full_name NVARCHAR(100) NOT NULL,
    specialization NVARCHAR(100),
    qualification NVARCHAR(100),
    phone_number VARCHAR(20),
    email VARCHAR(100),
    address NVARCHAR(255),
    start_date DATE,
    FOREIGN KEY (id) REFERENCES [User](id)
);
GO

-- ==============================
-- Table: Course
-- ==============================
CREATE TABLE Course (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    name NVARCHAR(100) NOT NULL,
    description NVARCHAR(255),
    number_of_lessons INT,
    fee DECIMAL(10,2)
);
GO

-- ==============================
-- Table: Class
-- ==============================
CREATE TABLE Class (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    course_id UNIQUEIDENTIFIER NOT NULL,
    name NVARCHAR(100),
    max_students INT,
    start_date DATE,
    teacher_id UNIQUEIDENTIFIER,
    FOREIGN KEY (course_id) REFERENCES Course(id),
    FOREIGN KEY (teacher_id) REFERENCES Teacher(id)
);
GO

-- ==============================
-- Table: Enrollment
-- ==============================
CREATE TABLE Enrollment (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    student_id UNIQUEIDENTIFIER NOT NULL,
    class_id UNIQUEIDENTIFIER NOT NULL,
    enrollment_date DATE DEFAULT GETDATE(),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (class_id) REFERENCES Class(id)
);
GO

-- ==============================
-- Table: ClassAssignment
-- ==============================
CREATE TABLE ClassAssignment (
    student_id UNIQUEIDENTIFIER NOT NULL,
    class_id UNIQUEIDENTIFIER NOT NULL,
    assigned_date DATE DEFAULT GETDATE(),
    PRIMARY KEY (student_id, class_id),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (class_id) REFERENCES Class(id)
);
GO

-- ==============================
-- Table: Schedule
-- ==============================
CREATE TABLE Schedule (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    class_id UNIQUEIDENTIFIER NOT NULL,
    session_date DATE,
    start_time TIME,
    room NVARCHAR(50),
    FOREIGN KEY (class_id) REFERENCES Class(id)
);
GO

-- ==============================
-- Table: Attendance
-- ==============================
CREATE TABLE Attendance (
    student_id UNIQUEIDENTIFIER NOT NULL,
    schedule_id UNIQUEIDENTIFIER NOT NULL,
    status VARCHAR(20) CHECK (status IN ('present', 'absent', 'late', 'excused')),
    note NVARCHAR(255),
    PRIMARY KEY (student_id, schedule_id),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (schedule_id) REFERENCES Schedule(id)
);
GO

-- ==============================
-- Table: Payment
-- ==============================
CREATE TABLE Payment (
    id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    enrollment_id UNIQUEIDENTIFIER NOT NULL,
    amount DECIMAL(10,2),
    payment_date DATE DEFAULT GETDATE(),
    method VARCHAR(20) CHECK (method IN ('none', 'cash', 'bank_transfer', 'credit_card')),
    status VARCHAR(20) CHECK (status IN ('paid', 'pending', 'failed')),
    FOREIGN KEY (enrollment_id) REFERENCES Enrollment(id)
);
GO

-- ==============================
-- Table: Score
-- ==============================

CREATE TABLE Score (
    student_id UNIQUEIDENTIFIER NOT NULL,
    class_id UNIQUEIDENTIFIER NOT NULL,
    score DECIMAL(5,2) CHECK (score >= 0 AND score <= 10),
    created_date DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (student_id) REFERENCES Student(id),
    FOREIGN KEY (class_id) REFERENCES Class(id)
);
GO
