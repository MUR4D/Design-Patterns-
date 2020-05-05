namespace SingletonCards
{
    class Card
    {
        public string Suit { get; set; }

        public int Index { get; set; }
        public override string ToString()
          {
              return $"{Suit} {Index}"; 
          }
    }
}
