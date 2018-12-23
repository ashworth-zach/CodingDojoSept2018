var express = require('express');
var mongoose = require('mongoose');
var app = express();
const session = require('express-session');
const flash = require('express-flash');
const bcrypt = require('bcrypt');
mongoose.connect('mongodb://localhost/api');

var bodyParser = require('body-parser');
app.use(bodyParser.json());

var path = require('path');

app.use(flash());
app.use(express.static(path.join(__dirname, './static')));

app.set('views', path.join(__dirname, './views'));

app.set('view engine', 'ejs');
app.set('trust proxy', 1) // trust first proxy
app.use(session({
    secret: 'keyboard cat',
    resave: false,
    saveUninitialized: true,
    cookie: {
        maxAge: 60000
    }
}))
var people = new mongoose.Schema({
    name: {
        type: String,
    },
}, {
    timestamps: true
})
// Store the Schema under the name 'People'
mongoose.model('people', people);

// Retrieve the Schema called 'User' and store it to the variable User

var people = mongoose.model('people');
app.get('/', function (req, res) {
    people.find({}, function (err, Users) {
        if (err) {
            res.json({
                message: "Error",
                error: err
            })
        } else {
            res.json({
                message: "success",
                data: Users
            })

        }
    })
})
app.get('/new/:name',function(req,res){
    people.create({name:req.params.name},function(err){
        if (err){
            console.log(err)
            res.json({
                message: "Error",
                error: err
            })
        }
        else{
            res.redirect('/');
        }
    })
})
app.get('/remove/:name',function(req,res){
    people.remove({name:req.params.name},function(err){
        if (err){
            console.log(err)
            res.json({
                message: "Error",
                error: err
            })
        }
        else{
            res.redirect('/');
        }
    })
})
app.get('/:name',function(req,res){
    people.find({name:req.params.name},function(err,people){
        if (err){
            console.log(err)
            res.json({
                message: "Error",
                error: err
            })
        }
        else{
            res.json({data:people});
        }
    })
})
app.listen(8000, function () {
    console.log("listening on port 8000");
})