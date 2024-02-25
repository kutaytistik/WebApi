using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Responses;
using Business.Dtos.Requests;

namespace Business.Abstracts
{
    public interface IBrandService
    {
        CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);
        List<GetAllBrandResponse> GetAll();

    }
    //responses and request
}
