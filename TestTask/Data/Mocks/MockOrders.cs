using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data.Interfaces;
using TestTask.Data.Models;
using TestTask.Data.Models.Authorization;

namespace TestTask.Data.Mocks
{
    public class MockOrders : IOrders
    {
        public IEnumerable<OrdersInformation> Orders 
        { 
            get 
            {
                string AccessToken= Repository.Authorization("38cd79b5f2b2486d86f562e3c43034f8", "8e49ff607b1f46e1a5e8f6ad5d312a80");
                OrdersRequestResult ordersRequestResult = Repository.SendARequestForAListOfOrders(AccessToken,1);                
                return ordersRequestResult.Result; 
            }
        }
    }
}
