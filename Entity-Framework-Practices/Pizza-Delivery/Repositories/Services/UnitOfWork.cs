//using Microsoft.EntityFrameworkCore;
//using Pizza_Delivery.Repositories.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pizza_Delivery.Repositories.Services
//{
//    public class UnitOfWork : IUnitOfWork, IDisposable
//    {
//        private readonly DbContext _context;
//        public UnitOfWork(DbContext context) => _context = context;

//        public IProductRepository ProductRepository => throw new NotImplementedException();

//        public IOrderRepository OrderRepository => throw new NotImplementedException();

//        public IOrderRepository orderRepository => throw new NotImplementedException();

//        public IDeliveriesRepository DeliveriesRepository => throw new NotImplementedException();

//        public IPaymentRepository paymentRepository => throw new NotImplementedException();

//        public IOrderDetailRepository orderDetailRepository => throw new NotImplementedException();

//        public int Complete() => _context.SaveChanges();
//        public void Dispose() => _context.Dispose();




//    }
//}
