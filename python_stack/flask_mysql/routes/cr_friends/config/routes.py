from cr_friends import app
from cr_friends.controllers.friends import Friends
friends = Friends()
@app.route('/')
def index():
    return friends.index()
@app.route('/process', methods=['POST'])
def process():    
    return friends.process()
