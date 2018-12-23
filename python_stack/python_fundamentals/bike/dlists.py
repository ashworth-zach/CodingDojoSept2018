class Node:
    def __init__(self,value=None,prev=None,next=None):
        self.value=value
        self.prev=prev
        self.next=next

class DoubleList:
    def __init__(self,value):
        self.value=value
        self.head=None
        self.tail=None
    def pushNode(self,value):
        new_node=Node(value)
        new_node.next=self.head
        new_node.prev=None
        if self.head is not None:
            self.head.prev = new_node
        self.head=new_node
    def deleteNode(self,value):
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
        # print(id(runner.next.next.prev))
    def insertNode(self,beforeval,value):
        node=Node(value)
        runner=self.head
        while beforeval!=runner.value:
            runner=runner.next
        node.prev=runner
        node.next=runner.next
        runner.next=node
        node.value=value
        print(id(node))
        # node.next=runner.next
        #node.value=value
        print(id(runner),' - ', value)
        return self
    def printAllValues(self,msg=''):
        runner = self.head          # create a runner     
        print("\n\nhead points to ", id(self.head))
        print("Printing the values in the list ---", msg,"---")
        while(runner.next != None):
            print(id(runner), runner.value, id(runner.next))
            runner = runner.next        
        print(id(runner), runner.value, id(runner.next))
list=DoubleList(1)
list.pushNode(5)
list.pushNode(54)
list.pushNode(11)
list.pushNode(12)
# list.deleteNode(11)
list.insertNode(11,7)
list.printAllValues()