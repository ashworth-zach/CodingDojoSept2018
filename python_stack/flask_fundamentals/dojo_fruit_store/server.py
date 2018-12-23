from flask import Flask, render_template, request, redirect
import datetime
app = Flask(__name__)  

@app.route('/')         
def index():
    return render_template("index.html")

@app.route('/checkout', methods=['POST'])         
def checkout():
    print(request.form)
    date=datetime.datetime.now()
    total=int(request.form['apple'])+int(request.form['strawberry'])+int(request.form['raspberry'])
    return render_template("checkout.html",date=date,total=total)

@app.route('/fruits')         
def fruits():
    return render_template("fruits.html")

if __name__=="__main__":   
    app.run(debug=True)    