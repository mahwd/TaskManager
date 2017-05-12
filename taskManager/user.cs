namespace taskManager
{
    partial class Program
    {
        public class user
        {
            public string name;
            private int point = 0;
            public user(string ad)
            {
                name = ad;
            }

            public int getPoint()
            {
                return this.point;
            }

            public void setPoint(int p)
            {
                this.point += p;
            }

        }
        }
    }








