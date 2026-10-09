namespace Buildings
{
      class Apartment
      {
            const int MAX_ROOMS = 10;
            private string ownerName;
            private Room[] roomsArr;
            private int roomCounter;
            
            public Apartment(string ownerName)
            {
                  this.ownerName = ownerName;
                  this.roomsArr = new Room[MAX_ROOMS];
            }

            public int TotalArea()
            {
                  int totArea = 0;
                  for (int i = 0; i < roomCounter; i += 1)
                  {
                        totArea += this.roomsArr[i].GetArea();
                  }
                  return totArea;
            }

            
                  
            
      }
}