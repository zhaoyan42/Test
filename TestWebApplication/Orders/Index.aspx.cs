using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExceptionTest;

namespace TestWebApplication.Orders
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IOrderService orderService = new OrderService();
            OrdersList.DataSource = orderService.GetAllOrders();
            OrdersList.DataBind();
        }
    }
}