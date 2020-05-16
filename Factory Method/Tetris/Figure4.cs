namespace factory
{
    class Figure4 :Figure
    {
        public override void Geometry()
        {
            geometry = new int[4, 4]
             {
              { 0,0,1,0},
              { 0,0,1,0},
              { 0,0,1,0},
              { 0,0,1,0},

             };
        }


        public Figure4()
        {
            color = RGB.Blue;
            Geometry();
        }
    }
}
