using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABALHO
{
    class Program
    {
        private static List<Menu> ListaMenu = new List<Menu>();
        static void Main(string[] args)
        {

            bool continua = true;
            do
            {
                Console.WriteLine("Menu Cadastro");
                Console.WriteLine("1-Incluir");
                Console.WriteLine("2-Alterar");
                Console.WriteLine("3-Excluir");
                Console.WriteLine("4-Listar");
                Console.WriteLine("5-Pesquisar");
                Console.WriteLine("9-Sair");
                Console.WriteLine("Qual sua opção: ");
                string opc = Console.ReadLine();
                Console.WriteLine(opc);


                switch (opc)
                {

                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("Incluir");
                        ListaMenu.Add(incluir());

                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Alterar");

                        if (ListaMenu.Count ==0)
                        {
                            Console.WriteLine("Não existe cadastro para ser alterado! ");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Write("Digite o ID que deseja alterar: ");
                            string alteracao = Console.ReadLine();
                            Menu auxiliador = ListaMenu.Find(x => x.Id == alteracao);

                            if (auxiliador == null)
                            {
                                Console.WriteLine("ID não encontrado! ");
                                Console.ReadLine();
                            }
                            if (auxiliador != null)
                            {
                                Console.Write("Digite o novo ID: ");
                                Menu modificar = ListaMenu.Find(x => x.Id == alteracao);
                                modificar.Id = Console.ReadLine();
                                Console.Clear();


                            }

                        }                                                                                                                                                   
                         break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Excluir");

                        if (ListaMenu.Count == 0)
                        {
                            Console.Write("Ops, não existem cadastros a serem excluídos!!! ");
                        }
                        else
                        {
                            Console.Write("Informe o ID para exclussão: ");
                            string guardar = Console.ReadLine();
                            if (ListaMenu.Remove(ListaMenu.Find(x => x.Id == guardar)))
                            {
                                Console.WriteLine("Cadastro excluído com sucesso! ");

                            }

                            else
                            {
                                Console.WriteLine("Não encontramos o registro solicitado! ");
                            }
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                                                                      
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Listar");

                        if (ListaMenu.Count == 0)
                        {
                            Console.WriteLine("Não existem registros! ");
                        }
                        else
                        {
                            listar();
                        }
                        Console.ReadLine();
                        Console.Clear();

                        
                        break;
                    case "5":
                        Console.WriteLine("Pesquisar");

                        Console.WriteLine("Digite o ID do cadastro que deseja encontrar: ");
                        string pesquisar = Console.ReadLine();
                        Menu aux = ListaMenu.Find(x => x.Id == pesquisar);
                        if (aux == null)
                        {
                            Console.Write("Ops, cadastro não encontrado!!! ");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("Cadastro encontrado: " + aux);
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        Console.Clear();

                                                                                                                                 


                        break;
                    case "9":
                        continua = false;
                        break;

                    default:
                        Console.WriteLine("Opção não existente!!!");
                        break;

                }


            } while (continua);
            Console.WriteLine("Aplicação encerrada!!!");
            Console.ReadKey();




        }


        private static Menu incluir()

        {
            Menu menu = new Menu();
            Console.Write("ID: ");
            menu.Id = Console.ReadLine();
            Console.Write("Nome: ");
            menu.Nome = Console.ReadLine();
            Console.Write("Fone: ");
            menu.Fone = Console.ReadLine();

            return menu;
        }

        private static void listar()
        {
            foreach (Menu menu in ListaMenu)
            {
               Console.WriteLine(menu);
            }   
           



        }


    }


    }







        
    

