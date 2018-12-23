from django.shortcuts import render, HttpResponse, redirect
from django.contrib import messages
from .models import *
from django.core import serializers
from django.http import JsonResponse
def index(request):
    context = {
        'posts': Post.objects.all(),
    }
    return render(request, 'post/index.html', context)
def create(request):

    Post.objects.create(content=request.POST['content'])
    posts=[Post.objects.last()]
    return JsonResponse(serializers.serialize("json", posts), content_type='application/json', safe=False)
