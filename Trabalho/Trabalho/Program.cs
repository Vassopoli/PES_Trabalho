﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARANDO VETORES
            string[] nmProduto = new string[999];
            string[] corProduto = new string[999];
            string[] cdFabricante = new string[999];
            string[] cdProduto = new string[999];

            //DECLARANDO VARIÁVEIS
            int i;
            char menu;

            // Roda todos os produtos
            for(i = 0; i < 999; i++)
		    {
                //INICIALIZANDO TODOS OS VETORES COM "zzz" (a última letra)
                nmProduto[i] = cdFabricante[i] = corProduto[i] = "zzz";

                // Preenche a esquerda do cdProduto com "0" até o código ter 3 casas. Ex.: 001, 010, 100
                cdProduto[i] = cdProduto[i].PadLeft(3, '0');
            }

            //ALIMENTANDO VETORES COM 15 VALORES CADA
            Alimenta15(ref cdProduto, ref nmProduto, ref cdFabricante, ref corProduto);

            //LAÇO DO MENU PRINCIPAL
            do
            {
                Console.Clear();
                Console.Write("O que deseja?\n");
                Console.Write("1. Incluir produto\n");
                Console.Write("2. Alterar produto\n");
                Console.Write("3. Excluir produto\n");
                Console.Write("4. Listagem dos produtos\n");
                Console.Write("5. Finalizar\n");
                Console.Write("Opção desejada: ");

                menu = char.Parse(Console.ReadLine());

                Console.Clear();

                //ESCOLHA DO USUÁRIO LEVA A UMA FUNÇÃO DE ALTERAR OU MENU DE LISTAS	
                switch (menu)
                {
                    case '1': IncluirProduto(ref cdProduto, ref nmProduto, ref cdFabricante, ref corProduto); break;
                    case '2': AlterarProduto(ref cdProduto, ref nmProduto, ref cdFabricante, ref corProduto); break;
                    case '3': ExcluirProduto(ref cdProduto, ref nmProduto, ref cdFabricante, ref corProduto); break;
                    case '4': MenuListagem(cdProduto, nmProduto, cdFabricante, corProduto); break;
                }
            }
            while (menu != '5');
            Console.Write("Programa Encerrado! Obrigado!");
        }

        static void Alimenta15(ref string[] cdProduto, ref string[] nmProduto, ref string[] cdFabricante, ref string[] corProduto)
        {
            nmProduto[0] = "BLUSA";
            nmProduto[1] = "BOLSA";
            nmProduto[2] = "CALÇA";
            nmProduto[3] = "CALÇA JEANS";
            nmProduto[4] = "BERMUDA";
            nmProduto[5] = "CAMISA";
            nmProduto[6] = "CAMISETA";
            nmProduto[7] = "CASACO";
            nmProduto[8] = "JAQUETA";
            nmProduto[9] = "LUVAS";
            nmProduto[10] = "MEIAS";
            nmProduto[11] = "ROUPAS DE BAIXO";
            nmProduto[12] = "ROUPAS DE BANHO";
            nmProduto[13] = "SAIA";
            nmProduto[14] = "SAPATOS";

            cdFabricante[0] = "AAA";
            cdFabricante[1] = "AAB";
            cdFabricante[2] = "AAC";
            cdFabricante[3] = "AAD";
            cdFabricante[4] = "AAE";
            cdFabricante[5] = "AAF";
            cdFabricante[6] = "AAG";
            cdFabricante[7] = "AAH";
            cdFabricante[8] = "AAI";
            cdFabricante[9] = "AAJ";
            cdFabricante[10] = "AAK";
            cdFabricante[11] = "AAL";
            cdFabricante[12] = "AAM";
            cdFabricante[13] = "AAN";
            cdFabricante[14] = "AAO";

            corProduto[0] = "AMARELO";
            corProduto[1] = "AZUL";
            corProduto[2] = "BRANCO";
            corProduto[3] = "AZUL";
            corProduto[4] = "CINZA";
            corProduto[5] = "LARANJA";
            corProduto[6] = "MARROM";
            corProduto[7] = "ROSA";
            corProduto[8] = "ROXO";
            corProduto[9] = "PRETO";
            corProduto[10] = "TURQUESA";
            corProduto[11] = "VERDE";
            corProduto[12] = "VERMELHO";
            corProduto[13] = "ROXO";
            corProduto[14] = "CINZA";
        }

        static void IncluirProduto(ref string[] cdProduto, ref string[] nmProduto, ref string[] cdFabricante, ref string[] corProduto)
        {
            // Declando variáveis	
            string espaco;
            int i = 0;

            for(i = 0; i <= 999; i++)
		    {
                if(i == 999)
                {
                    Console.Write("não há mais espaço para inclusão");
                    break;
                }
                else if(nmProduto[i] == "zzz")
                {
                    Console.Write("Para um novo produto digite:\n\n");
                    Console.Write("O nome: ");

                    nmProduto[i] = Console.ReadLine();

                    nmProduto[i] = nmProduto[i].ToUpper();

                    Console.Write("O Código do Fabricante no formato 'AAA' ");

                    cdFabricante[i] = Console.ReadLine();

                    cdFabricante[i] = cdFabricante[i].ToUpper();

                    Console.Write("E a cor (Substantivo em masculino Ex.: Preto, Vermelho): ");

                    corProduto[i] = Console.ReadLine();

                    corProduto[i] = corProduto[i].ToUpper();

                    Console.Write("\nO seguinte produto: \n");

                    // formata o que será exibido conforme o tamanho da palavra do produto
                    espaco = "";

                    for(int c = nmProduto[i].Length; c < 20; c++)
				    {
                        espaco = espaco + " ";

                    }

                    // Exibe
                    Console.Write("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n");

                    // Console.Write("Codigo: ", cdProduto [i]," Código do Fabricante:  ",  cdFabricante [i], " ", nmProduto [i]," "," Cor: ", corProduto[i], "\n");
                    Console.Write("Foi incluido!\n-----------------------------------------------------------------\n");
                    Console.Write("Pressione Enter para retornar ao menu...");

                    Console.ReadKey();
                    break;
                }
            }
        }

        static void AlterarProduto(ref string[] cdProduto, ref string[] nmProduto, ref string[] cdFabricante, ref string[] corProduto)
        {
            // Declarando variáveis
            int i, sn, sn2;

            string codigo, guardarCod, guardarNome, guardarCodFab, guardarCor, espaco;

            Console.WriteLine("Insira o Código do produto que deseja alterar: ");
            codigo = Console.ReadLine();

            codigo = codigo.PadLeft(3,'0');
            Console.Clear();

            for (i = 0; i < 999; i++)
            {
                if (cdProduto[i] == codigo)
                {
                    // formata o que será exibido conforme o tamanho da palavra do produto
                    espaco = "";

                    for (int c = nmProduto[i].Length; c < 20; c++)
                    {
                        espaco = espaco + " ";
                    }

                    // Exibe
                    Console.WriteLine("O produto à seguir será alterado:\n");

                    Console.WriteLine("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i]);

                    //variaveis que guardam o vetor inicial
                    guardarCod = cdProduto[i];

                    guardarNome = nmProduto[i];

                    guardarCodFab = cdFabricante[i];

                    guardarCor = corProduto[i];

                    //Confirmaão do usuário
                    Console.WriteLine("\n\nEste é o Produto que deseja alterar? 1.SIM  2.NÃO");

                    Console.WriteLine("\nOpção desejada: ");

                    sn = int.Parse(Console.ReadLine());

                    Console.Clear();

                    if (sn == 1)

                    {
                        Console.WriteLine("Insira o novo código do fabricante: ");

                        cdFabricante[i] = Console.ReadLine();

                        cdFabricante[i] = cdFabricante[i].ToUpper();

                        Console.WriteLine("Digite nome do Produto: ");

                        nmProduto[i] = Console.ReadLine();

                        //nmProduto[i] = tx.caixa_alta(nmProduto[i])

                        Console.WriteLine("Insira a nova cor: ");

                        corProduto[i] = Console.ReadLine();

                        //corProduto[i] = tx.caixa_alta(corProduto[i])

                        //Exibe o Novo Produto
                        Console.WriteLine("\nCódigo: ", cdProduto[i]);

                        // formata o que será exibido conforme o tamanho da palavra do produto
                        espaco = "";

                        for (int c = guardarNome.Length; c < 20; c++)
                        {
                            espaco = espaco + " ";

                        }

                        // Exibe
                        Console.WriteLine("\nAntes-->  Fabric.: ", guardarCodFab, " | Prod.: ", guardarNome, espaco, " | Cor: ", guardarCor);

                        // formata o que será exibido conforme o tamanho da palavra do produto
                        espaco = "";

                        for (int c = nmProduto[i].Length; c < 20; c++)
                        {
                            espaco = espaco + " ";

                        }

                        // Exibe
                        Console.WriteLine("\nDepois--> Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i]);

                        //Confirmação do Usuário
                        Console.WriteLine("\nConfirma a alteração? 1.SIM 2.NÃO ");

                        Console.WriteLine("\nOpção desejada: ");

                        sn2 = int.Parse(Console.ReadLine());

                        if (sn2 == 1)

                        {
                            Console.WriteLine("Produto Alterado com Sucesso!\n-----------------------------------------------------------------\n");
                            Console.WriteLine("Pressione Enter para retornar ao menu...");
                            Console.ReadKey();

                        }

                        //retorna os valores iniciais do vetor selecionado
                        else
                        {
                            cdProduto[i] = guardarCod;

                            nmProduto[i] = guardarNome;

                            cdFabricante[i] = guardarCodFab;

                            corProduto[i] = guardarCor;

                            Console.WriteLine("\nProduto não alterado");

                        }
                    }
                    else
                    {
                        Console.WriteLine("\nProduto não alterado!");
                        Console.ReadKey();
                    }

                    //Vacilou
                    if (i == 998)
                    {
                        Console.WriteLine("Produto não existe, favor verificar a lista.");
                        Console.WriteLine("\nPressione Enter para retornar ao menu... ");
                        Console.ReadKey();
                    }
                }
            }
        }

        static void ExcluirProduto(ref string[] cdProduto, ref string[] nmProduto, ref string[] cdFabricante, ref string[] corProduto)
        {
            // FUNÇÃO muda o valor do item buscado "zzz" o excluindo
            string excluido, espaco;
            int i, sn;
            Console.WriteLine("Digite o código do produto que deseja excluir: ");
            excluido = Console.ReadLine();
            excluido = excluido.PadLeft(3, '0');
            Console.Clear();
            //laço para encontrar o vetor código
            for(i = 0; i < 999; i++)
		    {
                if(cdProduto[i] == excluido)
                {
                    // formata o que será exibido conforme o tamanho da palavra do produto
                    espaco = "";

                    for(int c = nmProduto[i].Length; c < 20; c++)
				    {
                        espaco = espaco + " ";
                    }

                    // Exibe
                    Console.WriteLine("O produto à seguir será excluído:\n");

                    Console.WriteLine("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i]);

                    //Chance para o Usuário desistir
                    Console.WriteLine("\n\nConfirma a exclusão? 1.SIM 2.NÃO  ");
                    Console.WriteLine("\nOpção desejada: ");
                    sn = int.Parse(Console.ReadLine());

                    if(sn == 1)
                    {
                        nmProduto[i] = cdFabricante[i] = corProduto[i] = "zzz";
                        Console.WriteLine("\nO produto foi excluido");
                    }
                    else
                    {
                        Console.WriteLine("\nO produto não foi excluido");
                    }
                    Console.WriteLine("\nPressione Enter para retornar ao menu...");

                    Console.ReadKey();
                }
                //Vacilou
                if(i == 998)
                {
                    Console.WriteLine("Produto não existe, favor verificar a lista.");
                    Console.WriteLine("Pressione Enter para retornar ao menu...");
                    Console.ReadKey();
                }
            }
        }

        static void MenuListagem(string[] cdProduto, string[] nmProduto, string[] cdFabricante, string[] corProduto)
        {
            char listagem;

            Console.WriteLine("Qual tipo de lista deseja ver? \n");
            Console.WriteLine("1. Produtos ordenados por nome (em ordem alfabetica de um ponto a outro)\n");
            Console.WriteLine("2. Listagem dos produtos por código\n");
            Console.WriteLine("3. Exibir produtos de determinado fabricante\n");
            Console.WriteLine("4. Exibição dos produtos pertencentes a detemrinada cor\n");
            Console.WriteLine("5. Listagem de todos os produtos em estoque com todas as informações existentes sobre cada um dos produtos\n");

            listagem = char.Parse(Console.ReadLine());

            Console.Clear();    
    
            switch(listagem)
            {
                case '1': ListaNome(cdProduto, nmProduto, cdFabricante, corProduto); break;
                case '2': ListaCod(cdProduto, nmProduto, cdFabricante, corProduto); break;
                case '3': ListaFab(cdProduto, nmProduto, cdFabricante, corProduto); break;
                case '4': ListaCor(cdProduto, nmProduto, cdFabricante, corProduto); break;
                case '5': Lista(cdProduto, nmProduto, cdFabricante, corProduto); break;
            }
        }

        static void ListaNome(string[] cdProduto, string[] nmProduto, string[] cdFabricante, string[] corProduto)
        {
            string auxCad, nmInicial, nmFinal, espaco;
            int x, y, i, cont;

            Console.Write("Qual a letra inicial: ");
            nmInicial = Console.ReadLine();
            nmInicial = nmInicial.ToUpper();

            Console.Write("Qual a letra final: ");
            nmFinal = Console.ReadLine();
            nmFinal = nmFinal.ToUpper();

            // Verifica se a letra inicial não é maior que a letra final
            if (string.Compare(nmInicial, nmFinal)==1)
            {
                Console.Write("ERRO! A letra inicial maior que final.");
            }
            //Verifica se foram digitados números
            else if (!Regex.IsMatch(nmInicial, @"^[a-zA-Z]+$") || !Regex.IsMatch(nmFinal, @"^[a-zA-Z]+$"))
		    {
                Console.Write("Digite somente letras!");
            }
            else
            {
                // Reordena no método alfabético
                for(x = 0; x < 998; x++)
			    {
                    for(y = x + 1; y < 999; y++)
	
				    if(string.Compare(nmProduto[x], nmProduto[y])==1)
                    {
                        auxCad = nmProduto[x];
                        nmProduto[x] = nmProduto[y];
                        nmProduto[y] = auxCad;

                        auxCad = cdProduto[x];
                        cdProduto[x] = cdProduto[y];
                        cdProduto[y] = auxCad;

                        auxCad = cdFabricante[x];
                        cdFabricante[x] = cdFabricante[y];
                        cdFabricante[y] = auxCad;

                        auxCad = corProduto[x];
                        corProduto[x] = corProduto[y];
                        corProduto[y] = auxCad;
                    }
                }
                Console.Clear();

                //Produtos em ordem alfabética no intervalo especificado
                Console.Write("Todos os produtos de ", nmInicial, " até ", nmFinal, " em Ordem Alfabética \n\n");

                cont = 0;

                nmFinal = nmFinal + "zzzzz";


                for(i = 0; i < 999; i++)
			    {
                    if(nmProduto[i] != "zzz" && string.Compare (nmInicial, nmFinal)==1 && string.Compare (nmProduto[i], nmInicial)==1 &&string.Compare (nmProduto[i], nmFinal)==1)
                    {
                        // formata o que será exibido conforme o tamanho da palavra do produto
                        espaco = "";

                        for(int c = nmProduto[i].Length; c < 20; c++)
					    {
                            espaco = espaco + " ";
                        }

                        // Exibe
                        cont++;
                        Console.Write("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n");
                    }
                }

                //Validação dos dados inseridos
                if(cont != 0)
                {
                    Console.Write("Encontrado(s) ", cont, " produtos");
                }

                if(i == 998 || cont == 0)
                {
                    Console.Write("Não existem produtos nesta faixa: ");
                }
            }
            Console.Write("\nPressione Enter para retornar ao menu... ");
            Console.ReadKey();
    }

        static void ListaCod(string[] cdProduto, string[] nmProduto, string[] cdFabricante, string[] corProduto)
        {
            //declarando variáveis
            string auxCad, cdInicial, cdFinal, espaco;
            int x, y, i, cont;

            //Inicializar variáveis 
            Console.Write("Qual o número inicial: ");
            cdInicial = Console.ReadLine();
            cdInicial = cdInicial.PadLeft(3,'0');

            Console.Write("Qual a número final: ");
            cdFinal = Console.ReadLine();
            cdFinal = cdFinal.PadLeft(3,'0');

            if(string.Compare(cdInicial, cdFinal)==1)
            {
                Console.Write("ERRO! O número inicial  é maior que o final.");
            }
            else if(Regex.IsMatch(cdInicial, @"^[a-zA-Z]+$") || Regex.IsMatch(cdFinal, @"^[a-zA-Z]+$"))
		    {
                Console.Write("Digite somente números!");
            }
            else
            {
                //Rotina Ordena todos os vetores
                for(x = 0; x < 998; x++)
			    {
                    for (y = x + 1; y < 999; y++)
                    {
                        if (string.Compare (cdProduto[x], cdProduto[y])==1)
                        {
                            auxCad = nmProduto[x];
                            nmProduto[x] = nmProduto[y];
                            nmProduto[y] = auxCad;

                            auxCad = cdProduto[x];
                            cdProduto[x] = cdProduto[y];
                            cdProduto[y] = auxCad;

                            auxCad = cdFabricante[x];
                            cdFabricante[x] = cdFabricante[y];
                            cdFabricante[y] = auxCad;

                            auxCad = corProduto[x];
                            corProduto[x] = corProduto[y];
                            corProduto[y] = auxCad;
                        }
                    }
                }
                Console.Clear();

                //Produtos em ordem alfabética no intervalo
                Console.Write("Todos os produtos de ", cdInicial, " até ", cdFinal, " em Ordem Alfabética \n\n");
                cdFinal = cdFinal + "zzzzz";
                cont = 0;

                for(i = 0; i < 999; i++)
                {
                    if (cdProduto[i] != "zzz" && string.Compare(cdInicial , cdFinal)==1 && string.Compare(cdProduto[i], cdInicial)==1 && string.Compare(cdProduto[i], cdFinal)==1)
                    {
                        // formata o que será exibido conforme o tamanho da palavra do produto
                        espaco = "";

                        for (int c = nmProduto[i].Length; c < 20; c++) 
                        {
                            espaco = espaco + " ";
                        }

                        // Exibe
                        cont++;
                        Console.Write("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n");
                    }
                }
            //Validação dos dados inseridos do USUÁRIO
            if(cont != 0)
            {
                Console.Write("Encontrado(s) ", cont, " produtos");
            }

            if(i == 998 || cont == 0)
            {
                Console.Write("\nNão existem produtos nesta faixa: ");
            }
        }
        Console.Write("\nPressione Enter para retornar ao menu... ");
        Console.ReadKey();
    }

        static void ListaFab(string [] cdProduto, string[] nmProduto, string [] cdFabricante, string [] corProduto)
        {
            string fab, espaco;
            int i;

            Console.WriteLine("Qual Fabricante procura? ");
            fab = Console.ReadLine();
            fab = fab.ToUpper();

            Console.Clear();
        
            for(i = 0; i < 999; i++)
		    {
                if(cdFabricante[i] == fab)
                {
                    // formata o que será exibido conforme o tamanho da palavra do produto
                    espaco = "";

                    for(int c =i; c < 20; c++)
				    {
                        espaco = espaco + " ";
                    }

                    // Exibe
                    Console.WriteLine("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n");
                }
            }
            Console.WriteLine("\nPressione Enter para retornar ao menu... ");
            Console.ReadKey();
        }

        static void ListaCor(string[] cdProduto, string[] nmProduto, string[] cdFabricante, string[] corProduto)
        {
            string cor, espaco;
            int i;

            Console.WriteLine("Qual Cor procura? ");
            cor = Console.ReadLine();
            cor = cor.ToUpper();
            Console.Clear();
    
            for(i = 0; i < 999; i++)
		    {
                if(corProduto[i] == cor)
                {
                    // formata o que será exibido conforme o tamanho da palavra do produto
                    espaco = "";

                    for(int c =i; c < 20; c++)
				    {
                        espaco = espaco + " ";
                    }

                    // Exibe
                    Console.WriteLine("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n");
                }
            }
            Console.WriteLine("\nPressione Enter para retornar ao menu... ");
            Console.ReadKey();
        }

        static void Lista(string[] cdProduto, string[] nmProduto, string[] cdFabricante, string[] corProduto)
        {
            int i, totaItens = 0;
            string espaco;
    
            for(i = 0; i < 999; i++)
		    {
                if(nmProduto[i] != "zzz")
                {
                    // formata o que será exibido conforme o tamanho da palavra do produto
                    espaco = "";

                    for(int c = i; c < 20; c++)
				    {
                        espaco = espaco + " ";
                    }

                    // Exibe
                    Console.WriteLine("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n");
                    totaItens = i;
                }
            }
            totaItens++;
            Console.WriteLine("\nTotal de " + totaItens + " itens na lista\n");
            Console.WriteLine("Pressione Enter para retornar ao menu...");
            Console.ReadKey();
        }
    }
}
