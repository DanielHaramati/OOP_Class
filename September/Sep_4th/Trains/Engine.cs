namespace CompositeObjects
{
     class Engine
     {
          // Attributes
          private int license_number;
          private int production_year;

          // Default Constractor
          public Engine(int license_number, int production_year)
          {
               this.license_number = 0;
               this.production_year = 0;
          }

          public int Get_license_number()
          {
               return this.license_number;
          }

          public int Get_production_year()
          {
               return this.production_year;
          }

     }
}