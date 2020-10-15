using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Customer, CustomerDto>();
            });

            IMapper mapper = config.CreateMapper();
            var source = new Customer();
            var dest = mapper.Map<Customer, CustomerDto>(source);
            
            var config2 = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerDto, Customer>();
            });

            IMapper mapper2 = config.CreateMapper();
            var source2 = new CustomerDto();
            var des2t = mapper.Map<CustomerDto, Customer>(source2);
        }
    }
}