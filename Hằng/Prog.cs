using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace Bien
{
    class Prog
    {
        static void Main(string[] args)
        {
            // Hằng là một giá trị không thay đổi trong suốt chương trình
            // Buộc phải khai báo khi khởi tạo
            const int X = 101;
            // Cú pháp giống với khai báo biến, thêm const trước nó
            // Syntax: const <kiểu giá trị> <tên hằng> = <giá trị hằng>;
            Console.WriteLine(X);
            Console.ReadKey();
        }
    }
}