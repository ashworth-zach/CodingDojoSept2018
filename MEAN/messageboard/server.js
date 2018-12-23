var express = require("express");
var session = require("express-session");
var bodyParser = require('body-parser');
var path = require("path");
var app = express();
var mongoose = require("mongoose");
var Schema = mongoose.Schema;


app.set('views', __dirname + '/views');
app.set('view engine', 'ejs');

app.use(express.static(__dirname + "/static"));
app.use(bodyParser.json());
app.use(session({
    secret: 'Codingledojo42069'
}));

// This must match the db
mongoose.connect('mongodb://localhost/messageBoard');
mongoose.Promise = global.Promise;

// SCHEMA DEFINITION  (CHANGE THE NAME OF THE SCHEMA)//

var MessageSchema = new mongoose.Schema({
    username: String,
    message: String,
    _comments: [{ type: Schema.Types.ObjectId, ref: 'Comment'}]
}, {
    timestamps: true
});
mongoose.model("Message", MessageSchema);
var Message = mongoose.model("Message");

var CommentSchema = new mongoose.Schema({
    username: String,
    comment: String,
    _message: {type: Schema.Types.ObjectId, ref: 'Message' }
}, {
    timestamps: true
});
mongoose.model("Comment", CommentSchema);
var Comment = mongoose.model("Comment");
// END SCHEMA DEFINITION // 


app.get('/', function (req, res) {
    Message.find({}).populate("_comments").exec(function (errors, dbMessage) {
        if (errors) {
            console.log("Something has gone wrong.");
            res.render("index");
        }
        res.render("index", { messageKey: dbMessage });
    
    }
);
});


app.post("/new_message", function (req, res) {
    var newMessage = new Message({
        username: req.body.username,
        message: req.body.message
    });
    newMessage.save(function (errorsNewMessage) {
        if (errorsNewMessage) {
            console.log("There was an error inserting the new message into the DB.");
            res.redirect("/");
        } else {
            console.log(req.body);
            console.log("The new message was inserted into the DB.");
            res.redirect("/");
        }
    });
});

app.post("/new_comment/:id", function (req, res) {
    // Find the message that we are commenting on.
    Message.findOne({_id: req.params.id}, function(error1, message){
        // Create the new comment.
        var comment = new Comment({
            username: req.body.username,
            comment: req.body.comment,
            // in the _message collumn save the ID of the message that this comment is referring to.
            _message: message._id
        });
        // save the new comment into the db.
        comment.save(function (errorsComment1) {
            //  In the column _comments (which is an array) of this specific message where we are commenting, push the entire comment (as an object)
            message._comments.push(comment);
            // Save the newly pushed and updated column in Message Schema
            message.save(function(error2){
                if (errorsComment1) {
                    console.log("There was an error inserting the new comment into the DB.");
                    res.redirect("/");
                } else {
                    console.log(req.body);
                    console.log("The new comment was inserted into the DB.");
                    res.redirect("/");
                }
            });
        });
    });
});


app.listen(8000, function () {
    console.log(__dirname);
    console.log("Listening on port 8000");
});