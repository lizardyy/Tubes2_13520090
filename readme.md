# Tugas Besar 2 IF2211 Strategi Algoritma Semester II tahun 2021/2022

## Pengaplikasian Algoritma BFS dan DFS dalam Implementasi Folder Crawling

Pada Tubes kali ini akan dibuat sebuah aplikasi GUI sederhana yang dapat memodelkan fitur dari file explorer pada sistem operasi, yang pada tugas ini disebut dengan Folder Crawling. Dengan memanfaatkan algoritma Breadth First Search (BFS) dan DepthFirst Search (DFS), Program yang dibuat dapat menelusuri folder-folder yang ada pada direktori untuk mendapatkan direktori yang diinginkan. program juga akan memvisualisasikan hasil dari pencarian folder tersebut dalam bentuk pohon. Selain pohon, Program juga menampilkan list path dari daun-daun yang bersesuaian dengan hasil pencarian. Path tersebut akan meng-_hyperlink_ menuju folder parent dari file yang dicari, agar file langsung dapat diakses melalui file explorer.

## Disusun Oleh

KELOMPOK mesinPencari

1. Rahmat Rafid Akbar 13520090
2. Mahesa Lizardy 13520116
3. Hafidz Nur Rahman Ghozali 13520117

## Langkah Meng-_compile_

1. Instal terlebih dahulu Visual Studio dengan mengklik part **.NET desktop development** yang terdapat c# dan .NET desktop

2. jika sudah terinstall maka double klik solution **Tubes2_13520090.sln** yang ada di dalam folder yang akan otomatis membuka visual studio

3. rebuild solution dengan cara klik kanan pada folder **Solution 'Tubes2_13520090'** kemudian pilih rebuild solution

4. Kemudian klik logo run yang terdapat pada menu bar visual studio atau dapat menekan tombol f5 pada keyboard untuk menjalankan program

## Cara Penggunaan
1. klik logo run pada visual studio atau dapat langsung double klik pada **src.exe** yang terdapat pada folder bin

3. pilih folder yang akan dijadikan sebagai _starting directory_ dengan melakukan klik pada button Change Folder

3. masukan nama file name yang akan dicari pada textbox input file name

4. pilih algoritma yang akan digunakan dengan klik salah satu dari 2 radio button BFS / DFS

5. jika ingin mencari seluruh file yang ada pada folder dapat mencentang pada bagian _find all Occurence_ **(Opsional)**

6. Klik button search untuk melakukan pencarian

7. jika langkah 1,2, dan 3 sudah terpenuhi maka akan ditampilkan hasil berupa graf dari pencarian dan list path yang jika di klik akan meng-_hyperlink_ ke file exproler
