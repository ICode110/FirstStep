using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step001
{
    /*
     5.属性与索引器的使用‌
     创建一个 Matrix 类，使用属性管理矩阵的行数和列数，
     并实现一个索引器来访问矩阵中的特定元素
     */
    public class JC031_OOPE_Matrix
    {
        private int[,] data; //私有数组字段
        public int Row {  get; set; } //行自动属性
        public int Column { get; set; } //列自动属性

        public JC031_OOPE_Matrix(int row, int column) //构造方法
        { 
            Row = row; //行赋值
            Column = column; //列赋值
            data = new int[row, column];    
        }

        public int this[int row, int column]
        {
            get { return data[row, column]; }
            set { data[row, column] = value; }
        }
    }
}
