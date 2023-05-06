from datetime import datetime
from obterpessoas import obter_quantidade_pessoas


def construir_json(dados):
    # Informações para API
    idlocal = 1
    idcamera = 1
    descricaodolocal = "Testes Iniciais em diversos locais"
    descricaodacamera = "camera celular com droid cam"
    numerolotacao = 30

    data = {
            "idLocal": idlocal,
            "idCamera": idcamera,
            # "descricaoDoLocal": descricaodolocal,
            # "descricaoDaCamera": descricaodacamera,
            "lotacaoMaxima": numerolotacao,
            "numeroPessoas": obter_quantidade_pessoas(dados),
            # "percentualDeLotacao": ((int(obter_quantidade_pessoas(dados)) / numerolotacao) * 100) + "%",
            "percentualDeLotacao": str((int(obter_quantidade_pessoas(dados)) / numerolotacao) * 100) + "%",
            "dataInformacao": datetime.now().strftime("%d/%m/%Y %H:%M:%S")
    }

    return data
