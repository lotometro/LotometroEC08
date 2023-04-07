from datetime import datetime
from YOLOV7.obterpessoas import obter_quantidade_pessoas


def construir_json(dados):
    # Informações para API
    idlocal = 1
    idcamera = 1
    descricaodolocal = "Testes Iniciais em diversos locais"
    descricaodacamera = "camera celular com droid cam"
    numerolotacao = 30

    data = {
        "Camera 1": {
            "id_local": idlocal,
            "id_camera": idcamera,
            "descricaoDoLocal": descricaodolocal,
            "descricaoDaCamera": descricaodacamera,
            "numeroPessoas": obter_quantidade_pessoas(dados),
            "percentualDeLotacao": int(obter_quantidade_pessoas(dados)) / numerolotacao,
            "dataInformacao": datetime.now().strftime("%d/%m/%Y %H:%M:%S")
        }
    }

    return data
