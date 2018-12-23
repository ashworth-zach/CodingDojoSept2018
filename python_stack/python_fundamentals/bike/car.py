class Car:
    def __init__(self,price,speed,fuel,mileage,tax=0):
        self.price=price
        self.speed=speed
        self.fuel=fuel
        self.mileage=mileage
        if self.price>10000:
            self.tax=0.15
        else:
            self.tax=0.12
    def display_all(self):
        print('price: ',self.price, 'speed: ',self.speed,'fuel: ', self.fuel, 'mileage: ', self.mileage,'tax: ',self.tax)
car1=Car(2000,'100mph','full','22mpg')
car2=Car(60000,'300mph','empty','26mpg')
car3=Car(500,'120mph','empty','12mpg')
car4=Car(10000,'30mph','empty','52mpg')
car5=Car(5000,'4mph','full','12mpg')
car6=Car(22000,'50mph','full','2mpg')
car1.display_all()
car2.display_all()
car3.display_all()
car4.display_all()
car5.display_all()
car6.display_all()