using Domain.Entities;
using Domain.IRepository;
using Domain.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.implementation
{
    public class CvService : ICvService
    {
        private readonly ICvRepository _cvRepo;
        private readonly IUnitOfWorkRepository _unitOfWork;

        public CvService(ICvRepository cvRepo , IUnitOfWorkRepository unitOfWork)
        {
            _cvRepo = cvRepo;
            _unitOfWork = unitOfWork;
        }

        public Cv Get(int id) => _cvRepo.Get(id);

        public async Task<IEnumerable<Cv>> GetAll()
        {
            var res =  await _cvRepo.GetAll("ExperienceInformation,PersonalInformation");
            return res;
        }
        public bool Add(Cv entity)
        {
            try
            {
                _cvRepo.Add(entity);
                _unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       
      

        public bool Remove(int id) 
        {
            try
            {
                _cvRepo.Remove(id);
                _unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Cv entity)
        {

            try
            {
                _cvRepo.Update(entity);
                _unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
