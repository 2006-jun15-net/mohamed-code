
-- SELECT Track.Name, Genre.Name as Genre
-- FROM Track INNER JOIN Genre ON Track.GenreId = Genre.GenreId;

--all rock songs show in the format "aritst - song"

-- SELECT ar.Name + '-' + t.Name
-- FROM Track AS t
--     Join Genre as g on t.GenreId = g.GenreId
--     Join Album as al on t.AlbumId = al.AlbumId
--     Join Artist as ar on al.ArtistId = ar.ArtistId
-- WHERE g.Name = 'rock';

-- -- SHow all playlists ordered by total
-- Select p.PlaylistId, p.Name, COUNT(*) AS "Number of Tracks"  
-- From Playlist as p 
--     Left JOIN PlaylistTrack as pt on p.PlaylistId = pt.PlaylistId
-- GROUP by p.PlaylistId, p.Name;

-- show all invoices together with the name of the sales agents for each one
-- SELECT i.InvoiceId, i.InvoiceDate, e.FirstName, e.LastName
-- From Invoice as i 
--     Left Join customer as c on i.CustomerId = c.CustomerId
--     left join Employee as e on c.SupportRepId = e.EmployeeId

-- 1. show all invoices of customers from brazil (mailing address not billing)

-- SELECT i.InvoiceId, i.InvoiceDate, c.Country
-- From Invoice as i 
--     LEFT JOIN Customer as c on i.CustomerId = c.CustomerId
-- WHERE c.Country = 'brazil';

-- 1. which artists did not make any albums at all?
-- SELECT ArtistId from Artist
-- EXCEPT
-- SELECT ArtistId from Album;

-- select Name, ArtistId from Artist 
-- where ArtistId 
-- not in (select ArtistId from Album);


-- 2. which artists did not record any tracks of the Latin genre?
-- SELECT * from Artist 
--     where Artistid in(
--         SELECT Artistid from Album 
--         where AlbumId not in( 
--         SELECT AlbumId FROM Track
--         where GenreId in (Select GenreId from genre where Name = 'Latin')));

-- INSERT into Genre (GenreId, Name) VALUES (101, 'Misc');
-- UPDATE Genre
-- Set Name = 'Misc 1'
-- WHERE GenreId = 101; 

-- SELECT * FROM Genre
-- WHERE GenreId>100;

-- -- deletes all rows all at once
-- TRUNCATE TABLE Genre;

-- DELETE from Genre
-- WHERE GenreId > 100;

-- --Insert two rows
-- INSERT into Employee (EmployeeId, LastName, FirstName, Title) VALUES 
--     (1203, 'Salam', 'Mohamed', 'CEO'), 
--     (1160, 'Doe', 'John', 'Sanitation Executive')
-- --display those two
-- SELECT * FROM Employee
-- WHERE 1100<EmployeeId 
-- And EmployeeId<1205 


-- INSERT into Track (TrackId, Name, AlbumId, 
-- Composer, UnitPrice, MediaTypeId, Milliseconds) 
--     VALUES
--         (1839274, 'Revature Mixtape', 169, 'Mohamed Salam', 1800, 3, 4),
--         (4324234, 'Hot Revature', 170, 'Shaq', 180, 3, 4) 

-- SELECT * FROM Track
-- WHERE TrackId>10000

-- UPDATE Customer 
-- Set FirstName = 'Robert', LastName = 'Walter'
-- WHERE FirstName = 'Aaron' AND LastName = 'Mitchell'


-- SELECT * FROM Customer
-- WHERE FirstName = 'Robert' And LastName = 'Walter'







