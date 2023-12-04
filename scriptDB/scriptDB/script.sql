
CREATE TABLE aviones(
    id_avion SERIAL PRIMARY KEY,
    numero_serie_avion VARCHAR(20) NOT NULL,
    modelo_avion VARCHAR(50) NOT NULL,
    capacidad_pasajeros INTEGER NOT NULL,
    autonomia_vuelo INTEGER NOT NULL,
    id_piloto_responsable INTEGER REFERENCES pilotos(id_piloto)
);

CREATE TABLE almacenes (
    id_almacen SERIAL PRIMARY KEY,
    numero_almacen INTEGER NOT NULL,
    capacidad_almacen INTEGER NOT NULL,
    ubicacion_almacen VARCHAR(50) NOT NULL
);

CREATE TABLE capitanes (
    id_capitan SERIAL PRIMARY KEY,
    numero_licencia_capitan VARCHAR(20) NOT NULL,
    nombre_capitan VARCHAR(50) NOT NULL,
    salario_capitan INTEGER NOT NULL,
    turno_capitan VARCHAR(20) NOT NULL
);