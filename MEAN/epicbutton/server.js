var express = require('express');
var bodyParser = require('body-parser');
var queryString = require('querystring');

var session = require('express-session');
var app = express();
var server = require('http').Server(app);
var io = require('socket.io')(server);

app.set('views', __dirname + '/views');
app.set('view engine', 'ejs');
app.use(express.static(__dirname + '/static'));
app.use(bodyParser.urlencoded({
    extended: true
}));
app.use(session({
    secret: 'keyboardkitteh',
    resave: false,
    saveUninitialized: true,
    cookie: { maxAge: 60000 }
  }))
app.get('/', function (req, res) {
    res.render('index');
});
app.post('/makeuser', function(req,res){
    console.log(req.body.name);
    req.session.name=req.body.name;
    console.log(req.session.name);
    res.redirect('/chat');
})
app.get('/chat',function (req,res){
    res.render('chat',{name:req.session.name})
})
msgarr=[]
io.on('connection', function (socket) {
    console.log("Welcome");
    socket.on('newmessage', function (data) {
        console.log(data);
        msgarr.push(data);
        socket.broadcast.emit("message", {
            msg:data.msg,
            name: data.name
        })
        socket.emit("message", {
            msg:data.msg,
            name: data.name
        })
        
    });
});

server.listen('8000', function () {
    console.log("Listening on port 8000.");
});