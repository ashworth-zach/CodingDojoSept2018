class Animal:
    def __init__(self,name):
        self.name=name
        self.health=100
    def walk(self):
        self.health -=1
        return self
    def run(self):
        self.health -=5
        return self
    def displayhealth(self):
        print(self.health, ' : ', self.name)
        return self
class Dog(Animal):
    def __init__(self, name):
        super().__init__(name)
        self.health=150
    def pet(self):
        self.health+=5
        return self
    def displayhealth(self):
        print(self.health)
class Dragon(Animal):
    def __init__(self, name):
        super().__init__(name)
        self.health=170
    def fly(self):
        self.health -=10
        return self
    def displayhealth(self):
        print(self.health, ' : ', self.name + '  /IM A DRAGON')
        return self
frog=Animal('frog')
frog.walk().run().displayhealth()
dragon=Dragon('bichael micycle')
doggy=Dog('GOOBOYE')
doggy.pet().pet().pet().displayhealth() #goodboye
dragon.fly().displayhealth()
class Zoo:
    def __init__(self, zoo_name):
        self.animals = []
        self.name = zoo_name
    def addDog(self, name):
        self.animals.append( Dog(name) )
    def addDragon(self, name):
        self.animals.append( Dragon(name) )
    def printAllHealth(self):
        print("-"*30, self.name, "-"*30)
        for animal in self.animals:
            animal.displayHealth()
zoo1 = Zoo("John's Zoo")
zoo1.addDog("Tracy")
zoo1.addDog("Doggy")
zoo1.addDragon("Draggy")
zoo1.addDragon("Dragoon")
zoo1.printAllHealth()
# python=Animal('snake')
# python.fly().pet()