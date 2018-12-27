from flask import render_template,redirect,request
from cr_friends.models.friend import Friend
friend = Friend()
class Friends:
    def index(self):
        result = friend.index()
        return render_template('index.html', friends = result)
    def process(self):
        friend.process()
        return redirect('/')