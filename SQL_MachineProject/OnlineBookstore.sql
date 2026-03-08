CREATE TABLE Books (
    ISBN BIGINT PRIMARY KEY,
    Title VARCHAR(255),
    Genre VARCHAR(100),
    Price DECIMAL(10, 2),
    PublishDate VARCHAR(50),
    AuthorID INT
);

CREATE TABLE Authors (
    AuthorID INT PRIMARY KEY,
    Name VARCHAR(255),
    Biography TEXT
);

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Email VARCHAR(255),
    Address VARCHAR(255)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    OrderDate VARCHAR(50),
    CustomerID INT,
    TotalPrice DECIMAL(10, 2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

INSERT INTO Books (ISBN, Title, Genre, Price, PublishDate, AuthorID) VALUES 
(9781668094716, 'Mother Mary Comes to Me', 'Memoir', 30.00, 'Sep 2, 2025', 114),
(9780593831878, 'The Emperor of Gladness', 'Literary Fiction', 30.00, 'May 13, 2025', 115),
(9780063021471, 'Katabasis', 'Dark Academia', 35.00, 'Aug 26, 2025', 107),
(9780593798430, 'The Correspondent', 'Thriller', 28.00, 'May 6, 2025', 105),
(9780385550369, 'James', 'Historical Fiction', 28.00, 'Mar 19, 2024', 101),
(9781668023488, 'Abundance', 'Non-fiction', 30.00, 'Mar 18, 2025', 116),
(9780525556572, 'Everything Is Tuberculosis', 'History/Science', 28.00, 'Mar 18, 2025', 104),
(9781984857781, 'Good Things', 'CookBook', 45.00, 'Sep 16, 2025', 109),
(9780802165176, 'Heart the Lover', 'Romance', 28.00, 'Sep 30, 2025', 113),
(9780593329856, 'The Hidden Globe', 'Investigative', 30.00, 'Oct 8, 2024', 102),
(9781339001265, 'Talons of Power', 'Graphic Novel', 14.99, 'Dec 30, 2025', 112),
(9781250357632, 'Delusions', 'Humor/Essays', 29.00, 'Mar 3, 2026', 113),
(9781538773667, 'Kids, Wait Till You Hear This!', 'Autobiography', 36.00, 'Mar 10, 2026', 114),
(9781419782695, 'Partypooper (Wimpy Kid #20)', 'Children''s', 15.99, 'Oct 21, 2025', 111),
(9780374618599, 'Transcription', 'Literary Fiction', 25.00, 'Apr 7, 2026', 110);




INSERT INTO Authors (AuthorID, Name, Biography) 
VALUES 
(101, 'Percival Ecerett', 'Distinguished Professor at USC and prolific author of over 30 books, often exploring satire and race.'),
(102, 'Atossa A. Abrahamian', 'Journalist and editor focusing on citizenship, borders, and global economics.'),
(103, 'Ezra Klein', 'American journalist, political analyst, and co-founder of Vox; focuses on policy and polarization.'),
(104, 'John Green', 'Bestselling YA author and historian; co-founder of Complexly and advocate for global health.'),
(105, 'Virginia Evans', 'A pseudonymous or collective identity often used for specialized thriller and educational publications.A pseudonymous or collective identity often used for specialized thriller and educational publications.'),
(106, 'Ocean Vuong', 'Vietnamese-American poet and novelist; a MacArthur Genius" Grant recipient known for lyrical prose."'),
(107, 'R.F. Kuang', 'Award-winning fantasy and fiction author (The Poppy War), holding degrees from Oxford and Yale.'),
(108, 'Arundhati Roy', 'Man Booker Prize-winning Indian author and political activist, known for The God of Small Things.'),
(109, 'Samin Nosrat', 'American chef and TV host; author of the revolutionary Salt, Fat, Acid, Heat.'),
(110, 'Lily King', 'Award-winning American novelist known for exploring complex emotional landscapes and history.'),
(111, 'Jeff Kinner', 'American author and cartoonist; creator of the Diary of a Wimpy Kid series and owner of the bookstore An Unlikely Story.""'),
(112, 'Tui T. Sutherland', 'Venezuelan-American children''s book author, best known for the epic Wings of Fire series.'),
(113, 'Cazzie David', 'Scriptwriter and actress known for her dry humor and essays on modern anxiety.'),
(114, 'Liza Minnelli', 'Legendary EGOT-winning performer and actress; daughter of Judy Garland and Vincente Minnelli.'),
(115, 'Ben Lerner', 'Acclaimed poet and novelist; professor at Brooklyn College and MacArthur Fellow.'),
(116, ' Derek Thompson', 'Staff writer at The Atlantic and author focusing on economics, technology, and media trends.');



INSERT INTO Customers (CustomerID, FirstName, LastName, Email, Address) 
VALUES 
(1001, 'Haruhi', 'Suzumiya', 'suzuharu@gmail.com', 'Yokusuka'),
(1002, 'Kyon', 'Kusanagi', 'kyon_unlucky@gmail.com', 'Shinjuku'),
(1003, 'Yuki', 'Nagato', 'y.nagato@library-archive.org', 'Chuo'),
(1004, 'Mikuru', 'Asahina', 'm.asahina@time-travel.net', 'Nishinomiya'),
(1005, 'Itsuki', 'Koizumi', 'i.koizumi@agency.com', 'Nishinomiya'),
(1006, 'Shinji', 'Ikari', 's.ikari@nerv.org', 'Tokyo-3'),
(1007, 'Rei', 'Ayanami', 'rei.0@nerv.org', 'Tokyo-3'),
(1008, 'Asuka', 'Langley', 'asuka.soryu@nerv.org', 'Tokyo-3'),
(1009, 'Misato', 'Katsuragi', 'm.katsuragi@nerv.org', 'Akita'),
(110, 'Gendo', 'Ikari', 'g.ikari@nerv.org', 'Osaka'),
(111, 'Edward', 'Elric', 'fma_ed@alchemist.gov', 'Chiba');

CREATE TABLE OrderDetails (
    OrderDetailsID INT PRIMARY KEY,
    OrderID INT,
    ISBN BIGINT,
    Quantity INT,
    PurchasePrice DECIMAL(10, 2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ISBN) REFERENCES Books(ISBN)
);

INSERT INTO OrderDetails (OrderDetailsID, OrderID, ISBN, Quantity, PurchasePrice) 
VALUES 
(111111, 11115, 9780063021471, 1, 35.00),
(111112, 11116, 9780385550369, 1, 28.00), 
(111113, 11116, 9781668023488, 1, 30.00), 
(111114, 11117, 9780593831878, 1, 30.00), 
(111120, 11123, 9780525556572, 1, 28.00), 
(111121, 11123, 9781668094716, 1, 30.00); 



INSERT INTO Orders (OrderID, OrderDate, CustomerID, TotalPrice) 
VALUES 
(11111, '03-23-2026', 1001, 35.0),
(11112, '03-24-2026', 1002, 58.0),
(11113, '03-25-2026', 1003, 30.0),
(11114, '03-26-2026', 1004, 45.0),
(11115, '03-27-2026', 1005, 120.5),
(11116, '03-28-2026', 1006, 28.0),
(11117, '03-29-2026', 1007, 30.0),
(11118, '03-30-2026', 1008, 14.99),
(11119, '03-31-2026', 1009, 36.0),
(11120, '04-01-2026', 110, 25.0),
(11121, '04-02-2026', 111, 45.0);