from django.shortcuts import render, redirect, HttpResponse
def index(request):
    return HttpResponse('placeholder to later display all the list of blogs')
def new(request):
    return HttpResponse('placeholder to add a new blog')
# Create your views here.
def create(request):
    return redirect('/blogs')
def show(request, blogid):
    return HttpResponse('place holder to show blog number:'+str(blogid))
def edit(request, blogid):
    return HttpResponse('place holder to edit blog number:'+str(blogid))
def delete(request,blogid):
    return redirect('/blogs')