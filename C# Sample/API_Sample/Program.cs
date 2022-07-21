using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace API_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            //send order

            var symbol = "tsla";
            var qty = 100;
            var exchange = "bats";
            var type = "limit";
            var side = "buy";
            var price = 300.99;

            var request = WebRequest.Create("http://localhost:5005/sendOrder?symbol=" + symbol + "&qty=" + qty.ToString() + "&exchange=" + exchange + "&type=" + type + "&side=" + side + "&price=" + price.ToString());
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();

            Console.WriteLine(data);


            //view all orders

            request = WebRequest.Create("http://localhost:5005/orders");
            request.Method = "GET";

            webResponse = request.GetResponse();
            webStream = webResponse.GetResponseStream();
            reader = new StreamReader(webStream);
            data = reader.ReadToEnd();

            Console.WriteLine(data);
          

            //cancel order by ID

            var id = "TEST123+22721104994672?";
            request = WebRequest.Create("http://localhost:5005/cancelOrder?id=" + id);
            request.Method = "GET";

            webResponse = request.GetResponse();
            webStream = webResponse.GetResponseStream();
            reader = new StreamReader(webStream);
            data = reader.ReadToEnd();

            Console.WriteLine(data);


            request = WebRequest.Create("http://localhost:5005/positions");
            request.Method = "GET";

            webResponse = request.GetResponse();
            webStream = webResponse.GetResponseStream();
            reader = new StreamReader(webStream);
            data = reader.ReadToEnd();

            Console.WriteLine(data);

            //pause
            Console.Read();

        }
    }
}
