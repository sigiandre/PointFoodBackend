using PointFood.Commons;
using PointFood.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service
{
    public interface IClientService
    {
        ClientDto Create(ClientCreateDto model);
        ClientDto GetById(int id);
        DataCollection<ClientDto> GetAll(int page, int take);
        ClientDto GetByUsernameAndPassword(ClientLoginDto model);
        void Update(int id, ClientUpdateDto model);
        void Remove(int id);
    }
}
