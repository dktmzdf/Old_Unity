using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BSTNode
{
    public int data;
    public BSTNode left;
    public BSTNode right;
    
}

class BST
{
    BSTNode root = null;

    public void Insert_Node(int key)
    {
        if (root == null)
        {
            root = new BSTNode();
            root.data = key;
        }
        BSTNode node = getNode(root,key);
        node.data = key;
        
    }

    public void Remove_Node(int key)
    {
        BSTNode node = getNode(root, key);
        if (node == null)
        {
            Console.WriteLine("nothing {0} value",key);
        }
        else
        {
            BSTNode temp = node;
            BSTNode right = node.right;
            while (temp != null) 
            {
          
                if (temp.right != null)
                {
                    BSTNode tempRight = temp.right;
                    temp.right = right;
                    right = tempRight;
                }
                else
                {
                    temp.right = right;
                    right = null;
                }
                temp = node.left;
                
            }
            //////
            if (right != null)
            {
                temp.left = temp.right;
            }
            node = node.left;
            
        }
    }
    public BSTNode getNode(BSTNode node,int key)
    {
        
        while (node != null)
        {
            if (node.data > key)
            {
                if (node == null)
                {
                    node = new BSTNode();
                    return node;
                }
                node = node.right;
                
            }

            else if(node.data < key)
            {
                if (node == null)
                {
                    node = new BSTNode();
                    return node;
                }
                node = node.left;
                
            }
            //값이 같을때 같은 값을 가지고 있는 노드 반환
            else
            {
                break;
            }

        }
       

        return node;
    }
}

class Program
{
    struct BSTNode
    {
        
    }
    static void Main(string[] args)
    {
        int[] Array = new int[10] { 1, 2, 4, 5, 9, 53, 412, 6, 56, 312 };
    }
}
