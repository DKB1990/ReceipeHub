# ReceipeHub
1. To run this project, first run below SQL script in your database:

CREATE TABLE Receipe(
    Id VARCHAR(30) PRIMARY KEY,
    Level VARCHAR(10) NOT NULL,
    Name NVARCHAR(250) NOT NULL,
    CreatedDate DATETIME
);
GO;
CREATE TABLE IMAGE(
    Id VARCHAR(30) PRIMARY KEY,
    ImagePath NVARCHAR(250),
    ReceipeId VARCHAR(30),
    FOREIGN KEY (ReceipeId) REFERENCES Receipe(Id)
);
CREATE TABLE Ingredient(
    Id VARCHAR(30) PRIMARY KEY,
    Name NVARCHAR(250) NOT NULL,
    ReceipeId VARCHAR(30),
    FOREIGN KEY (ReceipeId) REFERENCES Receipe(Id)
);
GO;
CREATE TABLE Step(
    Id VARCHAR(30) PRIMARY KEY,
    Description NVARCHAR(250) NOT NULL,
    ReceipeId VARCHAR(30),
    FOREIGN KEY (ReceipeId) REFERENCES Receipe(Id)
);

2. Once you're done, then change the connection string in appsettings.json (https://github.com/DKB1990/ReceipeHub/blob/master/ChefDheeraj/appsettings.Development.json)
3. Build the solution to install the dependencies
4. Set the API project as Startup project by right clicking on the project and select option 'Set as startup project'
5. Run the project
6. Initially the project will take a few minutes to bundle AngularJS files.
7. You will a page with all the Receipes from DB.

That's it!!


