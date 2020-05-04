namespace factory
{
    class Figure5 :Figure
    {
        public override void Geometry()
        {
            geometry = new int[4, 4]
             {
              { 0,0,1,1},
              { 0,0,1,0},
              { 0,0,1,0},
              { 1,1,1,0},

             };
        }


        public Figure5()
        {
            color = RGB.Green;
            Geometry();
        }
    }
}
