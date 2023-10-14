CREATE DATABASE movies;

CREATE TABLE actors_table (
	ID int NOT NULL,
	LastName varchar(50),
	FirstName varchar(50),
	Age int,
	PRIMARY KEY (ID)
);

CREATE TABLE directors_table (
	ID int NOT NULL,
	LastName varchar(50),
	FirstName varchar(50),
	Age int,
	PRIMARY KEY (ID)
);

ALTER TABLE directors_table
ADD favorite_actor_ID int;


INSERT INTO actors_table
(ID, LastName, FirstName, Age)
VALUES
(1, 'Seinfeld', 'Jerry', 65),
(2, 'Ferrel', 'Will', 60),
(3, 'Cube', 'Ice', 55),
(4, 'Locke', 'Sondra', 74),
(5, 'Hanks', 'Tom', 67)
;


INSERT INTO directors_table
(ID, LastName, FirstName, Age, favorite_actor_ID)
VALUES
(1, 'David', 'Larry', 75, 1),
(2, 'Spielberg', 'Steven', 67, 5),
(3, 'Dre', 'Dr.', 59, 3),
(4, 'Thurber', 'Rawson', 48, 2),
(5, 'Eastwood', 'Clint', 93, 5)
;


SELECT * FROM actors_table;
SELECT * FROM directors_table;

SELECT actors_table.LastName, actors_table.FirstName, directors_table.FirstName, directors_table.LastName
FROM actors_table
INNER JOIN directors_table
ON actors_table.ID = directors_table.favorite_actor_ID;


