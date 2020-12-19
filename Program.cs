﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    
    

        public struct Vector3
        {
            public double x;
            public double y;
            public double z;
            public Vector3(double X, double Y, double Z) => (x, y, z) = (X, Y, Z);


            public override string ToString() => "({x}, {y}, {z})";
            //додавання векторів
            public static Vector3 operator +(Vector3 a, Vector3 b)
            {
                return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
            }
            //віднімання векторів
            public static Vector3 operator -(Vector3 a, Vector3 b)
            {
                return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
            }
            //множення векторів
            public static Vector3 operator *(Vector3 a, Vector3 b)
            {
                return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
            }
            //множення вектора на число
            public static Vector3 operator *(Vector3 a, int k)
            {
                return new Vector3(a.x * k, a.y * k, a.z * k);
            }
            //ділення вектора на число
            public static Vector3 operator /(Vector3 a, int k)
            {
                return new Vector3(a.x / k, a.y / k, a.z / k);
            }
            //нормування вектору
            public Vector3 Normalize()
            {
                double q = Math.Sqrt(x * x + y * y + z * z);
                return new Vector3(x / q, y / q, z / q);
            }
            //знаходження довжини
            public double GetLength()
            {
                double l = Math.Sqrt(x * x + y * y + z * z);
                return l;
            }
        }
    
    

    
}