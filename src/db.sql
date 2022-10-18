-- CREATE DATABASE jadijasok;
-- USE jadijasok;

CREATE TABLE szemely (
  id INT PRIMARY KEY,
  nev VARCHAR(100) UNIQUE NOT NULL);

CREATE TABLE kituntetes (
  id INT PRIMARY KEY,
  szemelyId INT FOREIGN KEY REFERENCES szemely(id),
  ev INT);

CREATE TABLE foglalkozas (
  szemelyId INT FOREIGN KEY REFERENCES szemely(id),
  megnevezes VARCHAR(50));