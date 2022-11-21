DROP DATABASE SPACECOURSE_DB
CREATE DATABASE SPACECOURSE_DB
USE SPACECOURSE_DB

-- CREATE TABLE Account(
-- 	user_password nvarchar(255),
-- 	user_name nvarchar(255) NOT NULL,
-- 	Primary key(user_name)
-- );
ALTER TABLE Users
ADD profile_pic varchar(255)
CREATE TABLE Users (
    id_user  int IDENTITY(1,1) NOT NULL,
    name_user nvarchar(255),
    user_password varchar(255),
    sdt varchar(255),
    emai varchar(255),
    user_name varchar(255),
    PRIMARY KEY(id_user)
);
CREATE TABLE AdminUser (
    id_admin int NOT NULL ,
    FOREIGN KEY (id_admin) REFERENCES Users(id_user)
);
CREATE TABLE Courses(
    id_course int IDENTITY(1,1) NOT NULL,
    subscriber_user int,
    is_premium BINARY,
    process float,
    name_course nvarchar(255),
    description nvarchar(2048),
    img_course varchar(1024),
    accent_color char(7),
    PRIMARY KEY(id_course),
    FOREIGN KEY(subscriber_user) REFERENCES Users(id_user)
);

CREATE TABLE Lessons(
    id_lesson int IDENTITY(1,1) NOT NULL Primary key ,
    process float,
    id_user int,
    name_lesson nvarchar(255),
    description nvarchar,
    video_lesson varchar(1024),
    id_course int,
    FOREIGN KEY(id_user) REFERENCES USERS(id_user),
    FOREIGN KEY(id_course) REFERENCES Courses(id_course),
);
CREATE TABLE Services(
    id_service int IDENTITY(1,1) Not null PRIMARY KEY,
    date_regis date,
    type_service nvarchar,
    id_user int,
    price float,
    FOREIGN KEY(id_user) REFERENCES USERS(ID_USER)
);
CREATE TABLE Feedback(
    id_feedback int IDENTITY(1,1) Not null Primary key,
    title nvarchar(255),
    id_course int,
    content nvarchar,
    id_user int,
    FOREIGN KEY(id_user) REFERENCES USERS(ID_USER),
    FOREIGN KEY(id_course) REFERENCES Courses(ID_COURSE),
);

CREATE TABLE Pay(
    id int not null primary key,
    loaithe nvarchar,
    ngaythanhtoan date,
    cvc int NULL,
    expire date NULL,
    sothe int, 
    madv int,
    id_user int,
    FOREIGN KEY(id_user) REFERENCES USERS(ID_USER),
);
CREATE TABLE Cerf(
    id_cer int not null primary key,
    ngaycap date,
    id_user int,
    id_lesson int,
    FOREIGN KEY(id_user) REFERENCES USERS(ID_USER),
    FOREIGN KEY(id_lesson) REFERENCES LESSONS(ID_LESSON),
);
