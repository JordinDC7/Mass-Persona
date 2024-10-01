CREATE TABLE reviews (
    ReviewID SERIAL PRIMARY KEY,      -- Auto-incrementing primary key
    Title VARCHAR(255) NOT NULL,      -- The title of the media being reviewed
    Category VARCHAR(100) NOT NULL,   -- The type of media (e.g., Movie, Book, Game)
    ReviewText TEXT,                  -- The review text for the media
    Rating INT CHECK (Rating >= 1 AND Rating <= 5), -- A rating out of 5
    DateReviewed DATE NOT NULL        -- The date when the media was reviewed
);

INSERT INTO public.reviews (Title, Category, ReviewText, Rating, DateReviewed)
VALUES 
('The Lord of the Rings', 'Book', 'An epic fantasy novel that explores the battle between good and evil.', 5, '2024-09-30'),
('The Godfather', 'Movie', 'A crime drama that tells the story of a powerful mafia family.', 5, '2024-09-29'),
('The Witcher 3: Wild Hunt', 'Game', 'A role-playing game that offers an immersive open world and complex storytelling.', 4, '2024-09-28'),
('Abbey Road', 'Music', 'The Beatles'' iconic album featuring some of their most popular songs.', 5, '2024-09-27'),
('Breaking Bad', 'TV Show', 'A story about a high school teacher who turns to a life of crime after a terminal cancer diagnosis.', 5, '2024-09-26');
