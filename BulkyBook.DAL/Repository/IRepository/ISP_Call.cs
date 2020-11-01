using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.DAL.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T Single<T>(string procedureNmae, DynamicParameters param = null);
        void Execute(string procedureNmae, DynamicParameters param = null);

        T OneRecore<T>(string procedureNmae, DynamicParameters param = null);

        IEnumerable<T> List<T>(string procedureNmae, DynamicParameters param = null);

        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1,T2>(string procedureNmae, DynamicParameters param = null);
    }
}
