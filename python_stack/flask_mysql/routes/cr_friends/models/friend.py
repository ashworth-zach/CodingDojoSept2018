from cr_friends.config.mysqlconnection import connectToMySQL
from flask import render_template,redirect,request

class Friend():
    def index(self):
        mysql=connectToMySQL('friends')
        result= mysql.query_db('select * from friends')
        return result
    def process(self):
        mysql = connectToMySQL("friends")
        query = "INSERT INTO friends (first_name, last_name, occupation, created_at, updated_at) VALUES (%(firstname)s, %(lastname)s, %(occupation)s, NOW(), NOW());"
        data={
            'firstname':request.form['firstname'],
            'lastname': request.form['lastname'],
            'occupation':request.form['occupation']
        }
        new_friend_id = mysql.query_db(query, data)
        return new_friend_id