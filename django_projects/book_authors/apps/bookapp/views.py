from django.shortcuts import render, redirect, HttpResponse
def index(request):
    return render(request, 'bookapp/index.html')

# Create your views here.
