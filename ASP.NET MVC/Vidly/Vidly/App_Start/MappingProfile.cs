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
            var dest2 = mapper.Map<CustomerDto, Customer>(source2);

            // AutoMapper for Movies
            var configForMovies=new MapperConfiguration(cfg => {
                cfg.CreateMap<Movie, MovieDto>();
            });

            IMapper mapperForMovies = configForMovies.CreateMapper();
            var sourceForMovies=new Movie();
            var destForMovies = mapperForMovies.Map<Movie, MovieDto>(sourceForMovies);
            

            var configForMovies2=new MapperConfiguration(cfg => {
                cfg.CreateMap<MovieDto, Movie>();
            });

            IMapper mapperForMovies2 = configForMovies.CreateMapper();
            var sourceForMovies2=new MovieDto();
            var destForMovies2 = mapperForMovies.Map<MovieDto, Movie>(sourceForMovies2);


        }
    }
}