using System;

namespace PC_Admin_Panel.Classes
{
    class Pack : Basic_Class
    {
        //   ###   Enum propeties   ###   //

        public enum Payment_Status : int { canceled = 0, waiting_for_a_transfer = 1, paid = 2 };

        public enum Delivery_Option : int { DHL = 1, GLS = 2, Traditional_Post = 3, Uber = 4, InPost = 5, Kurier48 = 6, Paczka_RUCH = 7, Paczka48 = 8 };

        public enum Delivery_Status : int { prepared = 1, on_the_way = 2, delivered = 3 }

        //   ###   CLass propeties   ###   //

        #region Propeties

        private int _id;
        private int _uid;
        private string _fname;
        private string _lname;
        private string _phone;
        private string _country;
        private string _postal_code;
        private string _place;
        private string _House_number;
        private double _weigth;
        private double _price;
        private int _quantity;
        private int _insurance;
        /*
         * Change type into string
         * 
        private Payment_Status _status;
        private Delivery_Status _position;
        private Delivery_Option _Option;
        */
        private string _status;
        private string _position;
        private string _Option;
        private string _ordered;
        private string _delivered;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        public string Fname
        {
            get { return _fname; }
            set { _fname = value; }
        }
        public string Lname
        {
            get { return _lname; }
            set { _lname = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string PostalCode
        {
            get { return _postal_code; }
            set { _postal_code = value; }
        }
        public string Place
        {
            get { return _place; }
            set { _place = value; }
        }
        public string HouseNumber
        {
            get { return _House_number; }
            set { _House_number = value; }
        }
        public double Weigth
        {
            get { return _weigth; }
            set { _weigth = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public int Insurance
        {
            get { return _insurance; }
            set { _insurance = value; }
        }
        /*
         * Change type into string
         * 
        public Payment_Status Status
        {
            get { return Status; }
            set { Status = value; }
        }
        public Delivery_Status Position
        {
            get { return Position; }
            set { Position = value; }
        }
        public Delivery_Option Option
        {
            get { return Option; }
            set { Option = value; }
        }
        */
        public string Status
        {
            get => _status;
            set => _status = value;
        }
        public string Position
        {
            get => _position;
            set => _position = value;
        }
        public string Option
        {
            get => _Option;
            set => _Option = value;
        }
        public string Ordered
        {
            get { return _ordered; }
            set { _ordered = value; }
        }
        public string Delivered
        {
            get { return _delivered; }
            set { _delivered = value; }
        }

        #endregion

        //   ###   Class constructors   ###   //  

        /// <summary>
        /// Basic class constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="uid"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="phone"></param>
        /// <param name="country"></param>
        /// <param name="postalCode"></param>
        /// <param name="place"></param>
        /// <param name="houseNumber"></param>
        /// <param name="weigth"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        /// <param name="insurance"></param>
        /// <param name="status"></param>
        /// <param name="position"></param>
        /// <param name="option"></param>
        /// <param name="ordered"></param>
        /// <param name="delivered"></param>
        /// <param name="Error_Message"></param>
        /// <param name="Error_Flag"></param>
        public Pack(
            int id,
            int uid, 
            string fname, 
            string lname, 
            string phone, 
            string country, 
            string postalCode, 
            string place, 
            string houseNumber,
            double weigth, 
            double price, 
            int quantity, 
            int insurance,
            /*
             * Change type into string
             * 
            Payment_Status status,
            Delivery_Status position,
            Delivery_Option option, 
            */
            string status,
            string position,
            string option,
            string ordered,
            string delivered,
            string Error_Message,
            bool Error_Flag
            ) : base(Error_Message, Error_Flag)
        {
            Id = id;
            Uid = uid;
            Fname = fname;
            Lname = lname;
            Phone = phone;
            Country = country;
            PostalCode = postalCode;
            Place = place;
            HouseNumber = houseNumber;
            Weigth = weigth;
            Price = price;
            Quantity = quantity;
            Insurance = insurance;
            Status = status;
            Position = position;
            Option = option;
            Ordered = ordered;
            Delivered = delivered;
        }

        //   ###   Methods   ###   //
    }
}
