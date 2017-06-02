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

        static void AlterarProduto(cadeia &cdProduto[], cadeia &nmProduto[], cadeia &cdFabricante[], cadeia &corProduto[])
        {
            // Declarando variáveis
            inteiro i, sn, sn2

        cadeia codigo, nada, guardarCod, guardarNome, guardarCodFab, guardarCor, espaco


        escreva("Insira o Código do produto que deseja alterar: ")

        leia(codigo)

        codigo = tx.preencher_a_esquerda('0', 3, codigo)

        limpa()


        para(i = 0; i < 999; i++)
		{
                se(cdProduto[i] == codigo)

            {
                    // formata o que será exibido conforme o tamanho da palavra do produto
                    espaco = ""

                para(inteiro c = tx.numero_caracteres(nmProduto[i]); c < 20; c++)
				{
                        espaco = espaco + " "

                }

                    // Exibe
                    escreva("O produto à seguir será alterado:\n")

                escreva("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i])

                //variaveis que guardam o vetor inicial
                    guardarCod = cdProduto[i]

                guardarNome = nmProduto[i]

                guardarCodFab = cdFabricante[i]

                guardarCor = corProduto[i]

                //Confirmaão do usuário
                    escreva("\n\nEste é o Produto que deseja alterar? 1.SIM  2.NÃO")

                escreva("\nOpção desejada: ")

                leia(sn)

                limpa()

                se(sn == 1)

                {
                        escreva("Insira o novo código do fabricante: ")

                    leia(cdFabricante[i])

                    cdFabricante[i] = tx.caixa_alta(cdFabricante[i])

                    escreva("Digite nome do Produto: ")

                    leia(nmProduto[i])

                    nmProduto[i] = tx.caixa_alta(nmProduto[i])

                    escreva("Insira a nova cor: ")

                    leia(corProduto[i])

                    corProduto[i] = tx.caixa_alta(corProduto[i])

                    //Exibe o Novo Produto
                        escreva("\nCódigo: ", cdProduto[i])

                    // formata o que será exibido conforme o tamanho da palavra do produto
                        espaco = ""

                    para(inteiro c = tx.numero_caracteres(guardarNome); c < 20; c++)
					{
                            espaco = espaco + " "

                    }

                        // Exibe
                        escreva("\nAntes-->  Fabric.: ", guardarCodFab, " | Prod.: ", guardarNome, espaco, " | Cor: ", guardarCor)

                    // formata o que será exibido conforme o tamanho da palavra do produto
                        espaco = ""

                    para(inteiro c = tx.numero_caracteres(nmProduto[i]); c < 20; c++)
					{
                            espaco = espaco + " "

                    }

                        // Exibe
                        escreva("\nDepois--> Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i])

                    //Confirmação do Usuário
                        escreva("\nConfirma a alteração? 1.SIM 2.NÃO ")

                    escreva("\nOpção desejada: ")

                    leia(sn2)

                    se(sn2 == 1)

                    {
                            escreva("Produto Alterado com Sucesso!\n-----------------------------------------------------------------\n")

                        escreva("Pressione Enter para retornar ao menu...")

                        leia(nada)

                        pare

                    }

                        //retorna os valores iniciais do vetor selecionado
                        senao

                    {
                            cdProduto[i] = guardarCod

                        nmProduto[i] = guardarNome

                        cdFabricante[i] = guardarCodFab

                        corProduto[i] = guardarCor

                        escreva("\nProduto não alterado")

                        pare

                    }
                    }
                    senao

                {
                        escreva("\nProduto não alterado!")

                    leia(nada)

                    pare

                }
                }
                //Vacilou
                se(i == 998)

            {
                    escreva("Produto não existe, favor verificar a lista.")

                escreva("\nPressione Enter para retornar ao menu... ")

                leia(nada)

                pare

            }
            }
        }

        static void ExcluirProduto(cadeia &cdProduto[], cadeia &nmProduto[], cadeia &cdFabricante[], cadeia &corProduto[])
        {
            // FUNÇÃO muda o valor do item buscado "zzz" o excluindo
            cadeia excluido, nada, auxCad, espaco
    
        inteiro i, sn, x, y
    

        escreva("Digite o código do produto que deseja excluir: ")
    
        leia(excluido)
    
        excluido = tx.preencher_a_esquerda('0', 3, excluido)
    
        limpa()
            //laço para encontrar o vetor código
            para(i = 0; i < 999; i++)
		{
                se(cdProduto[i] == excluido)

            {
                    // formata o que será exibido conforme o tamanho da palavra do produto
                    espaco = ""

                para(inteiro c = tx.numero_caracteres(nmProduto[i]); c < 20; c++)
				{
                        espaco = espaco + " "

                }

                    // Exibe
                    escreva("O produto à seguir será excluído:\n")

                escreva("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i])

                //Chance para o Usuário desistir
                    escreva("\n\nConfirma a exclusão? 1.SIM 2.NÃO  ")

                escreva("\nOpção desejada: ")

                leia(sn)

                se(sn == 1)

                {
                        nmProduto[i] = cdFabricante[i] = corProduto[i] = "zzz"

                    escreva("\nO produto foi excluido")

                }
                    senao

                {
                        escreva("\nO produto não foi excluido")

                }
                    escreva("\nPressione Enter para retornar ao menu...")

                leia(nada)

                pare


            }
                //Vacilou
                se(i == 998)

            {
                    escreva("Produto não existe, favor verificar a lista.")

                escreva("Pressione Enter para retornar ao menu...")

                leia(nada)

                pare

            }
            }
        }

        static void MenuListagem(cadeia cdProduto[], cadeia nmProduto[], cadeia cdFabricante[], cadeia corProduto[])
        {
            caracter listagem
    
        escreva("Qual tipo de lista deseja ver? \n")
    

        escreva("1. Produtos ordenados por nome (em ordem alfabetica de um ponto a outro)\n")
    
        escreva("2. Listagem dos produtos por código\n")
    
        escreva("3. Exibir produtos de determinado fabricante\n")
    
        escreva("4. Exibição dos produtos pertencentes a detemrinada cor\n")
    
        escreva("5. Listagem de todos os produtos em estoque com todas as informações existentes sobre cada um dos produtos\n")
    

        leia(listagem)
    
        limpa()
    
        escolha(listagem)
    
        {
                caso '1': ListaNome(cdProduto, nmProduto, cdFabricante, corProduto) pare
               caso '2': ListaCod(cdProduto, nmProduto, cdFabricante, corProduto) pare
              caso '3': ListaFab(cdProduto, nmProduto, cdFabricante, corProduto) pare
             caso '4': ListaCor(cdProduto, nmProduto, cdFabricante, corProduto) pare
            caso '5': Lista(cdProduto, nmProduto, cdFabricante, corProduto) pare

        }
        }

        static void ListaNome(cadeia cdProduto[], cadeia nmProduto[], cadeia cdFabricante[], cadeia corProduto[])
        {
            cadeia auxCad, nada, nmInicial, nmFinal, espaco
    
        inteiro x, y, i, cont
    
        escreva("Qual a letra inicial: ")
    
        leia(nmInicial)
    
        nmInicial = tx.caixa_alta(nmInicial)
    
        escreva("Qual a letra final: ")
    
        leia(nmFinal)
    
        nmFinal = tx.caixa_alta(nmFinal)
    
        // Verifica se a letra inicial não é maior que a letra final
            se(nmInicial > nmFinal)
    
        {
                escreva("ERRO! A letra inicial maior que final.")

        }
            //Verifica se foram digitados números
            senao se(tp.cadeia_e_inteiro(nmInicial, 10) == verdadeiro ou tp.cadeia_e_inteiro(nmFinal, 10) == verdadeiro)
		{
                escreva("Digite somente letras!")

        }
            senao
    
        {
                // Reordena no método alfabético
                para(x = 0; x < 998; x++)
			{
                    para(y = x + 1; y < 999; y++)
	
				se(nmProduto[x] > nmProduto[y])

                {
                        auxCad = nmProduto[x]

                    nmProduto[x] = nmProduto[y]

                    nmProduto[y] = auxCad


                    auxCad = cdProduto[x]

                    cdProduto[x] = cdProduto[y]

                    cdProduto[y] = auxCad


                    auxCad = cdFabricante[x]

                    cdFabricante[x] = cdFabricante[y]

                    cdFabricante[y] = auxCad


                    auxCad = corProduto[x]

                    corProduto[x] = corProduto[y]

                    corProduto[y] = auxCad

                }
                }
                limpa()

            //Produtos em ordem alfabética no intervalo especificado
                escreva("Todos os produtos de ", nmInicial, " até ", nmFinal, " em Ordem Alfabética \n\n")

            cont = 0

            nmFinal = nmFinal + "zzzzz"


            para(i = 0; i < 999; i++)
			{
                    se(nmProduto[i] != "zzz" e nmInicial <= nmFinal e nmProduto[i] >= nmInicial e nmProduto[i] <= nmFinal)

                {
                        // formata o que será exibido conforme o tamanho da palavra do produto
                        espaco = ""

                    para(inteiro c = tx.numero_caracteres(nmProduto[i]); c < 20; c++)
					{
                            espaco = espaco + " "

                    }

                        // Exibe
                        cont++

                    escreva("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n")

                }
                }

                //Validação dos dados inseridos
                se(cont != 0)

            {
                    escreva("Encontrado(s) ", cont, " produtos")

            }

                se(i == 998 ou cont == 0)

            {
                    escreva("Não existem produtos nesta faixa: ")

            }
            }
            escreva("\nPressione Enter para retornar ao menu... ")
    
        leia(nada)
    
    }

        static void ListaCod(cadeia cdProduto[], cadeia nmProduto[], cadeia cdFabricante[], cadeia corProduto[])
        {
            //declarando variáveis
            cadeia auxCad, nada, cdInicial, cdFinal, espaco
    
        inteiro x, y, i, cont
    
        //Inicializar variáveis 
            escreva("Qual o número inicial: ")
    
        leia(cdInicial)
    
        cdInicial = tx.preencher_a_esquerda('0', 3, cdInicial)
    
        escreva("Qual a número final: ")
    
        leia(cdFinal)
    
        cdFinal = tx.preencher_a_esquerda('0', 3, cdFinal)
    

        se(cdInicial > cdFinal)
    
        {
                escreva("ERRO! O número inicial  é maior que o final.")

        }
            senao se(tp.cadeia_e_inteiro(cdInicial, 10) == falso ou tp.cadeia_e_inteiro(cdFinal, 10) == falso)
		{
                escreva("Digite somente números!")

        }
            senao
    
        {
                //Rotina Ordena todos os vetores
                para(x = 0; x < 998; x++)
			{
                    para(y = x + 1; y < 999; y++)
	
				se(cdProduto[x] > cdProduto[y])

                {
                        auxCad = nmProduto[x]

                    nmProduto[x] = nmProduto[y]

                    nmProduto[y] = auxCad


                    auxCad = cdProduto[x]

                    cdProduto[x] = cdProduto[y]

                    cdProduto[y] = auxCad


                    auxCad = cdFabricante[x]

                    cdFabricante[x] = cdFabricante[y]

                    cdFabricante[y] = auxCad


                    auxCad = corProduto[x]

                    corProduto[x] = corProduto[y]

                    corProduto[y] = auxCad

                }
                }
                limpa()

            //Produtos em ordem alfabética no intervalo
                escreva("Todos os produtos de ", cdInicial, " até ", cdFinal, " em Ordem Alfabética \n\n")

            cdFinal = cdFinal + "zzzzz"

            cont = 0


            para(i = 0; i < 999; i++)
			{
                    se(cdProduto[i] != "zzz" e cdInicial <= cdFinal e cdProduto[i] >= cdInicial e cdProduto[i] <= cdFinal)

                {
                        // formata o que será exibido conforme o tamanho da palavra do produto
                        espaco = ""

                    para(inteiro c = tx.numero_caracteres(nmProduto[i]); c < 20; c++)
					{
                            espaco = espaco + " "

                    }

                        // Exibe
                        cont++

                    escreva("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n")

                }
                }

                //Validação dos dados inseridos do USUÁRIO
                se(cont != 0)

            {
                    escreva("Encontrado(s) ", cont, " produtos")

            }

                se(i == 998 ou cont == 0)

            {
                    escreva("\nNão existem produtos nesta faixa: ")

            }
            }
            escreva("\nPressione Enter para retornar ao menu... ")
    
        leia(nada)
    
    }

        static void ListaFab(cadeia cdProduto[], cadeia nmProduto[], cadeia cdFabricante[], cadeia corProduto[])
        {
            cadeia auxCad, nada, fab, espaco
    
        inteiro i
    

        escreva("Qual Fabricante procura? ")
    
        leia(fab)
    
        fab = tx.caixa_alta(fab)
    

        limpa()
    
        para(i = 0; i < 999; i++)
		{
                se(cdFabricante[i] == fab)

            {
                    // formata o que será exibido conforme o tamanho da palavra do produto
                    espaco = ""

                para(inteiro c = tx.numero_caracteres(nmProduto[i]); c < 20; c++)
				{
                        espaco = espaco + " "

                }

                    // Exibe
                    escreva("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n")

            }
            }
            escreva("\nPressione Enter para retornar ao menu... ")
    
        leia(nada)
    
    }

        static void ListaCor(cadeia cdProduto[], cadeia nmProduto[], cadeia cdFabricante[], cadeia corProduto[])
        {
            cadeia auxCad, nada, cor, espaco
    
        inteiro i
    

        escreva("Qual Cor procura? ")
    
        leia(cor)
    
        cor = tx.caixa_alta(cor)
    

        limpa()
    
        para(i = 0; i < 999; i++)
		{
                se(corProduto[i] == cor)

            {
                    // formata o que será exibido conforme o tamanho da palavra do produto
                    espaco = ""

                para(inteiro c = tx.numero_caracteres(nmProduto[i]); c < 20; c++)
				{
                        espaco = espaco + " "

                }

                    // Exibe
                    escreva("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n")

            }
            }
            escreva("\nPressione Enter para retornar ao menu... ")
    
        leia(nada)
    
    }

        static void Lista(cadeia cdProduto[], cadeia nmProduto[], cadeia cdFabricante[], cadeia corProduto[])
        {
            inteiro i, totaItens
    
        cadeia nada, espaco
    
        para(i = 0; i < 999; i++)
		{
                se(nmProduto[i] != "zzz")

            {
                    // formata o que será exibido conforme o tamanho da palavra do produto
                    espaco = ""

                para(inteiro c = tx.numero_caracteres(nmProduto[i]); c < 20; c++)
				{
                        espaco = espaco + " "

                }

                    // Exibe
                    escreva("Cód.: ", cdProduto[i], " | Fabric.: ", cdFabricante[i], " | Prod.: ", nmProduto[i], espaco, " | Cor: ", corProduto[i], "\n")

                totaItens = i

            }
            }
            totaItens++
    
        escreva("\nTotal de " + totaItens + " itens na lista\n")
    
        escreva("Pressione Enter para retornar ao menu...")
    
        leia(nada)
    
    }

    }
}
