using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09Estacionamento
{
	class Program
	{
		static List<string> carros = new List<string> { "______", "______", "______", "______", "______" };
		static void Main(string[] args)
		{
			string escolha;
			string placa;


			Console.WriteLine("---------- Bem vindo ao estacionamento ----------");
			Console.WriteLine("1. Estacionar\n2. Retirar veículo\n3. Listar veículos");
			escolha = Console.ReadLine();

			if (escolha == "1")
			{

				for (int i = 0; i < carros.Count; i++)
				{
					if (carros[i] == "______")
					{

						Console.WriteLine("Digite a placa do seu veículo:");
						placa = Console.ReadLine();
						int contagem = placa.Count();
						if (contagem == 6)
						{


							if (carros.Contains(placa))
							{
								Console.WriteLine("Esse veículo já está estacionado");
								Console.ReadLine();
								Console.Clear();
								Main(null);

								return;

							}

							carros[i] = placa.ToUpper();
							carros.Add(placa.ToUpper());
							Console.WriteLine($"Veiculo de placa {carros[i]} registrado com sucesso.");
							i++;
							Console.ReadLine();
							Console.Clear();
							Main(null);
							return;
						}
						Console.WriteLine("Formato Inválido");
						Console.ReadLine();
						Console.Clear();
						Main(null);

						return;

					}


				}

				Console.WriteLine("------ Estacionamento Lotado ------");
				Console.ReadLine();
				Console.Clear();
				Main(null);

				return;
			}

			if (escolha == "2")
			{
				Console.WriteLine("\n----- RETIRAR -----\n");
				Console.WriteLine("Informe a Placa do veiculo: ");
				string remover = Console.ReadLine();

				for (int i = 0; i < carros.Count; i++)
				{
					if (carros[i] == remover.ToUpper())
					{
						carros.Remove(remover);
						Console.WriteLine("Veiculo removido com sucesso.");
						carros[i] = "______";
						Console.ReadLine();
						Console.Clear();
						Main(null);

						return;


					}
				}

				Console.WriteLine("Carro não localizado");
				Console.ReadLine();
				Console.Clear();
				Main(null);

				return;

			}

			if (escolha == "3")
			{
				
				
				Console.WriteLine($"[{carros[0]}], [{carros[1]}], [{carros[2]}], [{carros[3]}], [{carros[4]}]");
				Console.ReadLine();
				Console.Clear();
				Main(null);

				return;

			}



		}
	}
}

