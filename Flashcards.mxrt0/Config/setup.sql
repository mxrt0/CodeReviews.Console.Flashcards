-- Create Stack Table
CREATE TABLE Stack (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Name VARCHAR(150) UNIQUE NOT NULL
);

-- Create Flashcard table
CREATE TABLE Flashcard (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Front VARCHAR(255) NOT NULL,
    Back VARCHAR(255) NOT NULL,
    StackId INT NOT NULL,
    FOREIGN KEY (StackId) REFERENCES Stack(Id)
);

-- Create Study Session table 
CREATE TABLE StudySession (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    SessionDate DATETIME NOT NULL,
    Score INT NOT NULL,
    StackId INT NOT NULL,
    FOREIGN KEY (StackId) REFERENCES Stack(Id)
);
