﻿using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Data.Dtos.Sessao;
using FilmesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>()
                .ForMember(sessaoDto => sessaoDto.HorarioInicio, opts =>
                opts.MapFrom(sessaoDto => sessaoDto.HorarioEncerramento.AddMinutes(sessaoDto.Filme.Duracao * (-1))));
        }
    }
}
