# LeetCode Problem Solutions in C#

## Introduction
🚀 Welcome to my LeetCode Problem Solutions repository! Ready to embark on a coding adventure? You're in the right place!
<br /> 🌟 Here, you'll find a treasure trove of C# solutions to LeetCode problems. Dive into diverse algorithmic challenges, explore different topics, and level up your coding skills with a dash of fun! Happy coding! 🎉
<br /> If you find this repository helpful, please consider giving it a ⭐️!

## Table of Contents

- [Arrays & Hashing](#arrays-&-hashing)
- [Two Pointers](#two-pointers)
- [Sliding Window](#sliding-window)
- [Stack](#stack)
- [Binary Search](#binary-search)
- [Linked List](#linked-list)
- [Trees][#trees]
- [Hints](#hints)

## Arrays & Hashing

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [1. Two Sum](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/TwoSum.cs) | Easy | O(n) | O(n) | Calculate diff between curr item and target and store it and index in **Dict** <br /> - If curr item is in dict, then itis the result |
| [14. Longest Common Prefix](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/LongestCommonPrefix.cs) | Easy | O(mn) | O(k) | - Iterate through all chars in first str (outer for) <br /> - Iterate through all strings and compare chars (inner for) <br /> - If you don't reach end of some str and chars are equal, add it to the prefix (after comparing char in all strs) |
| [28. Find the Index of the First Occurrence in a String](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/) | Easy | O(mn) | O(1) | |
| [58. Length of Last Word](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/LengthOfLastWord.cs) | Easy | O(n) | O(1) | - Iterate from the end and count non-space chars <br /> - The last word will end when counter > 0 and you reach space char |
| [118. Pascal's Triangle](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/PascalsTriangle.cs) | Easy | O(n^2) | O(n^2) | - First and last items of each row = 1 <br /> - Other j item in i row = arr[i-1][j-1] + arr[i-1][j] |
| [169. Majority Element](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/MajorityElement.cs) | Easy | O(n) | O(1) | - Boyer-Moore algorithm <br /> - Set first item as major, create counter <br /> - Iterate array, if curr == major - increase counter, otherwise - decrease <br /> - If counter == 0, reassign major = curr |
| [205. Isomorphic Strings](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/IsomorphicStrings.cs) | Easy | O(n) | O(n) | - Use two **Dict** to store s->t and t->s mappings <br /> - Iterate through string, if character exists in dict, check that mapping value is correct, else - add to dict (check this for both mappings dictionaries) |
| [217. Contains Duplicate](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ContainsDuplicate.cs) | Easy | O(n) | O(n) | - Write values to **Hash Set** <br /> - If already exists - true, otherwise - false |
| [242. Valid Anagram](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ValidAnagram.cs) | Easy | O(n) | O(n) | - Save counts of chars of s1 in **Dict** <br /> - Iterate s2, check that every char exists in dict and decrease count <br /> - Iterate Dict and check that all count = 0 |
| [290. Word Pattern](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/IsSubsequence.cs) | Easy | O(n) | O(1) | - Split string by space into words <br /> - Use two **Dict** for storing: word to pattern mapping and pattern to word mapping <br /> - If mapping violates - return false, otherwise - true |
| [303. Range Sum Query - Immutable](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/IsSubsequence.cs) | Easy | Constructor: O(n) <br /> SumRange: O(1) | Constructor: O(n) <br /> SumRange: O(1) | - Calulate prefix sums (left side + curr)  <br /> - Range sum = prefixSums[ right ] - prefixSums[ left-1 ] |
| [392. Is Subsequence](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/WordPattern.cs) | Easy | O(n) | O(n) | - Use two indexes for interation s1 and s2. <br /> - Iterate s1 index when chars equals |
| [448. Find All Numbers Disappeared in an Array](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/FindAllNumbersDisappearedInArray.cs) | Easy | O(n) | O(1) | - Iterate through array and mark item position (nums[ i ] - 1) as negative, use Abs <br /> - Positions that are postive - missed numbers (index + 1) |
| [605. Can Place Flowers](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/CanPlaceFlowers.cs) | Easy | O(n) | O(1) | - Iterate if previous, current, next place = 0 - place flower  |
| [724. Find Pivot Index](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/FindPivotIndex.cs) | Easy | O(n) | O(1) | - Calculate total sum <br /> - Iterate array from start and calculate left side sum <br /> - Right side sum = total - left - curr <br /> - Compare left and right sums |
| [929. Unique Email Addresses](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/UniqueEmailAddresses.cs) | Easy | O(nm) | O(n) | - Normalize each email, using split and replace <br /> - Add each unique email to **Hash Set** and return set count |
| [1189. Maximum Number of Balloons](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/MaximumNumberOfBalloons.cs) | Easy | O(n) | O(n) | - Count the frequency of letters in given string and store in **Dict** <br /> - Iterate through dict, possible count = total frequency / freq in word; return minimum count |
| [1299. Replace Elements with Greatest Element on Right Side](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ReplaceElementsWithGreatestElementOnRightSide.cs) | Easy | O(N) | O(N) | - For the last iten, greatest = -1, for second from end = last item <br /> - Iterate array from end, set greatest (at first is last item) <br /> - Update greatest var if current is greater |
| [1603. Design Parking System](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ParkingSystem.cs) | Easy | O(1) | O(n) | - Use array with three items, each item - parking places count for specific type |
| [1822. Sign of the Product of an Array](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/SignOfTheProductOfArray.cs) | Easy | O(N) | O(1) | - Do not multiply values, just create var = 1, multiply to -1 if nums[ i ] < 0 or return 0 if nums[ i ] = 0 |
| [1929. Concatenation of Array](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ConcatenationOfArray.cs) | Easy | O(N) | O(N) | - Create array with n*2 length <br /> - Fill values to i and i+n positions |
| [2215. Find the Difference of Two Arrays](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/FindTheDifferenceOfTwoArrays.cs) | Easy | O(n+m) | O(n+m) | - Convert arrays to **Hash Sets** <br /> - Check existence for both nums1 and nums2 |

## Two Pointers

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [26. Remove Duplicates from Sorted Array](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/RemoveDuplicatesFromSortedArray.cs) | Easy | O(n) | O(1) | - Maintain index to replace <br /> - Next item should be greater then previous |
| [27. Remove Element](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/RemoveDuplicatesFromSortedArray.cs) | Easy | O(n) | O(1) | - Use two pointers (start, end) <br /> - If you find value - swap start and end values and decrease end pointer, otherwise - increase start pointer  |
| [88. Merge Sorted Array](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/MergeSortedArray.cs) | Easy | O(n+m) | O(1) | - Merge arrays in reverse order <br /> - Three pointers (last item of arr1, last item of arr2, last item of result arr)  <br /> - Compare values |
| [125. Valid Palindrome](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ValidPalindrome.cs) | Easy | O(N) | O(1) | - Two pointers (start, end) <br /> - Move each pointer untill value will be letter or digit  <br /> - If values are not equal - return false |
| [283. Move Zeroes](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/MoveZeroes.cs) | Easy | O(N) | O(1) | - Maintain index to replace <br /> - Iterate array, swap non zero value with index to replace position  <br /> - Update index to replace |
| [344. Reverse String](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ReverseString.cs) | Easy | O(N) | O(1) | - Two pointers (start, end) <br /> - Swap chars |
| [680. Valid Palindrome II](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ValidPalindromeII.cs) | Easy | O(N) | O(1) | - Two pointers (start, end) <br /> - Move each pointer while values are equal  <br /> - If values are not equal - 2 options available: skip left character or right <br /> - Use helper method to check both options |
| [1768. Merge Strings Alternately](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/MergeStringsAlternately.cs) | Easy | O(N) | O(n+m) | - Iterate to the end of smaller string, building result <br /> - Iterate larger string |

## Sliding Window

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [1984. Minimum Difference Between Highest and Lowest of K Scores](AlgorithmsAndDS/AlgorithmsAndDS/SlidingWindow/Easy/MinimumDifferenceBetweenHighestAndLowestOfKScores.cs) | Easy | O(nlog(n)) | O(1) | - Sort array <br /> - Create sliding window of size k  <br /> - Calculate min diff between first and last items of window <br /> - Iterate and update min value |

## Stack

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [20. Valid Parentheses](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Easy/ValidParentheses.cs) | Easy | O(n) | O(n) | - Push open braces to stack <br /> - If current item is closing breace, it should be the same type as top of the stack  <br /> - If it's true pop value and continue, otherwise - false |
| [682. Baseball Game](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Easy/BaseballGame.cs) | Easy | O(n) | O(n) | - Push digits to stack <br /> - During operation, pop items, modify stack, calculateresult |

## Binary Search

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [35. Search Insert Position](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/SearchInsertPosition.cs) | Easy | O(log(n)) | O(1) | - Binary search while l <= r <br /> - Insert position will be left pointer |
| [704. Binary Search](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/BinarySearch.cs) | Easy | O(log(n)) | O(1) | - Two pointers (start, end) in sorted array <br /> - Calculate mid, if mid == target than return <br /> - Update left or right pointer according to mid |
| [374. Guess Number Higher or Lower](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/GuessNumberHigherOrLower.cs) | Easy | O(log(n)) | O(1) | - Binary search while l <= r <br /> - To compare mid value use guess function |
| [441. Arranging Coins](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/ArrangingCoins.cs) | Easy | O(log(n)) | O(1) | - Binary search while start <= end <br /> - Calculate sum of range 1...mid using formula: S = (n/2) * (1 + n) <br /> - Compare sum and n and update pointers <br /> - Since at the end start > end, start will start pointing to a value greater than the desired result. Return end as it will point to the correct value. |

## Linked List

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [21. Merge Two Sorted Lists](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/MergeTwoSortedLists.cs) | Easy | O(n) | O(1) | Create dummy node, iterate while list1 & list2 != null, fill values, then do not forget larger list values |
| [83. Remove Duplicates from Sorted List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/RemoveDuplicatesFromSortedList.cs) | Easy | O(n) | O(1) | Iterate the list, update pointers if curr.value == curr.next.val (or prev.val == curr.val) |
| [141. Linked List Cycle](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/LinkedListCycle.cs) | Easy | O(n) | O(1) | Use slow and fast (2 x slow) pointers <br /> - If slow == fast, then cycle exists |
| [160. Intersection of Two Linked Lists](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/IntersectionOfTwoLinkedLists.cs) | Easy | O(n + m) | O(1) | - Use two pointers pointerA and pointerB <br /> - When pointerA will reach end, then pointerA = headB  <br /> - When pointerB will reach end, then pointerB = headA <br />  - When pointerA == pointerB - it's intersection |
| [203. Remove Linked List Elements](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/RemoveLinkedListElements.cs) | Easy | O(n) | O(1) | - Create dummy node with next = head <br /> - Iterate with prev = dummy, curr = head <br /> - If curr.val == search val,then prev.next = curr.next |
| [206. Reverse Linked List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/ReverseLinkedList.cs) | Easy | O(n) | O(1) | Create two nodes, prev = null, curr = head <br /> - Iterate while curr != null and reverse pointers to prev node <br /> - Return prev node as new head |
| [234. Palindrome Linked List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/PalindromeLinkedList.cs) | Easy | O(n) | O(1) | - Slow and fast pointer while fast?.next != null (slow pointer will be the middle) <br /> - Reverse second part of the list  <br /> - Compare values from start and end |
| [876. Middle of the Linked List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/MiddleOfTheLinkedList.cs) | Easy | O(n) | O(1) | Use slow and fast (2 x slow) pointers while fast?.next != null <br /> - Slow pointer will be the middle in the end |

## Trees

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [94. Binary Tree Inorder Traversal](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/BinaryTreeInorderTraversal.cs) | Easy | O(n) | O(n) | - For iterative approach use stack (while stack.Any || currNode != null) <br /> - If currNode != null - push node to stack, go left  <br /> - If currNode == null - get prevNode from stack, add value to result,go the prevNode.right |
| [104. Maximum Depth of Binary Tree](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/MaximumDepthOfBinaryTree.cs) | Easy | O(n) | O(n) | - DFS iterative - use stack to store nodes and depth <br /> - BFS iterative - use queue to count levels <br /> - Recursion - return Max of recursive calls of left and right children + 1 |
| [144. Binary Tree Preorder Traversal](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/BinaryTreePreorderTraversal.cs) | Easy | O(n) | O(n) | - For iterative approach use stack (while stack.Any || currNode != null) <br /> - If currNode != null - add value to result, push currNode.right to stack, go left  <br /> - If currNode == null - currNode = node from stack |
| [145. Binary Tree Postorder Traversal](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/BinaryTreePostorderTraversal.cs) | Easy | O(n) | O(n) | - For iterative approach use stack (while stack.Any) to store node ond visited flag, push rootto stack <br /> - Pop from stack, if visited - add to result, otherwise - push curr as visited, left and right as not visited to stack |
| [226. Invert Binary Tree](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/BinaryTreePostorderTraversal.cs) | Easy | O(n) | O(n) | - Check null, swap left and right children, recursive call for both left and right child |

## Hints

- Find range sum/sum in array - prefix/postfix sum of array
- Find item in sorted array - binary search
- Move or remove elements in array - two pointers

## Algorithms

- Boyer-Moore
