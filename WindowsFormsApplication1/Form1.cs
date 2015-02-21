using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BoardForm : Form
    {
        

        public BoardForm()
        {
            InitializeComponent();
            

        }

        private void BoardForm_Load(object sender, EventArgs e)
        {
            DelHandler handler = Function1;
            //handler("hello world");
            //Function2(1, 2, handler);     // delegate
            lblText.Text = boxing();        // unboxing
            Func<int, long> fact = null;                    //delegate 
            fact = x => x > 1 ? x * fact(x - 1) : 1;        // delegate code
            //lblText.Text = "" + fact(10);
            //lblText.Text = reflexn();

            lblText.Text = array2();

            RealClass r = new RealClass();
            r.abstr();
            Singleton sing = Singleton.GetInstance();
            //sdfsfs
        }

        private string arrayL()
        {
            string ans = "";
            ArrayList lst = new ArrayList(10);
            lst.Add(10); lst.Add("str"); lst.Add('c'); lst.Add(5.000543);
            foreach (var l in lst)
            {
                ans += l.ToString() + " ";
            }
            return ans;
        }

        private string array2()
        {
            string ans = "";
            object[] arr = new object[10];
            arr[0] = 32;
            arr[1] = "dsfsdf";
            arr[2] = 'c';
            for (int i = 0; i < 3; i++ )
            {
                ans += arr[i].ToString() + " ";
            }
            return ans;
        }

        //private void pointerF()
        //{
            

        //    System.Console.WriteLine("Before = {0}", x);
        //    unsafe
        //    {             // use pointers
        //        int x = 10;
        //        int* p = &x;
        //        *p = 11;
                
        //    }
        //    System.Console.WriteLine("After = {0}", x);
        //}

        public delegate void DelHandler(string message);

        public void Function1(string message)
        {
            lblText.Text = message;
        }

        public void Function2(int x, int y, DelHandler callback)
        {
            callback("The number is: " + (x + y).ToString());
        }

        private string boxing()
        {
            object box = 42;
            long unbox = (long)(int)box;
            return "Boxing function: the unboxed number is - " + unbox;
        }

        private string reflexn()
        {
            var ans = new StringBuilder();
            var asmbl = Assembly.GetExecutingAssembly();
            ans.Append("Name: " + asmbl.FullName + "\n");
            ans.Append(asmbl.CodeBase + "\n");
            var types = asmbl.GetTypes();
            
            ans.Append("Types: ");
            foreach (var type in types)
            {
                
                //ans.Append(type.Name + " ");
                //var properties = type.GetProperties();
                //foreach (var prop in properties)
                //{
                //    ans.Append(prop.Name + " ");
                //}
                //ans.Append("\n");
                //ans.Append("Fields:\n");
                //var fields = type.GetFields();
                //foreach (var field in fields)
                //{
                //    ans.Append(field.Name + " ");
                //}
                //ans.Append("\n");
                var methods = type.GetMethods();
                foreach (var method in methods)
                {
                    ans.Append(method.Name);
                }

            }
            ans.Append("\n");



            //ans+= asmbl.FullName;
            return ans.ToString();
        }

        private void factorialFunc(int num)
        {
            Func<int, long> fact = null;
            fact = x => x > 1 ? x * fact(x - 1) : 1;
            //return fact;
        }
    }
}
