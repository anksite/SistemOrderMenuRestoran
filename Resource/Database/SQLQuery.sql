use db_resto

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

SELECT role FROM karyawan WHERE id='K001' AND password = '123'

INSERT INTO login_record VALUES('K001', CURRENT_TIMESTAMP);

CREATE TABLE transaksi(
	id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	tanggal DATETIME NOT NULL,
	note VARCHAR(100),
	status VARCHAR(10) NOT NULL, --DIPESAN, DIBAYAR, DIMASAK, SELESAI
	id_pegawai CHAR(5) NOT NULL
)

CREATE TABLE transaksi_item(
	id_transaksi int NOT NULL,
	id_menu CHAR(5) NOT NULL,
	qty numeric(18, 0) NOT NULL
)

INSERT INTO transaksi OUTPUT Inserted.ID 
VALUES(CURRENT_TIMESTAMP, 'Ini adalah Note3', 'DIPESAN', 'K001')

INSERT INTO transaksi_item VALUES(1, 'M001', 2)

select * from menu

select * from transaksi

select * from transaksi_item

