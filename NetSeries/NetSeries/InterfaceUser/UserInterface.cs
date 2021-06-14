using System;
using System.Collections;
using System.Globalization;

namespace NetSeries
{
    public class UserInterface : Program
    {
		public static string UserOption()
		{
			Console.WriteLine();
			Console.WriteLine("Bem vindo a NetSeries");
            Console.WriteLine();
			Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();
			Console.WriteLine("'Visualizar' todas as séries");
			Console.WriteLine("'Adicionar' nova série");
			Console.WriteLine("'Atualizar' série");
			Console.WriteLine("'Excluir' série");
			Console.WriteLine("'Informaçoes' da série");
            Console.WriteLine("'limpar' a tela");
			Console.WriteLine("'Sair' para sair");
			Console.WriteLine();

			string OptionUser = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return OptionUser;
		}
		
		public void ListSeries()
		{
			Console.WriteLine("Listar séries");
			var list = repository.Lista();
			if (list.Count == 0)
			{
				Console.WriteLine("Nenhuma série cadastrada.");
				return;
			}


			foreach (var serie in list)
			{
				var delete = serie.ReturnDeleted();

				Console.WriteLine("#ID {0}: - {1} {2}", serie.ReturnId(), serie.ReturnTitle(), (delete ? "*Excluído*" : ""));
			}
		}
		public void UpdateSerie()
		{
			Console.Write("Digite o id da série: ");
			int indexSerie = int.Parse(Console.ReadLine());

			
			Console.Write("Digite o Título da Série: ");
			string enterTitle = Console.ReadLine(); 

			foreach (int i in Enum.GetValues(typeof(Gender)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}

			Console.Write("Digite o gênero entre as opções acima: ");
			int enterGender = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de Início da Série: ");
			int enterAge = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string enterDescription = Console.ReadLine();

            Console.Write("Digite a Sinopse da Série: ");
			string enterSynopsis = Console.ReadLine();

            Console.Write("Digite a Duração Serie:");
			Console.WriteLine("Use o formato 'HH:mm'!");
			TimeSpan durationSerie = new TimeSpan(1, 30, 30);
			durationSerie = TimeSpan.Parse(Console.ReadLine());

			Series updateSerie = new Series(id: indexSerie,
				                        title: enterTitle,
										gender: (Gender)enterGender,
										age: enterAge,
										description: enterDescription,
										synopsis : enterSynopsis,
										duration : durationSerie);

            repository.Update(indexSerie, updateSerie);
		}
		public void InsertSerie()
        {
			Console.WriteLine("Inserir nova série");

			Console.Write("Digite o Título da Série: ");
			string enterTitle = Console.ReadLine();

			foreach (int i in Enum.GetValues(typeof(Gender)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Gender), i));
			}

			Console.Write("Digite o gênero entre as opções acima: ");
			int enterGender = int.Parse(Console.ReadLine());

			Console.Write("Digite o Ano de Início da Série: ");
			int enterAge = int.Parse(Console.ReadLine());

			Console.Write("Digite a Descrição da Série: ");
			string enterDescription = Console.ReadLine();

			Console.Write("Digite a Sinopse da Série: ");
			string enterSynopsis = Console.ReadLine();

			Console.WriteLine("Digite a Duração Serie:");
            Console.WriteLine("Use o formato 'HH:mm'!");
			
			TimeSpan durationSerie = new TimeSpan (1, 30, 30);
			durationSerie = TimeSpan.Parse(Console.ReadLine());
			

			Series newSerie = new Series(id: repository.NextId(),
										title: enterTitle,
										gender: (Gender)enterGender,
										age: enterAge,
										description: enterDescription,
										synopsis: enterSynopsis,
										duration: durationSerie);

			repository.Insert(newSerie);
		}

		public void ViewSeries()
		{
			Console.Write("Digite o id da série: ");
			int indexSerie = int.Parse(Console.ReadLine());

			var serie = repository.ReturnId(indexSerie);

			Console.WriteLine(serie);
		}

		public void DeleteSerie()
		{
			Console.Write("Digite o id da série: ");
			int indiceSerie = int.Parse(Console.ReadLine());

			repository.Delete(indiceSerie);
		}






	}


}
