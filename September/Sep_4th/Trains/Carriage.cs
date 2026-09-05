namespace CompositeObjects
{
    class Carriage
    {
        private int serial_id;
        private int passenger_capacity;
        private int total_active_passangers;

        public Carriage(int serial_id, int passenger_capacity)
        {
            this.serial_id = serial_id;
            this.passenger_capacity = passenger_capacity;
            this.total_active_passangers = 0;
        }

        public int get_pass_capacity()
        {
            return this.passenger_capacity;
        }

        public int get_total_active_passangers()
        {
            return this.total_active_passangers;
        }
    }
}
