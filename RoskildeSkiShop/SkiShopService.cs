using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoskildeSkiShop
{
    public class SkiShopService
    {
        public int _id;
        public string _skiLenght;
        public string _skiType;
        public int _price;

        public SkiShopService(int Id, string SkiLenght, string SkiType, int Price)
        {
            _id = Id;
            _skiLenght = SkiLenght;
            _skiType = SkiType;
            _price = Price;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string SkiType
        {
            get { return _skiType; }
            set { _skiType = value; }
        }

        //internal class SkiShopService : RoskildeSkiShop.SkiShopService
        //{
        //    public SkiShopService()
        //    {
        //    }
        //}
    }
}
