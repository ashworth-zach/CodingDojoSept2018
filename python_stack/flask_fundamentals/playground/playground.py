from flask import Flask, render_template
app = Flask(__name__)
@app.route('/play')
def index():
    return render_template("index.html",times=3)
@app.route('/play/<times>')
def playtimes(times):
    num=int(times)
    return render_template("index.html",times=num)
@app.route('/play/<times>/<color>')
def playtimecolor(times,color):
    num=int(times)
    return render_template("index.html",times=num,color=color)
if __name__=="__main__":
    app.run(debug=True)