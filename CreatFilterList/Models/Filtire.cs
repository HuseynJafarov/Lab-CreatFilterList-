using System;
using System.Collections.Generic;
using System.Text;

namespace List.Models
{
    public class Filtire<T> where T : Base
{
        public List<T> Filtr(List<T> datas, int startPrice, int endPrice)
        {

            return datas.FindAll(m => m.Price > startPrice && m.Price < endPrice);



        }
    }
}
