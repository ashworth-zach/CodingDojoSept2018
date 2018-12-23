from flask import Flask, render_template, request, redirect
app = Flask(__name__)
@app.route('/')
def index():
    return render_template("index.html")
@app.route('/result', methods=['POST'])
def result():
    print(request.form)
    print(request.form['firstname'])
    print(request.form['lastname'])
    print(request.form['language'])
    print(request.form['location'])
    print(request.form['message'])
    return render_template('result.html')
@app.route('/danger')
def danger():
    return redirect("/")
if __name__=="__main__":
    app.run(debug=True)