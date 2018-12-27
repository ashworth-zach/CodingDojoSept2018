def randint(min=0,max=100):
    import random
    x=random.random()*max
    while x < min:
        x=random.random()*max
    print(x)
randint(min=4000,max=5000)