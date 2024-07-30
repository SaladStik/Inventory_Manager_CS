-- Create schema if it doesn't exist
CREATE SCHEMA IF NOT EXISTS public;

-- Set the search path to the public schema
SET search_path TO public;

-- Drop existing tables if they exist
DROP TABLE IF EXISTS history CASCADE;
DROP TABLE IF EXISTS product CASCADE;
DROP TABLE IF EXISTS location CASCADE;
DROP TABLE IF EXISTS supplier CASCADE;

-- Create tables
CREATE TABLE supplier (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE location (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE product (
    id SERIAL PRIMARY KEY,
    model_number VARCHAR(255) NOT NULL UNIQUE,
    alias VARCHAR(255),
    type VARCHAR(255),
    quantity INTEGER NOT NULL,
    barcode VARCHAR(255) NOT NULL UNIQUE,
    require_serial_number BOOLEAN NOT NULL,
    image_url VARCHAR(500),
    supplier_id INTEGER,
    CONSTRAINT fk_supplier_id FOREIGN KEY(supplier_id) REFERENCES supplier(id),
    supplier_link VARCHAR(500),
    min_stock INTEGER,
    str_loc VARCHAR(255)
);

CREATE TABLE history (
    id SERIAL PRIMARY KEY,
    id_product INTEGER,
    id_location INTEGER,
    serial_number VARCHAR(255) NOT NULL UNIQUE,
    date TIMESTAMP,
    ticket_num VARCHAR(255),
    note VARCHAR(1000),
    CONSTRAINT fk_history_id_product FOREIGN KEY(id_product) REFERENCES product(id),
    CONSTRAINT fk_history_id_location FOREIGN KEY(id_location) REFERENCES location(id)
);

-- Insert default location
INSERT INTO location (name) VALUES ('Stock');

-- Insert initial suppliers
INSERT INTO supplier (name) VALUES ('Active IS');


ALTER TABLE product ADD COLUMN bin VARCHAR(50);

CREATE TABLE quick_sheets (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    description TEXT
);

CREATE TABLE quick_sheet_products (
    quick_sheet_id INT NOT NULL,
    product_id INT NOT NULL,
    FOREIGN KEY (quick_sheet_id) REFERENCES quick_sheets(id),
    FOREIGN KEY (product_id) REFERENCES product(id)
);


CREATE TABLE roles (
    id SERIAL PRIMARY KEY,
    role_name VARCHAR(50) UNIQUE NOT NULL
);

INSERT INTO roles (role_name) VALUES ('Administrator'), ('User'), ('Viewer');

CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(255) NOT NULL,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    role_id INTEGER NOT NULL REFERENCES roles(id)
);

-- Insert the default admin user with the Administrator role
ALTER TABLE users ADD COLUMN salt TEXT;
ALTER TABLE users ADD COLUMN forgot_password BOOLEAN DEFAULT FALSE;


