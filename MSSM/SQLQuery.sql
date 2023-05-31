create database TestDB;

create table Jabatan(
	KodeJabatan varchar(50) not null,
	NamaJabatan varchar(100) not null,
primary key(KodeJabatan)
);

insert into Jabatan values
('MNG', 'Manager'),
('ACC', 'Accounting'),
('MKT', 'Marketing'),
('ADM', 'Administrasi')

select * from jabatan

create table Karyawan(
	nip char(6) not null,
	nama_pegawai varchar(50),
	gender char(1),
	tgl_lahir datetime,
	golongan varchar(4),
	gaji decimal(12,3),
	alamat varchar(Max),
	telepon varchar(30),
	email varchar(60),
	tgl_gabung datetime,
	kdjabatan varchar(50),
	isactive bit,

	primary key(nip),
	constraint FK_kdjabatan Foreign Key(kdjabatan)
	references Jabatan(KodeJabatan)
);