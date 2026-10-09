namespace Buildings
{
      class Room
      {
            private int length;
            private int width;
            private string roomType;

            public Room(int length, int width, string roomType){
                  this.length = length;
                  this.width = width;
                  this.roomType = roomType;
            }

            // copy constractor
            public Room(Room other)
            {
                  this.length = other.GetLength();
                  this.width = other.GetWidth();
                  this.roomType = other.GetRoomType();
            }



            public int GetArea()
            {
                  return this.length * this.width;
            }
            public int GetLength(){
                  return this.length;
            }

            public int GetWidth()
            {
                  return this.width;
            }

            public string GetRoomType()
            {
                  return this.roomType;
            }
      }
}