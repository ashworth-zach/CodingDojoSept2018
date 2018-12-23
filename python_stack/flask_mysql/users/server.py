from flask import Flask, redirect, render_template, request, flash, session
import pymysql.cursors
import datetime
import re
from flask_bcrypt import Bcrypt        

# import the function connectToMySQL from the file mysqlconnection.py
from mysqlconnection import connectToMySQL
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
mysql = connectToMySQL("friends")

app = Flask(__name__)
app.secret_key = "ThisIsSecret!"
bcrypt = Bcrypt(app)
@app.route('/users',methods=['GET'])
def index():
    allfriends=mysql.query_db('select * from friends')
    return render_template('index.html',allfriends=allfriends)
@app.route('/users/<id>')
def show(id):
    data={
        "id":id
    }
    showuser=mysql.query_db('select * from friends where id=%(id)s',data)
    return render_template('index.html',allfriends=showuser)
@app.route('/users/<id>',methods=['post'])
def update(id):
    data={
        'firstname':request.form['firstname'],
        'lastname':request.form['lastname'],
        'occupation':request.form['occupation'],
        'id':id
    }
    mysql.query_db('UPDATE friends SET first_name = %(firstname)s, last_name = %(lastname)s, occupation= %(occupation)s where id = %(id)s',data)
    return redirect('/users/'+str(id))
@app.route('/users/new',methods=['GET','POST'])
def new():
    return render_template('createuser.html')
@app.route('/users/create',methods=['POST'])
def create():
    data={
        'firstname':request.form['firstname'],
        'lastname':request.form['lastname'],
        'occupation':request.form['occupation']
    }
    id=mysql.query_db('insert into friends(first_name,last_name,occupation,created_at,updated_at) VALUES(%(firstname)s,%(lastname)s,%(occupation)s,NOW(),NOW())',data)
    print(id)
    return redirect('/users/'+str(id))
@app.route('/users/<id>/edit')
def edit(id):
    return render_template('edituser.html',id=id)
@app.route('/users/<id>/destroy')
def delete(id):
    data={
        'id':id
    }
    mysql.query_db('DELETE from friends where id=%(id)s',data)
    return redirect('/users')
if __name__ == "__main__":
    app.run(debug=True)