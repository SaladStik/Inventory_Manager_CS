SET search_path TO public;

-- Drop existing tables and schema if they exist
DROP TABLE IF EXISTS users CASCADE;
DROP SCHEMA IF EXISTS public CASCADE;

-- Create schema
CREATE SCHEMA public;

-- Create tables
CREATE TABLE product (
	id SERIAL PRIMARY KEY,
	model_number VARCHAR(255) NOT NULL UNIQUE,
	type VARCHAR(255),
	quantity INTEGER NOT NULL,
	barcode VARCHAR(255) NOT NULL UNIQUE,
	require_serial_number BOOLEAN NOT NULL
);

CREATE TABLE location (
	id SERIAL PRIMARY KEY,
	name VARCHAR(255) NOT NULL UNIQUE
);

CREATE TABLE history (
	id SERIAL PRIMARY KEY,
	id_product INTEGER,
	id_location INTEGER,
	serial_number VARCHAR(255) NOT NULL UNIQUE,
	date TIMESTAMP,
	note VARCHAR(1000),
	CONSTRAINT fk_history_id_product FOREIGN KEY(id_product) REFERENCES product(id),
	CONSTRAINT fk_history_id_location FOREIGN KEY(id_location) REFERENCES location(id)
);

-- Insert default location
INSERT INTO location (name) VALUES ('Stock');
