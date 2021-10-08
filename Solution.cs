// Find how many distinct triplets (left, middle, right) there are between the arrays, where the middle element is the greatest in each triplet.
// Challenge source: https://www.hackerrank.com/challenges/triple-sum/problem

static long triplets(int[] leftArray, int[] middleArray, int[] rightArray) {
    
    // Make each array sorted and have distinct elements.
    Array.Sort(leftArray);
    Array.Sort(middleArray);
    Array.Sort(rightArray);
    leftArray = leftArray.Distinct().ToArray();
    middleArray = middleArray.Distinct().ToArray();
    rightArray = rightArray.Distinct().ToArray();
    
    int leftIndex = 0;
    int rightIndex = 0;
        
    long totalTriplets = 0;
        
    long leftTotal = 0;
    long rightTotal = 0;
        
    // Because the arrays are sorted, each middle value will be compatible with all previously found triplets.
    for(int middleIndex=0; middleIndex<middleArray.Length; middleIndex++){
        while(leftIndex < leftArray.Length && leftArray[leftIndex] <= middleArray[middleIndex]){
            leftTotal += 1;
            leftIndex += 1;
        }
        while(rightIndex < rightArray.Length && rightArray[rightIndex] <= middleArray[middleIndex]){
            rightTotal += 1;
            rightIndex += 1;
        }
        totalTriplets += leftTotal * rightTotal;
    }
        
    return totalTriplets;
}
