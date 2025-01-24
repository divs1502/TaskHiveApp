CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100),
    email VARCHAR(100) UNIQUE,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Create posts table
CREATE TABLE posts (
    id SERIAL PRIMARY KEY,
    user_id INTEGER REFERENCES users(id),
    title VARCHAR(255),
    content TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Insert some sample data into the users table
INSERT INTO users (name, email) VALUES 
('John Doe', 'john.doe@example.com'),
('Jane Smith', 'jane.smith@example.com');

-- Insert some sample data into the posts table
INSERT INTO posts (user_id, title, content) VALUES
(1, 'First Post', 'This is the content of the first post'),
(1, 'Second Post', 'This is the content of the second post'),
(2, 'Janes Post', 'Content from Janes post');


SELECT table_name
FROM information_schema.tables
WHERE table_schema = 'public';