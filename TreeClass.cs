using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class TreeClass
    {
        TSBNode root = null;
        string mystr = "";

        public TreeClass()
        {
                                                       //构建树的时候需要吧根节点的值初始化一下
            root = new TSBNode("", null, null);
        }

        public void setRootValue(string x)
        {
            root.data = x;
        }

        public TSBNode getRoot()         //返回根结点
        {
            return root;
        }

        public TSBNode insertSonNode(TSBNode targetNode, string value) //插入孩子结点
        {
            TSBNode nowSonNode = new TSBNode(value, null, null);
            TSBNode preSonNode = targetNode.getSonNode();
            if (preSonNode != null)
            {
                //先见前儿子变成现在儿子的兄弟,然后在添加儿子
                nowSonNode.setBroNode(preSonNode);
            }
            targetNode.setSonNode(nowSonNode);
            return nowSonNode;
        }

        public TSBNode insertBroNode(TSBNode targetNode, string value)  //插入兄弟结点
        {
            TSBNode nowBroNode = new TSBNode(value, null, null);
            TSBNode preBroNode = targetNode.getBroNode();
            if (preBroNode != null)
            {
                nowBroNode.setBroNode(targetNode.getBroNode());
            }
            targetNode.setBroNode(nowBroNode);
            return nowBroNode;
        }


        public TSBNode searchValue(string value)   //遍历整棵树查找结点
        {
             return searchValue(root, value);
        }
      
        public TSBNode searchValue(TSBNode node, string value)  //返回查找到的结点
        {
            TSBNode temp;

            if (node == null)
            {
                return null;
            }
            else if (node.getValue() == value)
            {
                return node;
            }
            else 
            {
                temp = searchValue(node.getSonNode(), value);
                if (temp != null)
                {
                    return temp;
                }
                else
                {
                    return searchValue(node.getBroNode(), value);
                }
            }
        }

        public int getCount()         //返回树的结点个数
        {
            return getCount(root);
        }
        public int getCount(TSBNode node)       //得到树的结点个数的递归算法
        {
            int cs, cb;            
            if (node == null)
            {
                return 0;
            }
            else
            {
                cs = getCount(node.getSonNode());
                cb = getCount(node.getBroNode());
                return cs + cb + 1;              //加1是因为根结点没有在统计中
            }
        }
         
        public int getHight()          //返回树的高度
        {
            return getHight(root);
        }
        public int getHight(TSBNode node)
        {
            int sh, bh;
            if (node == null)
            {
                return 0;
            }
            else
            {
                sh = getHight(node.getSonNode());
                bh = getHight(node.getBroNode());
                if (node.getSonNode() == null && node.getBroNode() != null)
                {
                    return bh - 1;
                }
                return (sh>bh)? (sh + 1):(bh + 1);
            }
        }

        public string displayTree()
        {
            mystr = "结点值\t\t孩子结点\t\t兄弟结点\r\n";
            displayTree(root);
            return mystr;
        }
        public void displayTree(TSBNode node)
        {
            string sb, son;
            if (node != null)
            {
                if (node.getBroNode() == null)            //判断该结点的兄弟结点是否为空，若为空则显示null，若不空则显示它的值
                    sb = "Null";
                else
                    sb = node.getBroNode().getValue().ToString();

                if(node.getSonNode() == null)        ////判断该结点的孩子结点是否为空，若为空则显示null，若不空则显示它的值
                    son = "Null";
                else
                    son = node.getSonNode().getValue().ToString();

                mystr += node.getValue().ToString() + "\t\t\n" + son + "\t\t\t\n" + sb + "\r\n";
                displayTree(node.getSonNode());
                displayTree(node.getBroNode());
            }

        }
    }
}
