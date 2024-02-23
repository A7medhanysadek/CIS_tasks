using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Transactions;

namespace stack_implimentaion
{
    public class stack
    {
        private int[] arr = new int[1000];
        private int Top;
        public stack()
        {
            Top = -1;
        }
        //بتتأكد اذا الستاك فاضي ولا لا
        public bool is_empty()
        {
            return Top == -1;
        }
        //هنا المستخدم بيبعت العنصر اللي عاوز يضيفه على الستاك الفنكشن بتتأكد اذا الستاك مليان ولا لا وعلى اساسه بتقرر تضيف العنصر ولا لا 
        public void push(int c)
        {
            if (Top+1==int.MaxValue)
                Console.WriteLine("stack is full");
            else
            {
                Top++;
                arr[Top] = c;
            }
        }
        //الفنكشن الخاصه بالمسح وظيفتها تتأكد ان الستاك مش فاضي وعلى اساسه بتقرر هتمسح ولا لا
        public void pop()
        {
            if (is_empty())
                Console.WriteLine("stack is empty");
            else
                Top--;
        }
        //هنا الفنكشن اللي بتطبع العنصر اللي على التوب
        public int get_Top()
        {
            return arr[Top];
        }
        //وهنا الفنكشن الخاصه بطباعة الستاك من فوق لتحت حسب مبادئ الستاك
        public void print()
        {
            for (int i = Top; i >= 0; i--)
            {
                Console.WriteLine("["+arr[i]+"]");
            }
        }
    }
    class main_class
    {
        static void Main(string[] args)
        {
            stack s = new stack();
            s.push(10);
            s.push(20);
            s.push(30);
            Console.WriteLine(s.get_Top());
            s.pop();
            s.print();
        }
    }
}
