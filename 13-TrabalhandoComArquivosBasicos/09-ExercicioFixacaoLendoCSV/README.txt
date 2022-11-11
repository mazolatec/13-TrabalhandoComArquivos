
Este conteudo é da freeCodeCamp
https://www.freecodecamp.org/portuguese/news/o-que-e-um-arquivo-csv-e-como-abrir-esse-formato-de-arquivo/
O que é um arquivo .csv? CSV é a sigla para Comma Separated Values (em português, valores separados por vírgulas). 
Um arquivo CSV é um arquivo de texto simples que armazena informações de planilhas e tabelas. 
O conteúdo geralmente é uma tabela de texto, números ou datas. Os arquivos CSV podem ser facilmente importados e exportados
usando programas que armazenam dados em tabelas.

O formato de arquivo CSV
Em geral, a primeira linha em um arquivo CSV contém os rótulos das colunas da tabela. Cada uma das linhas subsequentes representa uma linha da tabela. Vírgulas separam cada célula na linha, que é a razão para o nome do formato.

Aqui temos um exemplo de um arquivo CSV. O exemplo tem três colunas, com os rótulos 'name' (nome), 'id' e 'favorite food' (alimento predileto). Temos cinco linhas nele, incluindo a linha do cabeçalho.

name, id, favorite food
quincy, 1, hot dogs
beau, 2, cereal
abbey, 3, pizza
mrugesh, 4, ice cream




Fazer um programa para ler o caminho de um arquivo .csv
contendo os dados de itens vendidos. Cada item possui um
nome, preço unitário e quantidade, separados por vírgula. Você
deve gerar um novo arquivo chamado "summary.csv", localizado
em uma subpasta chamada "out" a partir da pasta original do
arquivo de origem, contendo apenas o nome e o valor total para
aquele item (preço unitário multiplicado pela quantidade),
conforme exemplo