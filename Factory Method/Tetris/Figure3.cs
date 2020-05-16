namespace factory
{
    class Figure3 :Figure
    {
        public override void Geometry()
        {
            geometry = new int[4, 4]
             {
              { 0,1,0,0},
              { 0,1,0,0},
              { 0,1,0,0},
              { 0,1,1,1},

             };
        }


        public Figure3()
        {
            color = RGB.Blue;
            Geometry();
        }
    }
}
