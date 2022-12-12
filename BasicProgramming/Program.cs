using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprogramming
{
	public class Administrasi
	{
		public void administrasi()
		{
			//mendeklarasi atau mendefinisikan variable data menggunakan array
			string[] Nama = new string[35];
			string[] Nim = new string[35];
			string[] Jurusan = new string[35];
			string[] Alamat = new string[35];
			string[] JK = new string[35];
			string[] DK = new string[35];

			int i, n = 0;
			//menginput jumlah data siswa yang ingin diinputkan
			Console.WriteLine("		PENDATAAN MAHASISWA UNIVERSITAS INFORMATIKA		");
			Console.WriteLine("=====================================================");

			Console.Write("Masukan Jumlah Mahasiswa = ");
			n = int.Parse(Console.ReadLine());
			//mengisi data yang diinputkan user dengan perulangan For
			for (i = 1; i <= n; i++)
			{
				//menampilkan 'Masukan Data Mahasiswa ke' variable i
				Console.WriteLine("Masukan Data Mahasiswa ke-" + i);
				Console.WriteLine("==========================");
				Console.Write("\n");

				//menampilkan Masukan Nama Mahsiswa
				Console.Write("Masukan Nama Mahasiswa = ");
				Nama[i] = Console.ReadLine();

				//menampilkan Masukan Nomor Induk Mahasiswa
				Console.Write("Masukan Nomor Induk Siswa = ");
				Nim[i] = Console.ReadLine();

				//menampilkan Masukan Jenis Kelamin
				Console.Write("Masukan Jenis Kelamin = ");
				JK[i] = Console.ReadLine();

				//menampilkan Masukan Alamat
				Console.Write("Masukan Alamat = ");
				Alamat[1] = Console.ReadLine();

				//menampilkan Masukan Jurusan
				Console.Write("Masukan Jurusan = ");
				Jurusan[i] = Console.ReadLine();

				//menampilkan Masukan Nama Dosen Kaprodi
				Console.Write("Masukan Nama Dosen Kaprodi = ");
				DK[i] = Console.ReadLine();
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.Write("Data Telah Dimasukan, Tekan Sembarang Untuk Menampilkan Data");
			Console.ReadLine();

			Console.Clear();
			Console.WriteLine("			Pendataan Admintrasi Mahasiswa yang Telah Anda Input	 ");
			Console.WriteLine("==================================================================");
			Console.Write("\n");
			Console.WriteLine("NO | Nama | Nim | Jenis Kelamin | Alamat | Jurusan | Dosen Kaprodi");

			//menampilkan hasil dari data yang telah di masukan oleh user dengan perulangan for 
			for (i = 1; i <= n; i++)
			{
				Console.WriteLine(" " + i + " " + Nama[i] + "\t" + Nim[i] + "\t" + JK[i] + "\t" + Alamat[i] + "\t" + Jurusan[i] + "\t" + DK[i]);



			}
			Console.WriteLine();
			Console.Write("Tekan 'ENTER' Untuk Melanjutkan Nilai Rata.....");
			Console.ReadLine();
		}

		public static void Main(string[] args)
		{
			//memanggil class admnstrasi
			Administrasi Admnst = new Administrasi();
			Admnst.administrasi();
			Console.Write("Masukkan Jumlah Data : ");
			int jml_data = Convert.ToInt32(Console.ReadLine());
			string[] nama = new string[jml_data];
			float[] total = new float[jml_data];

			for (int i = 0; i < jml_data; i++)
			{
				int jumlah = 0;
				Console.WriteLine($"-- Data Ke-{(i + 1)} --");
				Console.Write($"Masukan Nama Ke-{(i + 1)} : ");
				nama[i] = Console.ReadLine();
				Console.Write("Masukkan Jumlah Nilai : ");
				int jml_nilai = Convert.ToInt32(Console.ReadLine());
				float[] nilai = new float[jml_nilai];
				for (int j = 0; j < jml_nilai; j++)
				{
					Console.Write($"Nilai ke={(j + 1)} : ");
					jumlah = Convert.ToInt32(Console.ReadLine());
					nilai[j] = jumlah + nilai[j];
				}
				total[i] = ((nilai.Sum()) / jml_nilai);
			}

			for (int i = 0; i < jml_data; i++)
			{
				Console.WriteLine($"-- Data Ke-{i + 1} --");
				Console.WriteLine("Nama : " + nama[i]);
				Console.WriteLine("Rata-Rata : " + total[i]);
			}


		}

	}
}
	
