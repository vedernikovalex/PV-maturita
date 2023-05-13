class Node:
    def __init__(self,value):
        self.value = value
        self.next = None


class LinkedList:
    def __init__(self):
        self.head = None

    def AddNode(self, node):
        if self.head == None:
            self.head = node
        else:
            lastNode = self.head
            newNode = node
            newNode.next = lastNode
            self.head = newNode

    def __str__(self):
        currHead = self.head
        toPrint = ""
        while currHead.next != None:
            toPrint += (str(currHead.value) + " -> " + str(currHead.next.value))
            nextNode = currHead.next
            currHead.value = nextNode.value
            currHead.next = nextNode.next
        return toPrint

node1 = Node(1)
node2 = Node(2)
node3 = Node(3)
node4 = Node(4)
linkedlist = LinkedList()

linkedlist.AddNode(node1)
linkedlist.AddNode(node2)
linkedlist.AddNode(node3)
linkedlist.AddNode(node4)

print(linkedlist)