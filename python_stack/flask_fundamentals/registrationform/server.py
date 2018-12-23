# create a regular expression object that we can use run operations on
from flask import Flask,redirect,session,render_template,request,flash
import re

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

app = Flask(__name__)
app.secret_key = "ThisIsSecret!"

@app.route('/', methods=['GET'])
def index():
    return render_template("index.html")

@app.route('/process', methods=['POST'])
def submit():

    if len(request.form['firstname']) < 1:
        flash(u"first name cannot be blank!", 'errorfirstname')

    if request.form['firstname'].isalpha() is False:
        flash(u"first name cannot contain numbers", 'errorfirstname')

    if len(request.form['lastname']) < 1:
        flash(u"last name cannot be blank!", 'errorlastname')

    if request.form['lastname'].isalpha() is False:
        flash(u"last name cannot contain numbers", 'errorlastname')

    if len(request.form['email'])<1:
        flash(u'email can not be blank', 'erroremail')

    if not EMAIL_REGEX.match(request.form['email']):
        flash(u'please enter a valid email address', 'erroremail')

    if len(request.form['password'])<8:
        flash(u'password is too short', 'errorpassword')

    if request.form['password']!=request.form['passwordconf']:
        flash(u'passwords do not match', 'errorpasswordconf')

    elif request.form['firstname'].isalpha() is True and request.form['lastname'].isalpha() is True and len(request.form['firstname']) > 0 and len(request.form['lastname']) > 0 and len(request.form['email'])>0 and EMAIL_REGEX.match(request.form['email']) and len(request.form['password'])>8 and request.form['password']==request.form['passwordconf']:
        flash("Success!")
        session['lastname']=request.form['lastname']
        session['firstname']=request.form['firstname']
        session['email']=request.form['email'] 
        session['password']=request.form['password']
        return redirect('/result')

    return redirect('/')


@app.route('/result')
def result():

    return render_template('result.html', lastname=session['lastname'], firstname=session['firstname'], password = session['password'], email=session['email'])

if __name__=="__main__":
    app.run(debug=True)
