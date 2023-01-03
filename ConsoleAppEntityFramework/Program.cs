// See https://aka.ms/new-console-template for more information
using ConsoleAppEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Diagnostics;
using System.Text;

namespace ConsoleAppEntityFramework
{
	class Program
	{
		public static Random rand = new Random();
		public static Stopwatch stopwatch = new Stopwatch();

		public static void Main(string[] args)
		{
			EFContext context = new EFContext();

			return;

			try
			{
				string[] fileContent = File.ReadAllLines(@"C:\Users\qaleg\Downloads\Utilisateurs.csv",Encoding.GetEncoding("ISO-8859-1"));
				List<string> errorLines = new List<string>();
				for (int i = 1; i < fileContent.Length; i++)
				{
					string line = fileContent[i];

					Client c = CSV_Parver.GetClient(line);
					if (c == null)
						errorLines.Add($"line {i} can't be parsed : {line}");
					else

						DatabaseMng.Instance.Clients.Add(c);
				}
				Console.WriteLine($"Parsing End ! {((float)(fileContent.Length-1-errorLines.Count)/(float)(fileContent.Length-1)*100f)} % ");
				DatabaseMng.Instance.Save();
				Console.WriteLine("Saving done !");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error : "+ex.Message);
			}
			//List<long> times = new List<long>();

			//EState[] states = (EState[])Enum.GetValues(typeof(EState));

			//for (int i = 0; i < 100; i++)
			//{
			//	stopwatch.Restart();
			//	stopwatch.Stop();
			//	times.Add(stopwatch.ElapsedMilliseconds);
			//}
			//stopwatch.Restart();
			//context.SaveChanges();
			//stopwatch.Stop();

			//Console.WriteLine("item add in data base in : "+times.Average());
			//Console.WriteLine("database saved in: " + stopwatch.ElapsedMilliseconds);

		}
	}

	public class CSV_Parver
	{
		public static Client GetClient(string line)
		{
			if (!line.Contains(";"))
				return null;

			string[] col = line.Split(';');

			try
			{

				string userId = col[0];
				string linker = col[1];
				string userName = col[2];
				string lastName = col[3];
				string wallet = col[4];
				string creationDate = col[5];
				string lastUpdate = col[6];
				string login = col[7];
				string mail = col[8];
				string password = col[9];
				string phone = col[10];

				Client c = new Client();
				c.UserRegistreryToken = new RegistreryToken();
				c.UserRegistreryToken.RegistreryTokenID = Guid.NewGuid();
				c.UserRegistreryToken.RegistreryTokenEnabled = true;
				c.UserRegistreryToken.RegistreryTokenExpiredDate = (DateTime.Now+ new TimeSpan(700,0,0, 0, 0));

				c.UserID = Guid.Parse(userId);
				c.ClientLinkerFeatureEnabled = linker == "1";
				c.ClientFirstName = userName;
				c.ClientLastName = lastName;
				c.ClientWallet = int.Parse(wallet) * 100;
				c.RgpdObjectCreatedAt = DateTime.Parse(creationDate);
				c.RgpdObjectLastWrite = DateTime.Parse(lastUpdate);
				c.UserLogin = login;
				c.UserEmail = mail;
				c.UserPassword = password;
				c.UserPhone = phone;

				return c;
			}
			catch
			{
				return null;
			}
		}
	}

}

