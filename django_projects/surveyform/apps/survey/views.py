from django.shortcuts import render, redirect, HttpResponse
def index(request):
    return render(request, 'survey/index.html')
def process(request):
    if request.method == "POST":
        request.session['firstname']=request.POST['firstname']
        request.session['lastname']=request.POST['lastname']
        request.session['location']=request.POST['location']
        request.session['language']=request.POST['language']
        request.session['comment']=request.POST['comment']
        if 'timescompleted' not in request.session:
            request.session['timescompleted']=0
        request.session['timescompleted']=request.session['timescompleted']+1
        print(request.session['firstname'])
        return redirect("/show")
    else:
        print('why is it hitting this else')
        return redirect("/")
def show(request):
    return render(request, 'survey/result.html')
