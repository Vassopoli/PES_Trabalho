using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                cdProduto[i] = tx.preencher_a_esquerda('0', 3, tp.inteiro_para_cadeia(i + 1, 10));
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
                    case '3': ExcluirProduto(cdProduto, nmProduto, cdFabricante, corProduto); break;
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

                    for(int c = tx.numero_caracteres(nmProduto[i]); c < 20; c++)
				    {
                        espaco = espaco + " ";

                    }

                    // Exibe
                    Console.Write("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n");

                    // escreva("Codigo: ", cdProduto [i]," Código do Fabricante:  ",  cdFabricante [i], " ", nmProduto [i]," "," Cor: ", corProduto[i], "\n")
                    Console.Write("Foi incluido!\n-----------------------------------------------------------------\n");
                    Console.Write("Pressione Enter para retornar ao menu...");

                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
