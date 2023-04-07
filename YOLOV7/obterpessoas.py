import re

def obter_quantidade_pessoas(texto):
    # Verifica se a palavra "person" está na string
    indice = texto.find("person")
    if indice != -1:
        # Verifica se há caracteres suficientes antes da palavra "person"
        if indice >= 4:
            inicio = indice - 4
        else:
            inicio = 0

        # Obtem o trecho da string
        trecho = texto[inicio:indice]
        trecho = trecho.strip()
        # utilizando expressões regulares para obter os numeros do trecho da string
        lista = re.findall(r'\d+', trecho)
        listaint = list(map(int, lista))
        numeropessoas = listaint[0]

        return numeropessoas
    else:
        return None
