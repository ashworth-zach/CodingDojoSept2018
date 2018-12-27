def randint(min=0,max=100):
    import random
    x=random.random()*max
    while x < min:
        x=random.random()*max
    print(int(x))
randint(min=4000,max=4001)