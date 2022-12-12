using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create
{
	public class Program
	{
		static int[] ID = { };
		static string[] FirstName = { };
		static string[] LastName = { };
		static string[] UserName = { };
		static string[] Password = { };
		static int id = ID.Length;
		public static void Main(string[] args)
		{
			Create();
		}

		static void Create()
		{
			Console.Clear();
			Console.Write("First Name: ");
			string firstname = Console.ReadLine();
			Console.Write("Last Name: ");
			string lastName = Console.ReadLine();
			Console.Write("Password: ");
			string password = Console.ReadLine();
			CekPassword(password); //Fungsi untuk cek password
			User(firstname, lastName, password); //FUNGSI UNTUK Create User
			Console.WriteLine();
			Console.WriteLine("Data user berhasil dibuat");
			Console.ReadKey();
		}

		//USER
		static void User(string firstName, string lastName, string password)
		{
			id = id + 1;
			ID = ID.Append(id).ToArray();
			FirstName = FirstName.Append(firstName).ToArray();
			LastName = LastName.Append(lastName).ToArray();
			UserName = UserName.Append(firstName.Substring(0, 2) + lastName.Substring(0, 2)).ToArray();
			Password = Password.Append(password).ToArray();
		}
		//CEK PASSWORD
		static string CekPassword(string password)
		{
			while (true)
			{
				bool flag = true;
				if ((password.Length > 7) && (Enumerable.Any<char>((IEnumerable<char>)password, new Func<char, bool>(char.IsUpper)) && (Enumerable.Any<char>((IEnumerable<char>)password, new Func<char, bool>(char.IsLower)) && Enumerable.Any<char>((IEnumerable<char>)password, new Func<char, bool>(char.IsNumber)))))
				{
					flag = false;
				}
				else
				{
					Console.WriteLine("\nPassword must have at least 8 characters\n with at least one Capital letter, at least one lower case letter and at least one number.");
					Console.Write("Password: ");
					password = Console.ReadLine();
					flag = true;
				}
				if (!flag)
				{
					return password;
				}
			}
		}
	}
	
}


