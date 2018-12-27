from django.shortcuts import render, HttpResponse, redirect
from django.contrib import messages
from .models import User
def index(request):
    context={
        'users':User.objects.all().values()
    }
    return render(request, 'restful/index.html', context)
def new(request):
    return render(request, 'restful/new.html')
def create(request):
    errors = User.objects.basic_validator(request.POST)
    if len(errors):
        for key, value in errors.items():
            messages.error(request, value)
        return redirect('/users/new')
    else:
        user = User.objects.create()
        user.firstname = request.POST['firstname']
        user.lastname = request.POST['lastname']
        user.email = request.POST['email']
        user.save()
        return redirect('/users')
def edit(request, user_id):
    context={
        'users':User.objects.all().values().get(id=user_id)
    }
    return render(request, 'restful/edit.html', context)
def show(request, user_id):
    context={
        'user':User.objects.all().values().get(id=user_id)
    }
    print(context['user'])
    return render(request, 'restful/show.html', context)
def destroy(request, user_id):
    user = User.objects.get(id =user_id)
    user.delete()
    return redirect('/users')
def update(request,user_id):
    errors = User.objects.basic_validator(request.POST)
    if len(errors):
        for key, value in errors.items():
            messages.error(request, value)
        return redirect('/users/edit/'+user_id)
    else:
        user = User.objects.get(id =user_id)
        user.firstname = request.POST['firstname']
        user.lastname = request.POST['lastname']
        user.email = request.POST['email']
        user.save()
        return redirect('/users')