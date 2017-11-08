/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
        
        //Pre-order solution:
        
        if (t1 == null) //Basecase
            return t2;
        if (t2 == null)
            return t1;
        
        t1.val = t1.val + t2.val; //Add the current node's values together
        t1.left = MergeTrees(t1.left, t2.left); //Add the left child's tree together
        t1.right = MergeTrees(t1.right, t2.right); //Add the right child's tree together
        
        return t1;
        
    }
}
