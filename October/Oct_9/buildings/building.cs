namespace Buildings
{
      class Building
      {
            public const int MAX_APARTMENTS = 100;
            private string address;
            private Apartment[] apartments;

            public string ApartmentSizeCategory(Apartment ap)
            {
                  if(ap.TotalArea() <= 70)
                  {
                        return "small";
                  }
                  if (ap.TotalArea() <= 110)
                  {
                        return "medium";
                  }
                  if (ap.TotalArea() > 110)
                  {
                        return "large";
                  }
                  return "";
            }
      }
}