using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    abstract class Game
    {
        private const int Size = 8;
        private const int CellSize = 80;
        private bool[,] board;
        private List<Player> players;
        private BoardForm Form;

        public Game(BoardForm form)
        {
            this.Form = form;
            board = new bool[8, 8];
            players = new List<Player>();
        }


        internal void run()
        {
            while (true)
            {
                
            }
        }

        public abstract void check();


        private void drawBoard(PaintEventArgs e)
        {
            Graphics g = Form.CreateGraphics();
            Pen p = new Pen(Color.Black, 5);
            for (int i = 0; i < Size; i++)
            {
                g.DrawLine(p, i * CellSize, 0, i * CellSize, Size * CellSize);
                g.DrawLine(p, 0, i * CellSize, Size * CellSize, i * CellSize);
            }
        }
    }

    internal class AbstractClass
    {
        public AbstractClass()
        {
            System.Console.WriteLine("Hello from Abstract class");
        }

        public void check()
        {

        }

        public virtual void abstr() { }
    }

    internal class RealClass : AbstractClass
    {
        public RealClass()
        {
            //base.ToString();
            System.Console.WriteLine("Hello from real class");
        }

        public override void abstr()
        {
            System.Console.WriteLine("hello from abstract method");
        }

    }

    public class Singleton
    {
        private static Singleton Instance;
        private static object LockObj = new object();
        private Singleton() { }

        public static Singleton GetInstance(){
            lock (LockObj) { 
                if(Instance == null)
                    Instance = new Singleton();
            }
            return Instance;
        }
    }
}
