using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloNancy.Dto.Test;
using Nancy;
using Nancy.ModelBinding;

namespace HelloNancy.Module
{
    public class TestModule : NancyModule
    {
        public TestModule() : base("/api/v1/t")
        {
            Get["/ping"] = _ =>
            {
                return "pong";
            };

            Get["/OrderQuery"] = _ =>
            {
                string orderNo = this.Request.Query.OrderNo;
                return this.Response.AsJson(new Order { OrderNo = orderNo, OrderName = "good" + orderNo });
            };

            Post["/OrderFilter"] = _ =>
              {
                  var order = this.Bind<Order>();
                  List<Order> orderList = new List<Order> {
                    new Order { OrderNo="1",OrderName="good1"}
                    ,new Order { OrderNo="2",OrderName="good2"}
                    ,new Order { OrderNo="2",OrderName="good2"}
                  };
                  var newOrders = orderList.Where(a => a.OrderNo == order.OrderNo);
                  return Response.AsJson(newOrders);
              };
        }
    }
}
