class Node:
    def __init__(self, value):
        self.value = value
        self.next = None


class LinkedList:
    def __init__(self):
        self.head = None
        self.tail = None

    def append(self, value):
        new_node = Node(value)
        if self.head is None:
            self.head = new_node
            self.tail = new_node
        else:
            self.tail.next = new_node
            self.tail = new_node

    def delete(self, value):
        if self.head is None:
            return
        if self.head.value == value:
            self.head = self.head.next
            if self.head is None:
                self.tail = None
            return
        current_node = self.head
        while current_node.next is not None:
            if current_node.next.value == value:
                current_node.next = current_node.next.next
                if current_node.next is None:
                    self.tail = current_node
                return
            current_node = current_node.next

    def __str__(self):
        values = []
        current_node = self.head
        while current_node is not None:
            values.append(str(current_node.value))
            current_node = current_node.next
        return ' -> '.join(values)
