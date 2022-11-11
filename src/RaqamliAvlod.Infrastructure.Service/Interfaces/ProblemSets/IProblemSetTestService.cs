﻿using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.ProblemSets;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Infrastructure.Service.Interfaces.ProblemSets;

public interface IProblemSetTestService
{
    public Task<IEnumerable<ProblemSetTestViewModel>> GetAllAsync(PaginationParams @params);
    public Task<ProblemSetTestViewModel> GetAsync(long testId);
    public Task<bool> DeleteAsync(long testId);
    public Task<bool> UpdateAsync(ProblemSetTestCreateDto testCreateDto);
    public Task<bool> UpdateAsync(long testId, ProblemSetTestCreateDto testCreateDto);
}
