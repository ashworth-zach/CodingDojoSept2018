class Product:
    def __init__(self,price,name,weight,brand,status='for sale'):
        self.price=price
        self.name=name
        self.weight=weight
        self.brand=brand
        self.status=status
    def sell(self):
        self.status='sold'
        return self
    def addtax(self,tax):
        self.price=(self.price*tax)+self.price
        return self
    def returnitem(self,reason_for_return):
        if reason_for_return == 'defective':
            self.status='defect'
        if reason_for_return == 'opened':
            self.status='used'
            self.price=self.price*.8
        if reason_for_return == 'like new':
            self.status='for sale'
        return self
    def displayinfo(self):
        print('price: ', self.price, 'name: ', self.name, 'weight: ', self.weight, 'brand: ', self.brand, 'status: ',self.status)
        return self
product1=Product(500,'headphones','5lbs','beats')
product1.returnitem('defective').displayinfo().returnitem('opened').displayinfo().returnitem('like new').displayinfo();

