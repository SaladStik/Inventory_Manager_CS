SET search_path TO public;
CREATE USER inventory_admin WITH password 'admin';

DROP TABLE IF EXISTS users CASCADE;
DROP SCHEMA IF EXISTS public CASCADE;

CREATE SCHEMA public;

ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT SELECT ON TABLES TO inventory_admin;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT INSERT ON TABLES TO inventory_admin;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT DELETE ON TABLES TO inventory_admin;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT UPDATE ON TABLES TO inventory_admin;
 
CREATE TABLE product(
	id				SERIAL PRIMARY KEY,
	model_number	VARCHAR(255)		NOT NULL UNIQUE,
	type			VARCHAR(255),
	quantity		INTEGER				NOT NULL,
	barcode			VARCHAR(255)		NOT NULL UNIQUE,
	require_serial_number BOOLEAN		NOT NULL
); 

CREATE TABLE location(
	id			SERIAL PRIMARY KEY,
	name		VARCHAR(255)		NOT NULL UNIQUE
);

CREATE TABLE action(
	id			SERIAL PRIMARY KEY,
	name		VARCHAR(255)		NOT NULL UNIQUE
);

CREATE TABLE history(
	id				SERIAL PRIMARY KEY,
	id_product		INTEGER,
	id_location		INTEGER,
	id_action		INTEGER,
	serial_number	VARCHAR(255)	NOT NULL UNIQUE,
	date			TIMESTAMP,
	note			VARCHAR(1000),
	CONSTRAINT fk_history_id_product	FOREIGN KEY(id_product)		REFERENCES product(id),
	CONSTRAINT fk_history_id_location	FOREIGN KEY(id_location)	REFERENCES location(id),
	CONSTRAINT fk_history_id_action		FOREIGN KEY(id_action)		REFERENCES action(id)
);

