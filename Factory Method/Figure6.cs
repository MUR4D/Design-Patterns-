namespace factory
{
    class Figure6 :Figure
    {
        public override void Geometry()
        {
            geometry = new int[4, 4]
             {
              { 1,1,1,1},
              { 1,0,0,0},
              { 1,0,0,0},
              { 1,0,0,0},

             };
        }


        public Figure6()
        {
            color = RGB.Yellow;
            Geometry();
        }
    }
}
