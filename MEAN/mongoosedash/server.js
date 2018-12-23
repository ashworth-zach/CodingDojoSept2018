var express = require('express');
var mongoose = require('mongoose');
var app = express();
mongoose.connect('mongodb://localhost/27017');

var bodyParser = require('body-parser');

app.use(bodyParser.urlencoded({
    extended: true
}));

var path = require('path');

app.use(express.static(path.join(__dirname, './static')));

app.set('views', path.join(__dirname, './views'));

app.set('view engine', 'ejs');

var Goose = new mongoose.Schema({
    name: {
        type: String
    },
    food: {
        type: String
    }
}, {
    timestamps: true
})
// Store the Schema under the name 'User'
mongoose.model('Goose', Goose);
// Retrieve the Schema called 'User' and store it to the variable User
var Goose = mongoose.model('Goose');

app.get('/', function (req, res) {
    Goose.find({},function(err,gooses){

        res.render('index',{gooses:gooses});
    })
})
app.post('/mongoose', function (req, res) {
    var newgoose=new Goose();
    newgoose.name=req.body.name;
    newgoose.food=req.body.food;
    newgoose.save(function(err){
        if(err!=undefined){
            console.log(err);
        }
        else{
            console.log("success");
        }
    })
    res.redirect('/');
})
app.get('/mongoose/new', function (req, res) {
    res.render("newgoose");
})
app.get('/mongoose/:id', function (req, res) {
    console.log(req.params.id)
    Goose.find({_id:req.params.id}, function(err, gooses) {
        res.render("mongoose",{gooses:gooses});
       })
})
app.get('/mongoose/edit/:id', function (req, res) {
    console.log(req.params.id)
    Goose.find({_id:req.params.id}, function(err, gooses) {
        res.render("edit",{gooses:gooses});
       })
})
app.get('/mongoose/delete/:id', function (req, res) {
    console.log(req.params.id)
    Goose.remove({_id:req.params.id}, function(err, gooses) {
        res.redirect("/");
       })
})
app.post('/mongoose/update',function(req,res){
    Goose.findOne({_id: req.body.id}, function(err, goose){
        goose.name = req.body.name;
        goose.food=req.body.food;
        goose.save(function(err){
            res.redirect("/");
        })
       })
})
app.listen(8000, function () {
    console.log("listening on port 8000");
})