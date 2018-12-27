class MathDojo:
    def __init__(self):
        self.total=0  
    def add(self, *num):
        for i in range(0,len(num)):
            if type(num[i]) is list or type(num[i]) is tuple:
                for x in num[i]:
                    self.total+=x
            else:
                self.total+=num[i]
        return self
    def subtract(self,*num):
        for i in range(0,len(num)):
            if type(num[i]) is list or type(num[i]) is tuple:
                for x in num[i]:
                    self.total-=x
            else:
                self.total-=num[i]
        return self
    def result(self):
        print(self.total)
        return self
x = MathDojo()
x.add(2).add(2,5,1).subtract(3,2).result()