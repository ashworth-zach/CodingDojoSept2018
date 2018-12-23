class Node:
    def __init__(self, value):
        self.value = value
        self.next = None
    
class SList:
    def __init__(self,value):
        node=Node(value)
        self.head=node
    def addNode(self,value):
        node=Node(value)
        runner=self.head
        while(runner.next != None):
            runner = runner.next
        runner.next=node
    def removeNode(self,value):
        if self.head.value is value:
            self.head = self.head.next
            return self
        runner = self.head
        while runner.next is not None:
            if runner.next.value is value:
                runner.next = runner.next.next
                return self
            runner = runner.next
        return self


    def insertNode(self,value,index):
        node=Node(value)
        runner=self.head
        marker=0
        while marker<index:
            if marker==index-1:
                node.next=runner.next
                runner.next=node
            marker +=1
            runner=runner.next
        runner.value=value
        # node.next=runner.next
        #node.value=value
        print(id(runner),' - ', value, ' - ', index)
        return self

    def printAllValues(self,msg=''):
        runner = self.head          # create a runner     
        print("\n\nhead points to ", id(self.head))
        print("Printing the values in the list ---", msg,"---")
        while(runner.next != None):
            print(id(runner), runner.value, id(runner.next))
            runner = runner.next        
        print(id(runner), runner.value, id(runner.next))
list = SList(5)
list.addNode(7)
list.addNode(9)
list.addNode(1)
list.removeNode(9)
list.insertNode(15,1)
list.printAllValues('atttttttttempt 56456')