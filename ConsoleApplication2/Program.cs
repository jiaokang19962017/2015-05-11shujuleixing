﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region i++和++i
            //int i = 1;
            //int a = i++;
            //int b = ++i;
            //Console.WriteLine(a);//num++为1
            //Console.WriteLine(b);//++num为3
            #endregion
            #region &&和||
            //int x = 2, y = 5;
            //Boolean z = (x > 0) || (y < 8);//只有一个符合条件
            //Console.WriteLine("z={0}", z);
            //z = (x == 0) && (y < 8);//&&都必须符合条件
            //Console.WriteLine("z={0}",z);
            //z = !(x == 2);//!不等于
            //Console.WriteLine("z={0}", z);

            #endregion
            #region 三元运算符
            //Console.WriteLine("请输入成绩");
            //int score = int.Parse(Console.ReadLine());
            ////string succ = score >= 60 ? "及格" : "不及格";//三元运算符
            ////Console.WriteLine(succ);
            //if (score >= 60&&score<=100)
            //{
            //    Console.WriteLine("合格");
            //}else if (score < 60)
            //{
            //    Console.WriteLine("不合格");

            //}
            //else
            //{
            //    Console.WriteLine("输入有误");
            //}
            #endregion
            #region 隐式转换
            //string a;
            //a = 10 + "2a0";
            //Console.WriteLine(a);  //隐式转换
            //double z = 3.15;
            //int x = 2;
            //double y = x + z;
            //Console.WriteLine(y);
            #endregion
            #region 显式转换
            //int a = 1;
            //double b = 3.14159;
            //int c = (int)(a + b);  //数据类型转换  显式转换
            //Console.WriteLine(c);
            //int d = 987;
            //string e = d.ToString();//ToString()方法
            //Console.WriteLine(e);

            // int.Parse();
            // string g = "12345";
            //int h = Convert.ToInt32(g);  //这个方法可以很多类型转换
            #endregion
            #region 类型转换
            // string s1 = "123.9999";
            // string s2 = "908";
            //// int s3 = int.Parse(s1);
            // double s4 = Convert.ToDouble(s2);
            // float s5 = Convert.ToSingle(s1);
            // Console.WriteLine("{0}---{1}---", s4,s5);
            // int k = 12;
            // double d = 12.56;
            // string k1 = k.ToString();
            // string d1 = Convert.ToString(d);
            // Console.WriteLine("{0}----{1}", k1, d1);
            // #endregion
            #endregion
            #region 作业
            //string name = "焦康";
            //int age = 21;
            //char sex = '男';
            //double score = 100;
            //Console.WriteLine("姓名是:{0},年龄是:{1},性别是:{2},成绩是:{3}", name, age, sex, score);


            //Console.WriteLine("请输入姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入年龄");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入性别");
            //char sex = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("请输入成绩");
            //double score = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("姓名是:{0},年龄是:{1},性别是:{2},成绩是:{3}", name, age, sex, score);


            //int a = 10,b=20,temp;
            //temp = a;
            //a = b;
            //b = temp;
            //Console.WriteLine("交换后a={0},b={1}",a,b);


            //const double pi = 3.1415926;
            //Console.WriteLine("请输入圆的半径");
            //double r = Convert.ToDouble(Console.ReadLine());
            //double s = pi * (r * r);
            //Console.WriteLine("圆的面积为:{0}",s);


            //int s = 208653;
            //int day = s / (24 * 60 * 60);
            //int hour = s % (24 * 60 * 60)/(60 * 60);
            //int minute = s % (24 * 60 * 60) % (60 * 60) / 60;
            //int second = s % (24 * 60 * 60) % (60 * 60) % 60;
            //Console.WriteLine("{0}天{1}小时{2}分钟{3}秒",day,hour,minute,second);


            //int a, b = 10;
            //a = b++;
            //Console.WriteLine(a);//11
            //a = ++b;
            //Console.WriteLine(b);//12


            int a = 1, b = 1;
            bool bb = false;
            bool aa = (a != 1 && (bb = (b == 0 ? false : true)));
            Console.WriteLine("{0},{1}", aa, bb);
            #endregion
        }
    }
}
