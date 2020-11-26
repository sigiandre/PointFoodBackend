using PointFood.Dto;

namespace PointFood.Service
{
    public interface ICardService
    {
        CardDto Create(CardCreateDto model);
        CardDto GetById(int id);
        void Update(int id, CardUpdateDto model);
        void Remove(int id);
    }
}
