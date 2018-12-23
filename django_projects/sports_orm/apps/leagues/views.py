from django.shortcuts import render, redirect
from .models import League, Team, Player
from django.db.models import Q
from . import team_maker

def index(request):
	context = {
		"baseballleagues": League.objects.all().values().filter(sport='Baseball'),
	}
	return render(request, "leagues/index.html", context)

def make_data(request):
	team_maker.gen_leagues(10)
	team_maker.gen_teams(50)
	team_maker.gen_players(200)

	return redirect("index")