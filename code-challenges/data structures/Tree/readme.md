# ***Data Structure Implementation README***
------------------------------

# Binary Tree and Binary Search Tree
#### *Author: Chris Morton*

------------------------------

## Description
***[A tree is a data structure that holds values in linked nodes. Each node added points to a left ad right child. There are two types of tree implemented here, a Binary Search Tree and  Binary Tree ]***

*** The methods of the Binary Search Tree are, Add, and Contains.

*** The methods of the Binary Tree are, PreOrder, InOrder and PostOrder.



------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Add | Adds a new `Node` to the `Binary Search Tree` | O(log n) | O(1) | myBST.Add(99, root) |
| Contains | searches for a node value in the `Binar Search Tree` | O(log n) | O(1) | myBST.Contains(99, root) |
| PreOrder | recusive function that looks at all nodes on the `Binary Tree` and send the values of the nodes to a list | O(1) | O(1) | myBT.PreOrder(root, list) |
| InOrder | recusive function that looks at all nodes on the `Binary Tree` and send the values of the nodes to a list | O(1) | O(1) | myBT.InOrder(root, list)
| PostOrder | recusive function that looks at all nodes on the `Binary Tree` and send the values of the nodes to a list | O(1) | O(1) | myBT.PostOrder(root, list)



------------------------------

## Visuals

![Image 1](https://github.com/cmorto02/data-structures-and-algorithms/blob/master/code-challenges/data%20structures/Tree/Tree/images/BST.JPG)

------------------------------

## Change Log
1.1: *Added all of the unit testing and summary comments* 14 Apr 2019

------------------------------

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
