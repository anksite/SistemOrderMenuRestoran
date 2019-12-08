CREATE TABLE menu(
	id char(5) NOT NULL,
	nama varchar(50) NOT NULL,
	jenis varchar(10) NOT NULL,
	harga numeric(18, 0) NOT NULL
)


CREATE TABLE karyawan(
	id CHAR(5) NOT NULL,
	nama VARCHAR(50) NOT NULL,
	role VARCHAR(10) CHECK (ROLE IN('KASIR', 'DAPUR', 'ADMIN')) NOT NULL,
	password VARCHAR(15) NOT NULL
)

CREATE TABLE login_record(
	idPegawai CHAR(5) NOT NULL,
	waktu DATETIME NOT NULL
)

SELECT * FROM menu WHERE jenis = 'makan'

SELECT * FROM menu WHERE jenis = 'lain' AND nama LIKE '%sa%'

