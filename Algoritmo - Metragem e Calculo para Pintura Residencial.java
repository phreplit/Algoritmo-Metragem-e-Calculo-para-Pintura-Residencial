
// Author: PHNO - Tecnologo | Pos-Graduado
// Data Release: 29/11/2024
// Versao Codigo: 0.0.0.2v
// Replit: @PHNO, @PHREPLIT
// E-mail: phreplit@gmail.com

// Algoritmo: Metragem e Calculo para Pintura Residencial, algoritmo desenvolvido em java, desenvolvido para profissionais da area.

import java.io.IOException;
import java.util.Scanner; // importa lib

public class Main {

public static void main(String[] args) throws IOException, InterruptedException {

loop: 
while (true) {

	System.out.println("\n");
	System.out.println("\n");
	System.out.println(" Metragem e Calculo para Pintura Residencial ");
	System.out.println("");
	System.out.println("");
	System.out.println("1. Calcular Metro Quadrado de uma Parede");
	System.out.println("2. Calcular Quantidade de Latas por M²");
	System.out.println("3. Calcular Quantidade de Demaos por Lata(s)");
	System.out.println("4. Calcular Quantidade de Demaos por M²");
	System.out.println("5. Sair");
	System.out.println("");
	System.out.println("[8] Info");
	System.out.println("\n[9] Sobre "); // about
  
  System.out.println("\nDigite sua escolha: ");

Scanner scanner = new Scanner(System.in);

int choice = scanner.nextInt();

try {
  
switch (choice) {
  case 1:
    System.out.println("\nDigite a altura da parede: "); 
    int v1 = scanner.nextInt();
    System.out.println("\nDigite a largura da parede: "); 
    int v2 = scanner.nextInt();
    int result = (v1 * v2); 
    System.out.println("\n");
    System.out.println("\nA parede tem " + result + " metros quadrados."); 
    Scanner scanner1 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter = scanner1.nextLine();
    clear(); 
    break;
  case 2:
    int v4 = 360; // quantidade tinta por 1 metro quadrado
    int qtdtinta = 3600; // 1 lata tem 3600ml(3,6)
    System.out.println("\nDigite quantos metros quadrados tem a parede: ");  
    int v3 = scanner.nextInt();  // metros quadrados
    System.out.println("\n");
    int resultado = (v3 * v4); // quantidade de tinta por (n) tantos m²
    int resultado2 = (resultado / qtdtinta); // amount of cans
    System.out.println("\nA quantidade de tinta para pintar " + (v3) + " M² eh de " + (resultado) + " mililitro(s) e a quantidade de lata(s) eh de " + (resultado2) + " lata(s).");
    Scanner scanner2 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter2 = scanner2.nextLine();
    clear(); 
    break;
  case 3:
    int lata1 = 3600; // 1 lata de tinta
    int mq1 = 360; // 1 metro quadrado
    int v6 = 3; // 3600ml(3,6) dividido por 3 sera 1200ml equivale a 3 demaos
    System.out.println("\nDigite a quantidade de latas de tinta obtidas por M²: ");  
    int v5 = scanner.nextInt();
    System.out.println("\n");
    int result2 = (v5 * v6); // demao
    int calcqtdlitro = (v5 * lata1); // quantidade tinta
    int calcmq = (calcqtdlitro / mq1); // metro quadrado
    System.out.println("\nA quantidade de demaos por " + (v5) + " lata(s) de tinta sera de " + (result2) + " demao(s).");
    Scanner scanner3 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter3 = scanner3.nextLine();
    clear();
  break;
  case 4:
    int lata01 = 3600; // 1 lata de tinta
    int mq01 = 360; // 1 metro quadrado  
    int v8 = 3; // 3600ml(3,6) dividido por 3 sera 1200ml equivale a 3 demaos
    System.out.println("\nDigite a quantidade de latas de tinta obtidas por M²: ");   
    int v7 = scanner.nextInt();
    System.out.println("\n");
    int result3 = (v7 * v8); // demao
    int calcqtdlitro01 = (v7 * lata01); // quantidade tinta
    int calcmq01 = (calcqtdlitro01 / mq01); // metro quadrado
    System.out.println("\nA quantidade de demaos para pintar " + (calcmq01) + " metros quadrados sera de " + (result3) + " demao(s).");
    Scanner scanner4 = new Scanner(System.in);
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter4 = scanner4.nextLine();
    clear(); 
  break;
  case 5:
    System.out.println("\n Algoritmo Finalizado! ");
  break loop;
  case 8:
  clear();
  System.out.println("\n");
  System.out.println("Info");
  System.out.println("");
  System.out.println("Para Calcular Pintura com Tinta sem diluicao:");
  System.out.println("Com base em uma lata de tinta de 3,6L e com base em uma parede com (A 2,70 metros x L 3,70 metros) temos que A x L = a 10M², e entao temos que 1 lata com 3600ml de tinta dividido por 10 tera 360ml para cada 1M², esse sera o padrao do calculo 360ml = 1M², entao tem se que Quaisquer(N) metros quadrados x 360ml = a (N) litros de tinta e esse resultado dividido por 3600ml sera igual a (N) quantidade de latas de tinta.");
  System.out.println("Para calcular uma demao: ");
  System.out.println("Para pintar uma demao temos que uma bandeja de tinta tem 1000ml como referencia por demao, e uma lata de tinta tem 3600ml entao temos que uma lata tem 1200ml por demao ja que 1200ml vs 3 = a 3600ml(3,6L). Uma demao equivale a uma pintura completa de uma parede. Geralmente eh necessario de duas a tres demaos para pintar uma parede.");
  System.out.println("");
  System.out.println("Informacao Importante: ");
  System.out.println("");
  System.out.println("Este algoritmo foi desenvolvido com variaveis inteiras entao nao aceita numeros com virgula ex: 2,90 metros mude para 3 metros.");
  System.out.println("");
  Scanner scanner7 = new Scanner(System.in);
  System.out.println("\nTeclar enter para retornar ao menu...\n");
  String enter7 = scanner7.nextLine();
  clear();
  break;
  case 9:
  clear();
  System.out.println("\n");
  System.out.println("Algoritmo: Metragem e Calculo para Pintura Residencial");
  System.out.println("");
  System.out.println("Author: PHNO");
  System.out.println("Data Release: 29/11/2024");
  System.out.println("Versao Codigo: 0.0.0.2v");
  System.out.println("Replit: @PHNO, @PHREPLIT");
  System.out.println("E-mail: phreplit@gmail.com");
  System.out.println("");
  Scanner scanner8 = new Scanner(System.in);
  System.out.println("\nTeclar enter para retornar ao menu...\n");
  String enter8 = scanner8.nextLine();
  clear();
  break;
  default:
    Scanner scanner9 = new Scanner(System.in);
    System.out.println("\n Erro, Opcao Invalida! ");
    System.out.println("\nTeclar enter para retornar ao menu...\n");
    String enter9 = scanner9.nextLine();
    clear();
    }
  } catch (Exception e) {
  Scanner scanner9 = new Scanner(System.in);
  System.out.println("\nErro, falha no sistema!");
  System.out.println("\nTeclar enter para retornar ao menu...\n");
  String enter9 = scanner9.nextLine();
  clear();
  }            
}
}
public static void clear() {
     System.out.print("\033[H\033[2J"); // clear screen
     System.out.flush();
}
}