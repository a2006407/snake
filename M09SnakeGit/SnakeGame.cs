using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M09SnakeGit {

    public enum DireccioSnake {
        Dreta,Esquerra,Avall,Amunt
    }

    class SnakeGame {

        public const int X_SIZE = 5;
        public const int Y_SIZE = 5;
        private Point capSerp = new Point(0,0);

        public Point CapSerp { get => capSerp; set => CapSerp = value; }


        internal void moure() {
            capSerp.Y++;
        }


    }
}
