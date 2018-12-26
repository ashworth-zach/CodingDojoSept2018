from django.shortcuts import render, HttpResponse, redirect
  # the index function is called when root is visited
def index(request):
    context = {
        "email" : "blog@gmail.com",
        "name" : "mike"
    }
    return render(request, "first_app/index.html", context)
def new(request):
    #render('new.html')
    return HttpResponse("render('newform.html)")
def create(request):
    if request.method == "POST":
        print("*"*50)
        print(request.POST)
        print(request.POST['name'])
        print(request.POST['desc'])
        request.session['name'] = "test"  # more on session below
        print(request.session['name'])
        print("*"*50)
        return redirect("/")
    else:
        return redirect("/")
def show(request, number):
    print(number)
    return HttpResponse(number)
def edit(request,number):
    return HttpResponse('requesting to edit blog #: '+number)
def destroy(request,number):
    print(number)
    return redirect('/')