# ***Data Structure Implementation README***
------------------------------

# Linked List
#### *Author: Chris Morton*

------------------------------

## Description
***[A linked list is a data structure that holds values in linked nodes. Each node points to the next node in a singly linked list and each node points to the next and previous in a doubly linke list]***

A C# implementation of a `Singly Linked List`. Singly Linked Lists contain individual nodes that have a reference to the `Next` node in the list as well as a `Value`. The methods of this `Linked List` are `Insert`, `Includes`, `Print`, `Append`, `InsertAfter`, `InsertBefore` and `KthFromTheEnd`.

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Insert | Adds a new `Node` to the `Linked List` | O(1) | O(1) | myList.Insert(99) |
| Includes | Takes in a value and returns a boolean depending on if the value is in the `LinkedList` | O(n) | O(1) | myList.Includes(99) |
| Print | Prints the `Linked List` to the console | O(n) | O(1) | myList.Print() |
| Append | Adds a new `Node` to the end of the `LinkedList` | O(n) | O(1) | myList.Append(99) |
| InsertAfter | Adds a new `Node` to the `LinkedList` after the `Node` of a specified value | O(n) | O(1) | myList.InsertAfter(98, 99) |
| InsertBefore | Adds a new `Node` to the `LinkedList` before the `Node` of a specified value | O(n) | O(1) | myList.InsertBefore(98, 99) |
| KthFromTheEnd | returns the value of a `Node` that is the Kth from the end of the `Linked List` | O(n) | O(1) | myList.KthFromTheEnd(5) |





------------------------------

## Visuals

![Image 1](https://github.com/cmorto02/data-structures-and-algorithms/blob/master/code-challenges/data%20structures/SinglyLinkedList/SinglyLinkedList/LinkedListTesting/images/SLL.JPG)

##### Insert Method
*The Insert Method takes in an int as a parameter. A new Node is then created using the* 
*int param as its Value. The new Node is then placed in the Linked List at the Head and*
*the previous Head is assigned as the new Nodes Next.*
##### Includes Method
*The Includes Method takes in an int as a parameter then iterates through the Nodes of the*
*Linked List checking all the Values. If the value is found True is returned, if not then*
*False is returned.*
##### Print Method
*The Print Method displays a well formatted depiction of the current state of the*
*Linked List by iterating over all Nodes.*
##### Append Method
*The Append Method takes in an int as the parameter and creates a new node at the end of the linked list*
##### InsertAfter Method
*The InsertAfter Method takes in two ints as parameters and creates a new node with the value of the second parameter after the node with the value of the first parameter.*
##### InsertBefore Method
*The InsertAfter Method takes in two ints as parameters and creates a new node with the value of the second parameter before the node with the value of the first parameter.*
##### KthFromTheEnd Method
The KthFromTheEndMethod takes in an int as a parameter and returns the node that is the the parameter places from the end of the list.

------------------------------

## Change Log
1.3: *Added all of the unit testing, summary comments, and refactored the print method* 30 March 2019
1.2: *Added the kth from the end method* 27 March 2019
1.1: *Added the append, insertbefore and insertafter methods.* 26 March 2019

------------------------------

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
