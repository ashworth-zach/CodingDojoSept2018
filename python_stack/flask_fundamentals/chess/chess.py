from flask import Flask, render_template
app = Flask(__name__)
@app.route('/')
def index():
    return render_template("index.html",x=4,y=4)
@app.route('/<x>/<y>')
def buildchessboard(x,y):
    xint=int(x)
    yint=int(y)
    return render_template("index.html",x=xint,y=yint)
if __name__=="__main__":
    app.run(debug=True)