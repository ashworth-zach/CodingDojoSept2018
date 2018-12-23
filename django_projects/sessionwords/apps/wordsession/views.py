from django.shortcuts import render, redirect, HttpResponse
from time import gmtime, strftime
def index(request):
    return render(request, 'wordsession/index.html')
def add(request):
    bigorsmall=''
    if 'words' not in request.session:
        request.session['words']=[]
    temp_list = request.session['words']
    if request.POST['big_font'] =='1':
        bigorsmall = '30pt'
    if request.POST['big_font'] ==0:
        bigorsmall = '12pt'

    temp_list.append({'timestamp': strftime("%Y-%m-%d %H:%M %p", gmtime()),"word": request.POST['word'], "color": request.POST['color'], "showbig": bigorsmall})
    request.session['words'] = temp_list
    print(request.session['words'])
    return redirect('/session_words')