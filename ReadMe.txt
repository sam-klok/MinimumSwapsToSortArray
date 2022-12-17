You are given an unordered array consisting of consecutive integers  [1, 2, 3, ..., n] without any duplicates. 
You are allowed to swap any two elements. 
Find the minimum number of swaps required to sort the array in ascending order.


Solution: because it's consecutive integers, we can create corresponding indices, which match each proper location.
[1,3,2] --> indeces are [1,2,3] and corresponding proper locations [1,2,3] 
(let's start indexing from 1, not from 0, for easier match)
So we each swap should put at least one item to proper location. Or better both items.

Note: it's "minimum swaps", and not "the best time". 