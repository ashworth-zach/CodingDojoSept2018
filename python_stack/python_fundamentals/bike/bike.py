class Bike:
    def __init__(self,max_speed,miles, price):
        self.max_speed=max_speed
        self.miles=miles
        self.price=price
    def ride(self):
        self.miles=self.miles+10
        return self
    def reverse(self):
        self.miles=self.miles-5
        return self
    def displayinfo(self):
        print('miles: ',self.miles,', max speed: ',self.max_speed,', price: ',self.price)
        return self
bike1=Bike('30mph',10,'$250')
bike2=Bike('25mph',400,'$100')
bike3=Bike('15mph',20,'$275')
bike4=Bike('45mph',1200,'$1000')
bike1.ride().ride().ride().reverse().displayinfo()
bike2.ride().ride().reverse().reverse().displayinfo()
bike3.reverse().reverse().reverse().displayinfo()

