//REST API em node.js

const express = require('express'); //obter o framework express
const bodyParser = require('body-parser');
const mongoose = require('mongoose');
const cors = require('cors');

const app = express();
var fs = require('fs');

// configurando o body-parser para receber JSON
app.use(bodyParser.json());

// configurando o CORS para permitir acesso de qualquer origem
app.use(cors());

// configurando o mongoose para se conectar ao MongoDB
//mongodb+srv://lotometroec08:<password>@cluster0.ozbiz7i.mongodb.net/test
//mongodb+srv://${lotometroec08}:${lotometroec08}@cluster0.ozbiz7i.mongodb.net/${LotometroAPIServer}?retryWrites=true&w=majority
mongoose.connect('mongodb+srv://lotometroec08:lotometroec08@cluster0.ozbiz7i.mongodb.net/LotometroAPIServer?retryWrites=true&w=majority', {
  useNewUrlParser: true,
  useUnifiedTopology: true
});

// definindo o modelo do objeto que será armazenado no MongoDB
const localSchema = new mongoose.Schema({
  locais: [{
    local: String,
    camera: [{
      descricaoDoLocal: String,
      numeroPessoas: Number,
      percentualDeLotacao: Number,
      data: Date
    }]
  }]
});
const Locais = mongoose.model('Locais', localSchema);
module.exports = Locais;

// Endpoint para obter a lista de dados da camera
// definindo as rotas da API REST
app.get('/getLotacaoLocais', async (req, res) => {
  //const dadosCamera = await Camera.find();
  //res.json(dadosCamera);

  fs.readFile(__dirname + "/" + "dadosServidor.json", 'utf-8', function(err, data) {
    console.log(data);
    res.send(data);
  });
});


app.post('/inserirDadosTodosLocais', async (req, res) => {
  const dadoLocais = new Item(req.body);
  await dadoLocais.save();
  res.json(item);
});

app.delete('/items/:id', async (req, res) => {
  const id = req.params.id;
  await Item.findByIdAndDelete(id);
  res.json({ message: 'Item deletado com sucesso' });
});

// Servidor para ouvir na porta 18888

// iniciando o servidor na porta 44444
app.listen(44444, () => {
  console.log('Servidor iniciado na porta 44444');
});