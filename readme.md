# Tugas Besar 2 IF2211 Strategi Algoritma Semester II tahun 2021/2022

## Pengaplikasian Algoritma BFS dan DFS dalam Implementasi Folder Crawling

Pada Tubes kali ini akan dibuat sebuah aplikasi GUI sederhana yang dapat memodelkan fitur dari file explorer pada sistem operasi, yang pada tugas ini disebut dengan Folder Crawling. Dengan memanfaatkan algoritma Breadth First Search (BFS) dan DepthFirst Search (DFS), Program yang dibuat dapat menelusuri folder-folder yang ada pada direktori untuk mendapatkan direktori yang diinginkan. program juga akan memvisualisasikan hasil dari pencarian folder tersebut dalam bentuk pohon. Selain pohon, Program juga menampilkan list path dari daun-daun yang bersesuaian dengan hasil pencarian. Path tersebut diharuskan memiliki hyperlink menuju folder parent dari file yang dicari, agar file langsung dapat diakses melalui browser atau file explorer.

## Disusun Oleh

KELOMPOK mesinPencari

1. Rahmat Rafid Akbar 13520090
2. Mahesa Lizardy 13520116
3. Hafidz Nur Rahman Ghozali 13520117

## Langkah Meng-_compile_

1. cInstal terlebih dahulu Visual Studio dengan mengklik part **.NET desktop development**

2. jika sudah terinstall maka double klik solution yang ada di dalam folder **Tubes2_13520090** yang akan otomatis membuka visual studio

3. rebuild solution dengan cara klik kanan pada folder **Solution 'Tubes2_13520090'** kemudian pilih rebuild solution

4.Kemudian klik logo run yang terdapat pada menu bar visual studio atau dapat menekan tombol f5 pada keyboard

## Cara Penggunaan

1. pilih folder yang akan dijadikan sebagai _starting directory_ dengan menlakukan klik pada button Change Folder

2. masukan nama file name yang akan dicari pada textbox input file name

3. pilih algoritma yang akan digunakan dengan klik salah satu dari 2 radio button BFS / DFS

4. jika ingin mencari seluruh file yang ada pada folder dapat mencentang pada bagian Find all Occurence **(Opsional)**

5. Klik tombol search untuk melakukan pencarian

6. jika langkah 1,2, dan 3 sudah terpenuhi maka akan ditampilkan hasil berupa graf dari pencarian dan list path yang jika di klik akan hyperlink ke file exproler
