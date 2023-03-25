//REST API em node.js

var express = require('express'); //obter o framework express
var app = express();
var fs = require('fs');

// Endpoint para obter a lista de dados da camera
app.get('/getDadosLocais', function(req, res){
  fs.readFile(__dirname + "/" + "dadosServidor.json", 'utf-8', function(err, data) {
    console.log(data);
    res.send(data);
  });
})

// Servidor para ouvir na porta 19999

var server = app.listen(19999, function(){
  var host = server.address().address
  var port = server.address().port
  console.log("REST API Local para as cameras - Ouvindo em http://%s:%s", host,port)
})