from django.shortcuts import render, redirect, HttpResponse
def index(request):
    return render(request, 'ninjas/index.html')

# Create your views here.
