using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class TSBNode
    {
        public string data;
        public TSBNode bp;         //指向兄弟结点
        public TSBNode cp;         //指向孩子结点

        public TSBNode(string d, TSBNode b, TSBNode c)           //构造结点
        {
            data = d; 
            bp = b;
            cp = c;
        }

        public TSBNode()         //构造空结点
        {
            bp = null;
            cp = null;
        }

        public TSBNode getSonNode()      //返回指向的孩子结点
        {
            return cp;
        }
        public TSBNode getBroNode()      //返回指向的兄弟结点
        {
            return bp;
        }

        public string getValue()       //返回结点值
        { 
            return data;
        }

        public void setSonNode(TSBNode sonNode)        //设置孩子结点
        {
            cp = sonNode;
        }

        public void setBroNode(TSBNode broNode)     //设置兄弟结点
        {
            bp = broNode;
        }
        public void setNull(TSBNode node)
        {
            node = new TSBNode(null, null,null);
        }
    }


}

