using System;

namespace Domain.Interfaces;

public interface IBaseRepository<T>
{
    List<T> GetAll();
}
