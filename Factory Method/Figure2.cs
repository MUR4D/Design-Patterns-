namespace factory
{
    class Figure2 :Figure
    {
        public override void Geometry()
        {
            geometry = new int[4, 4]
             {
              { 1,1,1,0},
              { 0,0,1,0},
              { 0,0,1,0},
              { 0,0,1,1},

             };
        }


        public Figure2()
        {
            color = RGB.Red;
            Geometry();
        }
    }
}
