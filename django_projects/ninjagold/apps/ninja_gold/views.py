from django.shortcuts import render, redirect, HttpResponse
import random
def index(request):
    if 'gold' not in request.session:
        request.session['gold']=0
    if 'activity' not in request.session:
        request.session['activity']=[]
    return render(request, 'ninja_gold/index.html')
def process(request):
    
    hidden = request.POST['hidden']

    if hidden == 'farm':
        gold = random.randrange(10,20)
        request.session['gold']+=gold
        activity = request.session['activity']
        activity.append(activitylog(gold,hidden,request))
        request.session['activity']=activity

        return redirect('/ninjagold')
    
    if hidden == 'cave':
        gold = random.randrange(5,10)
        request.session['gold']+=gold
        activity = request.session['activity']
        activity.append(activitylog(gold,hidden,request))
        request.session['activity']=activity

        return redirect('/ninjagold')
    
    if hidden == 'house':
        gold = random.randrange(2,5)
        request.session['gold']+=gold
        activity = request.session['activity']
        activity.append(activitylog(gold,hidden,request))
        request.session['activity']=activity

        return redirect('/ninjagold')
    
    if hidden == 'casino':
        gold = random.randrange(0,50)
        activity = request.session['activity']
        activity.append(activitylog(gold,hidden,request))
        request.session['activity']=activity
        return redirect('/ninjagold')
def activitylog(gold,hidden,request):
    if hidden == 'casino':
        chance = random.randrange(0,2)
        if chance == 1:
            request.session['gold']+=gold
            return '<p class="greentext">you just won '+str(gold)+' gold at the '+hidden+'</p>'
        if chance == 0:
            request.session['gold']-=gold
            return '<p class="redtext">you just lost '+str(gold)+' gold at the '+hidden+', bummer.</p>'
    if hidden == 'farm':
        return '<p>you just found '+str(gold)+' gold at the '+hidden+'</p>'
    if hidden == 'cave':
        return '<p>you just found '+str(gold)+' gold at the '+hidden+'</p>'
    if hidden == 'house':
        return '<p>you just found '+str(gold)+' gold at the '+hidden+'</p>'