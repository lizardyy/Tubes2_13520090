using System;
using System.IO;
using System.Collections.Generic;

public class DFS
{
	public void DFSearch(string folder, string filesearch, List<string> pengecekan, List<string> result, bool checkAll)
	{
		//* -> Bagian 1 : Basis *//

		bool found_1 = false;
		// Cek semua file dalam folder sekarang, 
		// file dicek terlebih dahulu sebelum folder lainnya secara DFS.
		string[] currfiles = Directory.GetFiles(folder);
		foreach (string file in currfiles)
		{
			// File yang telah diperiksa ditambahkan ke list pengecekan
			pengecekan.Add(file);
			// Jika file yang dicek merupakan file yang dicari, tambahkan ke list result
			if (Path.GetFileName(file) == filesearch)
			{
				result.Add(file);
				found_1 = true;
			}
			// Jika tidak perlu mengecek semua file dan telah ditemukan 1 yang cocok, maka keluar dari proses pengecekan.
			if (!checkAll && found_1){
				return;
			}
		}
		
		
		//* -> Bagian 2 : Rekursif *//
		// Cek semua folder yang ada, lalu lakukan pengecekan secara rekursif untuk setiap folder
		string[] dirs = Directory.GetDirectories(folder);
		foreach (string dir in dirs)
		{
			pengecekan.Add(dir);
			DFSearch(dir, filesearch, pengecekan, result, checkAll);
			// Jika tidak perlu mengecek semua file dan telah ditemukan 1 yang cocok, maka keluar dari proses pengecekan.
			if (result.Count > 0 && !checkAll)
			{
				return;
			}
		}
	}
}



