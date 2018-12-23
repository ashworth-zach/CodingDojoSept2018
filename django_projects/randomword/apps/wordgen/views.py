from django.shortcuts import render, redirect, HttpResponse
from django.utils.crypto import get_random_string
# Create your views here.
def index(request):
    randomword={
        'word':get_random_string(length=14)
    }
    if 'timescompleted' not in request.session:
        request.session['timescompleted']=0
    request.session['timescompleted']=request.session['timescompleted']+1
    return render(request, 'wordgen/index.html', randomword)