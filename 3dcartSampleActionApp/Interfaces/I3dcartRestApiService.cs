using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3dcartSampleActionApp.Interfaces
{
    public interface I3dcartRestApiService
    {
        Task<T> MakeRequestAsync<T>(string endpoint, string token, int id, string storeSecureUrl);
    }
}
