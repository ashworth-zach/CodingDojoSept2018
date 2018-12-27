var express = require("express");
console.log("Let's find out what express is", express);
// invoke express and store the result in the variable app
var app = express();
// Now lets set the view engine itself so that express knows that we are using ejs as opposed to another templating engine like jade
app.set('view engine', 'ejs');
console.log("Let's find out what app is", app);
// use app's get method and pass it the base route '/' and a callback
app.set('views', __dirname + '/views'); 
app.use(express.static( __dirname + '/public/dist/public' ));
app.get('/', function(request, response) {
   response.render("index");
})
app.listen(8000, function() {
  console.log("listening on port 8000");
})