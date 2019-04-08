# ***Data Structure Implementation README***
------------------------------

# Stacks and Queues
#### *Author: Chris Morton*

------------------------------

## Description
***[A stack is a data structure that holds values in linked nodes. Each node added points to the next node down in the stack. This is a first in last out structure, so the last one you put on the stack is the first one to come off]***

*** The methods of the stack are Push, Pop, and Peek. 

***[A queue is a data structure that holds values in linked nodes. Each node added points to the next node back in the queue. This is a first in first out structure, so the last one you put in the queue is the last one to come out]***

*** The methods of the queue are Enqueue, Dequeue, and Peek. 

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Push | Adds a new `Node` to the `Stack` | O(1) | O(1) | myStack.Push(99) |
| Pop | Removes a node from the `Stack` | O(1) | O(1) | myStack.Pop() |
| Peek | Looks at the value of the first node on the`Stack` | O(1) | O(1) | myStack.Peek() |
| Enqueue | Adds a new `Node` to the `Queue` | O(1) | O(1) | myQueue.Enqueue(99) |
| Dequeue | Removes the first node in the `Queue` | O(1) | O(1) | myQueue.Dequeue(99) |
| Peek | Looks at the value of the first node in the `Queue` | O(1) | O(1) | myQueue.Peek(99) |



------------------------------

## Visuals

![Image 1](https://github.com/cmorto02/data-structures-and-algorithms/blob/master/code-challenges/data%20structures/SinglyLinkedList/SinglyLinkedList/LinkedListTesting/images/SLL.JPG)

##### Push Method
*The Push Method takes in an int as a parameter. A new Node is then created using the* 
*int param as its Value. The new Node is then placed in the Stack at the top and*
*the previous top is assigned as the new Nodes Next.*
##### Pop Method
*Removes the top node of the stack and reassigns its next as the new top*
##### Peek Method
*Returns the value of the data in the top node of the stack.*
##### Enqueue Method
*Takes in an int as a parameter, creates a new node and adds it to the back of the queue reassigning the preveios `Back` as the new node.*
##### Dequeue Method
*Removes the front node of the queue, and reassigns the next node as the front.*
##### Peek Method
*Returns the value of the first node in the queue. *
------------------------------

## Change Log
1.1: *Added all of the unit testing and summary comments* 7 Apr 2019

------------------------------

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
