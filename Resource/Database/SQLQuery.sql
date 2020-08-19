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



select * from karyawan

use db_resto

select menu.*, jual.terjual ,menu.harga*jual.terjual as omset from menu
JOIN (select ti.id_menu, SUM(ti.qty) terjual  
from transaksi_item ti
GROUP BY id_menu) jual ON jual.id_menu = menu.id

select ti.id_transaksi, m.nama, m.harga, ti.qty, t.status
from transaksi_item ti
JOIN menu m ON ti.id_menu = m.id
JOIN transaksi t ON ti.id_transaksi = t.id
AND ti.id_transaksi = 6

select lr.idPegawai, k.nama, lr.waktu 
from login_record lr
JOIN karyawan k ON k.id = lr.idPegawai
ORDER BY lr.waktu DESC

--DIPESAN, DIBAYAR, DIMASAK, SELESAI
UPDATE transaksi SET status = 'DIMASAK'
WHERE id = 6;

SELECT status FROM transaksi WHERE id = 6

SELECT id, item.item, note
FROM transaksi
JOIN (SELECT id_transaksi,SUM(qty) item
	FROM transaksi_item 
	GROUP BY id_transaksi) item ON item.id_transaksi = transaksi.id  
WHERE status = 'DIBAYAR'

select m.nama, ti.qty
from transaksi_item ti
JOIN menu m ON ti.id_menu = m.id
AND ti.id_transaksi = 6
