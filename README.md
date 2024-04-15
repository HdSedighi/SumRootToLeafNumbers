# Intuition
The intuition behind this solution is to perform a depth-first traversal of the binary tree while keeping track of the current sum formed by the path from the root to each leaf node. By accumulating the sum as we traverse, we can calculate the total sum of all paths where each path represents a number.

# Approach
The approach utilizes a recursive depth-first traversal. At each node, we update the current sum by multiplying it by 10 and adding the value of the current node. When we reach a leaf node, we return the final sum formed by the path from the root to that leaf. We sum up the results from the left and right subtrees to obtain the total sum of all paths.

# Complexity
- Time complexity: O(n), where n is the number of nodes in the binary tree. 

- Space complexity: O(h), where h is the height of the binary tree. 

__________________________________________________________________________________________
# Create a new console project
dotnet new console -n SumRootToLeafNumbers

# Run the project
dotnet run
