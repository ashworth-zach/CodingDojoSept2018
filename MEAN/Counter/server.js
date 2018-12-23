var express = require("express");
// path module -- try to figure out where and why we use this
var path = require("path");
// create the express app
var session = require('express-session');
// original code:
var app = express();
// more new code:
app.use(session({
  secret: 'keyboardkitteh',
  resave: false,
  saveUninitialized: true,
  cookie: { maxAge: 60000 }
}))
var bodyParser = require('body-parser');
// use it!
app.use(bodyParser.urlencoded({ extended: true }));
// static content
app.use(express.static(path.join(__dirname, "./static")));
// setting up ejs and our views folder
app.set('views', path.join(__dirname, './Views'));
app.set('view engine', 'ejs');
// root route to render the index.ejs view
app.get('/', function(req, res) {
    if(req.session.count==undefined){
        req.session.count=1;
    }
    else{
        req.session.count+=1;
    }
    res.render('index', {count: req.session.count});
})
app.get('/plus2', function(req, res) {
    if(req.session.count==undefined){
        req.session.count=2;
    }
    else{
        req.session.count+=2;
    }
    res.render('index', {count: req.session.count});
})
app.get('/reset',function(req,res){
    req.session.count=0;
    res.redirect('/');
})

// tell the express app to listen on port 8000
app.listen(8000, function() {
 console.log("listening on port 8000");
});