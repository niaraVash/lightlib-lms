﻿using System.Threading.Tasks;
using LightLib.Models.DTOs;
using LightLib.Service.Models;

namespace LightLib.Service.Interfaces {
    public interface ILibraryAssetService {
        Task<PagedServiceResult<LibraryAssetDto>> GetAll(int page, int perPage);
        Task<ServiceResult<LibraryAssetDto>> Get(int id);
        Task<ServiceResult<int>> Add(LibraryAssetDto newDto);
        
        Task<ServiceResult<string>> GetAuthorOrDirector(int assetId);
        
        Task<ServiceResult<LibraryBranchDto>> GetCurrentLocation(int id);
        
        Task<ServiceResult<int>> GetNumberOfCopies(int libraryAssetId);
        Task<ServiceResult<bool>> MarkLost(int assetId);
        Task<ServiceResult<bool>> MarkFound(int assetId);
    }
}