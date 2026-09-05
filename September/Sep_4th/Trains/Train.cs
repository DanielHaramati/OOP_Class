using System.Runtime.Versioning;

namespace CompositeObjects
{
    class Train
    {
        public const int Total_carriages = 10; // maximum number of carriages

        private Engine engine; 
        private Carriage[] carriages;
        private int index;
        
        public Train(Engine engine)
        {
            this.engine = engine;
            this.carriages = new Carriage[Total_carriages];
            this.index = 0;
        }

        public void SetNewEngine(Engine engine)
        {
            this.engine = engine;
        }


        public bool AddCarriage(Carriage carriage)
        {
            if (this.index == Total_carriages)
            {
                return false;
            }

            this.carriages[this.index] = carriage;
            this.index++;
            return true;
        }

        public int MaxTrainPassengars()
        {
            int count = 0;
            for (int i = 0; i < this.index; i++)
            {
                count += this.carriages[i].get_pass_capacity();
            }
            return count;
        }

        public double Average_active_passangers_carriages()
        {
            if (this.index <= 0)
            {
                return 0;
            }
            double sum = 0;
            for (int i = 0; i < this.index; i++)
            {
                sum += this.carriages[i].get_total_active_passangers(); 
            }
            return sum / index;
        }

    }
}