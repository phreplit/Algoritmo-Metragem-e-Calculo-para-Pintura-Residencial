
//  Author: PHNO - Tecnólogo | Pós-Graduado
//  Data Release: 04/11/2023
//  Versão Código: 2.0.1v
//  Replit: @PHNO, @PHREPLIT
//  E-mail: phreplit@gmail.com

// Algoritmo: Metragem e Calculo para Pintura Residencial, algoritmo desenvolvido em c, desenvolvido para profissionais da area.

#include <stdio.h> // importa lib
#include <stdlib.h> 
#include <math.h> 

int menu(); 
void op1(); // cabecalho
void op2(); 
void op3();
void op4();
void op8();
int menu_developer();

int menu() { // Funcao Menu  
int op, c;

printf("\n\t Metragem e Calculo para Pintura Residencial \n");

printf("\n");
printf("\n\t     Menu    \n");
printf("\n");

printf("\n1. Calcular Metro Quadrado de uma Parede");
printf("\n2. Calcular Quantidade de Latas por M²");
printf("\n3. Calcular Quantidade de Demaos por Lata(s)");
printf("\n4. Calcular Quantidade de Demaos por M²");
printf("\n5. Sair\n");
printf("\n[8] Info\n");
printf("\n[9] Sobre \n");

printf("\nDigite sua escolha: ");
scanf("%d", &op);

while ((c = getchar()) != '\n' && c != EOF) {
} // limpar o buffer do teclado.   
return op; 
}

int main() { // Funcao principal

int op = 0, c;

while (op != -1) { 
op = menu(); 
switch (op) { 
case 1: 
op1(); // funcao 
break; 
case 2: 
op2(); // funcao 
break; 
case 3: 
op3(); // funcao 
break;
case 4:
op4(); // funcao
break;
case 5:
printf("\n");
printf("\n Algoritmo Finalizado! \n"); // Ao Sair
printf("\n");
return 0;
break;
case 8:
op8(); // funcao
break;
case 9:
menu_developer(); // funcao
break; 
default: 
printf("\n");
printf("Opcao Invalida!\n");
printf("\n");
//printf("\n");
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
} 
} 
return 0; 
} 

void op1() { 
int v1;
int v2;
int resultado;
printf("\n");
printf("\nDigite a altura da parede: ");
scanf("%d", &v1, stdin);
printf("\n");
printf("\nDigite a largura da parede: ");
scanf("%d", &v2, stdin);
resultado = v1 * v2;
printf("\nA parede tem %d metros quadrados.\n", resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op2() { 
int v1; // metros quadrados
int v2 = 360; // quantidade tinta por 1 metro quadrado
int resultado; // quantidade de tinta por (n) tantos m²
int qtdtinta = 3600; // 1 lata tem 3600ml(3,6)
int resultado2; // quantidade de latas
printf("\n");
printf("\nDigite quantos metros quadrados tem a parede: ");
scanf("%d", &v1, stdin);
printf("\n");
resultado = (v1 * v2);
resultado2 = (resultado / qtdtinta);
printf("\nA quantidade de tinta para pintar %d M² eh de %d mililitro(s) e a quantidade de lata(s) eh de %d lata(s).\n", v1, resultado, resultado2);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op3() {
int v1;
int v2 = 3; // 3600ml(3,6) dividido por 3 sera 1200ml equivale a 3 demaos
int lata1 = 3600; // 1 lata de tinta
int resultado; // demao
int calcqtdlitro; // quantidade tinta
int calcmq; // metro quadrado
int mq1 = 360; // 1 metro quadrado
printf("\n");
printf("\nDigite a quantidade de latas de tinta obtidas por M²: ");
scanf("%d", &v1, stdin);
printf("\n");
resultado = (v1 * v2);
calcqtdlitro = (v1 * lata1);
calcmq = (calcqtdlitro / mq1);
printf("\nA quantidade de demaos por %d lata(s) de tinta sera de %d demao(s).\n", v1, resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op4() {
int v1;
int v2 = 3; // 3600ml(3,6) dividido por 3 sera 1200ml equivale a 3 demaos
int lata1 = 3600; // 1 lata de tinta
int resultado; // demao
int calcqtdlitro; // quantidade tinta
int calcmq; // metro quadrado
int mq1 = 360; // 1 metro quadrado
printf("\n");
printf("\nDigite a quantidade de latas de tinta obtidas por M²: ");
scanf("%d", &v1, stdin);
printf("\n");
resultado = (v1 * v2);
calcqtdlitro = (v1 * lata1);
calcmq = (calcqtdlitro / mq1);
printf("\nA quantidade de demaos para pintar %d metros quadrados sera de %d demao(s).\n", calcmq, resultado);
// system("pause"); // pausa tela windows
// system("Cls"); // limpa tela windows
// printf("\n"); // pula linha
printf("\nTeclar enter para retornar ao menu...\n");
getchar();
scanf("c\n");
system("clear");      // linux limpar tela
system("tput reset"); // linux limpar texto
return; 
}

void op8() {
system("clear");      // linux
system("tput reset"); // linux
printf("\nInfo\n");
printf("\nEste algoritmo foi desenvolvido com variaveis inteiras entao nao aceita numeros com virgula ex: 2,90 metros mude para 3 metros.\n");
printf("\nPara Calcular Pintura com Tinta sem diluicao:\n");
printf("\nCom base em uma lata de tinta de 3,6L e com base em uma parede com (A 2,70 metros x L 3,70 metros) temos que A x L = a 10M², e entao temos que 1 lata com 3600ml de tinta dividido por 10 tera 360ml para cada 1M², esse sera o padrao do calculo 360ml = 1M², então tem se que Quaisquer(N) metros quadrados x 360ml = a (N) litros de tinta e esse resultado dividido por 3600ml sera igual a (N) quantidade de latas de tinta.\n");
printf("\nPara calcular uma demao: \n");
printf("\nPara pintar uma demao temos que uma bandeja de tinta tem 1000ml como referencia por demao, e uma lata de tinta tem 3600ml entao temos que uma lata tem 1200ml por demao ja que 1200ml vs 3 = a 3600ml(3,6L). Uma demao equivale a uma pintura completa de uma parede. Geralmente eh necessario de duas a tres demaos para pintar uma parede.\n");
printf("\n Teclar enter para retornar ao menu...\n ");
getchar();
scanf("c\n");
system("clear");      // linux
system("tput reset"); // linux
return;
}

int menu_developer(){
  system("clear");      // linux
  system("tput reset"); // linux
  printf("\n Algoritmo: Metragem e Calculo para Pintura Residencial \n");
  printf("\n Author: PHNO ");
  printf("\n Data Release: 04/11/2023 ");
  printf("\n Versao Codigo: 2.0.1v");
  printf("\n Replit: @PHNO, @PHREPLIT");
  printf("\n E-mail: phreplit@gmail.com \n");
  printf("\n Teclar enter para retornar ao menu...\n ");
  getchar();
  scanf("c\n");
  system("clear");      // linux
  system("tput reset"); // linux
  return 0;
}
