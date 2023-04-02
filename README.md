# Lotometro

## Contagem automatica de pessoas com reconhecimento de imagens

### Com cameras fixas ou em drones, será possível realizar a contagem de pessoas e obter o percentual de lotação de um local

## Este projeto utiliza

- YoloV7 para processamento de imagens no local - processamento com GPU
- APIs REST - (MEAN)
- Integração com API Local em Python
- Integração com API Principal em (A definir)

## Configuração do ambiente

- IDE (PyCharm)
- Abrir Anaconda Prompt e navegar até o local do projeto e acessar pasta YOLOV7
- Inserir comandos:
- conda create -n yolov7
- conda activate yolov7
- pip install -r requirements.txt
- Abrir o projeto com o PyCharm e verificar se algum import contem erro, se sim, corrigir pela IDE

## Como usar (ainda em construção)

- Em detect.py, inserir o ip e porta da camera.
- Para testar com arquivo mp4, inserir o arquivo na pasta YOLOV7 e alterar a variavel source "seuVideo.mp4" e webcam = False
