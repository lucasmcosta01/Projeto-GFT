using System;

namespace NetSeries
{
    public class Program
    {
        public Repository repository = new();
        
        public static void Main(string[] args)
        {
            UserInterface userInterface = new();
            string optionUser = UserInterface.UserOption();

            while (optionUser.ToUpper()!= "SAIR")
            {
                switch (optionUser.ToUpper())
                {
                    case "VISUALIZAR":
                        userInterface.ListSeries();
                        break;
                    case "ADICIONAR":
                        userInterface.InsertSerie();
                        break;
                    case "ATUALIZAR":
                        userInterface.UpdateSerie();
                        break;
                    case "Excluir":
                        userInterface.DeleteSerie();
                        break;
                    case "INFORMAÇOES":
                        userInterface.ViewSeries();
                        break;
                    case "LIMPAR":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                optionUser = UserInterface.UserOption();

            }

        }
    }
}
