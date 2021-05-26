using MVC_ModelDemo.Models;
using System.Collections.Generic;

namespace MVC_ModelDemo.Repository
{
    public interface IPersonRepo
    {
        List<Person> GetAllPersons();
    }
}