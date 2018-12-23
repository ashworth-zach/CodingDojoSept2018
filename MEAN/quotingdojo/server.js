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

var Quotedb = new mongoose.Schema({
    name: {
        type: String
    },
    content: {
        type: String
    }
}, {
    timestamps: true
})
// Store the Schema under the name 'User'
mongoose.model('Quote', Quotedb);
// Retrieve the Schema called 'User' and store it to the variable User
var Quote = mongoose.model('Quote');

app.get('/', function (req, res) {
    res.render('index');
})
app.post('/quotes', function (req, res) {
    console.log("POST DATA", req.body);
    var newquote=new Quote();
    newquote.name=req.body.name;
    newquote.content=req.body.quote;
    newquote.save(function(err){
        if(err!=undefined){
            console.log(err);
        }
        else{
            console.log("success");
        }
    })
    res.redirect('/quotes');
})
app.get('/quotes', function (req, res) {
    Quote.find({}, function(err, quotes) {
        // Retrieve an array of users matching the name. Even if 1 record is found, the result will be an array the size of 1, with 1 object inside. (Notice, if we are expecting to retrieve one record, we may want to use findOne and retrieve the object as oppose to an array the size of one.
        // This code will run when the DB is done attempting to retrieve all matching records to {name:'Jessica'}
        res.render("quotes",{quotes:quotes});
       })
})
app.listen(8000, function () {
    console.log("listening on port 8000");
})