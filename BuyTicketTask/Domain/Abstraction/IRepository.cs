using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyTicketTask.Domain.Abstraction
{
    public interface IRepository<T>
    {
        T GetAll(int Id);
        void AddData(T data);
        void UpdateData(T data);
        void DeleteData(T data);
    }
}
