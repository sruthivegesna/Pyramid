Problem :

You will be given a triangle input (which is a binary tree) and you need to find the path that provides
the maximum possible sum of the numbers per the given rules below:
1. You will start from the top and move downwards to the last possible child.
2. You must proceed by changing between even and oddnumberssubsequently. Suppose that
you are on an even number, the next number you choose must be odd, or if you are on an
odd number the next number must be even. In other words, the final path would be
Odd -> even -> odd -> even ...
3. You must reach to the bottom of the pyramid.
4. Assume that there is at least one valid path to the bottom.
5. If there are multiple paths, which result in the samemaximumamount, you can choose any
of them.


Solution:
1.Took a Multidimentional Array to store the values of the Pyramid. And Matrix Range is the Matrix you want to Build for a Pyramid to see in Console.

2.ValidateEvenorOdd Method Takes two values(as binary tree has 2 child nodes) and a string which wants Even or Odd and returns the Maximum Value.

3.Check and print the path after knowing the Maximim Value in the child nodes and traverse down through the for loop.

4. Check the Sum of the Maximum Path and Print.
