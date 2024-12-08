
'''  Author: PHNO - Tecnologo | Pos-Graduado
     Data Release: 29/11/2024
     Versao Codigo: 0.0.0.2v
     Replit: @PHNO, @PHREPLIT
     E-mail: phreplit@gmail.com  '''

'''  Algoritmo: Metragem e Calculo para Pintura Residencial, algoritmo desenvolvido em python, desenvolvido para profissionais da area.  '''

import os # import lib - os clear
import sys
import json

def reset_text():
    os.system('cls' if os.name=='nt' else 'clear')

op = 0 
while op != -1:
  print('')
  print(' Metragem e Calculo para Pintura Residencial ')
  print('')
  print('')
  print('1. Calcular Metro Quadrado de uma Parede')
  print('2. Calcular Quantidade de Latas por M²')
  print('3. Calcular Quantidade de Demaos por Lata(s)')
  print('4. Calcular Quantidade de Demaos por M²')
  print('5. Sair')
  print('[8] Info')
  print('[9] Sobre')
  print('')
  op = int(input('Digite sua escolha: '))
  if op == 1:
   print('')
   v1 = int(input('Digite a altura da parede: '))
   print('')
   v2 = int(input('Digite a largura da parede: '))
   result = int(v1 * v2)
   print('')
   print('A parede tem {} metros quadrados.'.format(result))
   print('')
   print('Teclar enter para retornar ao menu...')
   a1 = str(input(''))
   reset_text()
  elif op == 2:
   qtdtinta = int(3600); # 1 lata tem 3600ml(3,6)
   v4 = int(360) # quantidade tinta por 1 metro quadrado
   print('')
   v3 = int(input('Digite quantos metros quadrados tem a parede: ')) # metros quadrados
   print('')
   result2 = int(v3 * v4) # quantidade de tinta por (n) tantos m²
   result3 = int(result2 / qtdtinta); # quantidade de latas
   print('')
   print('A quantidade de tinta para pintar {} M² eh de {} mililitro(s) e a quantidade de lata(s) eh de {} lata(s).'.format(v3,result2,result3))
   print('')
   print('Teclar enter para retornar ao menu...')
   a2 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 3:
   lata1 = int(3600); # 1 lata de tinta
   mq1 = int(360); # 1 metro quadrado
   v6 = int(3) # 3600ml(3,6) dividido por 3 sera 1200ml equivale a 3 demaos
   print('')
   v5 = int(input('Digite a quantidade de latas de tinta obtidas por M²: '))
   print('')
   result4 = int(v5 * v6); # demao
   calcqtdlitro = int(v5 * lata1); # quantidade tinta
   # calcmq = int(calcqtdlitro / mq1); # metro quadrado
   print('')
   print('A quantidade de demaos por {} lata(s) de tinta sera de {} demao(s).'.format(v5,result4))
   print('')
   print('Teclar enter para retornar ao menu...')
   a3 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 4:
   lata1 = int(3600); # 1 lata de tinta
   mq1 = int(360); # 1 metro quadrado
   v8 = int(3) # 3600ml(3,6) dividido por 3 sera 1200ml equivale a 3 demaos
   print('')
   v7 = int(input('Digite a quantidade de latas de tinta obtidas por M²: '))
   print('')
   result5 = int(v7 * v8) # demao
   calcqtdlitro = int(v7 * lata1); # quantidade tinta
   calcmq = int(calcqtdlitro / mq1); # metro quadrado
   print('')
   print('A quantidade de demaos para pintar {} metros quadrados sera de {} demao(s).'.format(calcmq,result5))
   print('')
   print('Teclar enter para retornar ao menu...')
   a4 = str(input(''))
   reset_text() # clear screen - lib os
  elif op == 5:
   print('')
   print('Algoritmo Finalizado!')
   print('')
   break
  elif op == 8:
   reset_text()
   print('')
   print('Info')
   print('')
   print('Para Calcular Pintura com Tinta sem diluicao:')
   print('Com base em uma lata de tinta de 3,6L e com base em uma parede com (A 2,70 metros x L 3,70 metros) temos que A x L = a 10M², ')
   print('e entao temos que 1 lata com 3600ml de tinta dividido por 10 tera 360ml para cada 1M², esse sera o padrao do calculo 360ml = 1M², ')
   print('entao tem se que Quaisquer(N) metros quadrados x 360ml = a (N) litros de tinta e esse resultado dividido por 3600ml sera igual a (N) quantidade de latas de tinta.')
   print('Para calcular uma demao: ')
   print('Para pintar uma demao temos que uma bandeja de tinta tem 1000ml como referencia por demao, e uma lata de tinta tem 3600ml ')
   print('entao temos que uma lata tem 1200ml por demao ja que 1200ml vs 3 = a 3600ml(3,6L). Uma demao equivale a uma pintura completa de uma parede. Geralmente eh necessario de duas a tres demaos para pintar uma parede.')
   print('')
   print('Informacao Importante: ')
   print('')
   print('Este algoritmo foi desenvolvido com variaveis inteiras entao nao aceita numeros com virgula ex: 2,90 metros mude para 3 metros.')
   print('Este algoritmo foi desenvolvido em Python 3 e por padrao exige sempre que a sua sintaxe e indentacao esteja sempre correta para sua correta compilacao em console.')
   print('')
   print('Teclar enter para retornar ao menu...')
   a5 = str(input(''))
   reset_text()
  elif op == 9:
   reset_text()
   print('')
   print('Algoritmo: Metragem e Calculo para Pintura Residencial')
   print('')
   print('Author: PHNO')
   print('Data Release: 29/11/2024')
   print('Versao Codigo: 0.0.0.2v')
   print('Replit: @PHNO, @PHREPLIT')
   print('E-mail: phreplit@gmail.com')
   print('')
   print('Teclar enter para retornar ao menu...')
   a6 = str(input(''))
   reset_text()
  else: 
   print('')
   print('Erro, Opcao Invalida!')
   print('')
   print('Teclar enter para retornar ao menu...')
   a7 = str(input(''))
   reset_text()
