from flask import Flask, redirect, render_template, request, flash
# import the function connectToMySQL from the file mysqlconnection.py
from mysqlconnection import connectToMySQL
app = Flask(__name__)
@app.route('/')
def index():
    mysql = connectToMySQL("friends")
    all_friends = mysql.query_db("SELECT * FROM friends")
    print("Fetched all friends", all_friends)
    return render_template('index.html', friends = all_friends)
if __name__ == "__main__":
    app.run(debug=True)
