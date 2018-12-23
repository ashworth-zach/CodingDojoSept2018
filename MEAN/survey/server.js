var express = require('express');
var bodyParser  = require('body-parser');
var queryString = require('querystring');
var app = express();
var server = require('http').Server(app);
var io = require('socket.io')(server);

app.set('views', __dirname + '/static/view');
app.set('view engine', 'ejs');
app.use(express.static(__dirname + '/static'));
app.use(bodyParser.urlencoded({ extended: true }));

app.get('/', function(req,res){
  res.render('index');
});

io.on('connection', function(socket){
  console.log("Welcome");
  socket.on('posting_form', function(data){
    var data = queryString.parse(data);
    var random_number = "";
    var updated_message = "";
    data = JSON.stringify(data);
    updated_message = 'You emitted the following information to the server: ' + data;
    random_number = "<br><p>Your lucky number emitted by the server is " + (Math.floor(Math.random() * 1000)) + 1;
    socket.emit('updated_message', updated_message);
    socket.emit('random_number', random_number);
  });
});

server.listen('3000', function(){
  console.log("Listening on port 3000.");
});