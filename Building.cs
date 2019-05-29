using System;


namespace planner
{
    class Building {
        private string _desginer = "Jonathan Schaffer";
        public string GetDesginer() {
            return _desginer;
        }

        private DateTime _dateConstructed {get; set;}
        public DateTime GetDate() {
            return _dateConstructed;
        }
        private string _address {get; set;}
        public string GetAddress() {
            return _address;
        }
        private string _owner {get; set;}

        public int stories {get; set;}

        public double width {get; set;}
        public double depth {get; set;}
        public string GetOwner() {
            return _owner;
        }

        public double Volume {
            get
            {
                return width * depth * (3 * stories);
            }
        }

        public Building (string address) {
                _address = address;
        }
        public void Construct() {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string buyerName) {
            _owner = buyerName;
        }

    }
    
}