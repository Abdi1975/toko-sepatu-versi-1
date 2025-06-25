# Aplikasi Penjualan Toko Sepatu

Aplikasi ini merupakan sistem informasi penjualan sepatu berbasis desktop yang dibuat menggunakan bahasa pemrograman **Visual Basic .NET (VB.NET)** dengan antarmuka **Windows Form**. Aplikasi ini dirancang untuk membantu pengelolaan data karyawan, user, sepatu, supplier, serta transaksi penjualan dan pembelian sepatu.

## Fitur Utama

### 🔐 Login
- Form login untuk autentikasi user berdasarkan **username** dan **password**.

### 🏠 Dashboard/Home
- Tampilan utama setelah login, dengan menu navigasi:
  - **Data Master**
  - **Transaksi**
  - **Setup**
  - **Laporan**
  - **Tentang**
  - **Keluar**

### 👨‍💼 Master Data Karyawan
- Menambahkan, mengedit, dan menghapus data karyawan.
- Fitur pencarian berdasarkan nama.
- Informasi yang dikelola: NIK, Nama, Jenis Kelamin, Tempat/Tanggal Lahir, Alamat, No. Telepon.

### 👤 Master Data User
- Pengelolaan user login berdasarkan NIK karyawan.
- Set username dan password untuk login ke aplikasi.

### 👟 Master Data Sepatu
- Menambahkan, mengubah, dan menghapus data sepatu.
- Atribut sepatu yang dikelola: Kode, Nama, Kategori, Merk, Warna, Ukuran, Satuan, Harga Beli, Harga Jual, Stok.
- Fitur pencarian sepatu berdasarkan nama, kategori, merk, atau ukuran.

### 🏬 Master Data Supplier
- Menambahkan dan mengelola informasi supplier.
- Data yang disimpan: Kode Supplier, Nama, Alamat, No. Telepon, Email, Website.

### 🛒 Transaksi Penjualan
- Form transaksi penjualan sepatu.
- Input data pembeli, memilih sepatu, menentukan jumlah, menghitung total harga otomatis, dan kalkulasi diskon serta kembalian.

### 📦 Transaksi Pembelian
- Form transaksi pembelian sepatu dari supplier.
- Menentukan supplier, sepatu yang dibeli, jumlah, dan perhitungan total harga.

## Teknologi yang Digunakan
- Visual Studio / VB.NET (Windows Forms)
- Backend database: Microsoft Access atau SQL Server (bergantung konfigurasi)
- Aset visual: Ikon, ilustrasi sepatu, dan logo toko

## Screenshot Antarmuka

| Tampilan | Deskripsi |
|----------|-----------|
| ![Screenshot 2024-12-11 085930](https://github.com/user-attachments/assets/56e9c958-e7eb-43d8-b8a4-f321c9190a1c) | Form login aplikasi |
| ![Screenshot 2024-12-11 085946](https://github.com/user-attachments/assets/ac74a185-e8be-45a7-ba56-85eea1074de5) | Tampilan beranda dengan menu utama |
| ![Screenshot 2024-12-11 090533](https://github.com/user-attachments/assets/d89e69fd-81d6-4be0-a5cb-204fb86390b6) | Form master data karyawan |
| ![Screenshot 2024-12-11 095040](https://github.com/user-attachments/assets/14549bc1-a991-448d-8ef5-19613b12d32d) | Form master data user |
| ![Screenshot 2024-12-11 095349](https://github.com/user-attachments/assets/a0f8bc13-b52a-46a0-aa67-dec479f7875f) | Form master data sepatu |
| ![Screenshot 2024-12-11 095410](https://github.com/user-attachments/assets/d9b362d0-a11e-43a4-a8b8-10a10932d9a9) | Form master data supplier |
| ![Screenshot 2024-12-11 104409](https://github.com/user-attachments/assets/ab36ab8b-7596-4c8f-8e80-2123ff817348) | Form transaksi penjualan sepatu |
| ![Screenshot 2024-12-11 110454](https://github.com/user-attachments/assets/7cae1763-350d-4373-8387-95bf900bd2cc) | Form transaksi pembelian sepatu |

## Pengembang
**Ramadhan Abdillah**
