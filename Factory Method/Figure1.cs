namespace factory
{
    class Figure1 :Figure
    {
        public override void Geometry()
        {
            geometry = new int[4, 4]
             {
              { 0,0,1,0},
              { 0,0,1,0},
              { 0,0,1,0},
              { 1,1,1,1},

             };
        }
       

        public Figure1()
        {
            color = RGB.Yellow;
            Geometry();
        }

    }
}
