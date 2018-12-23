from django.shortcuts import render, redirect, HttpResponse

def index(request):
    return HttpResponse('placeholder for surveys')
def new(request):
    return HttpResponse('placeholder for a new survey')