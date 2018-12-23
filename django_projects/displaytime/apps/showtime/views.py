from django.shortcuts import render, redirect, HttpResponse
from time import gmtime, strftime
def index(request):
    context = {
        "time": strftime("%Y-%m-%d %H:%M %S %p", gmtime())
    }
    return render(request,'showtime/index.html', context)
