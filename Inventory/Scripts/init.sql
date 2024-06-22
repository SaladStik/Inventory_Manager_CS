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
