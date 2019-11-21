psql -U postgres << "EOSQL"

CREATE DATABASE postgres;
\c postgres;

--------------------
-- TABLE: Shippers 
--------------------
CREATE TABLE Shippers(
    ShipperID      integer    NOT NULL,
    CompanyName    VARCHAR(40)    NOT NULL,
    Phone          VARCHAR(24),
    CONSTRAINT PK_Shippers PRIMARY KEY (ShipperID)
);

--------------------
-- Sequence: ShipperID
--------------------
CREATE SEQUENCE TS_ShipperID;

--------------------
-- INSERT
--------------------
INSERT INTO Shippers (ShipperID, CompanyName, Phone) VALUES(nextval('TS_ShipperID'), 'Speedy Express', '(503) 555-9831');
INSERT INTO Shippers (ShipperID, CompanyName, Phone) VALUES(nextval('TS_ShipperID'), 'United Package', '(503) 555-3199');
INSERT INTO Shippers (ShipperID, CompanyName, Phone) VALUES(nextval('TS_ShipperID'), 'Federal Shipping', '(503) 555-9930');

EOSQL