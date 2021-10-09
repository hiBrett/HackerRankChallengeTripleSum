## My solution to the HackerRank challenge "Triple Sum"

Challenge Source: https://www.hackerrank.com/challenges/triple-sum/problem

#### Description
Find how many distinct triplets (left, middle, right) there are between the three arrays (left, middle, right), where the middle element is the greatest in each triplet.

#### Solution
My strategy is to sort the three arrays. That way each middle value will be compatible with all previously found triplets.

### Steps
1. Sort the arrays.
2. Make each array have distinct elements.
3. For each middle element: Find the total number of disctinct pairs of (left, middle), and (right, middle).
<br/> Previously found pair totals should be included in the totals because the arrays are sorted and therefore the middle will be compatible with all previously found pairs.
<br/> Multiply the pair totals together to find the triplet total for that middle element.

### Time and Space Complexity
Uses Quick Sort which causes the solution to have O(n*logn) time complexity and O(logn) space complexity.
<br/><br/> If the input were guaranteed to be sorted and contain distinct values, the sort and distinct lines could be removed in a revised solution.
<br/> The revised solution would have O(1) space complexity.
<br/> The revised solution would have O(n) time complexity. This is because it would iterate through each array only one time, despite the nested loops.

### Improvement Ideas
The code could be changed to assume that the input arrays are sorted and distinct, then throw an error once it detects that they aren't.
<br/>Or, assume that the input arrays are sorted and distinct, then fix them once it detects that they aren't. The downside to this is the uncertainty in time and space complexity which could cause problems in some circumstances.
<br/>The input arrays could be validated to not be empty, though this may not be necessary as they are guaranteed to not be empty in the problem statement.
