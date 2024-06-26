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
- [Trees](#trees)
- [Priority Queue](#priority-queue)
- [Backtracking](#backtracking)
- [Graphs](#graphs)
- [Dynamic Programming](#dynamic-programming)
- [Hints](#hints)
- [Tries](#tries)
- [Intervals](#intervals)
- [Math & Geometry](#math--geometry)
- [Bit Manipulation](#bit-manipulation)
- [Greedy](#greedy)

## Arrays & Hashing

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [1. Two Sum](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/TwoSum.cs) | Easy | O(n) | O(n) | Calculate diff between curr item and target and store it and index in **Dict** <br /> - If curr item is in dict, then itis the result |
| [14. Longest Common Prefix](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/LongestCommonPrefix.cs) | Easy | O(mn) | O(k) | - Iterate through all chars in first str (outer for) <br /> - Iterate through all strings and compare chars (inner for) <br /> - If you don't reach end of some str and chars are equal, add it to the prefix (after comparing char in all strs) |
| [28. Find the Index of the First Occurrence in a String](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/FindTheIndexOfTheFirstOccurrenceInString.cs) | Easy | O(mn) | O(1) | |
| [36. Valid Sudoku](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Medium/ValidSudoku.cs) | Easy | O(n^2) | O(n^2) | - Use dictionaries with hash set to store items for each row, column and subboard (i/3, j/3) <br /> - Iterate through all items, if item already exists in rows or cols or subboard[ i/3 ][ j/3 ] - return false |
| [49. Group Anagrams](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Medium/GroupAnagrams.cs) | Medium | O(nm) | O(n) | - Use **Dictionary** to store groups <br /> - To calculate key, create char array of 26 items, iterate string and increment index of curr char (index = currChar - 'a'), convert char array to string <br /> - If current key already exists in dictionary, add string to values |
| [58. Length of Last Word](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/LengthOfLastWord.cs) | Easy | O(n) | O(1) | - Iterate from the end and count non-space chars <br /> - The last word will end when counter > 0 and you reach space char |
| [118. Pascal's Triangle](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/PascalsTriangle.cs) | Easy | O(n^2) | O(n^2) | - First and last items of each row = 1 <br /> - Other j item in i row = arr[i-1][j-1] + arr[i-1][j] |
| [128. Longest Consecutive Sequence](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Medium/LongestConsecutiveSequence.cs) | Medium | O(n) | O(n) | - Write all nums in **HashSet* <br /> - Iterate array and skip num if set contains num+1 value, in order to find the biggest possible num to start <br /> - When biggest possible to start is found, count length while set contains num - 1 value |
| [169. Majority Element](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/MajorityElement.cs) | Easy | O(n) | O(1) | - Boyer-Moore algorithm <br /> - Set first item as major, create counter <br /> - Iterate array, if curr == major - increase counter, otherwise - decrease <br /> - If counter == 0, reassign major = curr |
| [205. Isomorphic Strings](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/IsomorphicStrings.cs) | Easy | O(n) | O(n) | - Use two **Dict** to store s->t and t->s mappings <br /> - Iterate through string, if character exists in dict, check that mapping value is correct, else - add to dict (check this for both mappings dictionaries) |
| [217. Contains Duplicate](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ContainsDuplicate.cs) | Easy | O(n) | O(n) | - Write values to **Hash Set** <br /> - If already exists - true, otherwise - false |
| [238. Product of Array Except Self](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Medium/ProductOfArrayExceptSelf.cs) | Easy | O(n) | O(1) | - Calculate prefix product and store in result array <br /> - Calculate postfix product for each item and multiply on result item (prefix product) |
| [242. Valid Anagram](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/ValidAnagram.cs) | Easy | O(n) | O(n) | - Save counts of chars of s1 in **Dict** <br /> - Iterate s2, check that every char exists in dict and decrease count <br /> - Iterate Dict and check that all count = 0 |
| [290. Word Pattern](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/IsSubsequence.cs) | Easy | O(n) | O(1) | - Split string by space into words <br /> - Use two **Dict** for storing: word to pattern mapping and pattern to word mapping <br /> - If mapping violates - return false, otherwise - true |
| [303. Range Sum Query - Immutable](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/IsSubsequence.cs) | Easy | Constructor: O(n) <br /> SumRange: O(1) | Constructor: O(n) <br /> SumRange: O(1) | - Calulate prefix sums (left side + curr)  <br /> - Range sum = prefixSums[ right ] - prefixSums[ left-1 ] |
| [347. Top K Frequent Elements](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Medium/TopKFrequentElements.cs) | Medium | O(n) | O(n) | - Calculate frequency of each item and store in **Dictionary** <br /> - Write all frequencies to 2-dimesional array, where index - frequency, array - numbers with such frequency <br /> - Iterate from end of the array and add K elements to result |
| [392. Is Subsequence](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/WordPattern.cs) | Easy | O(n) | O(n) | - Use two indexes for interation s1 and s2. <br /> - Iterate s1 index when chars equals |
| [448. Find All Numbers Disappeared in an Array](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/FindAllNumbersDisappearedInArray.cs) | Easy | O(n) | O(1) | - Iterate through array and mark item position (nums[ i ] - 1) as negative, use Abs <br /> - Positions that are postive - missed numbers (index + 1) |
| [496. Next Greater Element I](AlgorithmsAndDS/AlgorithmsAndDS/ArraysAndHashing/Easy/NextGreaterElementI.cs) | Easy | O(n+m) | O(m) | - Use **Dict* to store nums1 items and index <br /> - Use a stack to keep a decreasing sub-sequence, whenever we see a number x greater than stack.peek() we pop all elements less than x and for all the popped ones, their next greater element is x |
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
| [11. Container With Most Water](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Medium/ContainerWithMostWater.cs) | Medium | O(n) | O(1) | - Use two pointers: start, end <br /> - Calculate area, update maxArea var if needed, if left height is greater then right - decrease end pointer, otherwise - increase start pointer |
| [15. 3Sum](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Medium/ThreeSum.cs) | Medium | O(n^2) | O(1) | - Sort array <br /> - Iterate array and for each item solve Two Sum With Sorted Array (use two pointers) |
| [26. Remove Duplicates from Sorted Array](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/RemoveDuplicatesFromSortedArray.cs) | Easy | O(n) | O(1) | - Maintain index to replace <br /> - Next item should be greater then previous |
| [27. Remove Element](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/RemoveDuplicatesFromSortedArray.cs) | Easy | O(n) | O(1) | - Use two pointers (start, end) <br /> - If you find value - swap start and end values and decrease end pointer, otherwise - increase start pointer |
| [80. Remove Duplicates from Sorted Array II](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Medium/RemoveDuplicatesFromSortedArrayII.cs) | Medium | O(n) | O(1) | - Use two pointers (i - iterate all items, indexToReplace) <br /> - Just go through the numbers and include those in the result that haven't been included twice already (nums[ i ] != nums[ indexToReplace - 2 ]) |
| [88. Merge Sorted Array](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/MergeSortedArray.cs) | Easy | O(n+m) | O(1) | - Merge arrays in reverse order <br /> - Three pointers (last item of arr1, last item of arr2, last item of result arr)  <br /> - Compare values |
| [125. Valid Palindrome](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ValidPalindrome.cs) | Easy | O(n) | O(1) | - Two pointers (start, end) <br /> - Move each pointer untill value will be letter or digit  <br /> - If values are not equal - return false |
| [167. Two Sum II - Input Array Is Sorted](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Medium/TwoSumII_InputArrayIsSorted.cs) | Medium | O(n) | O(1) | - Two pointers (left, right) <br /> - Calculate sum, if sum > target - decrease right pointer, sum < target - increase left pointer, sum = target - return indices |
| [189. Rotate Array](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Medium/RotateArray.cs) | Medium | O(n) | O(1) | - Make k % nums.Length to avoid redundant rotations <br /> - Reverse whole array <br /> - Reverse only first k elements (those elements that we want to shift) <br /> - Reverse other elements after k elements |
| [283. Move Zeroes](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/MoveZeroes.cs) | Easy | O(n) | O(1) | - Maintain index to replace <br /> - Iterate array, swap non zero value with index to replace position  <br /> - Update index to replace |
| [344. Reverse String](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ReverseString.cs) | Easy | O(n) | O(1) | - Two pointers (start, end) <br /> - Swap chars |
| [680. Valid Palindrome II](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ValidPalindromeII.cs) | Easy | O(n) | O(1) | - Two pointers (start, end) <br /> - Move each pointer while values are equal  <br /> - If values are not equal - 2 options available: skip left character or right <br /> - Use helper method to check both options |
| [881. Boats to Save People](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/ValidPalindromeII.cs) | Medium | O(nlog(n)) | O(n) | - Sort an array and use two pointers to iterate <br /> - If sum of two items <= limit - increase left pointer <br /> - Decrease right pointer, increase counter |
| [1768. Merge Strings Alternately](AlgorithmsAndDS/AlgorithmsAndDS/TwoPointers/Easy/MergeStringsAlternately.cs) | Easy | O(n) | O(n+m) | - Iterate to the end of smaller string, building result <br /> - Iterate larger string |

## Sliding Window

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [3. Longest Substring Without Repeating Characters](AlgorithmsAndDS/AlgorithmsAndDS/SlidingWindow/Medium/LongestSubstringWithoutRepeatingCharacters.cs) | Medium | O(n) | O(k) | - Use two pointers left and right starting from 0 position and **HashSet** to store chars <br /> - While right position char is in Set, remove left pointer char from set and increase left <br /> - After previous step all chars are unique - calculate max and continue until the end |
| [424. Longest Repeating Character Replacement](AlgorithmsAndDS/AlgorithmsAndDS/SlidingWindow/Medium/LongestRepeatingCharacterReplacement.cs) | Medium | O(n) | O(1) | - Use two pointers left and right starting from 0 <br /> - While iterating add frequency of each character in **Dictionary** <br /> - Store max frequance as maxFreq <br /> - While currLength - maxFreq > k - decrease left pointer char frequency, increase left pointer <br /> - max(result, currLength) |
| [1984. Minimum Difference Between Highest and Lowest of K Scores](AlgorithmsAndDS/AlgorithmsAndDS/SlidingWindow/Easy/MinimumDifferenceBetweenHighestAndLowestOfKScores.cs) | Easy | O(nlog(n)) | O(1) | - Sort array <br /> - Create sliding window of size k  <br /> - Calculate min diff between first and last items of window <br /> - Iterate and update min value |

## Stack

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [20. Valid Parentheses](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Easy/ValidParentheses.cs) | Easy | O(n) | O(n) | - Push open braces to stack <br /> - If current item is closing breace, it should be the same type as top of the stack  <br /> - If it's true pop value and continue, otherwise - false |
| [150. Evaluate Reverse Polish Notation](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Easy/ValidParentheses.cs) | Medium | O(n) | O(n) | - Iterate throuth tokens and push digits to stack <br /> - If curr item is operation, pop two values from stack, calculate and push to stack |
| [155. Min Stack](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Medium/MinStack.cs) | Medium | O(1) | O(n) | - Use two stacks to store values and min values (or use one stack with tuple)  <br /> - While pushing new value, compare it with last min value in stack to identify new min |
| [682. Baseball Game](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Easy/BaseballGame.cs) | Easy | O(n) | O(n) | - Push digits to stack <br /> - During operation, pop items, modify stack, calculateresult |
| [739. Daily Temperatures](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Medium/DailyTemperatures.cs) | Medium | O(n) | O(n) | - Iterate and push item and index to stack <br /> - While item > top in stack - calculate result subtracting indexes |
| [853. Car Fleet](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Medium/CarFleet.cs) | Medium | O(n) | O(n) | - Sort array by position <br /> - Iterate from last position, calculate left hours to target <br /> - Use stack to store values, push if leftHours > stack.Peek, return stack count |
| [946. Validate Stack Sequences](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Medium/ValidateStackSequences.cs) | Easy | O(n) | O(n) | Iterate and push item to stack and check while stack.Peek() == popped item - pop from stack |
| [2390. Removing Stars From a String](AlgorithmsAndDS/AlgorithmsAndDS/Stacks/Medium/RemovingStarsFromString.cs) | Medium | O(n) | O(n) | Use stack to store all chars before *, pop from stack when it is * |

## Binary Search

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [33. Search in Rotated Sorted Array](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Medium/SearchInRotatedSortedArray.cs) | Medium | O(log(n)) | O(1) | - Binary search while l <= r <br /> - If left <= mid and target in this range - go left, otherwise - go right <br /> - If left > mid and target in range between mid and right - go right, otherwise - go left |
| [35. Search Insert Position](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/SearchInsertPosition.cs) | Easy | O(log(n)) | O(1) | - Binary search while l <= r <br /> - Insert position will be left pointer |
| [74. Search a 2D Matrix](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Medium/SearchA2DMatrix.cs) | Medium | O(log(n*m)) | O(1) | - Option 1: Binary search while l <= r <br /> - Left = 0, right = rows * cols - 1 <br /> - Indexes: row = mid / cols; col = mid % cols <br /> - Option 2: use binary search to find row, then binary search in row to find target |
| [153. Find Minimum in Rotated Sorted Array](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Medium/FindMinimumInRotatedSortedArray.cs) | Medium | O(log(n)) | O(1) | - Binary search while l < r <br /> - If mid > rifht - go right, otherwise - go left <br /> - Min value will be on left pointer position at the end |
| [704. Binary Search](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/BinarySearch.cs) | Easy | O(log(n)) | O(1) | - Two pointers (start, end) in sorted array <br /> - Calculate mid, if mid == target than return <br /> - Update left or right pointer according to mid |
| [374. Guess Number Higher or Lower](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/GuessNumberHigherOrLower.cs) | Easy | O(log(n)) | O(1) | - Binary search while l <= r <br /> - To compare mid value use guess function |
| [441. Arranging Coins](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Easy/ArrangingCoins.cs) | Easy | O(log(n)) | O(1) | - Binary search while start <= end <br /> - Calculate sum of range 1...mid using formula: S = (n/2) * (1 + n) <br /> - Compare sum and n and update pointers <br /> - Since at the end start > end, start will start pointing to a value greater than the desired result. Return end as it will point to the correct value. |
| [540. Single Element in a Sorted Array](AlgorithmsAndDS/AlgorithmsAndDS/BinarySearch/Medium/SingleElementInASortedArray.cs) | Medium | O(log(n)) | O(1) | - Binary search while start <= end <br />  - Calculate length of one side (without the same element), if it's odd - use this side to search, otherwise - another |

## Linked List

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [2. Add Two Numbers](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/AddTwoNumbers.cs) | Medium | O(n) | O(n) | Don't forget to calulate value to add for next item (sum / 10), curr val = val % 10. Iterate while l1 != null || l2 != null || valueToadd > 0 |
| [19. Remove Nth Node From End of List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/RemoveNthNodeFromEndOfList.cs) | Medium | O(n) | O(1) | - Use one pointer (fast) and move it forward on N nodes <br /> - If fast == null, it means to remove head - return head.next <br /> - Use slow pointer from the begging and move slow and fast, until fast.next != null <br /> -  Slow pointer'll be before node to delete |
| [21. Merge Two Sorted Lists](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/MergeTwoSortedLists.cs) | Easy | O(n) | O(1) | Create dummy node, iterate while list1 & list2 != null, fill values, then do not forget larger list values |
| [23. Merge k Sorted Lists](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Hard/MergeKSortedLists.cs) | Easy | O(n*log(n)) | O(n) | - Option 1: Add all nodes to **MinHeap**, while minHeap.Any - pop node, add to result, push node.next to queue <br /> - Option 2 (Divide and Conquer): use MergerTwoSortedLists function to merge all lists |
| [61. Rotate List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/RotateList.cs) | Medium | O(n) | O(1) | - Find list length <br /> - Use k % length to avoid redundant operations <br /> - Use slow and fast pointers to get last node and previous node to K node from end <br /> - Move tail nodes to the beginning |
| [83. Remove Duplicates from Sorted List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/RemoveDuplicatesFromSortedList.cs) | Easy | O(n) | O(1) | Iterate the list, update pointers if curr.value == curr.next.val (or prev.val == curr.val) |
| [86. Partition List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/PartitionList.cs) | Medium | O(n) | O(n) | - Use two linked lists to store smaller then x nodes and equals or bigger <br /> - Joins two lists together |
| [92. Reverse Linked List II](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/ReverseLinkedListII.cs) | Medium | O(n) | O(1) | Find left node, reverse nodes up to right node, update pointers |
| [138. Copy List with Random Pointer](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/RemoveDuplicatesFromSortedList.cs) | Medium | O(n) | O(n) | Use **Dictionary** to store old node -> new node mappings <br /> |
| [141. Linked List Cycle](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/LinkedListCycle.cs) | Easy | O(n) | O(1) | Use slow and fast (2 x slow) pointers <br /> - If slow == fast, then cycle exists |
| [146. LRU Cache](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/LRUCache.cs) | Medium | O(1) | O(n) | - Use **LinkedList** for cache, use **Dictionary** to store key -> ListNode mapping <br /> - Get: if in dict - remove from list and add to the start of list, return value <br /> - Put: if not in dict and no capacity - remove last item, add new node to start of list |
| [143. Reorder List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/ReorderList.cs) | Medium | O(n) | O(1) | - Use slow and fast pointers to get mid item <br /> - Reverse second part of list <br /> - Using start pointer and last (will be available after reversing) to rearrange list |
| [147. Insertion Sort List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/InsertionSortList.cs) | Medium | O(n^2) | O(1) | - If item curr item is less then previous, find correct place from the beginning and insert |
| [160. Intersection of Two Linked Lists](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/IntersectionOfTwoLinkedLists.cs) | Easy | O(n + m) | O(1) | - Use two pointers pointerA and pointerB <br /> - When pointerA will reach end, then pointerA = headB  <br /> - When pointerB will reach end, then pointerB = headA <br />  - When pointerA == pointerB - it's intersection |
| [203. Remove Linked List Elements](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/RemoveLinkedListElements.cs) | Easy | O(n) | O(1) | - Create dummy node with next = head <br /> - Iterate with prev = dummy, curr = head <br /> - If curr.val == search val,then prev.next = curr.next |
| [206. Reverse Linked List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/ReverseLinkedList.cs) | Easy | O(n) | O(1) | Create two nodes, prev = null, curr = head <br /> - Iterate while curr != null and reverse pointers to prev node <br /> - Return prev node as new head |
| [234. Palindrome Linked List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/PalindromeLinkedList.cs) | Easy | O(n) | O(1) | - Slow and fast pointer while fast?.next != null (slow pointer will be the middle) <br /> - Reverse second part of the list  <br /> - Compare values from start and end |
| [287. Find the Duplicate Number](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/FindTheDuplicateNumber.cs) | Medium | O(n) | O(1) | - We need to find the start of cycle. Use slow and fast (2x) pointers and iterate array while slow != fast - it's first intersection. Now the distance from the array beginning to start of cycle equals distance between intersection to start of cycle. So use new slow2 pointer from the array start and move slow, slow2 pointers until slow != slow2 |
| [725. Split Linked List in Parts](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/SplitLinkedListInParts.cs) | Medium | O(n) | O(n) | - Calculate list length, part size ( length / k), nodes remainder (length % k) <br /> - Iterate and create parts of calculated size + 1 (if remainder > 0) |
| [876. Middle of the Linked List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Easy/MiddleOfTheLinkedList.cs) | Easy | O(n) | O(1) | Use slow and fast (2 x slow) pointers while fast?.next != null <br /> - Slow pointer will be the middle in the end |
| [1472. Design Browser History](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/DesignBrowserHistory.cs) | Easy | O(n) - Back, Forward <br /> O(1) - visit | O(n) | Use double linked list to store history (or two stacks) |
| [1721. Swapping Nodes in a Linked List](AlgorithmsAndDS/AlgorithmsAndDS/LinkedLists/Medium/SwappingNodesInALinkedList.cs) | Medium | O(n) | O(1) | - Use pointer and move it on to K node - it will be Kth node from the beginning <br /> - Use existing pointer (fast) and create new from head (start) <br /> - Iterate until fast.next != null,then start pointer'll be Kth node from end <br /> - Swap values |

## Trees

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [94. Binary Tree Inorder Traversal](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/BinaryTreeInorderTraversal.cs) | Easy | O(n) | O(n) | - For iterative approach use stack (while stack.Any || currNode != null) <br /> - If currNode != null - push node to stack, go left  <br /> - If currNode == null - get prevNode from stack, add value to result,go the prevNode.right |
| [100. Same Tree](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/SameTree.cs) | Easy | O(n) | O(n) | Check that values of trees nodes are equal, use recursion to repeat for each node (left and right) |
| [101. Symmetric Tree](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/SymmetricTree.cs) | Easy | O(n) | O(h) | - Start to check from root left and right children <br /> - If both null - return true, if onle one is null - false, then if left.val != right.val - return false  <br /> - Then we need to check node1.left with node2.right and node1.right with node2.left (repeat recursively) |
| [102. Binary Tree Level Order Traversal](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Medium/BinaryTreeLevelOrderTraversal.cs) | Medium | O(n) | O(n) | Iteartive BFS using queue, just get length of the queue, it'll be length of level, add level and enqueue all children (next level) |
| [103. Binary Tree Zigzag Level Order Traversal](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Medium/BinaryTreeZigzagLevelOrderTraversal.cs) | Medium | O(n) | O(n) | - Iterative BFS level order traversal usinq Queue <br /> - If level is even - write level array from the beginning, otherwise - from the end |
| [104. Maximum Depth of Binary Tree](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/MaximumDepthOfBinaryTree.cs) | Easy | O(n) | O(n) | - DFS iterative - use stack to store nodes and depth <br /> - BFS iterative - use queue to count levels <br /> - Recursion - return Max of recursive calls of left and right children + 1 |
| [108. Convert Sorted Array to Binary Search Tree](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/ConvertSortedArrayToBinarySearchTree.cs) | Easy | O(n) | O(log(n)) | - Use **Divide and Conquer** approach: mid value - node value, left subarray - left subtree, right subarray - right subtree <br /> - Use recursion for both left and right subtrees |
| [110. Balanced Binary Tree](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/MaximumDepthOfBinaryTree.cs) | Easy | O(n) | O(n) | - Find max depth of left and right children <br /> - Difference should be <= 1 <br /> - Repeat recursively for each node, if diff is invalid - mark result flag|
| [112. Path Sum](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/PathSum.cs) | Easy | O(n) | O(n) | - Iterative: use stack to store node and left sum (targetSum - node.val); use Post Order Traversal (push right and left child with calculated left sum); if leftSum == 0 and node is a leaf - return true <br /> - Recursive: use Dfs to calculate current nodes sum; if currSum == target - return true, otherwisw - dfs to left child OR dfs to right child |
| [144. Binary Tree Preorder Traversal](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/BinaryTreePreorderTraversal.cs) | Easy | O(n) | O(n) | - For iterative approach use stack (while stack.Any || currNode != null) <br /> - If currNode != null - add value to result, push currNode.right to stack, go left  <br /> - If currNode == null - currNode = node from stack |
| [145. Binary Tree Postorder Traversal](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/BinaryTreePostorderTraversal.cs) | Easy | O(n) | O(n) | - For iterative approach use stack (while stack.Any) to store node ond visited flag, push rootto stack <br /> - Pop from stack, if visited - add to result, otherwise - push curr as visited, left and right as not visited to stack |
| [199. Binary Tree Right Side View](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Medium/BinaryTreeRightSideView.cs) | Easy | O(n) | O(n) | - Iteartive BFS using queue (level order traversal) <br /> - Push to queue right child, then left <br /> - Add to result just first item from queue |
| [226. Invert Binary Tree](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/BinaryTreePostorderTraversal.cs) | Easy | O(n) | O(n) | - Check null, swap left and right children, recursive call for both left and right child |
| [230. Kth Smallest Element in a BST](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Medium/KthSmallestElementInBST.cs) | Medium | O(h) | O(h) | - Use iterative In Order Traversal with stack <br /> - Stop traversal when you reach k-th element |
| [543. Diameter of Binary Tree](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/DiameterOfBinaryTree.cs) | Easy | O(n) | O(n) | - For each node we need to identify max depth of left and right child <br /> - Calculate diameter as maxDepthLeft + maxDepthRight <br /> - Compare diameter with stored max value |
| [572. Subtree of Another Tree](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/SubtreeOfAnotherTree.cs) | Easy | O(nm) | O(nm) | For each node where value = subroot.value we need to check if it is SameTree(problem 100) or node.left/node.right is SameTree as subroot |
| [606. Construct String from Binary Tree](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/ConstructStringFromBinaryTree.cs) | Easy | O(n) | O(n) | Use DFS to recursively build string with PreOrder Traversal |
| [783. Minimum Distance Between BST Nodes](AlgorithmsAndDS/AlgorithmsAndDS/Trees/Easy/MinimumDistanceBetweenBSTNodes.cs) | Easy | O(n) | O(n) | Use inorder traversal and track previous node to calculate min difference |

## Priority Queue

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [215. Kth Largest Element in an Array](AlgorithmsAndDS/AlgorithmsAndDS/PriorityQueue/Medium/KthLargestElementInAnArray.cs) | Medium | O(n + k*log(k)) | O(k) | Use MinHeap of greatest elements of nums or QuickSelect |
| [295. Find Median from Data Stream](AlgorithmsAndDS/AlgorithmsAndDS/PriorityQueue/Hard/FindMedianFromDataStream.cs) | Medium | Add: O(log(n)) <br /> - Find: O(1) | Add: O(n) <br /> - Find: O(1) | - Use maxheap to store first part of values, minheap - second <br /> - Always add values to maxheap, and then balance two heap: length diff should be <= 1 and maxHeap.Peek() <= minHeap.Peek()  |
| [355. Design Twitter](AlgorithmsAndDS/AlgorithmsAndDS/PriorityQueue/Medium/Twitter.cs) | Medium | | | - Use **Dictionary** with **HashSet** to store user to followees mappings <br /> - Use LinkedList to store user tweets, most recent as head <br /> - GetNewsFeed: iterate through user followees and add each TweetHead to MaxHeap; while result < 10 or maxHeap.Any - pop Tweet from heap, add to result, push to MaxHeap Tweet.Next |
| [621. Task Scheduler](AlgorithmsAndDS/AlgorithmsAndDS/PriorityQueue/Medium/TaskScheduler.cs) | Medium | O(n) | O(n) | |
| [703. Kth Largest Element in a Stream](AlgorithmsAndDS/AlgorithmsAndDS/PriorityQueue/Easy/KthLargestElementInStream.cs) | Easy | O(log(n)) | O(k) | - Put elements to MinHeap always maintaining k elements  <br /> - During adding peek element from queue and compare with value, dequeue and enqueue new value if it is greater |
| [973. K Closest Points to Origin](AlgorithmsAndDS/AlgorithmsAndDS/PriorityQueue/Medium/KClosestPointsToOrigin.cs) | Medium | O(n*log(n)) | O(n) | - Calculate distance for each point and store it in MinHeap with distance as priority; return first k elements |
| [1046. Last Stone Weight](AlgorithmsAndDS/AlgorithmsAndDS/PriorityQueue/Easy/LastStoneWeight.cs) | Easy | O(nlog(n)) | O(n) | - Put all elements into a priority queue <br /> - Pop out the two biggest, push back the difference, until there are no more two elements left |

## Backtracking

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [22. Generate Parentheses](AlgorithmsAndDS/AlgorithmsAndDS/Backtracking/Medium/GenerateParentheses.cs) | Medium | | | - Use helper backtracking method, try add open braces, then closing brace, after each adding - recursive call with updated braces counters <br /> - Don't forget that we can add closing brace only if quantity of possible to add is greater then open braces |
| [39. Combination Sum](AlgorithmsAndDS/AlgorithmsAndDS/Backtracking/Medium/CombinationSum.cs) | Medium | O(2^n) | | - Use helper backtracking method <br /> - Add result conditions: if curr sum > target - return, if equals - addcombination to result <br /> - Main part: call Backtrack to the same index, then pop item from combination and call Backtrack to the next item (use for loop for this or index) |
| [78. Subsets](AlgorithmsAndDS/AlgorithmsAndDS/Backtracking/Medium/Subsets.cs) | Medium | O(2^n) | | - Use classic helper backtracking method |
| [79. Word Search](AlgorithmsAndDS/AlgorithmsAndDS/Backtracking/Medium/WordSearch.cs) | Medium | O(n * m * 4^n) | | - Use helper backtracking method <br /> - Iterate each item and find first letter of word and run Backtrack <br /> - In backtrack control indexes and that position wasn't visited yet and that word character equals to board char  <br /> - Call backtrack for all 4 possible pathes (top, bottom, left, right)  <br /> - Remove char from visited array |
| [90. Subsets II](AlgorithmsAndDS/AlgorithmsAndDS/Backtracking/Medium/SubsetsII.cs) | Medium | O(2^n) | | - Use classic helper backtracking method as for Subset problem, but sort array at first to add condition to skip duplicates |

## Graphs

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [133. Clone Graph](AlgorithmsAndDS/AlgorithmsAndDS/Graphs/Medium/CloneGraph.cs) | Medium | O(n) | O(n) | - Use *Dictionary* to store node -> newNode mapping  <br /> - Create copy of node and save in dictionary, if doesn't exist <br /> Repeat copying for all children recursively (or use BFS with queue for iterative approach) |
| [200. Number of Islands](AlgorithmsAndDS/AlgorithmsAndDS/Graphs/Medium/NumberOfIslands.cs) | Medium | O(n*m) | O(n*m) | - Iterate through array and run DFS if item == 1 and is not visited yet, and increase result count  <br /> - DFS: mark current cell as visited, run DFS for all directions (top, bottom, right, left) |
| [207. Course Schedule](AlgorithmsAndDS/AlgorithmsAndDS/Graphs/Medium/CourseSchedule.cs) | Medium | O(n+p) | O(n+p) | - Using *Dictionary* create course -> prerequisite list mappings <br /> - For each course (0...num) run DFS <br /> - DFS: if prerequisite list is empty - return true (course can be passed); if course is visited - return false (loop); Run DFS for each prerequisite, after success clear prerequisite list and update visited courses |
| [417. Pacific Atlantic Water Flow](AlgorithmsAndDS/AlgorithmsAndDS/Graphs/Medium/PacificAtlanticWaterFlow.cs) | Medium | O(n*m) | O(n*m) | - Run DFS from each Border item for both oceans and mark items as visited <br /> - Iterate grid and add to result item, if it was visited in both oceans |

## Dynamic Programming

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [5. Longest Palindromic Substring](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Medium/LongestPalindromicSubstring.cs) | Medium | O(n^2) | O(1) | - Iterate array, and check palindrome for each character - curr item is center, expan frmo center with two pointers (left, right); Edge Case - palindrome could be even or odd |
| [70. Climbing Stairs](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Easy/ClimbingStairs.cs) | Easy | O(n) | O(1) | ClimbingStairs(n) = ClimbingStairs(n-1) + ClimbingStairs(n-2) (do not use recursion, use for loop starting from n = 3, because n1 = 1, n2 = 2) |
| [91. Decode Ways](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Medium/NumDecodings.cs) | Medium | O(n) | O(1) | Iterate from end and use rule: dp[i] = dp[i+1] + dp[i+2] (possible to use only two vars and edge cases when char = 0 or number > 26) |
| [121. Best Time to Buy and Sell Stock](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Easy/BestTimeToBuyAndSellStock.cs) | Easy | O(n) | O(1) | - Use first item as price to buy, second as price to sell <br /> - If priceToSell < priceToBuy - move priceToBuy index (left pointer) to priceToSell index (right pointer), otherwise - calculate temp profit and compare with current max profit |
| [139. Word Break](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Medium/WordBreak.cs) | Medium | O(n * m * k) | O(n) | - create dp array with s.Length + 1 size, where last item = true <br /> - Iterate from s.Length-1 index to the start and in inner loop iterate each word  <br /> - If string from curr index with word length == word, then dp[i] = dp[i + word.Length]. If dp[i] == true, it means that word could be break from i index - break inner loop <br /> - Return dp[0] |
| [152. Maximum Product Subarray](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Medium/MaxProduct.cs) | Medium | O(n) | O(1) | - Iterate arr and always track currMin and currMax (initially first arr item) <br /> - If curr item < 0 - swap currMin and currMax <br /> - Calculate currMin as max(currItem, currMin * currItem) and currMax accordingly <br /> - Update result: max(result, currMax) |
| [198. House Robber](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Medium/HouseRobber.cs) | Medium | O(n) | O(1) | - For each item calculate max possible rob value, for 0 item is always nums[0], for K element = Max(nums[k] + nums[k - 2], nums[k - 1]) |
| [213. House Robber II](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Medium/HouseRobberII.cs) | Medium | O(n) | O(1) | - Because of houses are in circle there are two options with classic House robber: calculate max ignoring first house, calculate max ignoring last house <br /> - Return max of two results |
| [300. Longest Increasing Subsequence](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Medium/LongestIncreasingSubsequence.cs) | Medium | O(n^2) | O(n) | - Create array to store LIS for each item <br /> - For last item LIS = 1, so iterate from end and in inner loop check every item after curr for LIS and update max result var |
| [322. Coin Change](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Medium/CoinChange.cs) | Medium | O(amount * len(coins)) | O(amount) | - Try to find coin change for each value from 1 to amount <br /> - Create dictionary with keys from 0 to amount, each value will be amount + 1 (or int.max), for 0 key - value also be 0 <br /> - Iterate from 1 to amount (outer loop) <br /> - Iterate through each coin (inner loop) <br /> - Find difference between value in outer loop and coin (i - coin) <br /> - If diff >= 0 then we could find solution as Math.Min(map[i], 1 + map[diff]) <br /> - Reaturn map[amount] or -1 |
| [647. Palindromic Substrings](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Medium/PalindromicSubstrings.cs) | Medium | O(n^2) | O(1) | - Iterate array, and check palindrome for each character - curr item is center, expand from center with two pointers (left, right); Edge Case - palindrome could be even or odd |
| [746. Min Cost Climbing Stairs](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Easy/MinCostClimbingStairs.cs) | Easy | O(n) | O(1) | - Min cost for 0 item will be cost[0], for 1 - cost[1] (beacause we can jump on 1 or 2 stairs); for item 2 = cost[2] + min(costItem0, costItem1) <br /> - Calculate cost for each item and result will be the minimum of last and last - 1 items |
| [1137. N-th Tribonacci Number](AlgorithmsAndDS/AlgorithmsAndDS/DynamicProgramming/Easy/NTribonacciNumber.cs) | Easy | O(n) | O(1) | - If n == 0 - return 0, if n == 1 or n == 2 - return 1. For other values use three variables prev1 = 1, prev2 = 1, prev3 = 0. For each step from 3 up to N calculate sum of all vars and assign to prev1, move other variables |

## Tries

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [208. Implement Trie (Prefix Tree)](AlgorithmsAndDS/AlgorithmsAndDS/Tries/Trie.cs) | Medium | | | Create class TreeNode with boolean flag IsWord and Dictionary<char, TrieNode> Children; Use this class as root property in Trie class |
| [211. Design Add and Search Words Data Structure](AlgorithmsAndDS/AlgorithmsAndDS/Tries/Medium/DesignAddAndSearchWordsDataStructure.cs) | Medium | | | - Use Trie <br /> - In Search use DFS (if '.' search through all children) |
| [212. Word Search II](AlgorithmsAndDS/AlgorithmsAndDS/Tries/Hard/WordSearchII.cs) | Hard | O(n * m * 4^n) | O(w * l) | - Use Trie to store all words <br /> - Iterate through board and use WordSearch Dfs to find words |

## Intervals

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [56. Merge Intervals](AlgorithmsAndDS/AlgorithmsAndDS/Intervals/Medium/MergeIntervals.cs) | Medium | O(n*log(n)) | O(n) | - Sort intervals by start value <br /> - Iterate intervals and compare first with second for overlapping (first[1] >= second[0]) |
| [57. Insert Interval](AlgorithmsAndDS/AlgorithmsAndDS/Intervals/Medium/InsertInterval.cs) | Medium | O(n) | O(n) | - Iterate intervals, if interval less then new - add to result, otherwise - merge intervals <br /> - If end of new interval less then start of interval - insert new interval |
| [435. Non-overlapping Intervals](AlgorithmsAndDS/AlgorithmsAndDS/Intervals/Medium/InsertInterval.cs) | Medium | O(n*log(n)) | O(n) | - Sort intervals by start value <br /> - Iterate intervals (start from 1 index) and maintain prevEnd (end od 0 index interval) <br /> If start of new interval > prevEnd - update prevEnd  <br /> - Else count++, prevEnd = Min(prevEnd, end) - idea is to save interval with smaller end |

## Math & Geometry
| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [48. Rotate Image](AlgorithmsAndDS/AlgorithmsAndDS/Math/Medium/RotateImage.cs) | Medium | O(n^2) | O(1) | - Iterate matrix from bigger square to smaller square in center <br /> - If curr row = i and col = j, then newRow = j, newCol = rowsCount - i - 1 <br /> - For each square perform swap 4 times |
| [54. Spiral Matrix](AlgorithmsAndDS/AlgorithmsAndDS/Math/Medium/SpiralMatrix.cs) | Medium | O(n*m) | O(1) | - Initialize top, bottom, left and right vars <br /> - Idea to add first row values, then last column values, then last rows values, then first column values <br /> - Update border vars and repeat |
| [73. Set Matrix Zeroes](AlgorithmsAndDS/AlgorithmsAndDS/Math/Medium/SetMatrixZeroes.cs) | Medium | O(n*m) | O(1) | - Iterate through matrix, except 0 column and if curr == 0 then set first value in row and col to 0 - to identify <br /> - Iterate first column and if some value is 0 then set separate var to indicate that first col should be zero <br /> - Iterate through matrix bottom-up (from last value), except first column and set value to 0 if first value in row or col equals to 0  <br /> - Check col0 var and set first col to 0 if needed |

## Bit Manipulation

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [190. Reverse Bits](AlgorithmsAndDS/AlgorithmsAndDS/BitManipulation/Easy/ReverseBits.cs) | Easy | O(1) | O(1) | |
| [191. Number of 1 Bits](AlgorithmsAndDS/AlgorithmsAndDS/BitManipulation/Easy/MissingNumber.cs) | Easy | O(k), k - number of 1 bits | O(1) | |
| [268. Missing Number](AlgorithmsAndDS/AlgorithmsAndDS/BitManipulation/Easy/MissingNumber.cs) | Easy | O(n) | O(1) | |
| [338. Counting Bits](AlgorithmsAndDS/AlgorithmsAndDS/BitManipulation/Easy/CountingBits.cs) | Easy | O(n) | O(1) | |
| [371. Sum of Two Integers](AlgorithmsAndDS/AlgorithmsAndDS/BitManipulation/Medium/SumOfTwoIntegers.cs) | Medium | O(1) | O(1) | - We always need to make a ^ b and (a & b) << 1 <br /> - While b != 0, calculate XOR, calculate (a & b) << 1 and assign to b, assign XOR to a - Use XOR to simple add bits, use & and << to find additionals 1 bits |

## Greedy

| Problem | Complexity | Time Complexity | Space Complexity | Solution Hints |
| ------- | ---------- | --------------- | ---------------- | -------------- |
| [53. Maximum Subarray](AlgorithmsAndDS/AlgorithmsAndDS/Greedy/Medium/MaximumSubarray.cs) | Medium | O(n) | O(1) | - Iterate array, and count sum, if previous sum < 0 - then don't count it and currSum = current item; always update result value to max possible |
| [55. Jump Game](AlgorithmsAndDS/AlgorithmsAndDS/Greedy/Medium/JumpGame.cs) | Medium | O(n) | O(1) | - Iterate array from the last-1 and the goal is last index <br /> - If we could reach goal from curr index, then goal after it = index <br /> - Result will be goal == 0 |

## Hints

- Find range sum/sum in array - prefix/postfix sum of array
- Find item in sorted array - binary search
- Move or remove elements in array - two pointers
- Reversing array could help in rotating array by k elements
- Monotonic stack
- Quick select
- Compare multiple items - use min/max heap (Merge K Sorted Lists)
- Sum 1..n = n * (n + 1) / 2

## Algorithms

- Boyer-Moore

## Bit Manipulation Hints
- 14 = { 1110 }2 = 1 * 23 + 1 * 22 + 1 * 21 + 0 * 20 = 14
- Left Shift ( << ): Left shift operator is a binary operator which shift the some number of bits, in the given bit pattern, to the left and append 0 at the end. Left shift is equivalent to multiplying the bit pattern with 2^k (if we are shifting k bits).
- Right Shift ( >> ): Right shift operator is a binary operator which shift the some number of bits, in the given bit pattern, to the right and append 1 at the end. Right shift is equivalent to dividing the bit pattern with 2^k (if we are shifting k bits).
